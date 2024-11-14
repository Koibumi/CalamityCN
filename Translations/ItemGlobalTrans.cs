using CalamityMod;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityCN.Utils;
using System.Runtime.CompilerServices;
using Terraria.Localization;

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
                if (Main.zenithWorld)
                {
                    tooltips.ReplaceText("盗贼", "盗贱");
                }
        }
    }
}
