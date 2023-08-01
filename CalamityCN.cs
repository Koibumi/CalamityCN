using CalamityCN.Utils;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using System.Collections.Generic;
using MonoMod.RuntimeDetour;
using System.Reflection;
using System.Linq;
using System;

namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        public CalamityCN() { CalamityCN.Instance = this; base.PreJITFilter = new DisableJIT(); }
        internal static CalamityCN Instance;
        private List<Hook> _onHooks;

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
            foreach (Type type in CalamityCN.Instance.Code.GetTypes())
            {
                if (type.IsSubclassOf(typeof(OnPatcher)))
                {
                    OnPatcher onPatcher = Activator.CreateInstance(type) as OnPatcher;
                    // TODO: logger
                    if (onPatcher.ModifiedMethod != null && onPatcher != null && onPatcher.AutoLoad)
                    {
                        this._onHooks.Add(new Hook(onPatcher.ModifiedMethod, onPatcher.Delegate));
                    }
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
            }
            //typeof(LocalizationLoader).GetCachedMethod("Autoload").Invoke(null, new object[] { this });//强制重新加载自己Mod的hjson，因为patch加载在hjson加载后
        }

        public override void Unload()
        {
            Instance = null;
            if (this._onHooks != null)
            {
                foreach (Hook hook in this._onHooks)
                {
                    if (hook != null)
                    {
                        hook.Dispose();
                    }
                }
                this._onHooks = null;
                ClearCache();
            }
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