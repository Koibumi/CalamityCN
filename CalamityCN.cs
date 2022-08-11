using System.Globalization;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.ModLoader;
using static On.Terraria.GameContent.UI.Elements.UIKeybindingListItem;
using static On.Terraria.Localization.LanguageManager;

namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        private static CalamityCN _instance;
        public static CalamityCN Instance => _instance;
        public override void PostSetupContent()
        {

            if (ModLoader.TryGetMod("CalamityMod", out Mod Calamity))
            {

                ItemNameDict itemNameDictionary = new ItemNameDict();
                ItemToolTipDict itemTooltipDictionary = new ItemToolTipDict();
                NPCNameDict npcNameDictionary = new NPCNameDict();
                BuffNameDict buffNameDictionary = new BuffNameDict();
                BuffDescriptionDict buffDescriptionDictionary = new BuffDescriptionDict();



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


                //NPC名称
                foreach (var npcName in npcNameDictionary.NPCName)
                {
                    Calamity.Find<ModNPC>(npcName.Key).DisplayName.AddTranslation(7, npcName.Value);
                }
            }
        }

        public override void Load()
        {
            _instance = this;
            SetLanguage_GameCulture += Fix;
            GetFriendlyName += TranslatedFriendlyName;
            Main.QueueMainThreadAction(() =>
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            });
        }
        public override void Unload()
        {
            Main.QueueMainThreadAction(() =>
            {
                Thread.CurrentThread.CurrentCulture = Language.ActiveCulture.CultureInfo;
            });
            SetLanguage_GameCulture -= Fix;
            GetFriendlyName -= TranslatedFriendlyName;
            _instance = null;
        }

        private void Fix(orig_SetLanguage_GameCulture orig, LanguageManager self, GameCulture culture)
        {
            orig.Invoke(self, culture);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }
        private string TranslatedFriendlyName(orig_GetFriendlyName orig, UIKeybindingListItem item)
        {
            string keybindName = item.GetType().GetField("_keybind", (BindingFlags)60).GetValue(item) as string;
            if (Language.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese))
            {
                if (keybindName == "CalamityMod: Normality Relocator")
                {
                    return "灾厄：常态定位器";
                }
                if (keybindName == "CalamityMod: Rage Mode")
                {
                    return "灾厄：暴怒模式";
                }
                if (keybindName == "CalamityMod: Adrenaline Mode")
                {
                    return "灾厄：肾上腺素";
                }
                if (keybindName == "CalamityMod: Elysian Guard")
                {
                    return "灾厄：极乐守护";
                }
                if (keybindName == "CalamityMod: Armor Set Bonus")
                {
                    return "灾厄：套装奖励";
                }
                if (keybindName == "CalamityMod: Astral Teleport")
                {
                    return "灾厄：天魔星石传送";
                }
                if (keybindName == "CalamityMod: Astral Arcanum UI Toggle")
                {
                    return "灾厄：星辉秘术UI";
                }
                if (keybindName == "CalamityMod: Momentum Capacitor Effect")
                {
                    return "灾厄：动量电容器";
                }
                if (keybindName == "CalamityMod: Sand Cloak Effect")
                {
                    return "灾厄：沙尘披风";
                }
                if (keybindName == "CalamityMod: Spectral Veil Teleport")
                {
                    return "灾厄：幽灵披风传送";
                }
                if (keybindName == "CalamityMod: Booster Dash")
                {
                    return "灾厄：喷射器冲刺";
                }
                if (keybindName == "CalamityMod: Angelic Alliance Blessing")
                {
                    return "灾厄：圣天誓盟祝福";
                }
                if (keybindName == "CalamityMod: God Slayer Dash")
                {
                    return "灾厄：弑神者冲刺";
                }
                if (keybindName == "CalamityMod: Exo Chair Speed Up")
                {
                    return "灾厄：星流飞椅加速";
                }
                if (keybindName == "CalamityMod: Exo Chair Slow Down")
                {
                    return "灾厄：星流飞椅减速";
                }
            }
            return orig.Invoke(item);

        }
    }
}