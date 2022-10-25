//本来想学tru带名字放到hjson，但没成功先这样吧(
using System;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Translations
{
	public class VanillaBuffTooltipInjector : GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tooltip, ref int rare)
	{
		string tip = "";
		if (type == 3)
		{
			tip = "移动速度增加15%";
			return;
		}
		if (type == 7)
		{
			tip = "魔法伤害增加10%";
			return;
		}
		if (type == 16)
		{
			tip = "箭矢速度增加20%，箭矢伤害增加5%";
			return;
		}
		if (type == 26)
		{
			tip = "所有属性小幅度提升";
			return;
		}
		if (type == 62)
		{
			tip = "所受伤害降低15%";
			return;
		}
		switch (type)
		{
			case 71:
				tip = "近战、鞭子和盗贼攻击对敌人造成毒液减益";
				break;
			case 72:
				break;
			case 73:
				tip = "近战、鞭子和盗贼攻击对敌人造成诅咒焰减益";
				break;
			case 74:
				tip = "近战、鞭子和盗贼攻击对敌人造成着火效果";
				break;
			case 75:
				tip = "近战、鞭子和盗贼攻击使敌人掉落更多金子";
				break;
			case 76:
				tip = "近战、鞭子和盗贼攻击使敌人防御力降低";
				break;
			case 77:
				tip = "近战、鞭子和盗贼攻击对敌人造成困惑减益";
				break;
			case 78:
				tip = "所有攻击喷出彩纸";
				break;
			case 79:
				tip = "近战、鞭子和盗贼攻击对敌人造成中毒减益";
				break;
		}
		if (type == 88)
		{
			tip = "混沌传送杖被禁用";
			return;
		}
		if (type == 95)
		{
			tip = "所受伤害降低10%";
			return;
		}
		if (type == 96)
		{
			tip = "所受伤害降低20%";
			return;
		}
		if (type == 97)
		{
			tip = "所受伤害降低30%";
			return;
		}
		if (type == 114)
		{
			tip = "伤害降低5%";
			return;
		}
		if (type == 179)
		{
			tip = "伤害增加7.5%";
			return;
		}
		if (type == 180)
		{
			tip = "伤害增加15%";
			return;
		}
		if (type == 181)
		{
			tip = "伤害增加22.5%";
			return;
		}
		if (type <= 192)
			{
				if (type == 189)
				{
					tip = "被太阳射线灼烧";
					return;
				}
				if (type != 192)
				{
					return;
				}
				tip = "移动速度增加10%，挖掘速度增加20%";
				return;
			}
			else
			{
				if (type == 206)
				{
					tip = "所有属性中幅度提升";
					return;
				}
				if (type != 207)
				{
					return;
				}
				tip = "所有属性大幅度提升";
			}
		if (!tip.Equals(""))
		{
			tooltip = tip;
		}
	}

	public override bool IsLoadingEnabled(Mod mod)
		{
			return LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese) && ModLoader.TryGetMod("CalamityMod", out Mod Calamity);
		}

	}
    
}
