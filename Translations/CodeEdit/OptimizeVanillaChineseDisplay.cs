using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Reflection;
using Terraria;
using Terraria.Localization;

namespace CalamityCN.Translations.CodeEdit
{
    public class OptimizeVanillaChineseDisplay
    {
        private static ILHook wordwrapString;
        public static void Load()
        {
            wordwrapString = new ILHook(typeof(Utils).GetMethod("WordwrapString", (BindingFlags)60), new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr("-")))
                    return;
                cursor.Index += 2;
                cursor.EmitDelegate<Func<string, string>>((withHyphen) =>
                {
                    if (GameCulture.FromCultureName(GameCulture.CultureName.Chinese).IsActive)
                        return withHyphen.Substring(0, withHyphen.Length - 1);
                    else return withHyphen;
                });

                if (!cursor.TryGotoNext(i => i.MatchLdstr("-")))
                    return;
                cursor.Index += 2;
                cursor.EmitDelegate<Func<string, string>>((withHyphen) =>
                {
                    if (GameCulture.FromCultureName(GameCulture.CultureName.Chinese).IsActive)
                        return withHyphen.Substring(0, withHyphen.Length - 1);
                    else return withHyphen;
                });
            }));
            wordwrapString.Apply();
        }
        public static void Unload()
        {
            if (wordwrapString is not null)
                wordwrapString.Dispose();
            wordwrapString = null;
        }
    }
}
