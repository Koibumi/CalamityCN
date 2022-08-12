using CalamityMod;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.UI.CalamitasEnchants;
using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;
using static CalamityMod.UI.CalamitasEnchants.EnchantmentManager;

namespace CalamityCN.Translations.CodeEdit
{
    public class EnchantmentTranslation
    {
        private static ILHook fixExhume;
        private static ILHook fixCost;
        private static Hook disenchant;
        private static Dictionary<string, string[]> translationDict;
        public static void Load()
        {
            translationDict = new Dictionary<string, string[]>()
            {
                // 第一个是英文名，后俩是名称和说明，这是固定格式
                { "Exhume", new string[] { "死灵炼注".zh(), "将该物品转化为更加强大的物品。".zh() } },
                { "Aflame", new string[] { "魔焱".zh(), "攻击会点燃目标，但拿着该物品时会受到伤害性减益。"} },
                { "Ephemeral", new string[] { "须臾".zh(), "连续使用时伤害会持续降低。停止使用时，伤害会逐渐恢复。刚开始使用时它会造成比正常情况下高得多的伤害。".zh() } },
                { "Withering", new string[] { "凋零".zh(), "当你受伤，会根据之前累计造成的伤害恢复一定比例的生命值，最高可达100%。随后，你会持续受到减益伤害，但你造成的伤害会上升。".zh() } },
                { "Resentful", new string[] { "憎懣".zh(), "使弹幕的伤害取决于目标与你的距离，距离越远，伤害越高。反之亦然。".zh() } },
                { "Bloodthirsty", new string[] { "嗜血".zh(), "使弹幕的伤害取决于目标与你的距离，距离越近，伤害越高。反之亦然。".zh() } },
                { "Persecuted", new string[] { "压迫".zh(), "当攻击时，或随着时间推移，你的附近会生成一个恶魔之门，并在一小段时间后生成恶魔。如果恶魔出现之前传送门被严重破坏，恶魔们会选择攻击敌怪；否则，当传送门消失后，恶魔们就会选择攻击玩家。".zh() } },
                { "Lecherous", new string[] { "淫欲".zh(), "生成一个硫磺怪物处于你和你的鼠标中间，干扰你的武器发射的弹幕。硫磺怪物死亡后会释放很多红心。".zh() } },
                { "Tainted", new string[] { "邪染".zh(), "取消该物品的弹幕，在挥舞武器时，两只额外的骷髅手臂会与你一起挥舞武器。".zh() } },
                { "Oblatory", new string[] { "献奉".zh(), "减少魔力消耗并大幅增加伤害，但使用该物品偶尔会消耗你的生命值。".zh() } },
                { "Traitorous", new string[] { "背叛".zh(), "当你的魔力值低于50%时，使用该武器会随机生成一个无差别攻击一切生物的怪物。".zh() } },
                { "Indignant", new string[] { "愤慨".zh(), "使用时召唤一个恶魔攻击你，但恶魔死亡后会产生治愈射线治疗你。".zh() } },
                { "Hellbound", new string[] { "狱使".zh(), "召唤物会在生成40秒后产生剧烈爆炸并消失。在这40秒内，召唤物存在时间越久，造成的伤害越高，并且会随机产生小范围爆炸。".zh() } },
            };

            for (int i = 0; i < EnchantmentList.Count; i++)
            {
                foreach (var item in translationDict)
                {
                    if (item.Key == EnchantmentList[i].Name)
                    {
                        EnchantmentList[i] = EnchantmentList[i] with { Name = item.Value[0], Description = item.Value[1] };
                        break;
                    }
                }
            }
            disenchant = new Hook(typeof(EnchantmentManager).GetMethod("get_ClearEnchantment", (BindingFlags)60), () => 
            {
                return new Enchantment("祛魔", string.Empty, -18591774, null, delegate (Item item)
                {
                    item.Calamity().AppliedEnchantment = null;
                    item.Calamity().DischargeEnchantExhaustion = 0f;
                }, (Item item) => item.IsEnchantable() && item.shoot >= 0);
            });

            fixExhume = new ILHook(typeof(CalamitasEnchantUI).GetMethod("InteractWithEnchantIcon", (BindingFlags)60), new ILContext.Manipulator(
                il =>
                {
                    var cursor = new ILCursor(il);
                    for (int i = 0; i < 3; i++)
                    {
                        if (!cursor.TryGotoNext(i => i.MatchLdstr("Exhume")))
                            continue;
                        cursor.Index++;
                        cursor.EmitDelegate<Func<string, string>>((exhume) =>
                        {
                            return translationDict["Exhume"][0];
                        }
                        );
                    }
                }));
            fixCost = new ILHook(typeof(CalamitasEnchantUI).GetMethod("DrawEnchantmentCost", (BindingFlags)60), new ILContext.Manipulator(
                il =>
                {
                    var cursor = new ILCursor(il);
                    if (!cursor.TryGotoNext(i => i.MatchLdstr("Cost: ")))
                        return;
                    cursor.Index++;
                    cursor.EmitDelegate<Func<string, string>>((cost) =>
                    {
                        return "花费：".zh();
                    });
                }));

            fixExhume.Apply();
            fixCost.Apply();
            disenchant.Apply();
        }
        public static void Unload()
        {
            translationDict = null;
            if (fixExhume is not null)
                fixExhume.Dispose();
            fixExhume = null;
            if (fixCost is not null)
                fixCost.Dispose();
            fixCost = null;
            if (disenchant is not null)
                disenchant.Dispose();
            disenchant = null;
        }
    }
}
