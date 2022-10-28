using System;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.AdultEidolonWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Crags;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.DraedonLabThings;
using CalamityMod.NPCs.ExoMechs;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.GreatSandShark;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.PlagueEnemies;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SulphurousSea;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.NPCs.Yharon;
using CalamityCN.LangUtils;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace CalamityCN.Translations.TransInHjson
{
	public class Bestiary : GlobalNPC
	{
		public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.IsCN && ModsCall.Calamity != null;
		}

		public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			if (npc.type == ModContent.NPCType<Bloatfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Bloatfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BobbitWormHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BobbitWormHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BoxJellyfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BoxJellyfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ChaoticPuffer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ChaoticPuffer", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ColossalSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ColossalSquid", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Cuttlefish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Cuttlefish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DevilFish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DevilFish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DevilFishAlt>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DevilFishAlt", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<EidolonWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.EidolonWyrmHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GiantSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GiantSquid", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GulperEelHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GulperEelHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Laserfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Laserfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<LuminousCorvina>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.LuminousCorvina", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<MirageJelly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.MirageJelly", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<MorayEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.MorayEel", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<OarfishHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.OarfishHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ReaperShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ReaperShark", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ToxicMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ToxicMinnow", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Viperfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Viperfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AcidEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AcidEel", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BabyFlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BabyFlakCrab", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BloodwormNormal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BloodwormNormal", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CragmawMire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CragmawMire", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<FlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.FlakCrab", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GammaSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GammaSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<IrradiatedSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.IrradiatedSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Mauler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Mauler", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<NuclearTerror>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.NuclearTerror", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<NuclearToad>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.NuclearToad", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Orthocera>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Orthocera", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Radiator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Radiator", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Skyfin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Skyfin", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SulphurousSkater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SulphurousSkater", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Trilobite>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Trilobite", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AdultEidolonWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AdultEidolonWyrmHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AquaticScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AquaticScourgeHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AquaticUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AquaticUrchin", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Aries>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Aries", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AstralachneaGround>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AstralachneaGround", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AstralProbe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AstralProbe", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AstralSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AstralSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Atlas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Atlas", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BigSightseer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BigSightseer", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Hadarian>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Hadarian", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<HiveEnemy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Hive", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Hiveling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Hiveling", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Mantis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Mantis", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Nova>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Nova", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SmallSightseer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SmallSightseer", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<StellarCulex>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.StellarCulex", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Twinkler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Twinkler", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AstrumAureus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AstrumAureus", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AstrumDeusHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AstrumDeusHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Brimling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Brimling", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BrimstoneElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BrimstoneElemental", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Bumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Bumblefuck", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CalamitasClone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CalamitasClone", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Cataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Cataclysm", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Catastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Catastrophe", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SoulSeeker>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SoulSeeker", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CeaselessVoid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CeaselessVoid", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DarkEnergy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DarkEnergy", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrabShroom>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrabShroom", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Crabulon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Crabulon", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CalamityEye>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CalamityEye", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CharredSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CharredSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CultistAssassin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CultistAssassin", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DespairStone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DespairStone", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<HeatSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.HeatSpirit", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Scryllar>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Scryllar", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SoulSlurper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SoulSlurper", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Cryogen>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Cryogen", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DesertNuisanceHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DesertNuisanceHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DesertScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DesertScourgeHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CosmicGuardianHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CosmicGuardianHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DevourerofGodsHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DevourerofGodsHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Androomba>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Androomba", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Nanodroid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Nanodroid", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<RepairUnitCritter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.RepairUnitCritter", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Draedon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Draedon", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Apollo>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Apollo", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AresBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AresBody", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Artemis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Artemis", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ThanatosHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ThanatosHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GreatSandShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GreatSandShark", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DankCreeper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DankCreeper", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DarkHeart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DarkHeart", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<HiveBlob>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.HiveBlob", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<HiveCyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.HiveCyst", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<HiveMind>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.HiveMind", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Anahita>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Anahita", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AquaticAberration>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AquaticAberration", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Leviathan>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Leviathan", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<LeviathanStart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.LeviathanStart", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AeroSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AeroSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Rimehound>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Rimehound", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ArmoredDiggerHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ArmoredDiggerHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AuroraSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AuroraSpirit", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BloomSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BloomSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Bohldohr>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Bohldohr", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Cnidrion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Cnidrion", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CosmicElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CosmicElemental", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerAmber>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerAmber", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerAmethyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerAmethyst", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerCrystal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerCrystal", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerDiamond>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerDiamond", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerEmerald>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerEmerald", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerRuby>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerRuby", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerSapphire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerSapphire", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrawlerTopaz>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrawlerTopaz", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrimulanBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrimulanBlightSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Cryon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Cryon", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CryoSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CryoSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<EbonianBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.EbonianBlightSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Eidolist>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Eidolist", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<FearlessGoldfishWarrior>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.FearlessGoldfishWarrior", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Frogfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Frogfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<FusionFeeder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.FusionFeeder", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Horse>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Horse", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<IceClasper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.IceClasper", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ImpiousImmolator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ImpiousImmolator", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<MantisShrimp>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.MantisShrimp", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<OverloadedSoldier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.OverloadedSoldier", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerennialSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerennialSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PhantomSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PhantomSpirit", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritL>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PhantomSpiritL", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritM>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PhantomSpiritM", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritS>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PhantomSpiritS", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Piggy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Piggy", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ProfanedEnergyBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ProfanedEnergyBody", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Rotdog>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Rotdog", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ScornEater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ScornEater", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SeaUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SeaUrchin", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ShockstormShuttle>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ShockstormShuttle", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Stormlion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Stormlion", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Sunskater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Sunskater", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ThiccWaifu>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ThiccWaifu", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WildBumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WildBumblefuck", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WulfrumAmplifier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WulfrumAmplifier", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WulfrumDrone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WulfrumDrone", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WulfrumGyrator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WulfrumGyrator", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WulfrumHovercraft>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WulfrumHovercraft", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WulfrumRover>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WulfrumRover", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<OldDuke>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.OldDuke", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SulphurousSharkron>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SulphurousSharkron", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerforatorCyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerforatorCyst", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerforatorHeadLarge", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadMedium>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerforatorHeadMedium", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadSmall>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerforatorHeadSmall", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PerforatorHive>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PerforatorHive", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PlaguebringerGoliath>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PlaguebringerGoliath", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Melter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Melter", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PestilentSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PestilentSlime", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PlagueCharger>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PlagueCharger", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PlagueChargerLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PlagueChargerLarge", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PlaguebringerMiniboss>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PlaguebringerMiniboss", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Plagueshell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Plagueshell", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Viruling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Viruling", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Polterghast>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Polterghast", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianCommander>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ProfanedGuardianCommander", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianDefender>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ProfanedGuardianDefender", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianHealer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.ProfanedGuardianHealer", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Providence>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Providence", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<RavagerBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.RavagerBody", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CosmicLantern>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CosmicLantern", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Signus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Signus", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CorruptSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CorruptSlimeSpawn", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrimsonSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrimsonSlimeSpawn", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<CrimsonSlimeSpawn2>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.CrimsonSlimeSpawn2", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SlimeGodCore>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SlimeGodCore", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SplitCrimulanSlimeGod>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SplitCrimulanSlimeGod", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SplitEbonianSlimeGod>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SplitEbonianSlimeGod", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<StormWeaverHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.StormWeaverHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AnthozoanCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AnthozoanCrab", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BelchingCoral>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BelchingCoral", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Catfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Catfish", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Flounder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Flounder", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Gnasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Gnasher", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Trasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Trasher", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BabyGhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BabyGhostBell", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<BlindedAngler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.BlindedAngler", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Clam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Clam", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<EutrophicRay>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.EutrophicRay", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GhostBell", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<GiantClam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.GiantClam", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<PrismBack>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.PrismBack", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SeaFloaty>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SeaFloaty", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SeaMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SeaMinnow", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SeaSerpent1>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SeaSerpent1", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SepulcherHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SepulcherHead", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SoulSeekerSupreme>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SoulSeekerSupreme", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SupremeCalamitas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SupremeCalamitas", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SupremeCataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SupremeCataclysm", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SupremeCatastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SupremeCatastrophe", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<AndroombaFriendly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.AndroombaFriendly", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<DILF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.DILF", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<FAP>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.FAP", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<SEAHOE>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.SEAHOE", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<THIEF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.THIEF", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<WITCH>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.WITCH", Array.Empty<object>())));
			}
			if (npc.type == ModContent.NPCType<Yharon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetTextValue("CalamityMod.Bestiary.Yharon", Array.Empty<object>())));
			}
		}
	}
}
