using System;
using System.Collections.Generic;
using CalamityCN.Utils;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using InfernumMode.Items.Relics;
using CalamityMod.Items.SummonItems;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfernumTooltipTrans : GlobalItem
	{
		public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN;
		}

		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ModContent.ItemType<ProfanedShard>())
			{
				ItemHelper.ApplyTooltipEdits(item, tooltips, (Item i, TooltipLine l) => l.Text == "Summons the Profaned Guardians when used in the profaned garden at the far right of the underworld", delegate (TooltipLine tooltip)
				{
					tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.Tooltip.ProfanedShard.0", Array.Empty<object>());
				});
				ItemHelper.TranslateTooltip(item, tooltips, "Warning", delegate (TooltipLine tooltip)
				{
					tooltip.Text = LangHelper.GetTextValue("InfernumMode.Items.Tooltip.ProfanedShard.Warning", Array.Empty<object>());
				});
				return;
			}

			foreach (TooltipLine line in tooltips)
			{
				if (item.type == ItemID.CelestialSigil)
				{
					line.Text = line.Text.Replace("Summons the Moon Lord immediately\nCreates an arena at the player's position\nNot consumable.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.Vanilla.CelestialSigil", Array.Empty<object>()));
				}
				if (item.type == ItemID.LihzahrdPowerCell)
				{
					line.Text = line.Text.Replace("\nCreates a rectangular arena around the altar. If the altar is inside of the temple solid tiles within the arena are broken", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.Vanilla.LihzahrdPowerCell", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<ProfanedCore>())
				{
					line.Text = line.Text.Replace("Summons Providence when used at the alter in the profaned temple at the far right of the underworld", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.ProfanedCore", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<ProvidenceRelic>())
				{
					line.Text = line.Text.Replace("The first major hurdle following the defeat of the Moon Lord. Your triumph over her was by no means a small feat.\nPerhaps consider fighting her again during the night for a special challenge?", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.ProvidenceRelic.0", Array.Empty<object>()));
					line.Text = line.Text.Replace("Bruh? What the heck? Are you OK?\nYou were supposed to fight her at night AFTER beating her during the day first!", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.ProvidenceRelic.HasBeatedInfernumNightProvBeforeDay", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<DraedonRelic>())
				{
					line.Text = line.Text.Replace("You have done phenomenally. There is only one challenge left now-\nFace the Witch.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.DraedonRelic.0", Array.Empty<object>()));
					line.Text = line.Text.Replace("Spectacular work. You have conquered all of the major obstacles.\nTake pride in this accomplishment, for you are considerably stronger than you were when you began.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.DraedonRelic.DownedSCal", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<SupremeCalamitasRelic>())
				{
					line.Text = line.Text.Replace("You have done phenomenally. There is only one challenge left now-\nFace the Cosmic Engineer.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.SupremeCalamitasRelic.0", Array.Empty<object>()));
					line.Text = line.Text.Replace("Spectacular work. You have conquered all of the major obstacles.\nTake pride in this accomplishment, for you are considerably stronger than you were when you began.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.SupremeCalamitasRelic.DownedExoMechs", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<EyeOfCthulhuRelic>())
				{
					line.Text = line.Text.Replace("Remember to not force yourself too much in the pursuit of victory. Take breaks if you need to.\nThe most important thing is fun.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.EyeOfCthulhuRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
				{
					line.Text = line.Text.Replace("The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.EmpressOfLightRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<GolemRelic>())
				{
					line.Text = line.Text.Replace("Simple methodical planning goes a long way. It will be invaluable against future obstacles.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.GolemRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<KingSlimeRelic>())
				{
					line.Text = line.Text.Replace("Even seasoned players may struggle somewhat in the face of something new and unfamiliar. Adaptability is key.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.KingSlimeRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<MoonLordRelic>())
				{
					line.Text = line.Text.Replace("You have done very well thus far.\nMay your tenacity guide you through the remaining challenges.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.MoonLordRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<OldDukeRelic>())
				{
					line.Text = line.Text.Replace("Difficult as the fight may be, you were wise to endure and overcome the challenge it brings.\nYou will find that the mechanics it tested will be relevant again soon.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.OldDukeRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<PlanteraRelic>())
				{
					line.Text = line.Text.Replace("Be proud of your death count!\nThe more you die, the more you're learning. Keep going!", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.PlanteraRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<SkeletronRelic>())
				{
					line.Text = line.Text.Replace("The first major roadblock. You are better now than before you faced it. Did you have fun learning its patterns?", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.SkeletronRelic", Array.Empty<object>()));
				}
				if (item.type == ModContent.ItemType<DevourerOfGodsRelic>())
				{
					line.Text = line.Text.Replace("Sometimes pure reaction skill is the most valuable thing to cultivate.\nYou are in the final stretch. Your determination has proven invaluable up to this point.\nMay it guide you through the last challenges.", LangHelper.GetTextValue("InfernumMode.Items.Tooltip.DevourerOfGodsRelic", Array.Empty<object>()));
				}
			}
		}
	}
}
