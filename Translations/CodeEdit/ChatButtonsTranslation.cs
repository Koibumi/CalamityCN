using CalamityMod.NPCs.TownNPCs;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CalamityCN.Translations.CodeEdit
{
    public class ChatButtonsTranslation
    {
        private static List<ILHook> buttonTranslation;

        public static void Load()
        {
            buttonTranslation = new List<ILHook>();

            QuickTranslate(typeof(THIEF), "Refund", "退款".zh());
            QuickTranslate(typeof(SEAHOE), "Help", "帮助".zh());
            QuickTranslate(typeof(WITCH), "Enchant", "咒术炼注".zh());
            QuickTranslate(typeof(FAP), "Death Count", "死亡次数".zh());
            foreach (ILHook hook in buttonTranslation)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
        public static void Unload()
        {
            foreach (ILHook hook in buttonTranslation)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            buttonTranslation = null;
        }
        private static void QuickTranslate(Type type, string origin, string trans)
        {
            buttonTranslation.Add(new ILHook(
            type.GetMethod("SetChatButtons", (BindingFlags)60 | BindingFlags.GetProperty),
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
