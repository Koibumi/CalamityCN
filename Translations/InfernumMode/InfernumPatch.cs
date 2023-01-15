using CalamityCN.Utils;
using InfernumMode;
using InfernumMode.Content.Achievements.InfernumAchievements;
using InfernumMode.Content.BehaviorOverrides.BossAIs.CalamitasClone;
using InfernumMode.Content.BehaviorOverrides.BossAIs.DoG;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.Ares;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.ArtemisAndApollo;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Draedon.Thanatos;
using InfernumMode.Content.BehaviorOverrides.BossAIs.PlaguebringerGoliath;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Providence;
using InfernumMode.Content.BehaviorOverrides.BossAIs.SupremeCalamitas;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Twins;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Yharon;
using InfernumMode.Content.BossIntroScreens;
using InfernumMode.Core.GlobalInstances.Systems;
using InfernumMode.GlobalInstances;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
    public class InfernumPatch
    {
        private static List<ILHook> ILHooksI;
        public static void Load()
        {
            ILHooksI = new List<ILHook>();

            //成就
            QuickTranslate(typeof(BabysFirstAchievement), "Initialize", "First Of Many", "死海无涯");
            QuickTranslate(typeof(BabysFirstAchievement), "Initialize", "The higher the count, the more you've learnt\n[c/777777:Die to an Infernum boss]", "死的越多，懂得越多\n[c/777777:在炼狱模式下死于Boss]");
            QuickTranslate(typeof(BereftVassalAchievement), "Initialize", "Forgotten Sands", "尘封已久");
            QuickTranslate(typeof(BereftVassalAchievement), "Initialize", "Best the Bereft Vassal in combat, in the far reaches of the desert's dunes\n[c/777777:Defeat the Bereft Vassal]", "在远方的沙丘的边缘击败无邦遗臣\n[c/777777:击败无邦遗臣]");
            QuickTranslate(typeof(ExoPathAchievement), "Initialize", "Lab Rat", "实验白鼠");
            QuickTranslate(typeof(ExoPathAchievement), "Initialize", "Become Draedon's favorite test subject\n[c/777777:Beat all Infernum Exo Mech combinations]", "成为嘉登最爱的实验素材\n[c/777777:在炼狱模式中击败所以星流巨械组合]");
            QuickTranslate(typeof(InfernalChaliceAchievement), "Initialize", "Baptized By Hellfire", "狱火洗礼");
            QuickTranslate(typeof(InfernalChaliceAchievement), "Initialize", "Complete the final challenge, and earn your reward\n[c/777777:Obtain the Infernal Chalice]", "完成最终挑战，并领取你的奖励\n[c/777777:获得炼狱圣杯]");
            QuickTranslate(typeof(KillAllBossesAchievement), "Initialize", "Infer-it-all!", "全都下炼狱去吧！");
            QuickTranslate(typeof(KillAllBossesAchievement), "Initialize", "Rip and tear, until it is done\n[c/777777:Beat every Infernum Boss]", "撕碎一切，直至尘埃落定\n[c/777777:在炼狱模式中击败每一个Boss]");
            QuickTranslate(typeof(KillAllMinibossesAchievement), "Initialize", "Mini-Meany!", "小小的震撼！");
            QuickTranslate(typeof(KillAllMinibossesAchievement), "Initialize", "Defeat the various minor threats across the world!\n[c/777777:Beat every Infernum Miniboss]", "击败潜藏在世界各地的威胁\n[c/777777:在炼狱模式中击败每一个迷你Boss]");
            QuickTranslate(typeof(MechaMayhemAchievement), "Initialize", "Malicious Machinery", "恶意军工厂");
            QuickTranslate(typeof(MechaMayhemAchievement), "Initialize", "Decommission the Maniacal Mechanical trio in one fell swoop!\n[c/777777:Beat Infernum Mecha-Mayhem]", "在一次清扫中同时让三台疯狂的机器报废\n[c/777777:在炼狱模式下击败机甲暴乱]");
            QuickTranslate(typeof(NightProviAchievement), "Initialize", "Night Knight", "午夜骑士");
            QuickTranslate(typeof(NightProviAchievement), "Initialize", "Challenge the Profaned Goddess under the gaze of the stars\n[c/777777:Beat Infernum Night Providence]", "在群星的注视中向亵渎天神发起挑战\n[c/777777:在炼狱模式中击败夜晚亵渎天神]");
            QuickTranslate(typeof(RamlessDoGAchievement), "Initialize", "Ramification", "寸止挑战");
            QuickTranslate(typeof(RamlessDoGAchievement), "Initialize", "Best the Devourer at his own game: without a ram!\n[c/777777:Beat the Infernum Devourer of Gods without using a ram dash]", "将计就计击败神明吞噬者\n[c/777777:在炼狱模式中不使用冲刺击败神明吞噬者]");
            //难度
            QuickTranslate(typeof(InfernumDifficulty), "FavoredDifficultyAtTier", "Death", "死亡");
            QuickTranslate(typeof(InfernumDifficulty), "get_ExpandedDescription", "[c/B32E81:Many major foes will be different, having more challenging AI.] \n[c/B32E81:Adrenaline takes considerably longer to charge.] \n[c/FF0055:Adaptability is imperative.]", "[c/B32E81:大部分敌人变得不同，拥有更具挑战的AI。] \n[c/B32E81:肾上腺素充能时间变长。] \n[c/FF0055:适应力必不可少!]");
            //嘉登
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "DrawWrapper", "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "选择两台巨械。选择的第一台巨械一开始会单独作战\n当它受到了一定的伤害后，选择的第二台巨械将会出现并协同战斗");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。");
            //QuickTranslate(typeof(DrawDraedonSelectionUIWithAthena), "HandleInteractionWithButton", "Artemis and Apollo, a pair of extremely agile destroyers with unstable energy reserves.", "阿尔忒弥斯和阿波罗，一对能量储备十分不稳定的超耐久自动机器。");
            //Override
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Now choose.", "现在，选择吧。");
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Your efforts are very intriguing.", "你的努力十分有趣。");
            QuickTranslate(typeof(DraedonBehaviorOverride), "PreAI", "Go on. Continue feeding information to my machines.", "继续吧，向我的机械输送更多信息。");
            string[][] DBOHDS = new string[][] {
               new string [2] {"Intriguing. Truly, intriguing.", "有趣，十分有趣。"},
               new string [2] {"My magnum opera, truly and utterly defeated.", "我引以为傲的杰作，彻底失败了。"},
               new string [2] {"This outcome was not what I had expected.", "这也非是我预期中的结果。"},
               new string [2] {"...Excuse my introspection. I must gather my thoughts after that display.", "……很抱歉，但在看了这样一场“展示”之后，我必须得花点时间整理我的思绪。"},
               new string [2] {"It is perhaps not irrational to infer that you are beyond my reasoning.", "分析你的行为已超出了我的计算能力，但这也许并不荒谬。"},
               new string [2] {"Now.", "现在。"},
               new string [2] {"You would wish to reach the Tyrant. I cannot assist you in that.", "你想要接触那位暴君。可惜我无法帮到你。"},
               new string [2] {"It is not a matter of spite, for I would wish nothing more than to observe such a conflict.", "这并非出自怨恨，毕竟从一开始，我的目标就只有观察刚才的这一场战斗。"},
               new string [2] {"But now, I must return to my machinery. You may use the Codebreaker if you wish to face my creations once again.", "但现在，我得把注意力放回到我的机械上了。如果你想再次面对我的造物，就使用密码破译器吧。"},
               new string [2] { "In the meantime, I bid you farewell, and good luck in your future endeavors.", "至此，我向你道别，祝你的未来一路顺风。" }
             };
            foreach (string[] il in DBOHDS)
            {
                if (!il[1].Equals(""))
                {
                    QuickTranslate(typeof(DraedonBehaviorOverride), "HandleDefeatStuff", il[0], il[1]);
                }
            }
            #region Exo Mechs
            // Ares
            QuickTranslate(typeof(AresBodyBehaviorOverride), "DoBehavior_PrecisionBlasts", "ARES-09: CORE TEMPERATURES RAPIDLY INCREASING. SELF DESTRUCTION IMMINENT.", "");
            QuickTranslate(typeof(AresBodyBehaviorOverride), "DoBehavior_PrecisionBlasts", "ARES-09: PREPARING 'PRECISION GAMMA-BLASTS' MUTUAL DESTRUCTION PROTOCOL.", "");
            QuickTranslate(typeof(AresBodyBehaviorOverride), "DoBehavior_PrecisionBlasts", "You have made a grave miscalculation.", "");
            // Apollo & Artemis
            QuickTranslate(typeof(ApolloBehaviorOverride), "DoBehavior_ThemonuclearBlitz", "ARTEMIS-01: COMBINED ENERGY RESERVES AT LOW CAPACITY. SYSTEM FAILURE IMMINENT.", "");
            QuickTranslate(typeof(ApolloBehaviorOverride), "DoBehavior_ThemonuclearBlitz", "APOLLO-03: PREPARING 'THERMONUCLEAR BLITZ' MUTUAL DESTRUCTION PROTOCOL.", "");
            // Thanatos
            QuickTranslate(typeof(ThanatosHeadBehaviorOverride), "DoBehavior_MaximumOverdrive", "THANATOS-05: EXO TURRETS BURNING AT UNSTABLE ENERGY LEVELS. SELF DESTRUCTION IMMINENT.", "");
            QuickTranslate(typeof(ThanatosHeadBehaviorOverride), "DoBehavior_MaximumOverdrive", "THANATOS-05: PREPARING 'MAXIMUM OVERDRIVE CHARGE' MUTUTAL DESTRUCTION PROTOCOL.", "");
            #endregion

            QuickTranslate(typeof(SupremeCalamitasBehaviorOverride), "DoBehavior_DesperationPhase", "... Congratulations.", "……恭喜你。");
            
            QuickTranslate(typeof(GlobalNPCOverrides), "OnKill", "A profaned shrine has erupted from the ashes at the underworld's edge!", "一座亵渎神庙从地狱边缘的灰烬中拔地而起！");
           
            QuickTranslate(typeof(PlaguebringerGoliathBehaviorOverride), "DoBehavior_BombConstructors", "NUCLEAR CORE GENERATED. INITIATING BUILD PROCEDURE!", "核能核心启动，组装程序启动！");
            
            QuickTranslate(typeof(ProvidenceBehaviorOverride), "PreAI", "The blazing air rises...", "空气变得灼热起来……");
            QuickTranslate(typeof(ProvidenceBehaviorOverride), "PreAI", "The blue flames roar...", "苍蓝的烈火猛烈咆哮……");
            
            QuickTranslate(typeof(TwinsAttackSynchronizer), "DoAI", ": DEFENSES PENETRATED. INITIATING PROCEDURE SHLD-17ECF9.", "：防御被突破，启动程序SHLD-17ECF9。");
            QuickTranslate(typeof(TwinsAttackSynchronizer), "DoAI", ": ERROR DETECTING SECONDARY UNIT. BURNING EXCESS FUEL RESERVES.", "：检测到辅助装置错误，燃烧多余的燃料储备。");
            
            QuickTranslate(typeof(YharonBehaviorOverride), "DoBehavior_FinalDyingRoar", "The heat is surging...", "热浪滚滚……");
            QuickTranslate(typeof(YharonBehaviorOverride), "PreAI", "The air is scorching your skin...", "空气炙烤着你的皮肤……");
            
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "Destroy ", "摧毁");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "him", "他");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "her", "她");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", ", my brothers.", "，我的兄弟们。");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "I will not be defeated so easily.", "我不会被轻易击败。");
            QuickTranslate(typeof(CalamitasCloneBehaviorOverride), "PreAI", "You will suffer.", "你将痛不欲生。");

            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!", "我不会被毁灭！！！");
            //第二个重复当前代码翻译不到，摆
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!", "我不会被毁灭！！！");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT BE DESTROYED!!!!", "我不会被毁灭！！！！");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I WILL NOT...", "我不会……");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "DoDeathEffects", "I...", "我……");
            QuickTranslate(typeof(DoGPhase2HeadBehaviorOverride), "Phase2AI", "A GOD DOES NOT FEAR DEATH!", "神！不惧死亡！");
            //圣物
            QuickTranslate(typeof(Utilities), "get_InfernalRelicText", "Imbued with the infernal flames of a defeated foe", "以殁者之火铸其形，其焰猩赫");
            //POD
            //QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "YOU CANNOT EVADE ME SO EASILY!", "想如此轻易地躲开我？绝无可能！");
            //QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "YOU CANNOT HOPE TO OUTSMART A MASTER OF DIMENSIONS!", "智取一名掌控次元的大师？痴心妄想！");
            //QuickTranslate(typeof(PoDItems), "DoGTeleportDenialText", "NOT SO FAST!", "太慢了！");
            //QuickTranslate(typeof(PoDPlayer), "PostUpdateMiscEffects", "Infernum is not allowed in Master Mode, For the Worthy, or Eternity Mode.", "炼狱模式无法在大师模式、For the Worthy种子、永恒模式下启用。");
            //QuickTranslate(typeof(PoDPlayer), "PreKill", " could not withstand the red lightning.", "无法承受住红色闪电。");
            //QuickTranslate(typeof(PoDPlayer), "PreKill", " was incinerated by ungodly fire.", "被亵渎之火烧成灰烬。");
            //QuickTranslate(typeof(PoDPlayer), "PreKill", " went mad.", "疯了。");
            //Intro
            if (CalamityCNConfig.Instance.InfernumCNFont)
            {
                QuickTranslate(typeof(AnahitaIntroScreen), "get_TextToDisplay", "Forgotten Deity\nAnahita", "遗忘精灵\n阿娜希塔");
                QuickTranslate(typeof(AquaticScourgeIntroScreen), "get_TextToDisplay", "Sulphuric Serpent\nThe Aquatic Scourge", "Sulphuric Serpent\n渊海灾虫");
                QuickTranslate(typeof(AresIntroScreen), "get_TextToDisplay", "Prediction Game Master\nAres", "预判游戏大师\n阿瑞斯");
                QuickTranslate(typeof(AresIntroScreen), "get_TextToDisplay", "The Ultimate War Machine\nAres", "终极战争机器\n阿瑞斯");
                QuickTranslate(typeof(ArtemisAndApolloIntroScreen), "get_TextToDisplay", "The Supreme Hunters\nArtemis and Apollo", "终极猎手\n阿尔忒弥斯和阿波罗");
                QuickTranslate(typeof(AstrumAureusIntroScreen), "get_TextToDisplay", "The Infected Stomper\nAstrum Aureus", "The Infected Stomper\n白金星舰");
                QuickTranslate(typeof(AstrumDeusIntroScreen), "get_TextToDisplay", "The Star Weaver\nAstrum Deus", "织星者\n星神游龙");
                QuickTranslate(typeof(BetsyIntroScreen), "get_TextToDisplay", "Mother of Wyverns\nBetsy", "Mother of Wyverns\n双足翼龙");
                QuickTranslate(typeof(BrainOfCthulhuIntroScreen), "get_TextToDisplay", "Eldritch Mind\nThe Brain of Cthulhu", "Eldritch Mind\n克苏鲁之脑");
                QuickTranslate(typeof(BrimstoneElementalIntroScreen), "get_TextToDisplay", "Scarred Numen\nThe Brimstone Elemental", "Scarred Numen\n硫磺火元素");
                QuickTranslate(typeof(CalamitasCloneIntroScreen), "get_TextToDisplay", "False Witch\nCalamitas' Clone", "False Witch\n灾厄之影");
                QuickTranslate(typeof(CeaselessVoidIntroScreen), "get_TextToDisplay", "The Never-Ending\nCeaseless Void", "The Never-Ending\n无尽虚空");
                QuickTranslate(typeof(CrabulonIntroScreen), "get_TextToDisplay", "The Reanimated Carcass\nCrabulon", "The Reanimated Carcass\n菌生蟹");
                QuickTranslate(typeof(CryogenIntroScreen), "get_TextToDisplay", "The Unstable Prison\nCryogen", "The Unstable Prison\n极地之灵");
                QuickTranslate(typeof(CultistIntroScreen), "get_TextToDisplay", "Ancient Doomsayer\nThe Lunatic Cultist", "Ancient Doomsayer\n拜月教邪教徒");
                QuickTranslate(typeof(DeerclopsIntroScreen), "get_TextToDisplay", "Winter Beast\nThe Deerclops", "Winter Beast\n独眼巨鹿 ");
                QuickTranslate(typeof(DesertScourgeIntroScreen), "get_TextToDisplay", "Dried Glutton\nThe Desert Scourge", "Dried Glutton\n荒漠灾虫");
                QuickTranslate(typeof(DestroyerIntroScreen), "get_TextToDisplay", "World Excavator\nThe Destroyer", "World Excavator\n毁灭者");
                QuickTranslate(typeof(DoGIntroScreen), "get_TextToDisplay", "The Conceited\nDevourer of Gods", "The Conceited\n神明吞噬者");
                QuickTranslate(typeof(DraedonIntroScreen), "get_TextToDisplay", "The Cosmic Engineer\nDraedon", "寰宇匠师\n嘉登");
                QuickTranslate(typeof(DragonfollyIntroScreen), "get_TextToDisplay", "Failed Experiment\nThe Dragonfolly", "Failed Experiment\n痴愚金龙");
                QuickTranslate(typeof(DreadnautilusIntroScreen), "get_TextToDisplay", "Nightmare of the Blood Moon\nDreadnautilus", "Nightmare of the Blood Moon\n恐惧鹦鹉螺");
                QuickTranslate(typeof(DukeFishronIntroScreen), "get_TextToDisplay", "Terror of the Seas\nDuke Fishron", "Terror of the Seas\n猪龙鱼公爵");
                QuickTranslate(typeof(EaterOfWorldsIntroScreen), "get_TextToDisplay", "Terror of the Corruption\nThe Eater of Worlds", "Terror of the Corruption\n世界吞噬者");
                QuickTranslate(typeof(EmpressOfLightIntroScreen), "get_TextToDisplay", "Prismatic Fae\nThe Empress of Light", "Prismatic Fae\n光之女皇");
                QuickTranslate(typeof(EyeOfCthulhuIntroScreen), "get_TextToDisplay", "Demonic Seer\nThe Eye of Cthulhu", "Demonic Seer\n克苏鲁之眼");
                //QuickTranslate(typeof(GolemIntroScreen), "get_TextToDisplay", "NUMBER ! SALSMAN\n[Circa 1997]", "NUMBER ! SALSMAN\n[Circa 1997]");
                QuickTranslate(typeof(GolemIntroScreen), "get_TextToDisplay", "The Ancient Idol\nGolem", "The Ancient Idol\n石巨人");
                QuickTranslate(typeof(HiveMindIntroScreen), "get_TextToDisplay", "Collective Growth\nThe Hive Mind", "Collective Growth\n腐巢意志");
                QuickTranslate(typeof(KingSlimeIntroScreen), "get_TextToDisplay", "Monarch of the Gelatinous\nKing Slime", "Monarch of the Gelatinous\n史莱姆王");
                QuickTranslate(typeof(LeviathanIntroScreen), "get_TextToDisplay", "Timeworn Beast\nThe Leviathan", "Timeworn Beast\n利维坦");
                //QuickTranslate(typeof(MoonLordIntroScreen), "get_TextToDisplay", "The Remains of the Moon Lord-", "The Remains of the Moon Lord-");
                QuickTranslate(typeof(OldDukeIntroScreen), "get_TextToDisplay", "Speed Demon\nThe Old Duke", "Speed Demon\n硫海遗爵");
                QuickTranslate(typeof(OldDukeIntroScreen), "get_TextToDisplay", "Sulphuric Terror\nThe Old Duke", "Sulphuric Terror\n硫海遗爵");
                QuickTranslate(typeof(PBGIntroScreen), "get_TextToDisplay", "Infected Insectoid\nThe Plaguebringer Goliath", "Infected Insectoid\n瘟疫使者歌莉娅");
                QuickTranslate(typeof(PerforatorHiveIntroScreen), "get_TextToDisplay", "Bloodied Parasites\nThe Perforators", "Bloodied Parasites\n血肉宿主");
                QuickTranslate(typeof(PlanteraIntroScreen), "get_TextToDisplay", "The Overgrowth\nPlantera", "The Overgrowth\n世纪之花");
                QuickTranslate(typeof(PolterghastIntroScreen), "get_TextToDisplay", "Wrathful Coalescence\nThe Polterghast", "Wrathful Coalescence\n噬魂幽花");
                QuickTranslate(typeof(ProfanedGuardiansIntroScreen), "get_TextToDisplay", "Disciples of Purity\nThe Profaned Guardians", "Disciples of Purity\n亵渎守卫");
                //QuickTranslate(typeof(ProfanedTempleIntroScreen), "get_TextToDisplay", "Cleansed Site\nThe Profaned Garden", "Cleansed Site\nThe Profaned Garden");
                QuickTranslate(typeof(ProvidenceIntroScreen), "get_TextToDisplay", "The Blaze of Purity\nProvidence", "The Blaze of Purity\n亵渎天神");
                QuickTranslate(typeof(ProvidenceIntroScreen), "get_TextToDisplay", "The Blaze of Absolution\nProvidence", "The Blaze of Absolution\n亵渎天神");
                QuickTranslate(typeof(QueenBeeIntroScreen), "get_TextToDisplay", "Oversized Insect\nQueen Bee", "Oversized Insect\n蜂王");
                QuickTranslate(typeof(QueenSlimeIntroScreen), "get_TextToDisplay", "Hallowed Mass\nThe Queen Slime", "Hallowed Mass\n史莱姆皇后");
                QuickTranslate(typeof(RavagerIntroScreen), "get_TextToDisplay", "The Fortress of Flesh\nRavager", "The Fortress of Flesh\n毁灭魔像");
                QuickTranslate(typeof(SCalIntroScreen), "get_TextToDisplay", "The Brimstone Witch\nCalamitas", "硫火女巫\n至尊灾厄");
                QuickTranslate(typeof(SignusIntroScreen), "get_TextToDisplay", "The Fathomless Assassin\nSignus", "The Fathomless Assassin\n神之使徒西格纳斯");
                QuickTranslate(typeof(SkeletronIntroScreen), "get_TextToDisplay", "The Old Man's Curse\nSkeletron", "The Old Man's Curse\n骷髅王");
                QuickTranslate(typeof(SkeletronPrimeIntroScreen), "get_TextToDisplay", "Contraption of Dread\nSkeletron Prime", "Contraption of Dread\n机械骷髅王");
                QuickTranslate(typeof(SlimeGodIntroScreen), "get_TextToDisplay", "Primordial Formation\nThe Slime God", "Primordial Formation\n史莱姆之神");
                QuickTranslate(typeof(StormWeaverIntroScreen), "get_TextToDisplay", "Atmospheric Predator\nThe Storm Weaver", "Atmospheric Predator\n风暴编织者");
                QuickTranslate(typeof(ThanatosIntroScreen), "get_TextToDisplay", "The Perfect Annihilator\nThanatos", "The Perfect Annihilator\n塔纳托斯");
                QuickTranslate(typeof(TwinsIntroScreen), "get_TextToDisplay", "Mechanical Observers\nRetinazer and Spazmatism", "Mechanical Observers\n双子魔眼");
                QuickTranslate(typeof(WoFIntroScreen), "get_TextToDisplay", "Hungering Conglomeration\nThe Wall of Flesh", "Hungering Conglomeration\n血肉墙");
                //当前字体文件没“犽”字，悲
                QuickTranslate(typeof(YharonIntroScreen), "get_TextToDisplay", "Grand\nYharon", "Grand\n丛林龙 牙戎");
                QuickTranslate(typeof(YharonIntroScreen), "get_TextToDisplay", "Unwavering Guardian\nYharon", "Unwavering Guardian\n丛林龙 牙戎");
            }
            
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
            type.GetCachedMethod(methodName),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((eng) => trans);
            })));
        }
        private static void QuickTranslate(Type type, string methodName, string origin, string trans, int times)
        {
            ILHooksI.Add(new ILHook(
            type.GetCachedMethod(methodName),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                for (int i = 0; i < times; i++)
                {
                    if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                        return;
                    cursor.Index++;
                    cursor.EmitDelegate<Func<string, string>>((eng) => trans);
                }
            })));
        }
    }
}
