
## 检查过期翻译

**警告：某些“未翻译”的内容可能具有程序意义，本来就不应翻译；某些“英文较新”的内容可能只是修改了英文错别字，中文不该更新；某些“缺少中文”内容可能是因版本控制或显示原因特意留作显示英文，请勿以该脚本的输出结果作为更新翻译的唯一参考，请多方对照实际情况后再修改！如果不懂就去汉化组群里问！**

使用 Git 历史逐条比较英文和中文翻译的最后修改时间：

```powershell
python Scripts/check_translation_age.py
```

不加参数时会自动以 `review` 格式覆盖生成 `Scripts/Output/translation-review.txt`；需要输出到终端或其他格式时再显式指定参数。

默认检查 `Dialogues` 和 `Localization`。常用选项：

```powershell
# 按“可能未翻译、英文较新、缺少中文”的顺序分类，再按文件分组写入 UTF-8 文本文件
python Scripts/check_translation_age.py --format review --output Scripts/Output/translation-review.txt

# 仅检查本地化 HJSON，并显示英文存在而中文缺失的项目
python Scripts/check_translation_age.py --scope localization --show-missing

# 将英文更新截止日期改为 2025-01-01
python Scripts/check_translation_age.py --english-since 2025-01-01 --format review --output Scripts/Output/translation-review.txt

# 也可以使用 Git 提交、标签或 HEAD~N 作为英文更新截止点
python Scripts/check_translation_age.py --english-since HEAD~10 --format review --output Scripts/Output/translation-review.txt

# 导出为 CSV
python Scripts/check_translation_age.py --format csv > translation-age.csv
```

英文内容为空或仅含空白的条目会被忽略。中文与英文完全相同，或中文内容仅包含 ASCII 字符时，会标记为“可能未翻译”；中文内容整体被花括号或方括号包住、既不含小写英文字母也不含空白的内容，以及 `Bandit.Name.*` / `TownPiggy.Name.*` 条目会排除。review 按“可能未翻译、英文较新、缺少中文”的顺序分类，并在分类内按文件分组。英文较新检查默认只考虑 2026-07-01 及之后的英文更新；`--english-since` 可传日期或 Git 提交作为截止点。`review` 中的修改时间只显示到月份，并列出更新人和提交标题；标题会标出英文行号，仅在中英文行号不同时额外标出中文行号。

发现英文较新的条目时退出码为 1，解析或 Git 错误时退出码为 2；没有发现时为 0。

