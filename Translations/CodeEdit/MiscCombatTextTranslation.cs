using CalamityMod.Projectiles.Melee;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalamityCN.Translations.CodeEdit
{
    public class MiscCombatTextTranslation
    {
        private static List<ILHook> ILHooks;
        public static void Load()
        {
            ILHooks = new List<ILHook>();
            QuickTranslate(typeof(ArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！".zh());
            QuickTranslate(typeof(TrueArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！".zh());
            QuickTranslate(typeof(ArkoftheElementsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！".zh());
            QuickTranslate(typeof(ArkoftheCosmosParryHoldout), "GeneralParryEffects", "Parry!", "格挡！".zh());

            foreach (ILHook hook in ILHooks)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
        public static void Unload()
        {
            foreach (ILHook hook in ILHooks)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            ILHooks = null;
        }
        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooks.Add(new ILHook(
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
