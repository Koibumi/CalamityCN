using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;
using CalamityMod;
using CalamityMod.Projectiles.Melee;
using CalamityMod.Projectiles.Summon;

namespace CalamityCN.Translations.Patch
{
    public class TextPatch
    {
        private static List<ILHook> ILHooksT;
        public static void Load()
        {
            ILHooksT = new List<ILHook>();
            QuickTranslate(typeof(ArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(TrueArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(ArkoftheElementsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(ArkoftheCosmosParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(AtlasMunitionsAutocannonHeld), "AI", "OUCH! HOT!", "我焯！好烫！");


            //QuickTranslate(typeof(), "", "", "");

            foreach (ILHook hook in ILHooksT)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
            public static void Unload()
            {
                foreach (ILHook hook in ILHooksT)
                {
                    if (hook is not null)
                        hook.Dispose();
                }
                ILHooksT = null;
            }
        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooksT.Add(new ILHook(
            type.GetMethod(methodName, (BindingFlags)60 | BindingFlags.Instance),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((eng) => trans);
            })));
        }
    }
}
