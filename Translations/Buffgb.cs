//本来想学tru带名字放到hjson，但没成功先这样吧(
using System;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Translations
{
	public class Buffgb : GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tooltip, ref int rare)
	{
		string tip = "";
		if (type <= 62)
		{
			if (type <= 16)
			{
				if (type != 3)
				{
					if (type != 7)
					{
						if (type == 16)
						{
							tip = "箭矢速度增加20%，箭矢伤害增加5%";
						}
					}
					else
					{
						tip = "魔法伤害增加10%";
					}
				}
				else
				{
					tip = "移动速度增加15%";
				}
			}
			else if (type != 26)
			{
				if (type != 39)
				{
					if (type == 62)
					{
						tip = "所受伤害降低15%";
					}
				}
				else
				{
					tip = "你无法再生";
				}
			}
			else
			{
				tip = "所有属性小幅提升";
			}
		}
		else if (type <= 114)
		{
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
				default:
					switch (type)
					{
						case 88:
							tip = "混沌传送杖被禁用";
							break;
						case 89:
						case 90:
						case 91:
						case 92:
						case 93:
						case 94:
							break;
						case 95:
							tip = "所受伤害降低10%";
							break;
						case 96:
							tip = "所受伤害降低20%";
							break;
						case 97:
							tip = "所受伤害降低30%";
							break;
						case 98:
						case 99:
						case 100:
							break;
						default:
							if (type == 114)
							{
								tip = "所受伤害降低5%";
							}
							break;
					}
					break;
			}
		}
		else if (type <= 181)
		{
			if (type != 124)
			{
				switch (type)
				{
					case 179:
						tip = "伤害增加7.5%";
						break;
					case 180:
						tip = "伤害增加15%";
						break;
					case 181:
						tip = "伤害增加22.5%";
						break;
				}
			}
			else
			{
				tip += "。免疫冷冻、冰冻和冰河时代减益";
			}
		}
		else if (type == 189)
		{
			tip = Language.GetTextValue("BuffDescription.Daybreak");
		}
		else if (type == 192)
		{
			tip = "移动速度增加10%，挖掘速度增加20%";
		}
		else if (type == 206)
		{
			tip = "所有属性中幅度提升";
		}
		else if (type == 207)
		{
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
