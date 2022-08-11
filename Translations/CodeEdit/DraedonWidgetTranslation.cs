using CalamityMod;
using CalamityMod.CustomRecipes;
using CalamityMod.Items;
using CalamityMod.TileEntities;
using CalamityMod.Tiles.DraedonSummoner;
using CalamityMod.UI;
using CalamityMod.World;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;

namespace CalamityCN.Translations.CodeEdit
{
    public class DraedonWidgetTranslation
    {
        private static List<ILHook> IlHooks;
        private static List<Hook> Hooks;
        private static List<string> SchematicText;
        private static List<string> ExoUIText;
        private static List<string> KnowledgeText;
        public static void Load()
        {
            IlHooks = new List<ILHook>();
            Hooks = new List<Hook>();
            SchematicText = new List<string>(new string[]
            {
                "Within an army, as weapons do, the soldiers serve different purposes. That distinction is crucial, as the wrong tool in the wrong hands—no matter how potent—may as well be a wooden club.\nAddendum: Seek out my base of operations closest to the Lihzahrd’s home. I wish you the best of luck with all sincerity, for it has been a long time since I have had a worthy test subject. ",
                "在一支军队中，士兵就如同武器一样有着不同的用途。它们的区别至关重要，毕竟如果错误的工具在错误的人手中的话——无论那些工具有多么厉害——可能也就和一根木头球棒差不多。"+
                "附录：去寻找距离蜥蜴神庙最近的行动基地。我真诚地祝愿你好运，毕竟我已经很久没有遇到过如此有价值的实验对象了。",
                "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change. However, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint. Go now to Hell, for the next component stored in what were once my forges.",
                "随着军衔的提高，装备的杀伤力也会增长。在有能力的士兵手里，这些武器也确实可以带来改变。可惜，这些有能力的士兵除了遵循上头的命令外根本不会自己行动。\n"+
                "附录：如果你读到了这里，就说明你已经取得了不小的成果。不要灰心，现在出发前往地狱，在那个曾是我的铸造厂的地方寻找储存在那里的下一个部件。",
                "Only the highest ranking in the battalions of Yharim’s army held these weapons. However these are still not my most potent tools. Those...characters could not be trusted with them.\nAddendum: The final piece remains. Travel now from the hottest fire this land has to offer, to the most frigid cold. I cannot deny having some sense of poetic symmetry.",
                "在亚利姆的军队中，只有那些军衔最高的人员才可以持有这些武器。然而它们仍然不是我最得意的工具。那些......角色根本没有得到足够的信任去使用它们。\n"+
                "附录：还剩下最后一块，现在就从这片大陆上最热的领域，去往这片大陆上最冷的土地。好吧，我不能否认我灵感乍现来了点对仗。",
                "I have since made progress to even greater weapons than these, but they remain creations to be proud of. No progress can be made without a desire that comes from dissatisfaction.\nAddendum: The time has come. You are ready.",
                "之后我还制作出过比这些东西更为强大的武器，但这并不能否认我依然为这些造物感到骄傲。毕竟如果没有源于不满的渴望，我也没法取得突破。\n"+
                "附录：时机已到，你已经准备好了。"
            });
            ExoUIText = new List<string>(new string[]
            {
                "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.",
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。",
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。",
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。"
            });
            KnowledgeText = new List<string>(new string[]
            {
                "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.",
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。",
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。",
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。"
            });

            QuickTranslate(typeof(CodebreakerTile), "RightClick",
                "No decryption computer installed", "未安装解密计算机");
            QuickTranslate(typeof(CodebreakerUI), "DisplayNotStrongEnoughErrorText",
                "Encryption unsolveable: Upgrades required.", "解密请求失败：需要升级解码装置");
            QuickTranslate(typeof(CodebreakerUI), "DisplayCostText",
                "Cost: ", "花费：");
            QuickTranslate(typeof(CodebreakerUI), "DrawDecryptCancelConfirmationText",
                "Are you sure?", "确定吗？");
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton",
                "Contact", "对话");
            QuickTranslate(typeof(TECodebreaker), "UpdateTime",
                "You learned how to create new things!", "你学会了如何制作新的东西！");
            for (int i = 0; i < 4; i++)
            {
                QuickTranslate(typeof(TECodebreaker), "get_UnderlyingSchematicText", SchematicText[i * 2], SchematicText[i * 2 + 1]);
            }
            for (int i = 0; i < 3; i++)
            {
                QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", ExoUIText[i * 2], ExoUIText[i * 2 + 1]);
            }

            
            Hooks.Add(new Hook(typeof(CalamityGlobalItem).GetMethod("InsertKnowledgeTooltip", BindingFlags.Public | BindingFlags.Static), TranslateKnowledgeTooltip));

            foreach (ILHook hook in IlHooks)
            {
                if (hook is not null)
                    hook.Apply();
            }
            foreach (Hook hook in Hooks)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
        public static void Unload()
        {
            foreach (ILHook hook in IlHooks)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            foreach (Hook hook in Hooks)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            IlHooks = null;
            Hooks = null;
            SchematicText = null;
            ExoUIText = null;
            KnowledgeText = null;
        }

        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            IlHooks.Add(new ILHook(
            type.GetMethod(methodName, (BindingFlags)60 | BindingFlags.GetProperty),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((eng) => trans);
            })));
        }

        private static void TranslateKnowledgeTooltip(List<TooltipLine> tooltips, int tier, bool allowOldWorlds = false)
        {
            TooltipLine tooltipLine = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge1", "你没有足够的知识去制做这个");
            TooltipLine tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先破译特定的原型图");
            switch (tier)
            {
                case 1:
                    tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先找到沉沦之海的加密原型图");
                    break;
                case 2:
                    tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先破译小行星的加密原型图");
                    break;
                case 3:
                    tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先破译丛林的加密原型图");
                    break;
                case 4:
                    tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先破译地狱的加密原型图");
                    break;
                case 5:
                    tooltipLine2 = new TooltipLine(CalamityCN.Instance, "SchematicKnowledge2", "必须先破译雪原的加密原型图");
                    break;
            }
            tooltipLine.OverrideColor = tooltipLine2.OverrideColor = Color.Cyan;
            bool flag = allowOldWorlds && CalamityWorld.IsWorldAfterDraedonUpdate;
            tooltips.AddWithCondition(tooltipLine, !ArsenalTierGatedRecipe.HasTierBeenLearned(tier) && !flag);
            tooltips.AddWithCondition(tooltipLine2, !ArsenalTierGatedRecipe.HasTierBeenLearned(tier) && !flag);
        }
    }
}
