using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.Systems;
using CalamityMod.UI;
using CalamityMod.UI.CalamitasEnchants;
using Terraria;


namespace CalamityCN.Translations.Patch {

    public class Reflection : ContentTranslation, ILoadableContent {
        public override bool IsTranslationEnabled {
            get {
                return ModsCall.Calamity != null && ModsCall.IsCN;
            }
        }

        public override float Priority {
            get {
                return 1f;
            }
        }

        public void LoadContent() {

            List<ValueTuple<string, string>> list = new List<ValueTuple<string, string>>();
            list.Add(new ValueTuple<string, string>("Exhume", "（死灵炼注）将该物品转化为更加强大的物品。".zh()));
            list.Add(new ValueTuple<string, string>("愤慨", "使用时召唤一个恶魔攻击你，但恶魔死亡后会产生治愈射线治疗你。".zh()));
            list.Add(new ValueTuple<string, string>("魔焱", "攻击会点燃目标，但拿着该物品时会受到伤害性减益。".zh()));
            list.Add(new ValueTuple<string, string>("献奉", "减少魔力消耗并大幅增加伤害，但使用该物品偶尔会消耗你的生命值。".zh()));
            list.Add(new ValueTuple<string, string>("憎懣", "使弹幕的伤害取决于目标与你的距离，距离越远，伤害越高。反之亦然。".zh()));
            list.Add(new ValueTuple<string, string>("嗜血", "使弹幕的伤害取决于目标与你的距离，距离越近，伤害越高。反之亦然。".zh()));
            list.Add(new ValueTuple<string, string>("须臾", "连续使用时伤害会持续降低。停止使用时，伤害会逐渐恢复。\n刚开始使用时它会造成比正常情况下高得多的伤害。".zh()));
            list.Add(new ValueTuple<string, string>("狱使", "召唤物会在生成40秒后产生剧烈爆炸并消失。\n在这40秒内，召唤物存在时间越久，造成的伤害越高，并且会随机产生小范围爆炸。".zh()));
            list.Add(new ValueTuple<string, string>("邪染", "取消该物品的弹幕，在挥舞武器时，两只额外的骷髅手臂会与你一起挥舞武器。".zh()));
            list.Add(new ValueTuple<string, string>("背叛", "当你的魔力值低于25%时，使用该武器会立即消耗你的全部魔力值并随机生成一个无差别攻击一切生物的怪物。".zh()));
            list.Add(new ValueTuple<string, string>("凋零", "当你受伤，会根据之前累计造成的伤害恢复一定比例的生命值，最高可达100%。\n随后，你会持续受到减益伤害，但你造成的伤害会上升。".zh()));
            list.Add(new ValueTuple<string, string>("压迫", "当攻击时，或随着时间推移，你的附近会生成一个恶魔之门，并在一小段时间后生成恶魔。\n如果恶魔出现之前传送门被严重破坏，恶魔们会选择攻击敌怪；\n否则，当传送门消失后，恶魔们就会选择攻击玩家。".zh()));
            list.Add(new ValueTuple<string, string>("淫欲", "生成一个硫磺怪物处于你和你的鼠标中间，干扰你的武器发射的弹幕。\n硫磺怪物死亡后会释放很多红心。".zh()));

            /*
				List<ValueTuple<string, string>> enchantmentTranslation = list;
				PropertyInfo property = typeof(EnchantmentManager).GetProperty("EnchantmentList", BindingFlags.Static | BindingFlags.Public);
				List<Enchantment> enchantmentList = ((property != null) ? property.GetValue(null) : null) as List<Enchantment>;
				if (enchantmentList != null)
				{
					for (int i = 0; i < enchantmentList.Count; i++)
					{
						Enchantment currentEnchantment = enchantmentList[i];
						currentEnchantment.Name = enchantmentTranslation[i].Item1;
						currentEnchantment.Description = enchantmentTranslation[i].Item2;
						enchantmentList[i] = currentEnchantment;
					}
				}
				PropertyInfo property2 = typeof(EnchantmentManager).GetProperty("ClearEnchantment", BindingFlags.Static | BindingFlags.Public);
				if (property2 == null)
				{
					return;
				}
				object typeFromHandle = typeof(Enchantment);
				property2.SetValue(typeFromHandle, new Enchantment("祛魔".zh(), string.Empty, -18591774, null, delegate (Item item)
				{
					CalamityUtils.Calamity(item).AppliedEnchantment = null;
					CalamityUtils.Calamity(item).DischargeEnchantExhaustion = 0f;
				}, (Item item) => CalamityUtils.IsEnchantable(item) && item.shoot >= 0));

			DifficultyModeSystem.Difficulties[0].Name = "无".zh();
				DifficultyModeSystem.Difficulties[0].ShortDescription = "没有开启任何灾厄难度的泰拉之旅".zh();
				DifficultyModeSystem.Difficulties[1].Name = "复仇".zh();
				DifficultyModeSystem.Difficulties[1].ShortDescription = "[c/F54254:预期的灾厄之旅！]".zh();
				DifficultyModeSystem.Difficulties[2].Name = "死亡".zh();
				DifficultyModeSystem.Difficulties[2].ShortDescription = "[c/C82DF7:对更有经验的，想复仇模式更进一步的玩家的更强挑战]".zh();
				DifficultyModeSystem.Difficulties[3].Name = "恶意哪去了?".zh();
				DifficultyModeSystem.Difficulties[3].ShortDescription = "[c/FB7152:恶意模式已经被移除，但它的AI改动留在了Boss Rush中]\n[c/FB7152:如果你因为之前计划进行恶意之旅而感到失望，我们诚挚地道歉]".zh();
			*/

            FieldInfo field = typeof(AstralArcanumUI).GetField("CircleNames", BindingFlags.Static | BindingFlags.NonPublic);
            string[] circleNames = ((field != null) ? field.GetValue(null) : null) as string[];
            if (circleNames != null) {
                circleNames[0] = "地狱".zh();
                circleNames[1] = "地牢".zh();
                circleNames[2] = "丛林".zh();
                circleNames[3] = "随机".zh();
            }

        }
        public void UnloadContent() {
        }
    }
}
