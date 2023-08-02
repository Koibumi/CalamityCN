
using CalamityMod;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Translations
{
    public class ItemGlobalTrans : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN && ModsCall.Calamity != null;
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (item.Calamity().devItem)
                {
                    line.Text = line.Text.Replace("Developer Item", "开发者物品");
                }

                if (item.Calamity().donorItem)
                {
                    line.Text = line.Text.Replace("Donor Item", "捐赠者物品");
                }

                if (item.accessory && !item.social && item.prefix > 0)
                {
                    line.Text = line.Text.Replace("damage reduction", "伤害减免");
                    line.Text = line.Text.Replace("stealth generation", "潜行值恢复速度");

                }
            }
        }
    }
}
