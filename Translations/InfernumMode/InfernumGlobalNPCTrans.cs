using System;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.GreatSandShark;
using InfernumMode.Core.GlobalInstances.Systems;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfernumGlobalNPCTrans : GlobalNPC
	{
		public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCN;
		}

		public override void ModifyTypeName(NPC npc, ref string typeName)
		{
			if (WorldSaveSystem.InfernumModeEnabled)
			{
				if (npc.type == ModContent.NPCType<GreatSandShark>())
				{
					typeName = "旱海狂鲨，托勒斯";
				}
				if (npc.type == ModContent.NPCType<CalamitasClone>())
				{
					typeName = "遗落灾影";
				}
				if (npc.type == ModContent.NPCType<Cataclysm>())
				{
					typeName = "遗落灾祸之影";
				}
				if (npc.type == ModContent.NPCType<Catastrophe>())
				{
					typeName = "遗落灾难之影";
				}
			}
		}
	}
}
