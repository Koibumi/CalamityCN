using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.Buffs.StatBuffs;
using CalamityMod.Buffs.Summon;
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Translations.TransInHjson
{
	public class BuffGlobalTrans : GlobalBuff
	{
		public override void ModifyBuffTip(int type, ref string tooltip, ref int rare)
	{
		string tip = "";
			if (type == ModContent.BuffType<BossEffects>())
			{
				tip = LangHelper.GetTextValue(CalamityConfig.Instance.BossZen ? "CalamityMod.Buffs.BossEffects.Description.BossZen" : "CalamityMod.Buffs.BossEffects.Description", Array.Empty<object>());
			}

			if (type == ModContent.BuffType<ProfanedBabs>())
			{
				tip = ((tooltip == "The Profaned Babs will accompany you!") ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description", Array.Empty<object>()) : tip);
			}

			if (type == ModContent.BuffType<ProfanedCrystalBuff>())
            {
				Player player = Main.player[Main.myPlayer];
				if (player.Calamity().profanedCrystalBuffs)
				{
					if (player.Calamity().endoCooper)
					{
						tooltip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.1", Array.Empty<object>());
						return;
					}
					if (player.Calamity().magicHat)
					{
						tooltip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.2", Array.Empty<object>());
						return;
					}
					bool offense = (Main.dayTime && !player.wet) || player.lavaWet;
					bool enrage = player.statLife <= (int)((double)player.statLifeMax2 * 0.5);
					tooltip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.3", Array.Empty<object>()) + (offense ? ((Main.dayTime ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.4", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.5", Array.Empty<object>())) + LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.6", Array.Empty<object>())) : ((player.wet ? (player.honeyWet ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.7", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.8", Array.Empty<object>())) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.9", Array.Empty<object>())) + LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.10", Array.Empty<object>()))) + (enrage ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.11", Array.Empty<object>()) : "");
					return;
				}
				else
				{
					if (DownedBossSystem.downedSCal && DownedBossSystem.downedExoMechs)
					{
						tooltip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.12", Array.Empty<object>());
						return;
					}
					tooltip = ((!DownedBossSystem.downedExoMechs) ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.13", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.14", Array.Empty<object>()));
					return;
				}
			}

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
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Archery.Description", Array.Empty<object>());
							}
					}
					else
					{
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.MagicPower.Description", Array.Empty<object>());
						}
				}
				else
				{
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Swiftness.Description", Array.Empty<object>());
					}
			}
			else if (type != 26)
			{
				if (type != 39)
				{
					if (type == 62)
					{
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.IceBarrier.Description", Array.Empty<object>());
						}
				}
				else
				{
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.CursedInferno.Description", Array.Empty<object>());
					}
			}
			else
			{
					tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedS.Description", Array.Empty<object>());
			}
		}
		else if (type <= 114)
		{
			switch (type)
			{
				case 71:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueVenom.Description", Array.Empty<object>());
						break;
				case 72:
					break;
				case 73:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueCursedFlames.Description", Array.Empty<object>());
						break;
				case 74:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueFire.Description", Array.Empty<object>());
						break;
				case 75:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueGold.Description", Array.Empty<object>());
						break;
				case 76:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueIchor.Description", Array.Empty<object>());
						break;
				case 77:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueNanites.Description", Array.Empty<object>());
						break;
				case 78:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueConfetti.Description", Array.Empty<object>());
						break;
				case 79:
						tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbuePoison.Description", Array.Empty<object>());
						break;
				default:
					switch (type)
					{
						case 88:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.ChaosState.Description", Array.Empty<object>());
							break;
						case 89:
						case 90:
						case 91:
						case 92:
						case 93:
						case 94:
							break;
						case 95:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance1.Description", Array.Empty<object>());
								break;
						case 96:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance2.Description", Array.Empty<object>());
								break;
						case 97:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance3.Description", Array.Empty<object>());
								break;
						case 98:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight1.Description", Array.Empty<object>());
								break;
						case 99:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight2.Description", Array.Empty<object>());
								break;
						case 100:
								tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight3.Description", Array.Empty<object>());
								break;
						default:
							if (type == 114)
							{
									tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Endurance.Description", Array.Empty<object>());
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
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg1.Description", Array.Empty<object>());
						break;
					case 180:
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg2.Description", Array.Empty<object>());
						break;
					case 181:
							tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg3.Description", Array.Empty<object>());
						break;
				}
			}
			else
			{
					tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Warmth.Description", Array.Empty<object>());
			}
		}
		else if (type == 189)
		{
				tip = Language.GetTextValue("BuffDescription.Daybreak");
		}
		else if (type == 192)
		{
				tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.SugarRush.Description", Array.Empty<object>());
		}
			else if (type == 206)
			{
				tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedM.Description", Array.Empty<object>());
			}
			else if (type == 207)
			{
				tip = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedL.Description", Array.Empty<object>());
			}
		if (!tip.Equals(""))
		{
				tooltip = tip;
		}
	}

	public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.IsCN && ModsCall.Calamity != null;
		}

	}
    
}
