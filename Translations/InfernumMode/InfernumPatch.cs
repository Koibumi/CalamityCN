using CalamityCN.Utils;
using InfernumMode;
using InfernumMode.Content.Achievements;
using InfernumMode.Content.BehaviorOverrides.BossAIs.Cultist;
using InfernumMode.Content.Items.Accessories;
using InfernumMode.Content.Items.Misc;
using InfernumMode.Content.Items.Weapons.Magic;
using InfernumMode.Content.Projectiles;
using InfernumMode.Content.UI;
using InfernumMode.Core.GlobalInstances.Players;
using InfernumMode.Core.GlobalInstances.Systems;
//using InfernumModeMusic.Projectiles;
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

            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "The Twins", "双子魔眼");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Moon Lord", "月亮领主");
            QuickTranslate(typeof(InfernumUIAchievementListItem), "DrawSelf", "Profaned Guardians", "亵渎守卫");

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
