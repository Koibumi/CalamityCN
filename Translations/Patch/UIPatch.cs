using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;
using CalamityMod;
using CalamityMod.Tiles.DraedonSummoner;
using CalamityMod.TileEntities;
using CalamityMod.UI.DraedonSummoning;
using CalamityMod.UI.ModeIndicator;
using CalamityMod.UI.Rippers;
using CalamityMod.UI;

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
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。",
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。",
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。"
                });

                for (int i = 0; i < 3; i++)
                {
                    QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", ExoUIText[i * 2], ExoUIText[i * 2 + 1]);
                }

            //破译
            QuickTranslate(typeof(CodebreakerTile), "RightClick","No decryption computer installed", "未安装解密计算机");
            QuickTranslate(typeof(CodebreakerUI), "DisplayNotStrongEnoughErrorText","Encryption unsolveable: Upgrades required.", "解密请求失败：需要升级解码装置");
            QuickTranslate(typeof(CodebreakerUI), "DisplayCostText","Cost: ", "花费：");
            QuickTranslate(typeof(CodebreakerUI), "DrawDecryptCancelConfirmationText","Are you sure?", "确定吗？");
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton","Contact", "对话");
            QuickTranslate(typeof(TECodebreaker), "UpdateTime","You learned how to create new things!", "你学会了如何制作新的东西！");
            //难度UI
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", " Mode is ", "模式");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "active", "已启用");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "not active", "未启用");
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Click to select a difficulty mode]", "[c/919191:点击选择难度]");
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Higher difficulty modes can only be toggled in Expert Mode or above]", "[c/919191:只能在专家模式及以上时开启更高难度]");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "Currently Selected : ", "当前选择的难度：");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "\n[c/737373:Hold the 'Shift' key for more information]", "\n[c/737373:按住Shift键查看更多信息]");
            //属性条
            QuickTranslate(typeof(RipperUI), "Draw", "Rage: ", "怒气: ");
            QuickTranslate(typeof(RipperUI), "Draw", "Adrenaline", "肾上腺素");
            QuickTranslate(typeof(RipperUI), "Draw", "Nanomachines", "纳米机器");
            QuickTranslate(typeof(StealthUI), "Draw", "Stealth: ", "潜行值: ");
            QuickTranslate(typeof(StealthUI), "Draw", "Hold SHIFT for more information on Rogue stealth", "按住SHIFT查看更多盗贼潜行值信息");
            QuickTranslate(typeof(StealthUI), "Draw", "Rogue stealth builds while not attacking and slower while moving\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage and crit\nHaving more stealth regeneration slightly decreases the damage bonus from stealth\nThis is offset by you being able to use stealth strikes far more often", "盗贼潜行值会在玩家不攻击或缓慢移动时增加\n当潜行值达到上限时，可以进行潜伏攻击\n盗贼潜行值只会在攻击时减少，移动不会减少\n盗贼潜行值越高，盗贼武器伤害和暴击率越高\n潜行恢复速度越快会降低伤害加成\n这是为了平衡更快的使用潜伏攻击");
            


            //QuickTranslate(typeof(), "", "", "");

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
