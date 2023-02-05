using System;
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
			if (npc.type == ModContent.NPCType<GreatSandShark>() && WorldSaveSystem.InfernumMode)
			{
				typeName = "托勒斯，旱海狂鲨";
			}
		}
	}
}
