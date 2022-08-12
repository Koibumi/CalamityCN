using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.TileEntities;
using CalamityMod.Tiles.DraedonSummoner;
using CalamityMod.UI;
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
        private static List<ILHook> ILHooks;
        private static Hook Schematic;
        private static List<string> SchematicText;
        private static List<string> ExoUIText;
        private static List<string> KnowledgeText;
        public static void Load()
        {
            ILHooks = new List<ILHook>();
            SchematicText = new List<string>(new string[]
            {
                "在一支军队中，士兵就如同武器一样有着不同的用途。它们的区别至关重要，毕竟如果错误的工具在错误的人手中的话——无论那些工具有多么厉害——可能也就和一根木头球棒差不多。\n附录：去寻找距离蜥蜴神庙最近的行动基地。我真诚地祝愿你好运，毕竟我已经很久没有遇到过如此有价值的实验对象了。".zh(),
                "随着军衔的提高，装备的杀伤力也会增长。在有能力的士兵手里，这些武器也确实可以带来改变。可惜，这些有能力的士兵除了遵循上头的命令外根本不会自己行动。\n附录：如果你读到了这里，就说明你已经取得了不小的成果。不要灰心，现在出发前往地狱，在那个曾是我的铸造厂的地方寻找储存在那里的下一个部件。".zh(),
                "在亚利姆的军队中，只有那些军衔最高的人员才可以持有这些武器。然而它们仍然不是我最得意的工具。那些......角色根本没有得到足够的信任去使用它们。\n附录：还剩下最后一块，现在就从这片大陆上最热的领域，去往这片大陆上最冷的土地。好吧，我不能否认我灵感乍现来了点对仗。".zh(),
                "之后我还制作出过比这些东西更为强大的武器，但这并不能否认我依然为这些造物感到骄傲。毕竟如果没有源于不满的渴望，我也没法取得突破。附录：时机已到，你已经准备好了。"
            });
            ExoUIText = new List<string>(new string[]
            {
                "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.",
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。".zh(),
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。".zh(),
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。".zh()
            });
            KnowledgeText = new List<string>(new string[]
            {
                "You don't have sufficient knowledge to create this yet",
                "你没有足够的知识来制作这个物品".zh(),
                "A specific schematic must be deciphered first",
                "必须先破译特定的原型图".zh(),
                "The Sunken Sea schematic must be deciphered first",
                "必须先找到沉沦之海的加密原型图。".zh(),
                "The Planetoid schematic must be deciphered first",
                "必须先破译小行星的加密原型图".zh(),
                "The Jungle schematic must be deciphered first",
                "必须先破译丛林的加密原型图".zh(),
                "The Underworld schematic must be deciphered first",
                "必须先破译地狱的加密原型图".zh(),
                "The Ice biome schematic must be deciphered first",
                "必须先破译雪原的加密原型图".zh(),
            });

            Schematic = new Hook(typeof(TECodebreaker).GetMethod("get_UnderlyingSchematicText", (BindingFlags)60), get_UnderlyingSchematicText);

            QuickTranslate(typeof(CodebreakerTile), "RightClick",
                "No decryption computer installed", "未安装解密计算机".zh());
            QuickTranslate(typeof(CodebreakerUI), "DisplayNotStrongEnoughErrorText",
                "Encryption unsolveable: Upgrades required.", "解密请求失败：需要升级解码装置".zh());
            QuickTranslate(typeof(CodebreakerUI), "DisplayCostText",
                "Cost: ", "花费：".zh());
            QuickTranslate(typeof(CodebreakerUI), "DrawDecryptCancelConfirmationText",
                "Are you sure?", "确定吗？".zh());
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton",
                "Contact", "对话".zh());
            QuickTranslate(typeof(TECodebreaker), "UpdateTime",
                "You learned how to create new things!", "你学会了如何制作新的东西！".zh());
            /*for (int i = 0; i < 4; i++)
            {
                QuickTranslate(typeof(TECodebreaker), "get_UnderlyingSchematicText", SchematicText[i * 2], SchematicText[i * 2 + 1]);
            }*/
            for (int i = 0; i < 3; i++)
            {
                QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", ExoUIText[i * 2], ExoUIText[i * 2 + 1]);
            }
            for (int i = 0; i < 7; i++)
            {
                QuickTranslate(typeof(CalamityGlobalItem), "InsertKnowledgeTooltip", KnowledgeText[i * 2], KnowledgeText[i * 2 + 1]);
            }


            foreach (ILHook hook in ILHooks)
            {
                if (hook is not null)
                    hook.Apply();
            }
            Schematic.Apply();
        }
        public static void Unload()
        {
            foreach (ILHook hook in ILHooks)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            ILHooks = null;
            SchematicText = null;
            ExoUIText = null;
            KnowledgeText = null;
            Schematic.Dispose();
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

        private static string get_UnderlyingSchematicText(TECodebreaker orig)
        {
            if (orig.HeldSchematicID == 0 || !CalamityLists.EncryptedSchematicIDRelationship.ContainsKey(orig.HeldSchematicID))
                return string.Empty;
            int num = CalamityLists.EncryptedSchematicIDRelationship[orig.HeldSchematicID];
            if (num == ModContent.ItemType<EncryptedSchematicPlanetoid>())
                return SchematicText[0];
            else if (num == ModContent.ItemType<EncryptedSchematicJungle>())
                return SchematicText[1];
            else if (num == ModContent.ItemType<EncryptedSchematicHell>())
                return SchematicText[2];
            else if (num == ModContent.ItemType<EncryptedSchematicIce>())
                return SchematicText[3];
            return string.Empty;
        }
    }
}
