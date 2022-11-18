using CalamityCN.Utils;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.ModLoader;
using static On.Terraria.GameContent.UI.Elements.UIKeybindingListItem;


namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        private static CalamityCN _instance;
        public static CalamityCN Instance => _instance;
        public List<ContentTranslation> Contents;
        private List<Hook> _onHooks;

        public override void Load()
        {
            _instance = this;
            GetFriendlyName += TranslatedFriendlyName;
            MonoModHooks.RequestNativeAccess();
            this.Contents = new List<ContentTranslation>();
            this._onHooks = new List<Hook>();
            foreach (Type type in CalamityCN.Instance.Code.GetTypes())
            {
                if (type.IsSubclassOf(typeof(ContentTranslation)))
                {
                    ContentTranslation contentTranslation = Activator.CreateInstance(type) as ContentTranslation;
                    if (contentTranslation != null)
                    {
                        this.Contents.Add(contentTranslation);
                    }
                }
                if (type.IsSubclassOf(typeof(OnPatcher)))
                {
                    OnPatcher onPatcher = Activator.CreateInstance(type) as OnPatcher;
                    if (onPatcher != null && onPatcher.AutoLoad)
                    {
                        this._onHooks.Add(new Hook(onPatcher.ModifiedMethod, onPatcher.Delegate));
                    }
                }
                this.Contents.Sort((ContentTranslation n, ContentTranslation t) => n.Priority.CompareTo(t.Priority));
            }
            if (this._onHooks.Count > 0)
            {
                foreach (Hook hook in this._onHooks)
                {
                    if (hook != null)
                    {
                        hook.Apply();
                    }
                }
            }
            if (this.Contents.Count > 0)
            {
                foreach (ContentTranslation contentTranslation2 in from x in this.Contents
                                                                   where x.IsTranslationEnabled
                                                                   select x)
                {
                    ILoadableContent loadableContent = contentTranslation2 as ILoadableContent;
                    if (loadableContent != null)
                    {
                        loadableContent.LoadContent();
                    }
                }
            }
        }

        public override void PostSetupContent()
        {
            ModLoader.TryGetMod("CalamityMod", out Mod Calamity);
            /*(网址格式改不了https://url/wiki/{})
            ModLoader.TryGetMod("Wikithis", out Mod wikithis);
            if (wikithis != null && !Main.dedServ)
            {
                wikithis.Call(0, Calamity, "soammer.com/calamitywiki", GameCulture.CultureName.Chinese);
            }
            */
            if (Calamity !=null)
            {

                ItemNameDict.Load();
                ItemToolTipDict.Load();
                NPCNameDict.Load();
                BuffNameDict.Load();
                BuffDescriptionDict.Load();

                foreach (var itemName in ItemNameDict.ItemName)
                {
                    Calamity.Find<ModItem>(itemName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, itemName.Value);
                }
                foreach (var itemTooltip in ItemToolTipDict.ItemToolTip)
                {
                    Calamity.Find<ModItem>(itemTooltip.Key).Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, itemTooltip.Value);
                }
                foreach (var effectName in BuffNameDict.EffectName)
                {
                    Calamity.Find<ModBuff>(effectName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, effectName.Value);
                }
                foreach (var effectDescription in BuffDescriptionDict.EffectDescription)
                {
                    Calamity.Find<ModBuff>(effectDescription.Key).Description.AddTranslation((int)GameCulture.CultureName.Chinese, effectDescription.Value);
                }
                foreach (var npcName in NPCNameDict.NPCName)
                {
                    Calamity.Find<ModNPC>(npcName.Key).DisplayName.AddTranslation(7, npcName.Value);
                }
            }
        }
        public override void Unload()
        {
            GetFriendlyName -= TranslatedFriendlyName;

            ItemNameDict.Unload();
            ItemToolTipDict.Unload();
            NPCNameDict.Unload();
            BuffNameDict.Unload();
            BuffDescriptionDict.Unload();

            _instance = null;
            CalamityCNConfig.Instance = null;
            if (this.Contents != null)
            {
                foreach (ContentTranslation contentTranslation in this.Contents)
                {
                    ILoadableContent loadableContent = contentTranslation as ILoadableContent;
                    if (loadableContent != null)
                    {
                        loadableContent.UnloadContent();
                    }
                }
            }
            if (this._onHooks != null)
            {
                foreach (Hook hook in this._onHooks)
                {
                    if (hook != null)
                    {
                        hook.Dispose();
                    }
                }
            }
            this._onHooks = null;
            this.Contents = null;
        }

        private string TranslatedFriendlyName(orig_GetFriendlyName orig, UIKeybindingListItem item)
        {
            string keybindName = item.GetType().GetField("_keybind", (BindingFlags)60).GetValue(item) as string;
            if (Language.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese))
            {
                if (keybindName == "CalamityMod: Normality Relocator")
                {
                    return "灾厄：常态定位器".zh();
                }
                if (keybindName == "CalamityMod: Rage Mode")
                {
                    return "灾厄：暴怒模式".zh();
                }
                if (keybindName == "CalamityMod: Adrenaline Mode")
                {
                    return "灾厄：肾上腺素".zh();
                }
                if (keybindName == "CalamityMod: Elysian Guard")
                {
                    return "灾厄：极乐守护".zh();
                }
                if (keybindName == "CalamityMod: Armor Set Bonus")
                {
                    return "灾厄：套装奖励".zh();
                }
                if (keybindName == "CalamityMod: Astral Teleport")
                {
                    return "灾厄：天魔星石传送".zh();
                }
                if (keybindName == "CalamityMod: Astral Arcanum UI Toggle")
                {
                    return "灾厄：星辉秘术UI".zh();
                }
                if (keybindName == "CalamityMod: Sand Cloak Effect")
                {
                    return "灾厄：沙尘披风".zh();
                }
                if (keybindName == "CalamityMod: Spectral Veil Teleport")
                {
                    return "灾厄：幽灵披风传送".zh();
                }
                if (keybindName == "CalamityMod: Booster Dash")
                {
                    return "灾厄：喷射器冲刺".zh();
                }
                if (keybindName == "CalamityMod: Angelic Alliance Blessing")
                {
                    return "灾厄：圣天誓盟祝福".zh();
                }
                if (keybindName == "CalamityMod: God Slayer Dash")
                {
                    return "灾厄：弑神者冲刺".zh();
                }
                if (keybindName == "CalamityMod: Exo Chair Slow Down")
                {
                    return "灾厄：星流飞椅减速".zh();
                }
            }
            return orig.Invoke(item);

        }
    }
}