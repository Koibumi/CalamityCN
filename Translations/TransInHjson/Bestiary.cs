using System;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.PrimordialWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
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
using CalamityCN.Utils;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;
using CalamityMod.NPCs.CalClone;

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
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Bloatfish")));
			}
			if (npc.type == ModContent.NPCType<BobbitWormHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BobbitWormHead")));
			}
			if (npc.type == ModContent.NPCType<BoxJellyfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BoxJellyfish")));
			}
			if (npc.type == ModContent.NPCType<ChaoticPuffer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ChaoticPuffer")));
			}
			if (npc.type == ModContent.NPCType<ColossalSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ColossalSquid")));
			}
			if (npc.type == ModContent.NPCType<Cuttlefish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Cuttlefish")));
			}
			if (npc.type == ModContent.NPCType<DevilFish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DevilFish")));
			}
			if (npc.type == ModContent.NPCType<DevilFishAlt>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DevilFishAlt")));
			}
			if (npc.type == ModContent.NPCType<EidolonWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.EidolonWyrmHead")));
			}
			if (npc.type == ModContent.NPCType<GiantSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GiantSquid")));
			}
			if (npc.type == ModContent.NPCType<GulperEelHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GulperEelHead")));
			}
			if (npc.type == ModContent.NPCType<Laserfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Laserfish")));
			}
			if (npc.type == ModContent.NPCType<LuminousCorvina>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.LuminousCorvina")));
			}
			if (npc.type == ModContent.NPCType<MirageJelly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.MirageJelly")));
			}
			if (npc.type == ModContent.NPCType<MorayEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.MorayEel")));
			}
			if (npc.type == ModContent.NPCType<OarfishHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.OarfishHead")));
			}
			if (npc.type == ModContent.NPCType<ReaperShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ReaperShark")));
			}
			if (npc.type == ModContent.NPCType<ToxicMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ToxicMinnow")));
			}
			if (npc.type == ModContent.NPCType<Viperfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Viperfish")));
			}
			if (npc.type == ModContent.NPCType<AcidEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AcidEel")));
			}
			if (npc.type == ModContent.NPCType<BabyFlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BabyFlakCrab")));
			}
			if (npc.type == ModContent.NPCType<BloodwormNormal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BloodwormNormal")));
			}
			if (npc.type == ModContent.NPCType<CragmawMire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CragmawMire")));
			}
			if (npc.type == ModContent.NPCType<FlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.FlakCrab")));
			}
			if (npc.type == ModContent.NPCType<GammaSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GammaSlime")));
			}
			if (npc.type == ModContent.NPCType<IrradiatedSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.IrradiatedSlime")));
			}
			if (npc.type == ModContent.NPCType<Mauler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Mauler")));
			}
			if (npc.type == ModContent.NPCType<NuclearTerror>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.NuclearTerror")));
			}
			if (npc.type == ModContent.NPCType<NuclearToad>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.NuclearToad")));
			}
			if (npc.type == ModContent.NPCType<Orthocera>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Orthocera")));
			}
			if (npc.type == ModContent.NPCType<Radiator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Radiator")));
			}
			if (npc.type == ModContent.NPCType<Skyfin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Skyfin")));
			}
			if (npc.type == ModContent.NPCType<SulphurousSkater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SulphurousSkater")));
			}
			if (npc.type == ModContent.NPCType<Trilobite>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Trilobite")));
			}
			if (npc.type == ModContent.NPCType<PrimordialWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AdultEidolonWyrmHead")));
			}
			if (npc.type == ModContent.NPCType<AquaticScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AquaticScourgeHead")));
			}
			if (npc.type == ModContent.NPCType<AquaticUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AquaticUrchin")));
			}
			if (npc.type == ModContent.NPCType<Aries>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Aries")));
			}
			if (npc.type == ModContent.NPCType<AstralachneaGround>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AstralachneaGround")));
			}
			if (npc.type == ModContent.NPCType<AstralProbe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AstralProbe")));
			}
			if (npc.type == ModContent.NPCType<AstralSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AstralSlime")));
			}
			if (npc.type == ModContent.NPCType<Atlas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Atlas")));
			}
			if (npc.type == ModContent.NPCType<SightseerSpitter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BigSightseer")));
			}
			if (npc.type == ModContent.NPCType<Hadarian>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Hadarian")));
			}
			if (npc.type == ModContent.NPCType<HiveEnemy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.HiveEnemy")));
			}
			if (npc.type == ModContent.NPCType<Hiveling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Hiveling")));
			}
			if (npc.type == ModContent.NPCType<Mantis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Mantis")));
			}
			if (npc.type == ModContent.NPCType<Nova>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Nova")));
			}
			if (npc.type == ModContent.NPCType<SightseerCollider>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SmallSightseer")));
			}
			if (npc.type == ModContent.NPCType<StellarCulex>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.StellarCulex")));
			}
			if (npc.type == ModContent.NPCType<Twinkler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Twinkler")));
			}
			if (npc.type == ModContent.NPCType<AstrumAureus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AstrumAureus")));
			}
			if (npc.type == ModContent.NPCType<AstrumDeusHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AstrumDeusHead")));
			}
			if (npc.type == ModContent.NPCType<Brimling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Brimling")));
			}
			if (npc.type == ModContent.NPCType<BrimstoneElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BrimstoneElemental")));
			}
			if (npc.type == ModContent.NPCType<Bumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Bumblefuck")));
			}
			if (npc.type == ModContent.NPCType<CalamitasClone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CalamitasClone")));
			}
			if (npc.type == ModContent.NPCType<Cataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Cataclysm")));
			}
			if (npc.type == ModContent.NPCType<Catastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Catastrophe")));
			}
			if (npc.type == ModContent.NPCType<SoulSeeker>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SoulSeeker")));
			}
			if (npc.type == ModContent.NPCType<CeaselessVoid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CeaselessVoid")));
			}
			if (npc.type == ModContent.NPCType<DarkEnergy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DarkEnergy")));
			}
			if (npc.type == ModContent.NPCType<CrabShroom>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrabShroom")));
			}
			if (npc.type == ModContent.NPCType<Crabulon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Crabulon")));
			}
			if (npc.type == ModContent.NPCType<CalamityEye>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CalamityEye")));
			}
			if (npc.type == ModContent.NPCType<InfernalCongealment>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CharredSlime")));
			}
			if (npc.type == ModContent.NPCType<RenegadeWarlock>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CultistAssassin")));
			}
			if (npc.type == ModContent.NPCType<DespairStone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DespairStone")));
			}
			if (npc.type == ModContent.NPCType<HeatSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.HeatSpirit")));
			}
			if (npc.type == ModContent.NPCType<Scryllar>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Scryllar")));
			}
			if (npc.type == ModContent.NPCType<SoulSlurper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SoulSlurper")));
			}
			if (npc.type == ModContent.NPCType<Cryogen>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Cryogen")));
			}
			if (npc.type == ModContent.NPCType<DesertNuisanceHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DesertNuisanceHead")));
			}
			if (npc.type == ModContent.NPCType<DesertScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DesertScourgeHead")));
			}
			if (npc.type == ModContent.NPCType<CosmicGuardianHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CosmicGuardianHead")));
			}
			if (npc.type == ModContent.NPCType<DevourerofGodsHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DevourerofGodsHead")));
			}
			if (npc.type == ModContent.NPCType<Androomba>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Androomba")));
			}
			if (npc.type == ModContent.NPCType<Nanodroid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Nanodroid")));
			}
			if (npc.type == ModContent.NPCType<RepairUnitCritter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.RepairUnitCritter")));
			}
			if (npc.type == ModContent.NPCType<Draedon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Draedon")));
			}
			if (npc.type == ModContent.NPCType<Apollo>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Apollo")));
			}
			if (npc.type == ModContent.NPCType<AresBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AresBody")));
			}
			if (npc.type == ModContent.NPCType<Artemis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Artemis")));
			}
			if (npc.type == ModContent.NPCType<ThanatosHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ThanatosHead")));
			}
			if (npc.type == ModContent.NPCType<GreatSandShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GreatSandShark")));
			}
			if (npc.type == ModContent.NPCType<DankCreeper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DankCreeper")));
			}
			if (npc.type == ModContent.NPCType<DarkHeart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DarkHeart")));
			}
			if (npc.type == ModContent.NPCType<HiveBlob>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.HiveBlob")));
			}
			if (npc.type == ModContent.NPCType<HiveTumor>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.HiveTumor")));
			}
			if (npc.type == ModContent.NPCType<HiveMind>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.HiveMind")));
			}
			if (npc.type == ModContent.NPCType<Anahita>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Anahita")));
			}
			if (npc.type == ModContent.NPCType<AquaticAberration>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AquaticAberration")));
			}
			if (npc.type == ModContent.NPCType<Leviathan>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Leviathan")));
			}
			if (npc.type == ModContent.NPCType<LeviathanStart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.LeviathanStart")));
			}
			if (npc.type == ModContent.NPCType<AeroSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AeroSlime")));
			}
			if (npc.type == ModContent.NPCType<Rimehound>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Rimehound")));
			}
			if (npc.type == ModContent.NPCType<ArmoredDiggerHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ArmoredDiggerHead")));
			}
			if (npc.type == ModContent.NPCType<AuroraSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AuroraSpirit")));
			}
			if (npc.type == ModContent.NPCType<BloomSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BloomSlime")));
			}
			if (npc.type == ModContent.NPCType<Bohldohr>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Bohldohr")));
			}
			if (npc.type == ModContent.NPCType<Cnidrion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Cnidrion")));
			}
			/*
			if (npc.type == ModContent.NPCType<CosmicElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CosmicElemental")));
			}
			*/
			if (npc.type == ModContent.NPCType<CrawlerAmber>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerAmber")));
			}
			if (npc.type == ModContent.NPCType<CrawlerAmethyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerAmethyst")));
			}
			if (npc.type == ModContent.NPCType<CrawlerCrystal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerCrystal")));
			}
			if (npc.type == ModContent.NPCType<CrawlerDiamond>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerDiamond")));
			}
			if (npc.type == ModContent.NPCType<CrawlerEmerald>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerEmerald")));
			}
			if (npc.type == ModContent.NPCType<CrawlerRuby>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerRuby")));
			}
			if (npc.type == ModContent.NPCType<CrawlerSapphire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerSapphire")));
			}
			if (npc.type == ModContent.NPCType<CrawlerTopaz>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrawlerTopaz")));
			}
			if (npc.type == ModContent.NPCType<CrimulanBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrimulanBlightSlime")));
			}
			if (npc.type == ModContent.NPCType<Cryon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Cryon")));
			}
			if (npc.type == ModContent.NPCType<CryoSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CryoSlime")));
			}
			if (npc.type == ModContent.NPCType<EbonianBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.EbonianBlightSlime")));
			}
			if (npc.type == ModContent.NPCType<Eidolist>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Eidolist")));
			}
			if (npc.type == ModContent.NPCType<FearlessGoldfishWarrior>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.FearlessGoldfishWarrior")));
			}
			if (npc.type == ModContent.NPCType<Frogfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Frogfish")));
			}
			if (npc.type == ModContent.NPCType<FusionFeeder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.FusionFeeder")));
			}
			if (npc.type == ModContent.NPCType<Horse>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Horse")));
			}
			if (npc.type == ModContent.NPCType<IceClasper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.IceClasper")));
			}
			if (npc.type == ModContent.NPCType<ImpiousImmolator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ImpiousImmolator")));
			}
			if (npc.type == ModContent.NPCType<MantisShrimp>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.MantisShrimp")));
			}
			if (npc.type == ModContent.NPCType<OverloadedSoldier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.OverloadedSoldier")));
			}
			if (npc.type == ModContent.NPCType<PerennialSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerennialSlime")));
			}
			if (npc.type == ModContent.NPCType<PhantomSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PhantomSpirit")));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritL>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PhantomSpiritL")));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritM>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PhantomSpiritM")));
			}
			if (npc.type == ModContent.NPCType<PhantomSpiritS>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PhantomSpiritS")));
			}
			if (npc.type == ModContent.NPCType<Piggy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Piggy")));
			}
			if (npc.type == ModContent.NPCType<ProfanedEnergyBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ProfanedEnergyBody")));
			}
			if (npc.type == ModContent.NPCType<Rotdog>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Rotdog")));
			}
			if (npc.type == ModContent.NPCType<ScornEater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ScornEater")));
			}
			if (npc.type == ModContent.NPCType<SeaUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SeaUrchin")));
			}
			if (npc.type == ModContent.NPCType<ShockstormShuttle>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ShockstormShuttle")));
			}
			if (npc.type == ModContent.NPCType<Stormlion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Stormlion")));
			}
			if (npc.type == ModContent.NPCType<Sunskater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Sunskater")));
			}
			if (npc.type == ModContent.NPCType<ThiccWaifu>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ThiccWaifu")));
			}
			if (npc.type == ModContent.NPCType<WildBumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WildBumblefuck")));
			}
			if (npc.type == ModContent.NPCType<WulfrumAmplifier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WulfrumAmplifier")));
			}
			if (npc.type == ModContent.NPCType<WulfrumDrone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WulfrumDrone")));
			}
			if (npc.type == ModContent.NPCType<WulfrumGyrator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WulfrumGyrator")));
			}
			if (npc.type == ModContent.NPCType<WulfrumHovercraft>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WulfrumHovercraft")));
			}
			if (npc.type == ModContent.NPCType<WulfrumRover>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WulfrumRover")));
			}
			if (npc.type == ModContent.NPCType<OldDuke>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.OldDuke")));
			}
			if (npc.type == ModContent.NPCType<SulphurousSharkron>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SulphurousSharkron")));
			}
			if (npc.type == ModContent.NPCType<PerforatorCyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerforatorCyst")));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerforatorHeadLarge")));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadMedium>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerforatorHeadMedium")));
			}
			if (npc.type == ModContent.NPCType<PerforatorHeadSmall>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerforatorHeadSmall")));
			}
			if (npc.type == ModContent.NPCType<PerforatorHive>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PerforatorHive")));
			}
			if (npc.type == ModContent.NPCType<PlaguebringerGoliath>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PlaguebringerGoliath")));
			}
			if (npc.type == ModContent.NPCType<Melter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Melter")));
			}
			if (npc.type == ModContent.NPCType<PestilentSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PestilentSlime")));
			}
			if (npc.type == ModContent.NPCType<PlagueCharger>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PlagueCharger")));
			}
			if (npc.type == ModContent.NPCType<PlagueChargerLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PlagueChargerLarge")));
			}
			if (npc.type == ModContent.NPCType<PlaguebringerMiniboss>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PlaguebringerMiniboss")));
			}
			if (npc.type == ModContent.NPCType<Plagueshell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Plagueshell")));
			}
			if (npc.type == ModContent.NPCType<Viruling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Viruling")));
			}
			if (npc.type == ModContent.NPCType<Polterghast>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Polterghast")));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianCommander>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ProfanedGuardianCommander")));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianDefender>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ProfanedGuardianDefender")));
			}
			if (npc.type == ModContent.NPCType<ProfanedGuardianHealer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.ProfanedGuardianHealer")));
			}
			if (npc.type == ModContent.NPCType<Providence>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Providence")));
			}
			if (npc.type == ModContent.NPCType<RavagerBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.RavagerBody")));
			}
			if (npc.type == ModContent.NPCType<CosmicLantern>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CosmicLantern")));
			}
			if (npc.type == ModContent.NPCType<Signus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Signus")));
			}
			if (npc.type == ModContent.NPCType<CorruptSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CorruptSlimeSpawn")));
			}
			if (npc.type == ModContent.NPCType<CrimsonSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrimsonSlimeSpawn")));
			}
			if (npc.type == ModContent.NPCType<CrimsonSlimeSpawn2>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.CrimsonSlimeSpawn2")));
			}
			if (npc.type == ModContent.NPCType<SlimeGodCore>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SlimeGodCore")));
			}
			if (npc.type == ModContent.NPCType<SplitCrimulanPaladin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SplitCrimulanSlimeGod")));
			}
			if (npc.type == ModContent.NPCType<SplitEbonianPaladin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SplitEbonianSlimeGod")));
			}
			if (npc.type == ModContent.NPCType<StormWeaverHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.StormWeaverHead")));
			}
			if (npc.type == ModContent.NPCType<AnthozoanCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AnthozoanCrab")));
			}
			if (npc.type == ModContent.NPCType<BelchingCoral>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BelchingCoral")));
			}
			if (npc.type == ModContent.NPCType<Toxicatfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Toxicatfish")));
			}
			if (npc.type == ModContent.NPCType<Sulflounder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Sulflounder")));
			}
			if (npc.type == ModContent.NPCType<Gnasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Gnasher")));
			}
			if (npc.type == ModContent.NPCType<Trasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Trasher")));
			}
			if (npc.type == ModContent.NPCType<BabyGhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BabyGhostBell")));
			}
			if (npc.type == ModContent.NPCType<BlindedAngler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.BlindedAngler")));
			}
			if (npc.type == ModContent.NPCType<Clam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Clam")));
			}
			if (npc.type == ModContent.NPCType<EutrophicRay>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.EutrophicRay")));
			}
			if (npc.type == ModContent.NPCType<GhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GhostBell")));
			}
			if (npc.type == ModContent.NPCType<GiantClam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.GiantClam")));
			}
			if (npc.type == ModContent.NPCType<PrismBack>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.PrismBack")));
			}
			if (npc.type == ModContent.NPCType<SeaFloaty>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SeaFloaty")));
			}
			if (npc.type == ModContent.NPCType<SeaMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SeaMinnow")));
			}
			if (npc.type == ModContent.NPCType<SeaSerpent1>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SeaSerpent1")));
			}
			if (npc.type == ModContent.NPCType<SepulcherHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SepulcherHead")));
			}
			if (npc.type == ModContent.NPCType<SoulSeekerSupreme>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SoulSeekerSupreme")));
			}
			if (npc.type == ModContent.NPCType<SupremeCalamitas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SupremeCalamitas")));
			}
			if (npc.type == ModContent.NPCType<SupremeCataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SupremeCataclysm")));
			}
			if (npc.type == ModContent.NPCType<SupremeCatastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SupremeCatastrophe")));
			}
			if (npc.type == ModContent.NPCType<AndroombaFriendly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.AndroombaFriendly")));
			}
			if (npc.type == ModContent.NPCType<DILF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.DILF")));
			}
			if (npc.type == ModContent.NPCType<FAP>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.FAP")));
			}
			if (npc.type == ModContent.NPCType<SEAHOE>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.SEAHOE")));
			}
			if (npc.type == ModContent.NPCType<THIEF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.THIEF")));
			}
			if (npc.type == ModContent.NPCType<WITCH>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.WITCH")));
			}
			if (npc.type == ModContent.NPCType<Yharon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("CalamityMod.Bestiary.Yharon")));
			}
		}
	}
}
