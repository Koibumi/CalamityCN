using CalamityMod.UI;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Reflection;
using Terraria;
using Terraria.Localization;

namespace CalamityCN.Translations.CodeEdit
{
    public class OptimizeChineseDisplay
    {
        private static ILHook wordwrapString; // 原版WordwrapString函数，会在换行时自动判断英文词语位置并增加连接符
        private static ILHook draedonDecryptionStuff; // 嘉登解密时出现的乱码错位空行问题
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

            draedonDecryptionStuff = new ILHook(typeof(CodebreakerUI).GetMethod("HandleDecryptionStuff", BindingFlags.Public | BindingFlags.Static), new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchCall(typeof(Char).GetMethod("IsWhiteSpace", new Type[] { typeof(Char) }))))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<bool, bool>>((isWhiteSpace) => (!GameCulture.FromCultureName(GameCulture.CultureName.Chinese).IsActive) && isWhiteSpace);
            }));

            wordwrapString.Apply();
            draedonDecryptionStuff.Apply();
        }
        public static void Unload()
        {
            if (wordwrapString is not null)
                wordwrapString.Dispose();
            if (draedonDecryptionStuff is not null)
                draedonDecryptionStuff.Dispose();

            wordwrapString = null;
            draedonDecryptionStuff = null;
        }
    }
}
