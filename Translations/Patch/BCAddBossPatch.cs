using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.Items.Armor.Vanity;
using CalamityMod.Items.LoreItems;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Pets;
using CalamityMod.Items.Placeables.Furniture;
using CalamityMod.Items.Placeables.Furniture.CraftingStations;
using CalamityMod.Items.Placeables.Furniture.Trophies;
using CalamityMod.Items.SummonItems;
using CalamityMod.NPCs.AdultEidolonWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.GreatSandShark;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.Yharon;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityCN.Translations.Patch
{
    [JITWhenModsEnabled(new string[]
	{
		"CalamityMod"
	})]
	public class BCAddBossPatch : OnPatcher
	{

		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Calamity != null && ModsCall.IsCN && ModsCall.BossChecklist != null;
			}
		}

		public override MethodInfo ModifiedMethod
		{
			get
			{
				Mod calamity = ModsCall.Calamity;
				Type type = (calamity != null) ? calamity.Code.GetType("CalamityMod.WeakReferenceSupport") : null;
				if (type == null)
				{
					return null;
				}
				return type.GetMethod("AddCalamityBosses", BindingFlags.Static | BindingFlags.NonPublic);
			}
		}
		public override Delegate Delegate
		{
			get
			{
				return new Action<AddCalamityBossesDelegate, Mod, Mod>(this.Translation);
			}
		}

		private void Translation(AddCalamityBossesDelegate orig, Mod bossChecklist, Mod calamity)
		{
			string name = "荒漠灾虫";
			float difficulty = 1.6f;
			List<int> list = new List<int>();
			list.Add(ModContent.NPCType<DesertScourgeHead>());
			list.Add(ModContent.NPCType<DesertScourgeBody>());
			list.Add(ModContent.NPCType<DesertScourgeTail>());
			Func<bool> downed = () => DownedBossSystem.downedDesertScourge;
			object summon = ModContent.ItemType<DesertMedallion>();
			List<int> list2 = new List<int>();
			list2.Add(ModContent.ItemType<DesertScourgeTrophy>());
			list2.Add(ModContent.ItemType<DesertScourgeMask>());
			list2.Add(ModContent.ItemType<KnowledgeDesertScourge>());
			AddBoss(bossChecklist, calamity, name, difficulty, list, downed, summon, list2, "在沙漠环境使用 [i:" + ModContent.ItemType<DesertMedallion>().ToString() + "] 召唤", CalamityUtils.ColorMessage("荒漠灾虫潜入旱海之中……", new Color(238, 232, 170)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/DesertScourge/DesertScourge_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, null);
            AddMiniBoss(bossChecklist, calamity, "巨像蛤", 1.61f, ModContent.NPCType<GiantClam>(), () => DownedBossSystem.downedCLAM, null, null, "荒漠灾虫后自然刷新在沉沦之海", CalamityUtils.ColorMessage("巨像蛤重返水下岩窟之中……", new Color(127, 255, 212)), () => true, null, null);
			string name2 = "菌生蟹";
			float difficulty2 = 2.7f;
			int npcType = ModContent.NPCType<Crabulon>();
			Func<bool> downed2 = () => DownedBossSystem.downedCrabulon;
			object summon2 = ModContent.ItemType<DecapoditaSprout>();
			List<int> list3 = new List<int>();
			list3.Add(ModContent.ItemType<CrabulonTrophy>());
			list3.Add(ModContent.ItemType<CrabulonMask>());
			list3.Add(ModContent.ItemType<KnowledgeCrabulon>());
            AddBoss(bossChecklist, calamity, name2, difficulty2, npcType, downed2, summon2, list3, "在发光蘑菇地使用 [i:" + ModContent.ItemType<DecapoditaSprout>().ToString() + "] 召唤", CalamityUtils.ColorMessage("菌生蟹失去了对你的兴趣……", new Color(100, 149, 237)), () => true, null, null);
			string name3 = "腐巢意志";
			float difficulty3 = 3.98f;
			int npcType2 = ModContent.NPCType<HiveMind>();
			Func<bool> downed3 = () => DownedBossSystem.downedHiveMind;
			object summon3 = ModContent.ItemType<Teratoma>();
			List<int> list4 = new List<int>();
			list4.Add(ModContent.ItemType<HiveMindTrophy>());
			list4.Add(ModContent.ItemType<HiveMindMask>());
			list4.Add(ModContent.ItemType<KnowledgeHiveMind>());
			list4.Add(ModContent.ItemType<RottingEyeball>());
			AddBoss(bossChecklist, calamity, name3, difficulty3, npcType2, downed3, summon3, list4, "杀死刷新在腐化之地的腐化囊或在腐化之地使用 [i:" + ModContent.ItemType<Teratoma>().ToString() + "] 召唤", CalamityUtils.ColorMessage("腐化之源开始搜寻下一处繁衍之所……", new Color(148, 0, 211)), () => true, null, "CalamityMod/NPCs/HiveMind/HiveMindP2_Head_Boss");
			string name4 = "血肉宿主";
			float difficulty4 = 3.99f;
			int npcType3 = ModContent.NPCType<PerforatorHive>();
			Func<bool> downed4 = () => DownedBossSystem.downedPerforator;
			object summon4 = ModContent.ItemType<BloodyWormFood>();
			List<int> list5 = new List<int>();
			list5.Add(ModContent.ItemType<PerforatorTrophy>());
			list5.Add(ModContent.ItemType<PerforatorMask>());
			list5.Add(ModContent.ItemType<KnowledgePerforators>());
			list5.Add(ModContent.ItemType<BloodyVein>());
			AddBoss(bossChecklist, calamity, name4, difficulty4, npcType3, downed4, summon4, list5, "杀死刷新在猩红之地的血肉囊或在猩红之地使用 [i:" + ModContent.ItemType<BloodyWormFood>().ToString() + "] 召唤", CalamityUtils.ColorMessage("寄生意志开始搜寻下一位不幸宿主……", new Color(220, 20, 60)), () => true, null, null);
			string name5 = "史莱姆之神";
			float difficulty5 = 6.5f;
			List<int> list6 = new List<int>();
			list6.Add(ModContent.NPCType<SlimeGodCore>());
			list6.Add(ModContent.NPCType<EbonianSlimeGod>());
			list6.Add(ModContent.NPCType<CrimulanSlimeGod>());
			Func<bool> downed5 = () => DownedBossSystem.downedSlimeGod;
			object summon5 = ModContent.ItemType<OverloadedSludge>();
			List<int> list7 = new List<int>();
			list7.Add(ModContent.ItemType<SlimeGodTrophy>());
			list7.Add(ModContent.ItemType<SlimeGodMask>());
			list7.Add(ModContent.ItemType<SlimeGodMask2>());
			list7.Add(ModContent.ItemType<KnowledgeSlimeGod>());
			AddBoss(bossChecklist, calamity, name5, difficulty5, list6, downed5, summon5, list7, "使用 [i:" + ModContent.ItemType<OverloadedSludge>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("归元凝一的丑恶存在为它的同胞们完成了复仇……", new Color(186, 85, 51)), () => true, null, null);
			string name6 = "极地之灵";
			float difficulty6 = 8.5f;
			int npcType4 = ModContent.NPCType<Cryogen>();
			Func<bool> downed6 = () => DownedBossSystem.downedCryogen;
			object summon6 = ModContent.ItemType<CryoKey>();
			List<int> list8 = new List<int>();
			list8.Add(ModContent.ItemType<CryogenTrophy>());
			list8.Add(ModContent.ItemType<CryogenMask>());
			list8.Add(ModContent.ItemType<KnowledgeCryogen>());
			AddBoss(bossChecklist, calamity, name6, difficulty6, npcType4, downed6, summon6, list8, "在雪原群系使用 [i:" + ModContent.ItemType<CryoKey>().ToString() + "] 召唤", CalamityUtils.ColorMessage("冰灵在冷冽彻骨的寒风中渐行渐远……", new Color(0, 255, 255)), () => true, null, "CalamityMod/NPCs/Cryogen/Cryogen_Phase1_Head_Boss");
			string name7 = "渊海灾虫";
			float difficulty7 = 9.5f;
			List<int> list9 = new List<int>();
			list9.Add(ModContent.NPCType<AquaticScourgeHead>());
			list9.Add(ModContent.NPCType<AquaticScourgeBody>());
			list9.Add(ModContent.NPCType<AquaticScourgeTail>());
			Func<bool> downed7 = () => DownedBossSystem.downedAquaticScourge;
			object summon7 = ModContent.ItemType<Seafood>();
			List<int> list10 = new List<int>();
			list10.Add(ModContent.ItemType<AquaticScourgeTrophy>());
			list10.Add(ModContent.ItemType<AquaticScourgeMask>());
			list10.Add(ModContent.ItemType<KnowledgeAquaticScourge>());
			list10.Add(ModContent.ItemType<KnowledgeSulphurSea>());
			AddBoss(bossChecklist, calamity, name7, difficulty7, list9, downed7, summon7, list10, "在硫磺海使用 [i:" + ModContent.ItemType<Seafood>().ToString() + "] 召唤，或在硫磺海等待其自然刷新", CalamityUtils.ColorMessage("渊海灾虫游回汪洋之中……", new Color(238, 232, 170)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AquaticScourge/AquaticScourge_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/AquaticScourge/AquaticScourgeHead_Head_Boss");
			string name8 = "硫磺火元素";
			float difficulty8 = 10.5f;
			int npcType5 = ModContent.NPCType<BrimstoneElemental>();
			Func<bool> downed8 = () => DownedBossSystem.downedBrimstoneElemental;
			object summon8 = ModContent.ItemType<CharredIdol>();
			List<int> list11 = new List<int>();
			list11.Add(ModContent.ItemType<BrimstoneElementalTrophy>());
			list11.Add(ModContent.ItemType<BrimstoneWaifuMask>());
			list11.Add(ModContent.ItemType<KnowledgeBrimstoneCrag>());
			list11.Add(ModContent.ItemType<KnowledgeBrimstoneElemental>());
			list11.Add(ModContent.ItemType<CharredRelic>());
			AddBoss(bossChecklist, calamity, name8, difficulty8, npcType5, downed8, summon8, list11, "在硫火之崖使用 [i:" + ModContent.ItemType<CharredIdol>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("硫磺火元素重返她曾经的圣殿，如今的废墟中……", new Color(220, 20, 60)), () => true, null, null);
			string name9 = "灾厄";
			float difficulty9 = 11.7f;
			int npcType6 = ModContent.NPCType<CalamitasClone>();
			Func<bool> downed9 = () => DownedBossSystem.downedCalamitas;
			object summon9 = ModContent.ItemType<EyeofDesolation>();
			List<int> list12 = new List<int>();
			list12.Add(ModContent.ItemType<CalamitasTrophy>());
			list12.Add(ModContent.ItemType<CataclysmTrophy>());
			list12.Add(ModContent.ItemType<CatastropheTrophy>());
			list12.Add(ModContent.ItemType<CalamitasMask>());
			list12.Add(ModContent.ItemType<HoodOfCalamity>());
			list12.Add(ModContent.ItemType<RobesOfCalamity>());
			list12.Add(ModContent.ItemType<KnowledgeCalamitasClone>());
			AddBoss(bossChecklist, calamity, name9, difficulty9, npcType6, downed9, summon9, list12, "在夜晚使用 [i:" + ModContent.ItemType<EyeofDesolation>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("如果你渴望一场真正的战斗，那你战斗之前应当多做准备……", new Color(255, 165, 0)), () => true, null, null);
			string name10 = "旱海狂鲨";
			float difficulty10 = 12.09f;
			int npcType7 = ModContent.NPCType<GreatSandShark>();
			Func<bool> downed10 = () => DownedBossSystem.downedGSS;
			object summon10 = ModContent.ItemType<SandstormsCore>();
			List<int> list13 = new List<int>();
			list13.Add(3796);
			AddMiniBoss(bossChecklist, calamity, name10, difficulty10, npcType7, downed10, summon10, list13, "在花后沙尘暴杀死10只沙鲨或在沙漠使用 [i:" + ModContent.ItemType<SandstormsCore>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("终极掠食者隐匿到沙丘之下……", new Color(218, 165, 32)), () => true, null, null);
			string name11 = "阿娜希塔和利维坦";
			float difficulty11 = 12.8f;
			List<int> list14 = new List<int>();
			list14.Add(ModContent.NPCType<Leviathan>());
			list14.Add(ModContent.NPCType<Anahita>());
			Func<bool> downed11 = () => DownedBossSystem.downedLeviathan;
			object summon11 = null;
			List<int> list15 = new List<int>();
			list15.Add(ModContent.ItemType<LeviathanTrophy>());
			list15.Add(ModContent.ItemType<AnahitaTrophy>());
			list15.Add(ModContent.ItemType<LeviathanMask>());
			list15.Add(ModContent.ItemType<AnahitaMask>());
			list15.Add(ModContent.ItemType<KnowledgeOcean>());
			list15.Add(ModContent.ItemType<KnowledgeLeviathanAnahita>());
			AddBoss(bossChecklist, calamity, name11, difficulty11, list14, downed11, summon11, list15, "杀死海洋中的神秘生物", CalamityUtils.ColorMessage("海中恐惧沉入大洋之底……", new Color(127, 255, 212)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Leviathan/AnahitaLevi_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, null);
			string name12 = "白金星舰";
			float difficulty12 = 12.81f;
			int npcType8 = ModContent.NPCType<AstrumAureus>();
			Func<bool> downed12 = () => DownedBossSystem.downedAstrumAureus;
			object summon12 = ModContent.ItemType<AstralChunk>();
			List<int> list16 = new List<int>();
			list16.Add(ModContent.ItemType<AstrumAureusTrophy>());
			list16.Add(ModContent.ItemType<AstrumAureusMask>());
			list16.Add(ModContent.ItemType<KnowledgeAstrumAureus>());
			AddBoss(bossChecklist, calamity, name12, difficulty12, npcType8, downed12, summon12, list16, "在星辉瘟疫的夜晚使用 [i:" + ModContent.ItemType<AstralChunk>().ToString() + "] 召唤", CalamityUtils.ColorMessage("白金星舰指令已执行，开始返回……", new Color(255, 215, 0)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AstrumAureus/AstrumAureus_Head_Boss", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, null);
			string name13 = "瘟疫使者歌莉娅";
			float difficulty13 = 14.5f;
			int npcType9 = ModContent.NPCType<PlaguebringerGoliath>();
			Func<bool> downed13 = () => DownedBossSystem.downedPlaguebringer;
			object summon13 = ModContent.ItemType<Abombination>();
			List<int> list17 = new List<int>();
			list17.Add(ModContent.ItemType<PlaguebringerGoliathTrophy>());
			list17.Add(ModContent.ItemType<PlaguebringerGoliathMask>());
			list17.Add(ModContent.ItemType<KnowledgePlaguebringerGoliath>());
			list17.Add(ModContent.ItemType<PlagueCaller>());
			AddBoss(bossChecklist, calamity, name13, difficulty13, npcType9, downed13, summon13, list17, "在丛林使用 [i:" + ModContent.ItemType<Abombination>().ToString() + "] 召唤", CalamityUtils.ColorMessage("威胁性实体已被抹除，启动归巢程序。", new Color(0, 255, 0)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/PlaguebringerGoliath/PlaguebringerGoliath_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/PlaguebringerGoliath/PlaguebringerGoliath_Head_Boss");
			string name14 = "毁灭魔像";
			float difficulty14 = 16.5f;
			List<int> list18 = new List<int>();
			list18.Add(ModContent.NPCType<RavagerBody>());
			list18.Add(ModContent.NPCType<RavagerClawLeft>());
			list18.Add(ModContent.NPCType<RavagerClawRight>());
			list18.Add(ModContent.NPCType<RavagerHead>());
			list18.Add(ModContent.NPCType<RavagerLegLeft>());
			list18.Add(ModContent.NPCType<RavagerLegRight>());
			Func<bool> downed14 = () => DownedBossSystem.downedRavager;
			object summon14 = null;
			List<int> list19 = new List<int>();
			list19.Add(ModContent.ItemType<RavagerTrophy>());
			list19.Add(ModContent.ItemType<RavagerMask>());
			list19.Add(ModContent.ItemType<KnowledgeRavager>());
			AddBoss(bossChecklist, calamity, name14, difficulty14, list18, downed14, summon14, list19, "使用 [i:" + ModContent.ItemType<DeathWhistle>().ToString() + "] 召唤", CalamityUtils.ColorMessage("那由魔君所屠戮之人的血肉，扭曲形成的战争巨兽，再次开始寻找真正的恶徒……", new Color(178, 34, 34)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Ravager/Ravager_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/Ravager/RavagerBody_Head_Boss");
			string name15 = "星神游龙";
			float difficulty15 = 17.5f;
			List<int> list20 = new List<int>();
			list20.Add(ModContent.NPCType<AstrumDeusHead>());
			list20.Add(ModContent.NPCType<AstrumDeusBody>());
			list20.Add(ModContent.NPCType<AstrumDeusTail>());
			Func<bool> downed15 = () => DownedBossSystem.downedAstrumDeus;
			List<int> list21 = new List<int>();
			list21.Add(ModContent.ItemType<TitanHeart>());
			list21.Add(ModContent.ItemType<Starcore>());
			List<int> list22 = new List<int>();
			list22.Add(ModContent.ItemType<AstrumDeusTrophy>());
			list22.Add(ModContent.ItemType<AstrumDeusMask>());
			list22.Add(ModContent.ItemType<KnowledgeAstrumDeus>());
			list22.Add(ModContent.ItemType<KnowledgeAstralInfection>());
			list22.Add(ModContent.ItemType<ChromaticOrb>());
			AddBoss(bossChecklist, calamity, name15, difficulty15, list20, downed15, list21, list22, string.Concat(new string[]
			{
				"使用 [i:",
				ModContent.ItemType<TitanHeart>().ToString(),
				"] 或 [i:",
				ModContent.ItemType<Starcore>().ToString(),
				"] 在 [i:",
				ModContent.ItemType<AstralBeaconItem>().ToString(),
				"]"
			}), CalamityUtils.ColorMessage("初生星神重返天界……", new Color(255, 215, 0)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AstrumDeus/AstrumDeus_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/AstrumDeus/AstrumDeusHead_Head_Boss");
			string name16 = "亵渎守卫";
			float difficulty16 = 18.5f;
			int npcType10 = ModContent.NPCType<ProfanedGuardianCommander>();
			Func<bool> downed16 = () => DownedBossSystem.downedGuardians;
			object summon15 = ModContent.ItemType<ProfanedShard>();
			List<int> list23 = new List<int>();
			list23.Add(ModContent.ItemType<ProfanedGuardianTrophy>());
			list23.Add(ModContent.ItemType<ProfanedGuardianMask>());
			list23.Add(ModContent.ItemType<KnowledgeProfanedGuardians>());
			AddBoss(bossChecklist, calamity, name16, difficulty16, npcType10, downed16, summon15, list23, "在白天的神圣之地或地狱使用 [i:" + ModContent.ItemType<ProfanedShard>().ToString() + "] 召唤", CalamityUtils.ColorMessage("亵渎守卫必将保卫他们的至高女神，在所不辞……", new Color(255, 165, 0)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/ProfanedGuardians/ProfanedGuardians_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/ProfanedGuardians/ProfanedGuardianCommander_Head_Boss");
			string name17 = "痴愚金龙";
			float difficulty17 = 18.6f;
			int npcType11 = ModContent.NPCType<Bumblefuck>();
			Func<bool> downed17 = () => DownedBossSystem.downedDragonfolly;
			object summon16 = ModContent.ItemType<ExoticPheromones>();
			List<int> list24 = new List<int>();
			list24.Add(ModContent.ItemType<DragonfollyTrophy>());
			list24.Add(ModContent.ItemType<BumblefuckMask>());
			list24.Add(ModContent.ItemType<KnowledgeDragonfolly>());
			AddBoss(bossChecklist, calamity, name17, difficulty17, npcType11, downed17, summon16, list24, "在丛林使用 [i:" + ModContent.ItemType<ExoticPheromones>().ToString() + "] 召唤", CalamityUtils.ColorMessage("失败实验体重启繁衍日程……", new Color(255, 215, 0)), () => true, null, null);
			string name18 = "亵渎天神";
			float difficulty18 = 19.01f;
			int npcType12 = ModContent.NPCType<Providence>();
			Func<bool> downed18 = () => DownedBossSystem.downedProvidence;
			object summon17 = ModContent.ItemType<ProfanedCore>();
			List<int> list25 = new List<int>();
			list25.Add(ModContent.ItemType<ProvidenceTrophy>());
			list25.Add(ModContent.ItemType<ProvidenceMask>());
			list25.Add(ModContent.ItemType<KnowledgeProvidence>());
			AddBoss(bossChecklist, calamity, name18, difficulty18, npcType12, downed18, summon17, list25, "在白天的神圣之地或地狱使用 [i:" + ModContent.ItemType<ProfanedCore>().ToString() + "] 召唤", CalamityUtils.ColorMessage("亵渎天神隐没在耀眼火光中……", new Color(255, 165, 0)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/Providence/Providence_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/Providence/Providence_Head_Boss");
			string name19 = "无尽虚空";
			float difficulty19 = 19.5f;
			int npcType13 = ModContent.NPCType<CeaselessVoid>();
			Func<bool> downed19 = () => DownedBossSystem.downedCeaselessVoid;
			object summon18 = ModContent.ItemType<RuneofKos>();
			List<int> list26 = new List<int>();
			list26.Add(ModContent.ItemType<CeaselessVoidTrophy>());
			list26.Add(ModContent.ItemType<CeaselessVoidMask>());
			list26.Add(ModContent.ItemType<AncientGodSlayerHelm>());
			list26.Add(ModContent.ItemType<AncientGodSlayerChestplate>());
			list26.Add(ModContent.ItemType<AncientGodSlayerLeggings>());
			list26.Add(ModContent.ItemType<KnowledgeSentinels>());
			AddBoss(bossChecklist, calamity, name19, difficulty19, npcType13, downed19, summon18, list26, "在地牢使用 [i:" + ModContent.ItemType<RuneofKos>().ToString() + "] 召唤", CalamityUtils.ColorMessage("时空间的裂隙从你所能触及之处隐去……", new Color(75, 0, 130)), () => true, null, null);
			string name20 = "风暴编织者";
			float difficulty20 = 19.51f;
			List<int> list27 = new List<int>();
			list27.Add(ModContent.NPCType<StormWeaverHead>());
			list27.Add(ModContent.NPCType<StormWeaverBody>());
			list27.Add(ModContent.NPCType<StormWeaverTail>());
			Func<bool> downed20 = () => DownedBossSystem.downedStormWeaver;
			object summon19 = ModContent.ItemType<RuneofKos>();
			List<int> list28 = new List<int>();
			list28.Add(ModContent.ItemType<WeaverTrophy>());
			list28.Add(ModContent.ItemType<StormWeaverMask>());
			list28.Add(ModContent.ItemType<AncientGodSlayerHelm>());
			list28.Add(ModContent.ItemType<AncientGodSlayerChestplate>());
			list28.Add(ModContent.ItemType<AncientGodSlayerLeggings>());
			list28.Add(ModContent.ItemType<KnowledgeSentinels>());
			list28.Add(ModContent.ItemType<LittleLight>());
			AddBoss(bossChecklist, calamity, name20, difficulty20, list27, downed20, summon19, list28, "在太空使用 [i:" + ModContent.ItemType<RuneofKos>().ToString() + "] 召唤", CalamityUtils.ColorMessage("风暴编织者再度遁入风暴之中……", new Color(238, 130, 238)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/StormWeaver/StormWeaver_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/StormWeaver/StormWeaverHead_Head_Boss");
			string name21 = "西格纳斯";
			float difficulty21 = 19.52f;
			int npcType14 = ModContent.NPCType<Signus>();
			Func<bool> downed21 = () => DownedBossSystem.downedSignus;
			object summon20 = ModContent.ItemType<RuneofKos>();
			List<int> list29 = new List<int>();
			list29.Add(ModContent.ItemType<SignusTrophy>());
			list29.Add(ModContent.ItemType<SignusMask>());
			list29.Add(ModContent.ItemType<AncientGodSlayerHelm>());
			list29.Add(ModContent.ItemType<AncientGodSlayerChestplate>());
			list29.Add(ModContent.ItemType<AncientGodSlayerLeggings>());
			list29.Add(ModContent.ItemType<KnowledgeSentinels>());
			AddBoss(bossChecklist, calamity, name21, difficulty21, npcType14, downed21, summon20, list29, "在地狱使用 [i:" + ModContent.ItemType<RuneofKos>().ToString() + "] 召唤", CalamityUtils.ColorMessage("神使干净利落地完成了暗杀，不费吹灰之力……", new Color(186, 85, 211)), () => true, null, null);
			string name22 = "噬魂幽花";
			float difficulty22 = 20f;
			List<int> list30 = new List<int>();
			list30.Add(ModContent.NPCType<Polterghast>());
			list30.Add(ModContent.NPCType<PolterPhantom>());
			Func<bool> downed22 = () => DownedBossSystem.downedPolterghast;
			object summon21 = ModContent.ItemType<NecroplasmicBeacon>();
			List<int> list31 = new List<int>();
			list31.Add(ModContent.ItemType<PolterghastTrophy>());
			list31.Add(ModContent.ItemType<PolterghastMask>());
			list31.Add(ModContent.ItemType<KnowledgePolterghast>());
			AddBoss(bossChecklist, calamity, name22, difficulty22, list30, downed22, summon21, list31, "杀死30只幻魂或在地牢使用 [i:" + ModContent.ItemType<NecroplasmicBeacon>().ToString() + "] 召唤", CalamityUtils.ColorMessage("飘渺不定的幽魂恶兽消失在地牢深处……", new Color(176, 224, 230)), () => true, null, null);
			string name23 = "硫海遗爵";
			float difficulty23 = 20.5f;
			int npcType15 = ModContent.NPCType<OldDuke>();
			Func<bool> downed23 = () => DownedBossSystem.downedBoomerDuke;
			object summon22 = ModContent.ItemType<BloodwormItem>();
			List<int> list32 = new List<int>();
			list32.Add(ModContent.ItemType<OldDukeTrophy>());
			list32.Add(ModContent.ItemType<OldDukeMask>());
			list32.Add(ModContent.ItemType<KnowledgeOldDuke>());
			AddBoss(bossChecklist, calamity, name23, difficulty23, npcType15, downed23, summon22, list32, "击败噬魂幽花后的酸雨事件或使用 [i:" + ModContent.ItemType<BloodwormItem>().ToString() + "] 在硫磺海钓鱼召唤", CalamityUtils.ColorMessage("硫海遗爵消失在酸雨风暴中……", new Color(240, 230, 140)), () => true, null, null);
			string name24 = "神明吞噬者";
			float difficulty24 = 21f;
			int npcType16 = ModContent.NPCType<DevourerofGodsHead>();
			Func<bool> downed24 = () => DownedBossSystem.downedDoG;
			object summon23 = ModContent.ItemType<CosmicWorm>();
			List<int> list33 = new List<int>();
			list33.Add(ModContent.ItemType<DevourerofGodsTrophy>());
			list33.Add(ModContent.ItemType<DevourerofGodsMask>());
			list33.Add(ModContent.ItemType<KnowledgeDevourerofGods>());
			AddBoss(bossChecklist, calamity, name24, difficulty24, npcType16, downed24, summon23, list33, "使用 [i:" + ModContent.ItemType<CosmicWorm>().ToString() + "] 召唤", CalamityUtils.ColorMessage("噬神者撕裂了所有胆敢挑战神明之人，并尽情享用他们的灵魂……", new Color(0, 255, 255)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/DevourerofGods/DevourerofGods_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/DevourerofGods/DevourerofGodsHead_Head_Boss");
			string name25 = "丛林龙，犽戎";
			float difficulty25 = 22f;
			int npcType17 = ModContent.NPCType<Yharon>();
			Func<bool> downed25 = () => DownedBossSystem.downedYharon;
			object summon24 = ModContent.ItemType<JungleDragonEgg>();
			List<int> list34 = new List<int>();
			list34.Add(ModContent.ItemType<YharonTrophy>());
			list34.Add(ModContent.ItemType<YharonMask>());
			list34.Add(ModContent.ItemType<KnowledgeYharon>());
			AddBoss(bossChecklist, calamity, name25, difficulty25, npcType17, downed25, summon24, list34, "在丛林使用 [i:" + ModContent.ItemType<JungleDragonEgg>().ToString() + "] 召唤", CalamityUtils.ColorMessage("犽戎蔑视你的弱小，并不屑于在你的墓碑边多作停留……", new Color(255, 165, 0)), () => true, null, "CalamityMod/NPCs/Yharon/Yharon_Head_Boss");
			string name26 = "星流巨械";
			float difficulty26 = 22f;
			List<int> list35 = new List<int>();
			list35.Add(ModContent.NPCType<Apollo>());
			list35.Add(ModContent.NPCType<AresBody>());
			list35.Add(ModContent.NPCType<Artemis>());
			list35.Add(ModContent.NPCType<ThanatosHead>());
			Func<bool> downed26 = () => DownedBossSystem.downedExoMechs;
			object summon25 = null;
			List<int> list36 = new List<int>();
			list36.Add(ModContent.ItemType<AresTrophy>());
			list36.Add(ModContent.ItemType<ThanatosTrophy>());
			list36.Add(ModContent.ItemType<ArtemisTrophy>());
			list36.Add(ModContent.ItemType<ApolloTrophy>());
			list36.Add(ModContent.ItemType<DraedonMask>());
			list36.Add(ModContent.ItemType<AresMask>());
			list36.Add(ModContent.ItemType<ThanatosMask>());
			list36.Add(ModContent.ItemType<ArtemisMask>());
			list36.Add(ModContent.ItemType<ApolloMask>());
			list36.Add(ModContent.ItemType<KnowledgeExoMechs>());
			AddBoss(bossChecklist, calamity, name26, difficulty26, list35, downed26, summon25, list36, "使用装有金源量子冷却电池的密码破译器召唤", CalamityUtils.ColorMessage("毕竟不是完美造物……真是可惜……", new Color(127, 255, 212)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/ExoMechs/ExoMechs_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)rect.Center.X - (float)value.Width * 0.7f / 2f, (float)rect.Center.Y - (float)value.Height * 0.7f / 2f), null, color, 0f, Vector2.Zero, 0.7f, 0, 0f);
			}, null);
			string name27 = "至尊灾厄";
			float difficulty27 = 23f;
			int npcType18 = ModContent.NPCType<SupremeCalamitas>();
			Func<bool> downed27 = () => DownedBossSystem.downedSCal;
			List<int> list37 = new List<int>();
			list37.Add(ModContent.ItemType<AshesofCalamity>());
			list37.Add(ModContent.ItemType<CeremonialUrn>());
			List<int> list38 = new List<int>();
			list38.Add(ModContent.ItemType<SupremeCalamitasTrophy>());
			list38.Add(ModContent.ItemType<SupremeCataclysmTrophy>());
			list38.Add(ModContent.ItemType<SupremeCatastropheTrophy>());
			list38.Add(ModContent.ItemType<AshenHorns>());
			list38.Add(ModContent.ItemType<SCalMask>());
			list38.Add(ModContent.ItemType<SCalRobes>());
			list38.Add(ModContent.ItemType<SCalBoots>());
			list38.Add(ModContent.ItemType<KnowledgeCalamitas>());
			list38.Add(ModContent.ItemType<BrimstoneJewel>());
			list38.Add(ModContent.ItemType<Levi>());
            AddBoss(bossChecklist, calamity, name27, difficulty27, npcType18, downed27, list37, list38, string.Concat(new string[]
			{
				"使用 [i:",
				ModContent.ItemType<AshesofCalamity>().ToString(),
				"] 或 [i:",
				ModContent.ItemType<CeremonialUrn>().ToString(),
				"] 在 [i:",
				ModContent.ItemType<AltarOfTheAccursedItem>().ToString(),
				"]"
			}), CalamityUtils.ColorMessage("请不要浪费我的时间……", new Color(255, 165, 0)), () => true, null, "CalamityMod/NPCs/SupremeCalamitas/HoodedHeadIcon");
            AddBoss(bossChecklist, calamity, "成年幻海妖龙", 23.5f, ModContent.NPCType<AdultEidolonWyrmHead>(), () => DownedBossSystem.downedAdultEidolonWyrm, 1326, new List<int>(), "在深渊使用会对自身造成混沌状态减益的物品", CalamityUtils.ColorMessage("……", new Color(127, 255, 212)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AdultEidolonWyrm/AdultEidolonWyrm_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/AdultEidolonWyrm/AdultEidolonWyrmHead_Head_Boss");
		}

		private static void AddBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, List<int> npcTypes, Func<bool> downed, object summon, List<int> collection, string instructions, string despawn, Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
		{
			bossChecklist.Call(new object[]
			{
				"AddBoss",
				hostMod,
				name,
				npcTypes,
				difficulty,
				downed,
				available,
				collection,
				summon,
				instructions,
				despawn,
				portrait,
				bossHeadTex
			});
		}

		private static void AddBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, int npcType, Func<bool> downed, object summon, List<int> collection, string instructions, string despawn, Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
		{
			bossChecklist.Call(new object[]
			{
				"AddBoss",
				hostMod,
				name,
				npcType,
				difficulty,
				downed,
				available,
				collection,
				summon,
				instructions,
				despawn,
				portrait,
				bossHeadTex
			});
		}

		private static void AddMiniBoss(Mod bossChecklist, Mod hostMod, string name, float difficulty, int npcType, Func<bool> downed, object summon, List<int> collection, string instructions, string despawn, Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
		{
			bossChecklist.Call(new object[]
			{
				"AddMiniBoss",
				hostMod,
				name,
				npcType,
				difficulty,
				downed,
				available,
				collection,
				summon,
				instructions,
				despawn,
				portrait,
				bossHeadTex
			});
		}

		private delegate void AddCalamityBossesDelegate(Mod bossChecklist, Mod calamity);
	}
}
