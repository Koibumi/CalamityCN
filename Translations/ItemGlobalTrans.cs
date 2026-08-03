// using System.Collections.Generic;
// using System.Linq;
// using Terraria;
// using Terraria.ModLoader;

// namespace CalamityCN.Translations
// {
//     public class ItemGlobalTrans : GlobalItem
//     {
//         public override bool IsLoadingEnabled(Mod mod)
//         {
//             return ModsCall.IsCN && ModsCall.Calamity != null;
//         }

//         private const string TranslatorTeamReferenceItem = "TheCommunity";
//         private static int TranslatorTeamReferenceItemType = -1;

//         public override void SetStaticDefaults()
//         {
//             TranslatorTeamReferenceItemType = -1;
//             Mod calamity = ModsCall.Calamity;

//             if (calamity != null &&
//             calamity.TryFind(TranslatorTeamReferenceItem, out ModItem theItem))
//             {
//                 TranslatorTeamReferenceItemType = theItem.Type;
//             }
//         }

//         public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//         {
//             if (item.type == TranslatorTeamReferenceItemType)
//             {
//                 var ThankYouTooltip = tooltips.FirstOrDefault(x => x.Name == "Tooltip3" && x.Mod == "Terraria");
//                 if (ThankYouTooltip != null)
//                     ThankYouTooltip.OverrideColor = Main.DiscoColor;
//             }
//         }
//     }
// }
