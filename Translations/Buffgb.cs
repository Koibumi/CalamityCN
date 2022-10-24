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
		if (type <= 88)
			{
				if (type <= 16)
				{
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
					if (type != 16)
					{
						return;
					}
					tip = "箭矢速度增加20%，箭矢伤害增加5%";
					return;
				}
				else if (type <= 62)
				{
					if (type == 26)
					{
						tip = "所有属性小幅提升";
						return;
					}
					if (type != 62)
					{
						return;
					}
					tip = "所受伤害降低15%";
					return;
				}
				else
				{
					switch (type)
					{
					case 71:
					case 73:
					case 74:
					case 75:
					case 76:
					case 77:
					case 79:
						tip = tip.Insert(tip.IndexOf("Melee") + 5, "，鞭子和盗贼");
						return;
					case 72:
						break;
					case 78:
						tip = "所有攻击都会喷出彩纸";
						return;
					default:
						if (type != 88)
						{
							return;
						}
						tip = "混沌传送杖被禁用";
						return;
					}
				}
			}
			else if (type <= 181)
			{
				if (type <= 114)
				{
					switch (type)
					{
					case 95:
						tip = "所受伤害降低10%";
						return;
					case 96:
						tip = "所受伤害降低20%";
						return;
					case 97:
						tip = "所受伤害降低30%";
						return;
					default:
						if (type != 114)
						{
							return;
						}
						tip = "伤害降低5%";
						return;
					}
				}
				else
				{
					if (type == 124)
					{
						tip += "。免疫冷冻、冰冻和冰河时代减益";
						return;
					}
					switch (type)
					{
					case 179:
						tip = "伤害增加7.5%";
						return;
					case 180:
						tip = "伤害增加15%";
						return;
					case 181:
						tip = "伤害增加22.5%";
						return;
					default:
						return;
					}
				}
			}
			else if (type <= 192)
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
					tip = "所有属性中幅提升";
					return;
				}
				if (type != 207)
				{
					return;
				}
				tip = "所有属性大幅提升";
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
