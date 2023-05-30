using Terraria.ModLoader;
using CalamityCN.Utils;
using Terraria.Localization;
using InfernumModeMusic.Items;
using Terraria;
using System.Collections.Generic;

namespace CalamityCN.Translations.InfernumMode
{
    public class InfernumMusicItemTrans : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.InfernumMusic != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCN;
        }
        public override void SetDefaults(Item item)
        {
            //奇怪Hjson不生效
            if (item.type == ModContent.ItemType<SoulDrivenHeadphones>())
            {
                item.SetNameOverride(Language.GetTextValue("InfernumModeMusic.ItemName.SoulDrivenHeadphones"));
            }

        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (item.type == ModContent.ItemType<SoulDrivenHeadphones>())
                {
                    line.Text = line.Text.Replace("Allows you to pick and play custom Infernum music of defeated bosses, and to toggle a special boss battle theme", "允许你选择播放被击败Boss的炼狱战斗音乐，并切换特殊的Boss战斗主题");
                    line.Text = line.Text.Replace("As you hold onto them, you vaguely feel a mystical presence", "当你戴着它, 你隐约感觉到个神秘的存在");
                    line.Text = line.Text.Replace("You can also hear the sounds of instruments passionately playing", "你还可以听到充满激情的乐器演奏声");
                }
            }
        }
    }
}
