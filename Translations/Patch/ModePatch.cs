using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityMod;
using CalamityMod.Systems;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using Terraria.ModLoader;


namespace CalamityCN.Translations.Patch
{
    public class ModePatch
    {
        private static List<ILHook> DifficultyMode;

        public static void Load()
        {
            DifficultyMode = new List<ILHook>();

            //详细信息
            QuickTranslate(typeof(RevengeanceDifficulty), ":Enables the][c/85FFE9: Adrenaline] [c/", ":启用][c/85FFE9: 肾上腺素] [c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":mechanic. You gain Adrenaline while fighting bosses. Getting hit drops Adrenaline back to 0] \n[c/", ":机制. 对战Boss时可积攒肾上腺素条，受击时肾上腺素条归零。] \n[c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":    When Adrenaline is maxed, press] ", ":    当肾上腺素条满时，按下] ");
            QuickTranslate(typeof(RevengeanceDifficulty), ":for a large damage boost] \n[c/", ":获得大量伤害提升。] \n[c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":Enables the ][c/FF8B54:Rage][c/", ":启用][c/FF8B54: 怒气][c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ": mechanic. You gain Rage when in proximity of enemies or by using certain items] \n[c/", ": 机制. 在接近敌人或使用特定物品时会积攒怒气条。] \n[c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":    When Rage is maxed, press] ", ":    当怒气条满时，按下] ");
            QuickTranslate(typeof(RevengeanceDifficulty), ":for a temporary damage boost] \n[c/", ":获得少量伤害提升。] \n[c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":Most foes have higher stats and deal more damage] \n[c/", ":大多数敌怪属性提升，造成的伤害更高。] \n[c/");
            QuickTranslate(typeof(RevengeanceDifficulty), ":Bosses have new AI mechanics, new phases, and will drop Master Mode loot. Enemies spawn more frequently] \n[c/F7342A:This mode is more difficult than Expert. Be sure to prepare for the challenge]", ":Boss们拥有新的AI和阶段，会掉落大师模式专属物品。敌怪生成更频繁。] \n[c/F7342A:本模式比专家模式难度更高。准备好迎接挑战就开启吧。]");
            QuickTranslate(typeof(DeathDifficulty), "[c/B834E0:All foes will pose a much larger threat with aggressive AI and increased damage] \n[c/B834E0:Bosses have substantially harder AI changes. Enemies are even more numerous and can easily overwhelm you] \n[c/B834E0:Debuffs are especially lethal and the Abyss is significantly more dangerous] \n[c/E945FF:Vigilance and tenacity are crucial to survival]", "[c/B834E0:所有敌怪有着更具攻击性的AI，造成的伤害更高。] \n[c/B834E0:Boss们的AI变得更难，敌人多到可以淹没你]\n[c/B834E0:减益更致命，深渊更危险]\n[c/E945FF:保持警惕，坚韧不拔至关重要]");
            QuickTranslate(typeof(WhereMalice), "[c/EDEDED:Malice originally came about from an idea to make obtaining Legendary items less RNG-based]\n[c/EDEDED:It was meant to allow the player to enrage specific bosses, giving them new phases or attacks, to guarantee the drop]\n[c/EDEDED:However, this was watered down to what Malice was on release, being a difficulty which affected all bosses, and included RIV(Rare Item Variants)]\n\n[c/EDEDED:At the time, Malice was received poorly by a lot of players due to the bosses being overtuned to the point of being unfair, while locking items behind them]\n[c/939393:      ...No tester had beaten the Exo Mechs on Malice Mode when it released]\n[c/", "[c/EDEDED:恶意被设计出的初衷是为了使传奇武器的获取更少地依靠概率]\n[c/EDEDED:也就是说玩家激怒Boss，Boss获得新的攻击和阶段，击败Boss后必定掉落]\n[c/EDEDED:但是，当恶意真正加入游戏时，以上都被淡化了，只是一个单纯影响所有Boss和稀有变种的难度]\n\n[c/EDEDED:当时，大多数玩家都对恶意嗤之以鼻，难度不平衡，导致一些Boss超模并将它们掉落的物品锁定]\n[c/939393:      ...最初时没有测试者击败过恶意模式的星流巨械]\n[c/");
            QuickTranslate(typeof(WhereMalice), ":The explanation was that it was meant to be a \"refight\" mode, but that was never the real intention]\n\n[c/EDEDED:Malice-exclusive drops were eventually removed, as we did not want players to feel obligated to play a poorly balanced difficulty]\n[c/EDEDED:Over time, Malice was balanced to be less unfair, but we realized that with the exclusive drops gone, it was not worth the effort]\n[c/EDEDED:This is why we came down to deleting Malice, so that dev time and effort may be spent elsewhere, notably Death Mode]\n\n[c/", ":解释说恶意模式是一个“再战”的模式，但这个解释很牵强]\n\n[c/EDEDED:恶意模式专属物品最终也被移除，因为我们不希望玩家觉得必须去玩一个不平衡的难度]\n[c/EDEDED:随时间推移，恶意模式被重新平衡，但是我们意识到它已经没有了专属物品，这样做也毫无意义]\n[c/EDEDED:这也就是为什么删除了恶意模式，接下来开发者将会把注意力集中到死亡模式上]\n\n[c/");
            QuickTranslate(typeof(WhereMalice), ":We acknowledge that some players liked Malice because Death isn't challenging enough for their tastes]\n[c/", ":我们承认一些玩家喜欢恶意，因为死亡模式不足以给他们带来挑战]\n[c/");
            QuickTranslate(typeof(WhereMalice), ":If you want more difficulty, try the Infernum Addon, Master Mode, higher Boss HP Config, or for amusement, For The Worthy]", ":如果你想要更高难度，可以尝试炼狱模组，大师模式，Boss生命值百分比倍增配置设定，或者FTW]");

            foreach (ILHook hook in DifficultyMode)
            {
                if (hook is not null)
                    hook.Apply();
            }

        }

        public static void Unload()
        {
            foreach (ILHook hook in DifficultyMode)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            DifficultyMode = null;
        }
        private static void QuickTranslate(Type type, string origin, string trans)
        {
            DifficultyMode.Add(new ILHook(
            type.GetMethod("get_ExpandedDescription", (BindingFlags)60 | BindingFlags.Instance),
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
