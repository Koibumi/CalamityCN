using CalamityCN.Utils;
using MonoMod.RuntimeDetour;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.ModLoader;
using static On.Terraria.GameContent.UI.Elements.UIKeybindingListItem;
using Terraria;

namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        public CalamityCN(){CalamityCN.Instance = this; base.PreJITFilter = new DisableJIT();}
        internal static CalamityCN Instance;
        public List<ContentTranslation> Contents;
        private List<Hook> _onHooks;
        public DynamicSpriteFont BossIntroScreensFont;

        public override void PostSetupContent()
        {
            /*(网址格式改不了https://url/wiki/{})
            ModLoader.TryGetMod("Wikithis", out Mod wikithis);
            if (wikithis != null && !Main.dedServ)
            {
                wikithis.Call(0, Calamity, "soammer.com/calamitywiki", GameCulture.CultureName.Chinese);
            }
            */

        }
        public override void Load()
        {
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

        public override void Unload()
        {
            GetFriendlyName -= TranslatedFriendlyName;

            Instance = null;
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
                if (keybindName == "CalamityMod: Exo Chair Slow Down")
                {
                    return "灾厄：星流飞椅减速";
                }
                if (keybindName == "CalamityMod: Dash Double Tap Override")
                {
                    return "灾厄：单击冲刺";
                }
                if (keybindName == "InfernumMode: Wayfinder Create Key")
                {
                    return "炼狱：魔法门创造键";
                }
                if (keybindName == "InfernumMode: Wayfinder Destroy Key")
                {
                    return "炼狱：魔法门破坏键";
                }
            }
            return orig.Invoke(item);

        }
    }
}