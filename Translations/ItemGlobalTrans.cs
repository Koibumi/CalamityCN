using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using CalamityMod.Items.Accessories;

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
        if (item.type == ModContent.ItemType<TheCommunity>())
                {
                    var ThankYouTooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip3" && x.Mod == "Terraria");
                    if (ThankYouTooltip != null)
                        ThankYouTooltip.OverrideColor = Main.DiscoColor;
                }
        }
    }
}
