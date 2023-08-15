using CalamityCN.Utils;
using InfernumMode;
using InfernumMode.Content.Achievements;
using InfernumMode.Content.Achievements.DevWishes;
using InfernumMode.Content.Achievements.InfernumAchievements;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Cultist;
using InfernumMode.Content.Items.Accessories;
using InfernumMode.Content.Items.Misc;
using InfernumMode.Content.Items.Weapons.Magic;
using InfernumMode.Content.Projectiles;
using InfernumMode.Content.Tiles.Profaned;
using InfernumMode.Content.UI;
using InfernumMode.Core.GlobalInstances.Players;
using InfernumMode.Core.GlobalInstances.Systems;
using InfernumMode.Core.ILEditingStuff;
using InfernumModeMusic.Projectiles;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;

namespace CalamityCN.Translations.InfernumMode
{
    public class InfernumPatch
    {
        private static List<ILHook> ILHooksI;

        public static void Load()
        {
            ILHooksI = new List<ILHook>();

            //1.9.28进入提示
            QuickTranslate(typeof(UIPlayer), "OnEnterWorld", "[c/b90000:Infernum Mod: You have the ", "[c/b90000:炼狱模组： 你启用了");
            QuickTranslate(typeof(UIPlayer), "OnEnterWorld", " mod(s) enabled, these may cause some boss fights to crash.]\n[c/b90000:A fix is being worked on, but for the meantime disabling the mod(s) will fix the crashing.]", "模组，它可能造成一些Boss战斗报错。]\n[c/b90000:修复工作还在进行，但你可以禁用该模组暂时解决报错。]");

            //成就
            QuickTranslate(typeof(Achievement), "OnCompletion", "Achievement Completed! [c/ff884d:", "成就完成 [c/ff884d:");
            QuickTranslate(typeof(Achievement), "WishCompletionEffects", "Dev Wish Completed! [c/ff884d:", "开发者祈愿完成 [c/ff884d:");
            QuickTranslate(typeof(AchievementMenuUIHookEdit), "AchievementAdvisor_DrawOneAchievement", "Open Death Wishes", "打开死亡祈愿");
            QuickTranslate(typeof(AchievementUIManager), "InitializePage", "Death Wishes", "死亡祈愿");
            QuickTranslate(typeof(WishesUIManager), "InitializePage", "Dev Wishes", "开发者祈愿");
            #region Death Wishes
            QuickTranslate(typeof(BabysFirstAchievement), "Initialize", "First Of Many", "死海无涯");
            QuickTranslate(typeof(BabysFirstAchievement), "Initialize", "The higher the count, the more you've learnt\n[c/777777:Die to an Infernum boss]", "死的越多，懂得越多\n[c/777777:在炼狱模式中死于任意一个Boss]");
            QuickTranslate(typeof(BereftVassalAchievement), "Initialize", "Forgotten Sands", "尘封已久");
            QuickTranslate(typeof(BereftVassalAchievement), "Initialize", "Best the Bereft Vassal in combat, in the far reaches of the desert's dunes\n[c/777777:Defeat the Bereft Vassal]", "在远方的沙丘的边缘击败无邦封臣\n[c/777777:击败无邦封臣]");
            QuickTranslate(typeof(ExoPathAchievement), "Initialize", "Lab Rat", "实验白鼠");
            QuickTranslate(typeof(ExoPathAchievement), "Initialize", "Become Draedon's favorite test subject\n[c/777777:Beat all Infernum Exo Mech combinations]", "成为嘉登最爱的实验素材\n[c/777777:在炼狱模式中击败所有星流巨械组合]");
            QuickTranslate(typeof(InfernalChaliceAchievement), "Initialize", "Baptized By Hellfire", "狱火洗礼");
            QuickTranslate(typeof(InfernalChaliceAchievement), "Initialize", "Complete the final challenge, and earn your reward\n[c/777777:Obtain the Infernal Chalice]", "完成最终挑战，并领取你的奖励\n[c/777777:获得炼狱圣杯]");
            QuickTranslate(typeof(KillAllBossesAchievement), "Initialize", "Infer-it-all!", "皆入炼狱！");
            QuickTranslate(typeof(KillAllBossesAchievement), "Initialize", "Rip and tear, until it is done\n[c/777777:Beat every Infernum Boss]", "撕碎一切，直至尘埃落定\n[c/777777:在炼狱模式中击败每一个Boss]");
            QuickTranslate(typeof(KillAllMinibossesAchievement), "Initialize", "Mini-Meany!", "小小的震撼！");
            QuickTranslate(typeof(KillAllMinibossesAchievement), "Initialize", "Defeat the various minor threats across the world!\n[c/777777:Beat every Infernum Miniboss]", "击败潜藏在世界各地的威胁\n[c/777777:在炼狱模式中击败每一个迷你Boss]");
            QuickTranslate(typeof(MechaMayhemAchievement), "Initialize", "Malicious Machinery", "恶意军械");
            QuickTranslate(typeof(MechaMayhemAchievement), "Initialize", "Decommission the Maniacal Mechanical trio in one fell swoop!\n[c/777777:Beat Infernum Mecha-Mayhem]", "在一次清扫中同时让三台疯狂的机器报废\n[c/777777:在炼狱模式中击败机甲混战]");
            QuickTranslate(typeof(NightProviAchievement), "Initialize", "Night Knight", "戌时戍侍");
            QuickTranslate(typeof(NightProviAchievement), "Initialize", "Challenge the Profaned Goddess under the gaze of the stars\n[c/777777:Beat Infernum Night Providence]", "在群星的注视中向亵渎天神发起挑战\n[c/777777:在炼狱模式中击败夜晚亵渎天神]");
            QuickTranslate(typeof(RamlessDoGAchievement), "Initialize", "Rampage", "寸止挑战");
            QuickTranslate(typeof(RamlessDoGAchievement), "Initialize", "Best the Devourer at his own game: without a ram!\n[c/777777:Beat the Infernum Devourer of Gods without using a ram dash]", "将计就计击败神明吞噬者\n[c/777777:在炼狱模式中不使用冲刺击败神明吞噬者]");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Next: ", "下一位：");
            //QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Spazmatism", "");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "The Twins", "双子魔眼");
            //QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Moon Lord Core", "");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Moon Lord", "月亮领主");
            //QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Guardian Commander", "");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Profaned Guardians", "亵渎守卫");
            #endregion
            #region Dev Wishes
            QuickTranslate(typeof(BlahajWish), "Initialize", "Benevolent Force", "仁爱之力");
            QuickTranslate(typeof(BlahajWish), "Initialize", "Warm hugs\n[c/777777:Defeat Infernum Duke Fishron in under 1 minute]", "温暖的拥抱\n[c/777777:在一分钟内击败炼狱模式下的猪龙鱼公爵]");
            QuickTranslate(typeof(CrescentWish), "Initialize", "Post-apocalyptic", "末日之终");
            QuickTranslate(typeof(CrescentWish), "Initialize", "The witch's sins could never be fully atoned\n[c/777777:Defeat the Forgotten Shadow of Calamitas in the underworld]", "女巫的罪孽永远无法偿还\n[c/777777:在地狱击败遗落灾影]");
            QuickTranslate(typeof(EggWish), "Initialize", "The Chosen One", "天选之子");
            QuickTranslate(typeof(EggWish), "Initialize", "Legends tell of a mighty warrior who will venture into the world and find the legendary blade hidden within\n[c/777777:Find an egg sword shrine after defeating Golem]", "传说中有一位勇敢的勇者将会进入这个世界进行冒险，并找到隐藏其中的传奇之剑\n[c/777777:在击败石巨人后找到一个蛋之剑冢]");
            QuickTranslate(typeof(MatrixWish), "Initialize", "The Scientific Method", "科学方法");
            QuickTranslate(typeof(MatrixWish), "Initialize", "To experiment is to fail. To fail is to learn. To learn is to advance\n[c/777777:Defeat every single boss and Exo Mech combination]", "实验就是失败，失败就是学习，学习就是进步\n[c/777777:击败所有Boss和星流巨械的全部组合]");
            QuickTranslate(typeof(NightmareWish), "Initialize", "It Awakens", "它已苏醒");
            QuickTranslate(typeof(NightmareWish), "Initialize", "It demands a sacrifice. You seem like a good choice\n", "它需要献祭，而你正是个不错的选择\n");
            QuickTranslate(typeof(NightmareWish), "Initialize", "[c/777777:Sleep in the brimstone crags for ", "[c/777777:在硫火之崖睡");
            QuickTranslate(typeof(NightmareWish), "Initialize", " seconds]", "秒]");
            QuickTranslate(typeof(PurityWish), "Initialize", "The Tanning Starseed", "星光普照");
            QuickTranslate(typeof(PurityWish), "Initialize", "It feels like solar winds, and solar chimes\n[c/777777:Defeat Infernum Night Providence in under 3.5 minutes]", "这感觉就像太阳风和太阳钟\n[c/777777:在三分半内击败炼狱模式下的夜晚亵渎天神]");
            QuickTranslate(typeof(SakuraWish), "Initialize", "Innocent Breeze", "无邪微风");
            QuickTranslate(typeof(SakuraWish), "Initialize", "One hundred whimsical spirits, dancing playfully\n[c/777777:Find a Sakura Bud]", "一百个淘气的精灵正欢快地跳舞\n[c/777777:找到樱花花苞]");
            QuickTranslate(typeof(StormMaidenWish), "Initialize", "Lamentation", "哀歌");
            QuickTranslate(typeof(StormMaidenWish), "Initialize", "Their tears blend with the raindrops, mourning over all that couldn't be\n[c/777777:Defeat the Exo Mechs and Calamitas and find the spear near your spawn point during the rain]", "他们的眼泪跟雨水混合在一起，为一切不可能的事物哀悼\n[c/777777:击败星流巨械和灾厄，并在下雨天的出生点附近找到一把矛]");
            QuickTranslate(typeof(TabletWish), "Initialize", "Unsullied", "纯洁无暇");
            QuickTranslate(typeof(TabletWish), "Initialize", "Not all beasts are monsters\n[c/777777:Defeat the Aquatic Scourge without ever letting the acid meter exceed 50% during the battle]", "不是所有的野兽都是怪物\n[c/777777:在腐蚀度不超过50%的情况下击败渊海灾虫]");
            QuickTranslate(typeof(TophatWish), "Initialize", "Amazingly Asinine Assistant", "著名的铸币助手");
            QuickTranslate(typeof(TophatWish), "Initialize", "You're improving with every failure! Keep going!\n[c/777777:Have 3 deaths in a row to a boss]", "每一次失败都让你进步!继续前进!\n[c/777777:在任意Boss战累计死亡3次]");
            #endregion
            
            //嘉登
            QuickTranslate(typeof(CustomExoMechSelectionSystem), "DrawWrapper", "Pick two. The first mech will be fought alone. Once sufficiently damaged, the second mech will be summoned and the two will fight together.", "选择两台巨械。选择的第一台巨械一开始会单独作战\n当它受到一定的伤害后，选择的第二台巨械将会出现并协同战斗");
            QuickTranslate(typeof(CustomExoMechSelectionSystem), "HandleInteractionWithButton", "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。");
            QuickTranslate(typeof(CustomExoMechSelectionSystem), "HandleInteractionWithButton", "Ares, a heavyweight, diabolical monstrosity with six Exo superweapons.", "阿瑞斯，一个搭载着六台超级星流武器的庞然巨物。");
            QuickTranslate(typeof(CustomExoMechSelectionSystem), "HandleInteractionWithButton", "Artemis and Apollo, a pair of extremely agile destroyers with unstable energy reserves.", "阿尔忒弥斯和阿波罗，一对能量储备十分不稳定的超耐久自动机器。");

            //Other
            QuickTranslate(typeof(DebuffEffectsPlayer), "PreKill", " could not withstand the red lightning.", "无法承受住红色闪电的洗礼。");
            QuickTranslate(typeof(DebuffEffectsPlayer), "PreKill", " was incinerated by ungodly fire.", "被亵渎之火烧成了灰烬。");
            QuickTranslate(typeof(DebuffEffectsPlayer), "PreKill", " went mad.", "发疯了。");
            QuickTranslate(typeof(CultistBehaviorOverride), "PreAI", " was repelled by celestial forces.", "被天体力量驱逐。");
            QuickTranslate(typeof(HyperplaneMatrixProjectile), "DoBehavior_InitialShake", " was blown up.", "被炸碎了。");
            QuickTranslate(typeof(CalamityBossHPBarChangesSystem), "UndoBarChanges", "Dark Energy", "暗能量");

            //Relic
            QuickTranslate(typeof(Utilities), "get_InfernalRelicText", "Imbued with the infernal flames of a defeated foe", "以殁者之火铸其形，其焰猩赫");

            //特效Tooltip?翻译随手贴的可以再改改
            QuickTranslate(typeof(IllusionersReverie), "PreDrawTooltipLine", "An ", "一本");
            QuickTranslate(typeof(IllusionersReverie), "PreDrawTooltipLine", "incomprehensibly ", "令人费解的");
            QuickTranslate(typeof(IllusionersReverie), "PreDrawTooltipLine", "old tome. Somehow, in spite of its supposed age, it appears to be completely unscathed", "古老巨著。不知何故，尽管它的年代久远，但它似乎完好无损");

            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "You feel", "你感觉");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "You feel a ", "你感觉一只");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "guiding spirit", "精灵尝试指引");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", " trying to lead you the bloom’s home", "你去往花苞的家");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "Maybe you", "也许");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "The spirit is trying to draw your attention to the ", "精灵尝试吸引你的注意力到");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "water", "水中");
            QuickTranslate(typeof(SakuraBud), "PreDrawTooltipLine", "Maybe you should follow its call?", "也许你应该跟随它的指引？");

            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "A symbol of how beautiful love is when in bloom, and how easily it can wither away", "这象征着爱情在盛开时是多么美丽，而它又多么容易枯萎");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "A symbol of how beautiful ", "这象征着");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "love", "爱情");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", " is when it’s in bloom, and yet how easily it can wither away", "在盛开时是多么美丽，而它又多么容易枯萎");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "Temporary", "短暂的");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "Maybe with this, we can hold onto the ", "也许有了这个，我们就能保存");
            QuickTranslate(typeof(SakuraBloom), "PreDrawTooltipLine", "memories", "记忆");

            //InfernumModeMusic
            //QuickTranslate(typeof(SoulDrivenHeadphonesProj.MusicUIIcon), "Draw", "Now playing ", "现在播放 ");
            //QuickTranslate(typeof(SoulDrivenHeadphonesProj.MusicUIIcon), "Draw", " will be played during boss fights!", " 将在Boss战期间播放!");

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
    }
}
