using InfernumMode;
using InfernumMode.BehaviorOverrides.BossAIs.CalamitasClone;
using InfernumMode.BehaviorOverrides.BossAIs.DoG;
using InfernumMode.BehaviorOverrides.BossAIs.Draedon;
using InfernumMode.BehaviorOverrides.BossAIs.PlaguebringerGoliath;
using InfernumMode.BehaviorOverrides.BossAIs.Providence;
using InfernumMode.BehaviorOverrides.BossAIs.SupremeCalamitas;
using InfernumMode.BehaviorOverrides.BossAIs.Twins;
using InfernumMode.BehaviorOverrides.BossAIs.Yharon;
using InfernumMode.GlobalInstances;
using InfernumMode.ILEditingStuff;
using InfernumMode.Systems;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;

namespace CalamityCN.Translations.Patch
{
    [JITWhenModsEnabled(new string[]
    {
        "InfernumMode"
    })]
    public class InfernumPatch
    {
        private static List<ILHook> ILHooksI;
        public static void Load()
        {
            ILHooksI = new List<ILHook>();

            //难度
            QuickTranslate(typeof(InfernumDifficulty), "FavoredDifficultyAtTier", "Death", "死亡");
            QuickTranslate(typeof(InfernumDifficulty), "get_ExpandedDescription", "[c/B32E81:Many major foes will be different, having more challenging AI.] \n[c/B32E81:Adrenaline takes considerably longer to charge.] \n[c/FF0055:Adaptability is imperative.]", "[c/B32E81:大部分敌人变得不同，拥有更具挑战的AI。] \n[c/B32E81:肾上腺素充能时间变长。] \n[c/FF0055:适应力必不可少!]");
            //嘉登
            QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "DrawWrapper", "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "选择两台巨械。选择的第一台巨械一开始会单独作战\n当它受到一定量的伤害，选择的第二台巨械将会出现并协同战斗");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Artemis and Apollo, a pair of extremely agile destroyers with unstable energy reserves.", "阿尔忒弥斯和阿波罗，一对能量储备十分不稳定的超耐久自动机器。");

            //Override
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Now choose.", "现在，选择吧。");
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Your efforts are very intriguing.", "你的努力十分有趣。");
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Go on. Continue feeding information to my machines.", "继续，向我的机械输送更多信息。");
            string[][] DBOHDS = new string[][] {
               new string [2] {"Intriguing. Truly, intriguing.", "有趣，十分有趣。"},
               new string [2] {"My magnum opera, truly and utterly defeated.", "我的杰作，彻彻底底的失败了。"},
               new string [2] {"This outcome was not what I had expected.", "这个结果和我预料的不一样。"},
               new string [2] {"...Excuse my introspection. I must gather my thoughts after that display.", "……请原谅我的反省，但我必须得在这场展示之后整理我的思绪。"},
               new string [2] {"It is perhaps not irrational to infer that you are beyond my reasoning.", "推断你超出了我的计算范围，这也许不无道理。"},
               new string [2] {"Now.", "现在。"},
               new string [2] {"You would wish to reach the Tyrant. I cannot assist you in that.", "你想要接触那位暴君。可惜我无法帮到你。"},
               new string [2] {"It is not a matter of spite, for I would wish nothing more than to observe such a conflict.", "这并非出自怨恨，毕竟从一开始，我的目标就只有观察刚才的这一场战斗。"},
               new string [2] {"But now, I must return to my machinery. You may use the Codebreaker if you wish to face my creations once again.", "但是现在，我得回到我的机械工作上了。如果你想再次挑战我的造物可以使用破译器。"},
               new string [2] { "In the meantime, I bid you farewell, and good luck in your future endeavors.", "至此，该告别了，祝你未来旅途好运。" }
             };
            foreach (string[] il in DBOHDS)
            {
                if (!il[1].Equals(""))
                {
                    QuickTranslate(typeof(DraedonBehaviorOverride), "HandleDefeatStuff", il[0], il[1]);
                }
            }
            QuickTranslate(typeof(SupremeCalamitasBehaviorOverride), "DoBehavior_DesperationPhase", "... Congratulations.", "……恭喜你。");
            
            QuickTranslate(typeof(GlobalNPCOverrides), "OnKill", "A profaned shrine has erupted from the ashes at the underworld's edge!", "一座亵渎神庙从地狱边缘的灰烬中拔地而起！");
           
            QuickTranslate(typeof(PlaguebringerGoliathBehaviorOverride), "DoBehavior_BombConstructors", "NUCLEAR CORE GENERATED. INITIATING BUILD PROCEDURE!", "核能核心启动，组装程序启动！");
            
            QuickTranslate(typeof(ProvidenceBehaviorOverride), "PreAI", "The blazing air rises...", "空气变得灼热起来……");
            QuickTranslate(typeof(ProvidenceBehaviorOverride), "PreAI", "The blue flames roar...", "蓝色的火焰熊熊燃烧……");
            
            QuickTranslate(typeof(TwinsAttackSynchronizer), "DoAI", ": DEFENSES PENETRATED. INITIATING PROCEDURE SHLD-17ECF9.", "：防御被突破，启动程序SHLD-17ECF9。");
            QuickTranslate(typeof(TwinsAttackSynchronizer), "DoAI", ": ERROR DETECTING SECONDARY UNIT. BURNING EXCESS FUEL RESERVES.", "：检测到辅助装置错误，燃烧多余的燃料储备。");
            
            QuickTranslate(typeof(YharonBehaviorOverride), "DoBehavior_FinalDyingRoar", "The heat is surging...", "热浪滚滚……");
            QuickTranslate(typeof(YharonBehaviorOverride), "PreAI", "The air is scorching your skin...", "空气炙烤着你的皮肤……");
            
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "Destroy ", "消灭");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "him", "他");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "her", "她");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", ", my brothers.", "，兄弟们。");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "I will not be defeated so easily.", "我不会被轻易击败。");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "You will suffer.", "你将受尽折磨。");

            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!", "我不会被毁灭！！！");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!", "我不会被毁灭！！！");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!!", "我不会被毁灭！！！！");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT...", "我不会……");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I...", "我……");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "Phase2AI", "A GOD DOES NOT FEAR DEATH!", "神！不惧死亡！");
            //圣物
            QuickTranslate(typeof(Utilities), "get_InfernalRelicText", "Imbued with the infernal flames of a defeated foe", "击败的敌人被炼狱之火淹没");
            //POD
            QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "YOU CANNOT EVADE ME SO EASILY!", "你无法这么轻易地逃避我！");
            QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "YOU CANNOT HOPE TO OUTSMART A MASTER OF DIMENSIONS!", "你别指望智胜维度大师！");
            QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "NOT SO FAST!", "别跑太快！");
            QuickTranslate(typeof(PoDPlayer), "PostUpdateMiscEffects", "Infernum is not allowed in Master Mode, For the Worthy, or Eternity Mode.", "炼狱模式无法在大师模式、For the Worthy、永恒模式下启用。");
            QuickTranslate(typeof(PoDPlayer), "PreKill", " could not withstand the red lightning.", "无法承受住红色闪电。");
            QuickTranslate(typeof(PoDPlayer), "PreKill", " was incinerated by ungodly fire.", "被亵渎之火烧成灰烬。");
            QuickTranslate(typeof(PoDPlayer), "PreKill", " went mad.", "疯了。");

            //QuickTranslate(typeof(), "", "", "");

            foreach (ILHook hook in ILHooksI)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
        public static void Unload()
        {
            foreach (ILHook hook in ILHooksI)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            ILHooksI = null;
        }
        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooksI.Add(new ILHook(
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
