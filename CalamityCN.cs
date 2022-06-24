using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityCN
{
	public class CalamityCN : Mod
	{
        public CalamityCN()
        {

        }
        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod Calamity))
            {

                /*
                    ╔════════════════════════════════╗
                    ║ +-+ | 翻译加载 | +-+ ║
                    ╚════════════════════════════════╝
                */

                ItemNameDict itemNameDictionary = new ItemNameDict();
                ItemToolTipDict itemTooltipDictionary = new ItemToolTipDict();
                NPCNameDict npcNameDictionary = new NPCNameDict();
                BuffNameDict buffNameDictionary = new BuffNameDict();
                BuffDescriptionDict buffDescriptionDictionary = new BuffDescriptionDict();

                /*
                    ╔══════════════════════════════╗
                    ║ +-+ | 物品 | +-+ ║
                    ╚══════════════════════════════╝
                */

                //物品名称
                foreach (var itemName in itemNameDictionary.ItemName)
                {
                    Calamity.Find<ModItem>(itemName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, itemName.Value);
                }

                //物品说明
                foreach (var itemTooltip in itemTooltipDictionary.ItemToolTip)
                {
                    Calamity.Find<ModItem>(itemTooltip.Key).Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, itemTooltip.Value);
                }
                /*
                    ╔════════════════════════════════╗
                    ║ +-+ | 增益减益   | +-+ ║
                    ╚════════════════════════════════╝
                */

                //Buff名称
                foreach (var effectName in buffNameDictionary.EffectName)
                {
                    Calamity.Find<ModBuff>(effectName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, effectName.Value);
                }

                //Buff说明
                foreach (var effectDescription in buffDescriptionDictionary.EffectDescription)
                {
                    Calamity.Find<ModBuff>(effectDescription.Key).Description.AddTranslation((int)GameCulture.CultureName.Chinese, effectDescription.Value);
                }
                /*
                    ╔═════════════════════════════╗
                    ║ +-+ | NPC | +-+ ║
                    ╚═════════════════════════════╝
                */

                //NPC名称
                foreach (var npcName in npcNameDictionary.NPCName)
                {
                    Calamity.Find<ModNPC>(npcName.Key).DisplayName.AddTranslation(7, npcName.Value);
                }
            }
        }
    }
}