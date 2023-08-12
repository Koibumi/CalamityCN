using System.Collections.Generic;
using CalamityCN.Utils;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CalamityMod.Items.SummonItems;
using InfernumMode.Content.Items.Relics;
using InfernumMode.Content.Items;
using InfernumMode.Content.Items.Misc;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfernumTooltipTrans : GlobalItem
	{
		public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCN;
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ModContent.ItemType<ProfanedShard>())
			{
				ItemHelper.ApplyTooltipEdits(item, tooltips, (Item i, TooltipLine l) => l.Text == "Summons the Profaned Guardians when used on the cliff in the profaned garden at the far right of the underworld during day", delegate (TooltipLine tooltip)
				{
					tooltip.Text = "在地狱最右侧亵渎花园的悬崖上使用召唤亵渎守卫";
				});
				ItemHelper.TranslateTooltip(item, tooltips, "Warning", delegate (TooltipLine tooltip)
				{
					tooltip.Text = "当前世界没有亵渎神庙，击杀一次月亮领主来生成\n注意：确保已探索地狱嘉登实验室，生成亵渎神庙可能会破坏它";
				});
			}

			foreach (TooltipLine line in tooltips)
			{
				line.Text = line.Text.Replace("Developer Item", "开发者物品");

				if (item.type == ModContent.ItemType<Wayfinder>())
				{
					line.Text = line.Text.Replace("Hold LMB to teleport to the gate", "按住左键传送到魔法门");
					line.Text = line.Text.Replace("Hold LMB and", "按住左键和");
					line.Text = line.Text.Replace("unbound", "未绑定");
					line.Text = line.Text.Replace("to set the gate to your position", "键，设置你的魔法门传送点");
					line.Text = line.Text.Replace("to remove the gate", "键，移除魔法门");
				}
				
				if (item.type == ItemID.WormFood)
				{
					line.Text = line.Text.Replace("Enrages outside of the Corruption", "在腐化外狂暴");
				}
				if (item.type == ItemID.CelestialSigil)
				{
					line.Text = line.Text.Replace("Summons the Moon Lord immediately\nCreates an arena at the player's position\nNot consumable.", "立刻召唤月亮领主\n会在玩家的位置创建一个战斗场地\n不消耗");
				}
				if (item.type == ModContent.ItemType<EyeofDesolation>())
				{
					line.Text = line.Text.Replace("Summons the Forgotten Shadow of Calamitas when used during nighttime", "在夜晚使用召唤遗落灾影");
				}
				if (item.type == ModContent.ItemType<ProfanedCore>())
				{
					line.Text = line.Text.Replace("Summons Providence when used at the altar in the profaned temple at the far right of the underworld", "在地狱最右侧亵渎神庙中圣坛使用召唤亵渎天神");
				}
				if (item.type == ModContent.ItemType<RuneofKos>())
				{
					line.Text = line.Text.Replace("The Ceaseless Void can only be fought in the Archives", "无尽虚空只能在废弃档案室中战斗");
				}
				if (item.type == ItemID.LihzahrdPowerCell)
				{
					line.Text = line.Text.Replace("\nCreates a rectangular arena around the altar. If the altar is inside of the temple solid tiles within the arena are broken", "\n在祭坛周围创建一个矩形战斗场地，如果祭坛在神庙内，则场地内神庙方块会被破坏");
				}
				if (item.type == ModContent.ItemType<ProvidenceRelic>())
				{
					line.Text = line.Text.Replace("The first major hurdle following the defeat of the Moon Lord. Your triumph over her was by no means a small feat.\nPerhaps consider fighting her again during the night for a special challenge?", "这是在你击败月球领主后遇到的第一个阻碍。战胜她绝非易事。\n也许你可以试试在晚上与她来一次特别的战斗？");
					line.Text = line.Text.Replace("Bruh? What the heck? Are you OK?\nYou were supposed to fight her at night AFTER beating her during the day first!", "老兄？你在干什么？你还好吗？\n你应该先在白天击败过她一次后再在晚上与她战斗的！");
				}
				if (item.type == ModContent.ItemType<DraedonRelic>())
				{
					line.Text = line.Text.Replace("You have done phenomenally. There is only one challenge left now-\nFace the Witch.", "你做的很好。现在，只剩下一个挑战了-\n面对那位女巫。");
					line.Text = line.Text.Replace("Spectacular work. You have conquered all of the major obstacles.\nTake pride in this accomplishment, for you are considerably stronger than you were when you began.", "令人赞叹，你已经战胜了所有的困难。\n为这些成就感到骄傲吧，因为你已经比最初的时候更加强大了。");
				}
				if (item.type == ModContent.ItemType<SupremeCalamitasRelic>())
				{
					line.Text = line.Text.Replace("You have done phenomenally. There is only one challenge left now-\nFace the Cosmic Engineer.", "你做的很好。现在，只剩下一个挑战了-\n面对那位神匠。");
					line.Text = line.Text.Replace("Spectacular work. You have conquered all of the major obstacles.\nTake pride in this accomplishment, for you are considerably stronger than you were when you began.", "令人赞叹，你已经战胜了所有的困难。\n为这些成就感到骄傲吧，因为你已经比最初的时候更加强大了。");
				}
				if (item.type == ModContent.ItemType<EyeOfCthulhuRelic>())
				{
					line.Text = line.Text.Replace("Remember to not force yourself too much in the pursuit of victory. Take breaks if you need to.\nThe most important thing is fun.", "记住，你没有必要一直强迫自己取得胜利，有必要的话小憩一下也未尝不可。\n最重要的，是享受。");
				}
				if (item.type == ModContent.ItemType<EmpressOfLightRelic>())
				{
					line.Text = line.Text.Replace("The optional foes may at times be the most formidable. So too may they yield the greatest rewards.", "那些可选性的敌人有时可能很难对付。击败他们也可能会拥有很高的收益。");
				}
				if (item.type == ModContent.ItemType<GolemRelic>())
				{
					line.Text = line.Text.Replace("Simple methodical planning goes a long way. It will be invaluable against future obstacles.", "还有很长的路要走，有条不紊的计划将有助于克服未来的障碍。");
				}
				if (item.type == ModContent.ItemType<KingSlimeRelic>())
				{
					line.Text = line.Text.Replace("Even seasoned players may struggle somewhat in the face of something new and unfamiliar. Adaptability is key.", "即使是经验再丰富的玩家，面对陌生的挑战也会不熟练。适应力是关键。");
				}
				if (item.type == ModContent.ItemType<MoonLordRelic>())
				{
					line.Text = line.Text.Replace("You have done very well thus far.\nMay your tenacity guide you through the remaining challenges.", "到目前为止，你做得很好。\n但愿你的坚韧不拔能指引你完成剩下的挑战。");
				}
				if (item.type == ModContent.ItemType<OldDukeRelic>())
				{
					line.Text = line.Text.Replace("Difficult as the fight may be, you were wise to endure and overcome the challenge it brings.\nYou will find that the mechanics it tested will be relevant again soon.", "这也许是场困难的战斗，但你十分明智的忍受并克服了它所带来的挑战。\n你会发现它所测试你的机制将很快就会再次出现。");
				}
				if (item.type == ModContent.ItemType<PlanteraRelic>())
				{
					line.Text = line.Text.Replace("Be proud of your death count!\nThe more you die, the more you're learning. Keep going!", "为死亡次数而欢呼吧！\n死亡次数越多，表示您的经验越丰富。继续加油！");
				}
				if (item.type == ModContent.ItemType<SkeletronRelic>())
				{
					line.Text = line.Text.Replace("The first major roadblock. You are better now than before you faced it. Did you have fun learning its patterns?", "流程第一个阻碍，你现在比之前面对它更加熟练了，你享受熟练它攻击模式的过程吗？");
				}
				if (item.type == ModContent.ItemType<DevourerOfGodsRelic>())
				{
					line.Text = line.Text.Replace("Sometimes pure reaction skill is the most valuable thing to cultivate.\nYou are in the final stretch. Your determination has proven invaluable up to this point.\nMay it guide you through the last challenges.", "有些时候，纯粹的反应能力是最值得去培养的\n你已经到了最终的阶段。目前为止，你已经证明了你那无价的决心。\n愿它指引你完成最后的挑战。");
				}
				if (item.type == ModContent.ItemType<SandstormsCore>())
				{
					line.Text = line.Text.Replace("Opens a portal to the Lost Colosseum", "开启前往失落竞技场的入口");
					line.Text = line.Text.Replace("Your world does not currently have a Lost Gateway. Kill the Lunatic Cultist again to generate it.", "你的世界目前没有失落之门，杀死拜月教邪教徒以生成它。");
				}
			}
		}
	}
}
