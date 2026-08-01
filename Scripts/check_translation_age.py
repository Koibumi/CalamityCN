#!/usr/bin/env python3
"""Find English translation entries newer than their Chinese counterparts.

The script has no third-party dependencies. It identifies entries in the HJSON
localization files and string leaves in dialogue JSON files, then uses
``git blame`` to find the last commit that touched each entry.
"""

from __future__ import annotations

import argparse
import contextlib
import csv
import json
import os
import re
import subprocess
import sys
import textwrap
from concurrent.futures import ThreadPoolExecutor, as_completed
from dataclasses import asdict, dataclass
from datetime import date, datetime, time
from pathlib import Path
from typing import Iterator, Sequence


@dataclass(frozen=True)
class Entry:
    key: tuple[str | int, ...]
    start_line: int
    end_line: int
    content: str


@dataclass(frozen=True)
class LineStamp:
    timestamp: int
    commit: str
    author: str
    summary: str


@dataclass(frozen=True)
class Finding:
    status: str
    key: str
    english_file: str
    english_line: int | None
    english_time: str | None
    english_commit: str | None
    english_author: str | None
    english_summary: str | None
    english_content: str | None
    chinese_file: str
    chinese_line: int | None
    chinese_time: str | None
    chinese_commit: str | None
    chinese_author: str | None
    chinese_summary: str | None
    chinese_content: str | None


HJSON_KEY = re.compile(
    r'^\s*(?:"((?:\\.|[^"\\])*)"|([^:\s][^:]*?))\s*:\s*(.*)$'
)
BLAME_HEADER = re.compile(r"^([0-9a-f^]+)\s+\d+\s+(\d+)(?:\s+\d+)?$")


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description=(
            "Compare the last Git modification time of en-US entries with the "
            "matching zh-Hans entries."
        )
    )
    parser.add_argument(
        "--scope",
        choices=("all", "dialogues", "localization"),
        default="all",
        help="directories to scan (default: all)",
    )
    parser.add_argument(
        "--format",
        choices=("text", "review", "csv", "json"),
        default="text",
        help=(
            "report format written to stdout; review groups entries by file and "
            "shows current content (default: text)"
        ),
    )
    parser.add_argument(
        "--show-missing",
        action="store_true",
        help="also report missing Chinese files and entries",
    )
    parser.add_argument(
        "--english-since",
        default="2026-07-01",
        metavar="DATE_OR_COMMIT",
        help=(
            "only report English-newer entries updated on/after this YYYY-MM-DD "
            "date or Git commit (default: 2026-07-01)"
        ),
    )
    parser.add_argument(
        "--output",
        type=Path,
        help="write the report directly to a UTF-8 file instead of stdout",
    )
    parser.add_argument(
        "--jobs",
        type=int,
        default=min(8, os.cpu_count() or 1),
        help="parallel git blame processes (default: up to 8)",
    )
    parser.add_argument(
        "--repo",
        type=Path,
        default=Path(__file__).resolve().parent.parent,
        help="repository root (default: parent of Scripts)",
    )
    return parser.parse_args()


def pair_files(repo: Path, scope: str) -> list[tuple[Path, Path, str]]:
    pairs: list[tuple[Path, Path, str]] = []

    if scope in ("all", "dialogues"):
        root = repo / "Dialogues" / "en-US"
        if root.is_dir():
            for english in sorted(root.rglob("*.json")):
                relative = english.relative_to(root)
                pairs.append((english, repo / "Dialogues" / "zh-Hans" / relative, "json"))

    if scope in ("all", "localization"):
        root = repo / "Localization"
        if root.is_dir():
            for english in sorted(root.rglob("*.hjson")):
                relative = english.relative_to(root)
                parts = list(relative.parts)
                if "en-US" in parts:
                    parts[parts.index("en-US")] = "zh-Hans"
                elif parts[-1].startswith("en-US"):
                    parts[-1] = "zh-Hans" + parts[-1][len("en-US") :]
                else:
                    continue
                pairs.append((english, root.joinpath(*parts), "hjson"))

    return pairs


def hjson_content(
    lines: list[str], remainder: str, triple_start: int | None, end_index: int
) -> str:
    if triple_start is not None:
        block = "\n".join(lines[triple_start : end_index + 1])
        opening = block.find("'''")
        closing = block.rfind("'''")
        if opening >= 0 and closing > opening:
            return textwrap.dedent(block[opening + 3 : closing]).strip("\n")
        return block

    if len(remainder) >= 2 and remainder.startswith('"') and remainder.endswith('"'):
        try:
            value = json.loads(remainder)
            if isinstance(value, str):
                return value
        except json.JSONDecodeError:
            pass
    if len(remainder) >= 2 and remainder.startswith("'") and remainder.endswith("'"):
        return remainder[1:-1]
    return remainder


def parse_hjson_entries(path: Path) -> dict[tuple[str | int, ...], Entry]:
    lines = path.read_text(encoding="utf-8-sig").splitlines()
    entries: dict[tuple[str | int, ...], Entry] = {}
    stack: list[str] = []
    line_index = 0

    while line_index < len(lines):
        stripped = lines[line_index].strip()
        if not stripped or stripped.startswith(("//", "#")):
            line_index += 1
            continue

        if stripped.startswith("}"):
            if stack:
                stack.pop()
            line_index += 1
            continue

        match = HJSON_KEY.match(lines[line_index])
        if not match:
            line_index += 1
            continue

        quoted_key, plain_key, remainder = match.groups()
        key = json.loads(f'"{quoted_key}"') if quoted_key is not None else plain_key.strip()
        remainder = remainder.strip().rstrip(",").rstrip()

        if remainder == "{":
            stack.append(key)
            line_index += 1
            continue

        entry_key = tuple(stack) + (key,)
        end_index = line_index
        triple_start = None
        if remainder.startswith("'''"):
            triple_start = line_index
        elif not remainder:
            probe = line_index + 1
            while probe < len(lines) and not lines[probe].strip():
                probe += 1
            if probe < len(lines) and lines[probe].strip().startswith("'''"):
                triple_start = probe

        if triple_start is not None:
            end_index = triple_start
            if lines[triple_start].strip().count("'''") < 2:
                end_index += 1
                while end_index < len(lines) and "'''" not in lines[end_index]:
                    end_index += 1
                end_index = min(end_index, len(lines) - 1)

        content = hjson_content(lines, remainder, triple_start, end_index)
        entries[entry_key] = Entry(entry_key, line_index + 1, end_index + 1, content)
        line_index = end_index + 1

    return entries


@dataclass(frozen=True)
class JsonToken:
    kind: str
    value: object
    start_line: int
    end_line: int


def json_tokens(text: str) -> Iterator[JsonToken]:
    index = 0
    line = 1
    length = len(text)
    decoder = json.JSONDecoder()

    while index < length:
        character = text[index]
        if character.isspace():
            if character == "\n":
                line += 1
            index += 1
            continue
        if character in "{}[],:":
            yield JsonToken(character, character, line, line)
            index += 1
            continue
        if character == '"':
            start = index
            start_line = line
            index += 1
            escaped = False
            while index < length:
                current = text[index]
                if current == "\n":
                    line += 1
                if current == '"' and not escaped:
                    index += 1
                    break
                if current == "\\" and not escaped:
                    escaped = True
                else:
                    escaped = False
                index += 1
            raw = text[start:index]
            yield JsonToken("scalar", json.loads(raw), start_line, line)
            continue

        value, consumed = decoder.raw_decode(text[index:])
        raw = text[index : index + consumed]
        end_line = line + raw.count("\n")
        yield JsonToken("scalar", value, line, end_line)
        line = end_line
        index += consumed


def parse_json_entries(path: Path) -> dict[tuple[str | int, ...], Entry]:
    tokens = list(json_tokens(path.read_text(encoding="utf-8-sig")))
    position = 0
    entries: dict[tuple[str | int, ...], Entry] = {}

    def take(expected: str | None = None) -> JsonToken:
        nonlocal position
        if position >= len(tokens):
            raise ValueError("unexpected end of JSON")
        token = tokens[position]
        position += 1
        if expected is not None and token.kind != expected:
            raise ValueError(f"expected {expected!r}, got {token.kind!r}")
        return token

    def parse_value(key: tuple[str | int, ...]) -> None:
        token = tokens[position]
        if token.kind == "{":
            take("{")
            if tokens[position].kind == "}":
                take("}")
                return
            while True:
                name = take("scalar")
                if not isinstance(name.value, str):
                    raise ValueError("JSON object key is not a string")
                take(":")
                parse_value(key + (name.value,))
                separator = take()
                if separator.kind == "}":
                    return
                if separator.kind != ",":
                    raise ValueError("expected ',' or '}'")
        elif token.kind == "[":
            take("[")
            item_index = 0
            if tokens[position].kind == "]":
                take("]")
                return
            while True:
                parse_value(key + (item_index,))
                item_index += 1
                separator = take()
                if separator.kind == "]":
                    return
                if separator.kind != ",":
                    raise ValueError("expected ',' or ']'")
        else:
            scalar = take("scalar")
            # Dialogue text is the translatable surface; numeric timing metadata is not.
            if isinstance(scalar.value, str):
                entries[key] = Entry(key, scalar.start_line, scalar.end_line, scalar.value)

    parse_value(())
    if position != len(tokens):
        raise ValueError("unexpected data after JSON document")
    return entries


def worktree_stamp(timestamp: int) -> LineStamp:
    return LineStamp(timestamp, "WORKTREE", "Not Committed Yet", "Working tree")


def git_blame(repo: Path, path: Path) -> list[LineStamp]:
    relative = path.relative_to(repo).as_posix()
    process = subprocess.run(
        ["git", "blame", "--line-porcelain", "--", relative],
        cwd=repo,
        stdout=subprocess.PIPE,
        stderr=subprocess.PIPE,
        check=False,
    )
    file_time = int(path.stat().st_mtime)
    if process.returncode != 0:
        # Untracked files have no blame data. Treat their content as a worktree edit.
        tracked = subprocess.run(
            ["git", "ls-files", "--error-unmatch", "--", relative],
            cwd=repo,
            stdout=subprocess.DEVNULL,
            stderr=subprocess.DEVNULL,
            check=False,
        )
        if tracked.returncode != 0:
            line_count = len(path.read_text(encoding="utf-8-sig").splitlines())
            return [worktree_stamp(file_time) for _ in range(line_count)]
        error = process.stderr.decode("utf-8", errors="replace").strip()
        raise RuntimeError(f"git blame failed for {relative}: {error}")

    stamps: dict[int, LineStamp] = {}
    current_line: int | None = None
    current_commit: str | None = None
    current_author = ""
    current_summary = ""
    current_timestamp: int | None = None
    for raw_line in process.stdout.decode("utf-8", errors="replace").splitlines():
        header = BLAME_HEADER.match(raw_line)
        if header:
            current_commit = header.group(1)
            current_line = int(header.group(2))
            current_author = ""
            current_summary = ""
            current_timestamp = None
        elif raw_line.startswith("author "):
            current_author = raw_line[7:]
        elif raw_line.startswith("summary "):
            current_summary = raw_line[8:]
        elif raw_line.startswith("committer-time ") and current_line is not None:
            current_timestamp = int(raw_line.split(" ", 1)[1])
        elif raw_line.startswith("\t") and current_line is not None and current_timestamp is not None:
            normalized_commit = (current_commit or "").lstrip("^")
            if normalized_commit and not normalized_commit.strip("0"):
                stamps[current_line] = worktree_stamp(file_time)
            else:
                stamps[current_line] = LineStamp(
                    current_timestamp,
                    (current_commit or "")[:8],
                    current_author,
                    current_summary,
                )
            current_timestamp = None

    total_lines = len(path.read_text(encoding="utf-8-sig").splitlines())
    return [
        stamps.get(number, worktree_stamp(file_time))
        for number in range(1, total_lines + 1)
    ]


def entry_stamp(entry: Entry, stamps: Sequence[LineStamp]) -> LineStamp:
    relevant = stamps[entry.start_line - 1 : entry.end_line]
    if not relevant:
        raise ValueError(f"entry line {entry.start_line} is outside blame output")
    return max(relevant, key=lambda stamp: stamp.timestamp)


def display_key(key: tuple[str | int, ...]) -> str:
    result = ""
    for part in key:
        if isinstance(part, int):
            result += f"[{part}]"
        else:
            result += ("." if result else "") + part
    return result


def iso_time(timestamp: int) -> str:
    return datetime.fromtimestamp(timestamp).astimezone().isoformat(timespec="seconds")


def parse_english_since(repo: Path, value: str) -> tuple[int, str]:
    try:
        cutoff_date = date.fromisoformat(value)
    except ValueError:
        process = subprocess.run(
            ["git", "show", "-s", "--format=%ct", value],
            cwd=repo,
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            text=True,
            check=False,
        )
        if process.returncode != 0 or not process.stdout.strip().isdigit():
            error = process.stderr.strip() or "invalid date or Git commit"
            raise ValueError(f"--english-since {value!r}: {error}")
        timestamp = int(process.stdout.strip())
        return timestamp, f"{value} ({iso_time(timestamp)[:10]})"

    local_midnight = datetime.combine(cutoff_date, time.min).astimezone()
    return int(local_midnight.timestamp()), cutoff_date.isoformat()


def possibly_untranslated(
    key: tuple[str | int, ...], english: Entry, chinese: Entry
) -> bool:
    key_text = ".".join(str(part) for part in key)
    if key_text == "Bandit.Name" or key_text.startswith("Bandit.Name."):
        return False
    if key_text == "TownPiggy.Name" or key_text.startswith("TownPiggy.Name."):
        return False

    chinese_content = chinese.content.strip()
    if chinese_content.startswith("{") and chinese_content.endswith("}"):
        return False
    if chinese_content.startswith("[") and chinese_content.endswith("]"):
        return False
    if not re.search(r"[a-z]", chinese_content) and not re.search(r"\s", chinese_content):
        return False
    return bool(chinese_content) and (
        english.content == chinese.content or chinese_content.isascii()
    )


def inspect_pair(
    repo: Path,
    english: Path,
    chinese: Path,
    kind: str,
    show_missing: bool,
    english_since: int,
) -> tuple[list[Finding], int, int]:
    parser = parse_json_entries if kind == "json" else parse_hjson_entries
    english_entries = {
        key: entry for key, entry in parser(english).items() if entry.content.strip()
    }
    english_relative = english.relative_to(repo).as_posix()
    chinese_relative = chinese.relative_to(repo).as_posix()

    if not chinese.is_file():
        findings = []
        if show_missing:
            english_blame = git_blame(repo, english)
            for key, english_entry in english_entries.items():
                english_stamp = entry_stamp(english_entry, english_blame)
                findings.append(
                    Finding(
                        "missing-file",
                        display_key(key),
                        english_relative,
                        english_entry.start_line,
                        iso_time(english_stamp.timestamp),
                        english_stamp.commit,
                        english_stamp.author,
                        english_stamp.summary,
                        english_entry.content,
                        chinese_relative,
                        None,
                        None,
                        None,
                        None,
                        None,
                        None,
                    )
                )
        return findings, len(english_entries), 0

    chinese_entries = parser(chinese)
    english_blame, chinese_blame = git_blame(repo, english), git_blame(repo, chinese)
    findings: list[Finding] = []

    for key, english_entry in english_entries.items():
        chinese_entry = chinese_entries.get(key)
        if chinese_entry is None:
            if show_missing:
                english_stamp = entry_stamp(english_entry, english_blame)
                findings.append(
                    Finding(
                        "missing-entry",
                        display_key(key),
                        english_relative,
                        english_entry.start_line,
                        iso_time(english_stamp.timestamp),
                        english_stamp.commit,
                        english_stamp.author,
                        english_stamp.summary,
                        english_entry.content,
                        chinese_relative,
                        None,
                        None,
                        None,
                        None,
                        None,
                        None,
                    )
                )
            continue

        english_stamp = entry_stamp(english_entry, english_blame)
        chinese_stamp = entry_stamp(chinese_entry, chinese_blame)
        if possibly_untranslated(key, english_entry, chinese_entry):
            status = "possibly-untranslated"
        elif (
            english_stamp.timestamp >= english_since
            and english_stamp.timestamp > chinese_stamp.timestamp
        ):
            status = "outdated"
        else:
            continue

        if status in ("possibly-untranslated", "outdated"):
            findings.append(
                Finding(
                    status,
                    display_key(key),
                    english_relative,
                    english_entry.start_line,
                    iso_time(english_stamp.timestamp),
                    english_stamp.commit,
                    english_stamp.author,
                    english_stamp.summary,
                    english_entry.content,
                    chinese_relative,
                    chinese_entry.start_line,
                    iso_time(chinese_stamp.timestamp),
                    chinese_stamp.commit,
                    chinese_stamp.author,
                    chinese_stamp.summary,
                    chinese_entry.content,
                )
            )

    return findings, len(english_entries), len(chinese_entries)


def print_content(label: str, content: str | None) -> None:
    print(f"    {label}:")
    if content is None:
        print("      <缺失>")
    elif not content:
        print("      <空字符串>")
    else:
        for line in content.splitlines():
            print(f"      {line}")


def print_review(findings: list[Finding]) -> None:
    labels = {
        "outdated": "英文较新",
        "possibly-untranslated": "可能未翻译",
        "missing-entry": "缺少中文条目",
        "missing-file": "缺少中文文件",
    }
    category_statuses = (
        ("possibly-untranslated", "可能未翻译"),
        ("outdated", "英文较新"),
        ("missing", "缺少中文"),
    )

    def category_for(item: Finding) -> str:
        return "missing" if item.status in ("missing-entry", "missing-file") else item.status

    for category, category_label in category_statuses:
        category_findings = sorted(
            (item for item in findings if category_for(item) == category),
            key=lambda item: (item.english_file, item.english_line or 0, item.key),
        )
        print(f"\n{'#' * 80}\n分类: {category_label}\n{'#' * 80}")
        if not category_findings:
            print("（无）")
            continue

        current_file: str | None = None
        file_index = 0
        for item in category_findings:
            if item.english_file != current_file:
                if current_file is not None:
                    print()
                current_file = item.english_file
                file_index = 0
                print("=" * 80)
                print(f"文件: {item.english_file}")
                print(f"中文: {item.chinese_file}")
                print("=" * 80)

            file_index += 1
            line_label = f"行 {item.english_line or '-'}"
            if item.chinese_line is not None and item.chinese_line != item.english_line:
                line_label += f"，中文行 {item.chinese_line}"
            print(f"\n{file_index}. [{line_label}] [{labels[item.status]}] {item.key}")
            print(
                f"   EN: {item.english_time[:7] if item.english_time else '-'} | "
                f"{item.english_author or '-'} | {item.english_summary or '-'}"
            )
            print_content("英文内容", item.english_content)
            if item.chinese_line is None:
                print("   ZH: <缺失>")
            else:
                print(
                    f"   ZH: {item.chinese_time[:7] if item.chinese_time else '-'} | "
                    f"{item.chinese_author or '-'} | {item.chinese_summary or '-'}"
                )
            print_content("中文内容", item.chinese_content)


def print_report(findings: list[Finding], report_format: str) -> None:
    if report_format == "json":
        json.dump([asdict(item) for item in findings], sys.stdout, ensure_ascii=False, indent=2)
        print()
        return

    if report_format == "csv":
        fieldnames = list(Finding.__dataclass_fields__)
        writer = csv.DictWriter(sys.stdout, fieldnames=fieldnames, lineterminator="\n")
        writer.writeheader()
        writer.writerows(asdict(item) for item in findings)
        return

    if report_format == "review":
        print_review(findings)
        return

    for item in findings:
        print(f"[{item.status.upper()}] {item.key}")
        if item.english_line is None:
            print(f"  EN  {item.english_file}")
        else:
            print(
                f"  EN  {item.english_time}  {item.english_commit:<8}  "
                f"{item.english_file}:{item.english_line}"
            )
        if item.chinese_line is None:
            print(f"  ZH  {item.chinese_file}")
        else:
            print(
                f"  ZH  {item.chinese_time}  {item.chinese_commit:<8}  "
                f"{item.chinese_file}:{item.chinese_line}"
            )


def main() -> int:
    # Windows Python uses the legacy console code page for redirected output,
    # while PowerShell decodes native pipelines as UTF-8 in this repository's
    # usual environment. Keep terminal output native, but make pipes/files UTF-8.
    if os.name == "nt" and not sys.stdout.isatty():
        sys.stdout.reconfigure(encoding="utf-8")

    args = parse_args()
    if len(sys.argv) == 1:
        args.format = "review"
        args.output = Path("Scripts") / "Output" / "translation-review.txt"

    repo = args.repo.resolve()
    if args.jobs < 1:
        print("error: --jobs must be at least 1", file=sys.stderr)
        return 2
    if not (repo / ".git").exists():
        print(f"error: not a Git repository: {repo}", file=sys.stderr)
        return 2
    try:
        english_since, english_since_label = parse_english_since(repo, args.english_since)
    except ValueError as error:
        print(f"error: {error}", file=sys.stderr)
        return 2

    pairs = pair_files(repo, args.scope)
    findings: list[Finding] = []
    english_entry_count = 0
    chinese_entry_count = 0
    errors: list[str] = []

    show_missing = args.show_missing or args.format == "review"

    with ThreadPoolExecutor(max_workers=args.jobs) as executor:
        futures = {
            executor.submit(
                inspect_pair,
                repo,
                english,
                chinese,
                kind,
                show_missing,
                english_since,
            ): (
                english,
                chinese,
            )
            for english, chinese, kind in pairs
        }
        for future in as_completed(futures):
            english, _ = futures[future]
            try:
                pair_findings, english_count, chinese_count = future.result()
                findings.extend(pair_findings)
                english_entry_count += english_count
                chinese_entry_count += chinese_count
            except Exception as error:  # Continue so one malformed file does not hide all results.
                errors.append(f"{english.relative_to(repo).as_posix()}: {error}")

    findings.sort(key=lambda item: (item.english_file, item.english_line or 0, item.key))
    if args.output is None:
        print_report(findings, args.format)
    else:
        output_path = args.output.resolve()
        try:
            output_path.parent.mkdir(parents=True, exist_ok=True)
            with output_path.open("w", encoding="utf-8", newline="\n") as output:
                with contextlib.redirect_stdout(output):
                    print_report(findings, args.format)
        except OSError as error:
            print(f"error: cannot write report to {output_path}: {error}", file=sys.stderr)
            return 2
        print(f"Report written to {output_path}", file=sys.stderr)

    outdated_count = sum(item.status == "outdated" for item in findings)
    possibly_count = sum(item.status == "possibly-untranslated" for item in findings)
    missing_count = sum(item.status in ("missing-entry", "missing-file") for item in findings)
    print(
        f"Scanned {len(pairs)} file pairs, {english_entry_count} English entries and "
        f"{chinese_entry_count} Chinese entries; English-newer cutoff {english_since_label}; "
        f"found {outdated_count} outdated, {possibly_count} possibly untranslated"
        + (f" and {missing_count} missing items" if show_missing else "")
        + ".",
        file=sys.stderr,
    )
    for error in errors:
        print(f"error: {error}", file=sys.stderr)

    if errors:
        return 2
    return 1 if findings else 0


if __name__ == "__main__":
    raise SystemExit(main())
