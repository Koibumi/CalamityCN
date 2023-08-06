using CalamityCN.Utils;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;
using MonoMod.RuntimeDetour;
using System.Reflection;
using System.Linq;
using System;
using ReLogic.Graphics;

namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        public CalamityCN() { CalamityCN.Instance = this; base.PreJITFilter = new DisableJIT(); }
        internal static CalamityCN Instance;
        private List<Hook> _onHooks;
        public List<ContentTranslation> Contents;
        public DynamicSpriteFont BossIntroScreensFont;

        public override void PostSetupContent()
        {
            ModLoader.TryGetMod("CalamityMod", out Mod Calamity);
            ModLoader.TryGetMod("Wikithis", out Mod wikithis);
            if (wikithis != null && !Main.dedServ)
            {
                wikithis.Call(0, Calamity, "calamity.huijiwiki.com", GameCulture.CultureName.Chinese);
            }
        }
        public override void Load()
        {
            this._onHooks = new List<Hook>();
            this.Contents = new List<ContentTranslation>();
            foreach (Type type in CalamityCN.Instance.Code.GetTypes())
            {
                if (type.IsSubclassOf(typeof(OnPatcher)))
                {
                    OnPatcher onPatcher = Activator.CreateInstance(type) as OnPatcher;
                    // TODO: logger
                    if (onPatcher != null && onPatcher.AutoLoad)
                    {
                        this._onHooks.Add(new Hook(onPatcher.ModifiedMethod, onPatcher.Delegate));
                    }
                }
                if (type.IsSubclassOf(typeof(ContentTranslation)))
                {
                    ContentTranslation contentTranslation = Activator.CreateInstance(type) as ContentTranslation;
                    if (contentTranslation != null)
                    {
                        this.Contents.Add(contentTranslation);
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

            //TODO
            //typeof(LocalizationLoader).GetCachedMethod("Autoload").Invoke(null, new object[] { this });//强制重新加载自己Mod的hjson，因为patch加载在hjson加载后
        }

        public override void Unload()
        {
            Instance = null;
            CalamityCNConfig.Instance = null;
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
            this._onHooks = null;
            this.Contents = null;
            ClearCache();
        }
        public static void ClearCache()
        {
            if (typeof(ReflectionHelper).GetField("AssembliesCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is Dictionary<string, WeakReference[]> cache1)
            {
                foreach (var key in cache1.Keys.ToArray())
                {
                    cache1.Remove(key);
                }
            }

            if (typeof(ReflectionHelper).GetField("ResolveReflectionCache", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null) is Dictionary<string, WeakReference> cache2)
            {
                foreach (var key in cache2.Keys.ToArray())
                {
                    cache2.Remove(key);
                }
            }
        }
    }
}