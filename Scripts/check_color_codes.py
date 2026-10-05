#!/usr/bin/env python3
"""Check color-code parity between CalamityMod English and Chinese HJSON.

The report compares the ordered ``[c/COLOR:text]`` marker sequence for each
matching localization key. Color values are compared case-insensitively, while
repeated markers and their order are preserved.
"""

from __future__ import annotations

import argparse
import re
import sys
from dataclasses import dataclass
from pathlib import Path

from check_translation_age import Entry, parse_hjson_entries


COLOR_TAG = re.compile(r"\[c/([^:\]\r\n]+):", re.IGNORECASE)


@dataclass(frozen=True)
class Issue:
    kind: str
    relative_file: str
    key: tuple[str | int, ...] | None
    english: tuple[str, ...] = ()
    chinese: tuple[str, ...] = ()
    english_content: str | None = None
    chinese_content: str | None = None


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description=(
            "Compare [c/COLOR:text] markers in CalamityMod en-US and zh-Hans "
            "localization entries."
        )
    )
    parser.add_argument(
        "--output",
        type=Path,
        default=Path(__file__).resolve().parent / "Output" / "color-code-review.txt",
        help="UTF-8 report path (default: Scripts/Output/color-code-review.txt)",
    )
    parser.add_argument(
        "--repo",
        type=Path,
        default=Path(__file__).resolve().parent.parent,
        help="repository root (default: parent of Scripts)",
    )
    return parser.parse_args()


def pair_files(repo: Path) -> list[tuple[Path, Path, str]]:
    english_root = repo / "Localization" / "CalamityMod" / "en-US"
    chinese_root = repo / "Localization" / "CalamityMod" / "zh-Hans"
    if not english_root.is_dir():
        raise FileNotFoundError(f"English localization directory not found: {english_root}")

    pairs: list[tuple[Path, Path, str]] = []
    for english in sorted(english_root.rglob("*.hjson")):
        relative = english.relative_to(english_root)
        pairs.append((english, chinese_root / relative, relative.as_posix()))
    return pairs


def colors(entry: Entry | None) -> tuple[str, ...]:
    if entry is None:
        return ()
    return tuple(value.casefold() for value in COLOR_TAG.findall(entry.content))


def display_key(key: tuple[str | int, ...]) -> str:
    result = ""
    for part in key:
        if isinstance(part, int):
            result += f"[{part}]"
        else:
            result += ("." if result else "") + part
    return result


def format_codes(values: tuple[str, ...]) -> str:
    return "[" + ", ".join(values) + "]" if values else "[]"


def compare(repo: Path) -> tuple[list[Issue], int, list[str]]:
    issues: list[Issue] = []
    checked_entries = 0
    errors: list[str] = []

    for english_path, chinese_path, relative_file in pair_files(repo):
        try:
            english_entries = parse_hjson_entries(english_path)
        except (OSError, UnicodeError, ValueError) as error:
            errors.append(f"{relative_file} (en-US): {error}")
            continue

        if not chinese_path.is_file():
            errors.append(f"{relative_file} (zh-Hans): file not found")
            for key, english in english_entries.items():
                english_codes = colors(english)
                if english_codes:
                    issues.append(
                        Issue(
                            "missing-file",
                            relative_file,
                            key,
                            english=english_codes,
                            english_content=english.content,
                        )
                    )
            continue

        try:
            chinese_entries = parse_hjson_entries(chinese_path)
        except (OSError, UnicodeError, ValueError) as error:
            errors.append(f"{relative_file} (zh-Hans): {error}")
            continue

        for key in sorted(set(english_entries) | set(chinese_entries), key=display_key):
            english = english_entries.get(key)
            chinese = chinese_entries.get(key)
            english_codes = colors(english)
            chinese_codes = colors(chinese)
            if english is not None and chinese is not None:
                checked_entries += 1

            if english_codes == chinese_codes:
                continue
            if not english_codes and not chinese_codes:
                continue

            issues.append(
                Issue(
                    "mismatch" if english is not None and chinese is not None else "missing-entry",
                    relative_file,
                    key,
                    english=english_codes,
                    chinese=chinese_codes,
                    english_content=english.content if english is not None else None,
                    chinese_content=chinese.content if chinese is not None else None,
                )
            )

    return issues, checked_entries, errors


def render_report(
    repo: Path, issues: list[Issue], checked_entries: int, errors: list[str]
) -> str:
    lines = [
        "CalamityMod 汉化颜色代码检查",
        f"英文目录: {(repo / 'Localization' / 'CalamityMod' / 'en-US').as_posix()}",
        f"中文目录: {(repo / 'Localization' / 'CalamityMod' / 'zh-Hans').as_posix()}",
        f"已比较的中英文条目: {checked_entries}",
        f"发现颜色代码不对应: {len(issues)}",
        f"解析或文件错误: {len(errors)}",
        "",
    ]

    if issues:
        lines.append("=" * 80)
        lines.append("颜色代码不对应")
        lines.append("=" * 80)
        for number, issue in enumerate(issues, 1):
            key = display_key(issue.key) if issue.key is not None else "<文件>"
            lines.extend(
                [
                    f"{number}. [{issue.kind}] {issue.relative_file} :: {key}",
                    f"   EN codes: {format_codes(issue.english)}",
                    f"   ZH codes: {format_codes(issue.chinese)}",
                ]
            )
            if issue.english_content is not None:
                lines.append(f"   EN text: {issue.english_content}")
            if issue.chinese_content is not None:
                lines.append(f"   ZH text: {issue.chinese_content}")
            lines.append("")
    else:
        lines.extend(["=" * 80, "未发现颜色代码不对应。", "=" * 80, ""])

    if errors:
        lines.extend(["=" * 80, "解析或文件错误", "=" * 80])
        lines.extend(f"- {error}" for error in errors)
        lines.append("")

    return "\n".join(lines)


def main() -> int:
    args = parse_args()
    try:
        issues, checked_entries, errors = compare(args.repo.resolve())
    except (FileNotFoundError, OSError) as error:
        print(f"错误: {error}", file=sys.stderr)
        return 2

    report = render_report(args.repo.resolve(), issues, checked_entries, errors)
    try:
        args.output.parent.mkdir(parents=True, exist_ok=True)
        args.output.write_text(report, encoding="utf-8")
    except OSError as error:
        print(f"无法写入报告 {args.output}: {error}", file=sys.stderr)
        return 2

    print(f"报告已写入: {args.output}")
    print(f"发现颜色代码不对应: {len(issues)}")
    return 2 if errors else (1 if issues else 0)


if __name__ == "__main__":
    raise SystemExit(main())
