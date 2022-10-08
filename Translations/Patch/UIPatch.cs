using CalamityMod;
using CalamityMod.UI;
using CalamityMod.UI.ModeIndicator;
using CalamityMod.UI.DraedonSummoning;
using CalamityMod.UI.Rippers;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;


namespace CalamityCN.Translations.Patch
{
    public class UIPatch
    {
        
        private static List<ILHook> ILHooks;
        private static List<string> ExoUIText;
        public static void Load()
        {

                ILHooks = new List<ILHook>();
                ExoUIText = new List<string>(new string[]
                {
                "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.",
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。".zh(),
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。".zh(),
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。".zh()
                });

                for (int i = 0; i < 3; i++)
                {
                    QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", ExoUIText[i * 2], ExoUIText[i * 2 + 1]);
                }

                //难度UI
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", " Mode is ", "模式".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "active", "已启用".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "not active", "未启用".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Click to select a difficulty mode]", "[c/919191:点击选择难度]".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Higher difficulty modes can only be toggled in Expert Mode or above]", "[c/919191:只能在专家模式及以上时开启更高难度]".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "Currently Selected : ", "当前选择的难度：".zh());
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "\n[c/737373:Hold the 'Shift' key for more information]", "\n[c/737373:按住Shift键查看更多信息]".zh());
            //属性条
            QuickTranslate(typeof(RipperUI), "Draw", "Rage: ", "怒气:".zh());
            QuickTranslate(typeof(RipperUI), "Draw", "Adrenaline", "肾上腺素".zh());
            QuickTranslate(typeof(RipperUI), "Draw", "Nanomachines", "纳米机器".zh());

            //QuickTranslate(typeof(), "", "", "".zh());

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
            ExoUIText = null;
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
