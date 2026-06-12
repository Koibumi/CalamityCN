using CalamityCN;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN
{
    public class CalamityCNPlayer : ModPlayer
    {

        public override void OnEnterWorld()
        {
            Main.NewText("感谢使用灾厄维基汉化组的灾厄汉化补丁！为了适配灾厄模组的更新，我们发布了这个临时版本以修复可能的错误。", Color.Orange);
            Main.NewText("由于准备仓促，部分内容可能未翻译或不够准确，还请您理解，我们会在后续更新中改进，无需反馈相关问题。", Color.Orange);
            Main.NewText("正式版发布后，这些内容将得到更新。感谢您的支持！", Color.Orange);
        }

    }
}