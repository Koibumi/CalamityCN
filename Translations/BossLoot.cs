using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using CalamityMod.Projectiles.Summon.SmallAresArms;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityCN.Utils;

namespace CalamityCN.Translations.Patch {
    public class BossLoot {
        // private static List<ILHook> ILHooksT;
        // public static void Load() {
        //     ILHooksT = new List<ILHook>();

        //     //死亡名称
        //     QuickTranslate(typeof(CalamitasClone), "BossLoot", "The Calamitas Clone", "灾厄之影");
        //     QuickTranslate(typeof(RavagerBody), "BossLoot", "Ravager", "毁灭魔像");
        //     QuickTranslate(typeof(Bumblefuck), "BossLoot", "A Dragonfolly", "痴愚金龙");
        //     QuickTranslate(typeof(ProfanedGuardianCommander), "BossLoot", "A Profaned Guardian", "亵渎守卫");
        //     QuickTranslate(typeof(ProfanedGuardianDefender), "BossLoot", "A Profaned Guardian", "亵渎守卫");
        //     QuickTranslate(typeof(ProfanedGuardianHealer), "BossLoot", "A Profaned Guardian", "亵渎守卫");

        //     //QuickTranslate(typeof(), "", "", "".zh());

        //     foreach (ILHook hook in ILHooksT)
        //     {
        //         if (hook is not null)
        //             hook.Apply();
        //     }
        // }
        //     public static void Unload()
        //     {
        //         foreach (ILHook hook in ILHooksT)
        //         {
        //             if (hook is not null)
        //                 hook.Dispose();
        //         }
        //         ILHooksT = null;
        //     }
        // private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        // {
        //     ILHooksT.Add(new ILHook(
        //     type.GetCachedMethod(methodName),
        //     new ILContext.Manipulator(il =>
        //     {
        //         var cursor = new ILCursor(il);
        //         if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
        //             return;
        //         cursor.Index++;
        //         cursor.EmitDelegate<Func<string, string>>((eng) => trans);
        //     })));
        // }
    }
}
