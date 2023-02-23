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
using CalamityMod.Items.Placeables.Furniture.DevPaintings;
using CalamityMod.Items.Placeables.Furniture.Trophies;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.SummonItems.Invasion;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.AdultEidolonWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.CalClone;
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
			List<int> list2 = new List<int>
			{
				ModContent.ItemType<DesertScourgeTrophy>(),
				ModContent.ItemType<DesertScourgeMask>(),
				ModContent.ItemType<LoreDesertScourge>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list3 = new List<int>
			{
				ModContent.ItemType<CrabulonTrophy>(),
				ModContent.ItemType<CrabulonMask>(),
				ModContent.ItemType<LoreCrabulon>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name2, difficulty2, npcType, downed2, summon2, list3, "在发光蘑菇地使用 [i:" + ModContent.ItemType<DecapoditaSprout>().ToString() + "] 召唤", CalamityUtils.ColorMessage("菌生蟹失去了对你的兴趣……", new Color(100, 149, 237)), () => true, null, null);
			string name3 = "腐巢意志";
			float difficulty3 = 3.98f;
			int npcType2 = ModContent.NPCType<HiveMind>();
			Func<bool> downed3 = () => DownedBossSystem.downedHiveMind;
			object summon3 = ModContent.ItemType<Teratoma>();
			List<int> list4 = new List<int>
			{
				ModContent.ItemType<HiveMindTrophy>(),
				ModContent.ItemType<HiveMindMask>(),
				ModContent.ItemType<LoreHiveMind>(),
				ModContent.ItemType<RottingEyeball>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name3, difficulty3, npcType2, downed3, summon3, list4, "杀死刷新在腐化之地的腐化囊或在腐化之地使用 [i:" + ModContent.ItemType<Teratoma>().ToString() + "] 召唤", CalamityUtils.ColorMessage("腐化之源开始搜寻下一处繁衍之所……", new Color(148, 0, 211)), () => true, null, "CalamityMod/NPCs/HiveMind/HiveMindP2_Head_Boss");
			string name4 = "血肉宿主";
			float difficulty4 = 3.99f;
			int npcType3 = ModContent.NPCType<PerforatorHive>();
			Func<bool> downed4 = () => DownedBossSystem.downedPerforator;
			object summon4 = ModContent.ItemType<BloodyWormFood>();
			List<int> list5 = new List<int>
			{
				ModContent.ItemType<PerforatorTrophy>(),
				ModContent.ItemType<PerforatorMask>(),
				ModContent.ItemType<LorePerforators>(),
				ModContent.ItemType<BloodyVein>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name4, difficulty4, npcType3, downed4, summon4, list5, "杀死刷新在猩红之地的血肉囊或在猩红之地使用 [i:" + ModContent.ItemType<BloodyWormFood>().ToString() + "] 召唤", CalamityUtils.ColorMessage("寄生意志开始搜寻下一位不幸宿主……", new Color(220, 20, 60)), () => true, null, null);
			string name5 = "史莱姆之神";
			float difficulty5 = 6.5f;
			List<int> list6 = new List<int>();
			list6.Add(ModContent.NPCType<SlimeGodCore>());
			list6.Add(ModContent.NPCType<EbonianSlimeGod>());
			list6.Add(ModContent.NPCType<CrimulanSlimeGod>());
			Func<bool> downed5 = () => DownedBossSystem.downedSlimeGod;
			object summon5 = ModContent.ItemType<OverloadedSludge>();
			List<int> list7 = new List<int>
			{
				ModContent.ItemType<SlimeGodTrophy>(),
				ModContent.ItemType<SlimeGodMask>(),
				ModContent.ItemType<SlimeGodMask2>(),
				ModContent.ItemType<LoreSlimeGod>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name5, difficulty5, list6, downed5, summon5, list7, "使用 [i:" + ModContent.ItemType<OverloadedSludge>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("归元凝一的丑恶存在为它的同胞们完成了复仇……", new Color(186, 85, 51)), () => true, null, null);
			string name6 = "极地之灵";
			float difficulty6 = 8.5f;
			int npcType4 = ModContent.NPCType<Cryogen>();
			Func<bool> downed6 = () => DownedBossSystem.downedCryogen;
			object summon6 = ModContent.ItemType<CryoKey>();
			List<int> list8 = new List<int>
			{
				ModContent.ItemType<CryogenTrophy>(),
				ModContent.ItemType<CryogenMask>(),
				ModContent.ItemType<LoreArchmage>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name6, difficulty6, npcType4, downed6, summon6, list8, "在雪原群系使用 [i:" + ModContent.ItemType<CryoKey>().ToString() + "] 召唤", CalamityUtils.ColorMessage("冰灵在冷冽彻骨的寒风中渐行渐远……", new Color(0, 255, 255)), () => true, null, "CalamityMod/NPCs/Cryogen/Cryogen_Phase1_Head_Boss");
			string name7 = "渊海灾虫";
			float difficulty7 = 9.5f;
			List<int> list9 = new List<int>();
			list9.Add(ModContent.NPCType<AquaticScourgeHead>());
			list9.Add(ModContent.NPCType<AquaticScourgeBody>());
			list9.Add(ModContent.NPCType<AquaticScourgeTail>());
			Func<bool> downed7 = () => DownedBossSystem.downedAquaticScourge;
			object summon7 = ModContent.ItemType<Seafood>();
			List<int> list10 = new List<int>
			{
				ModContent.ItemType<AquaticScourgeTrophy>(),
				ModContent.ItemType<AquaticScourgeMask>(),
				ModContent.ItemType<LoreAquaticScourge>(),
				ModContent.ItemType<LoreSulphurSea>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name7, difficulty7, list9, downed7, summon7, list10, "在硫磺海使用 [i:" + ModContent.ItemType<Seafood>().ToString() + "] 召唤，或在硫磺海等待其自然刷新", CalamityUtils.ColorMessage("渊海灾虫游回汪洋之中……", new Color(238, 232, 170)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/AquaticScourge/AquaticScourge_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/AquaticScourge/AquaticScourgeHead_Head_Boss");

			Func<bool> downed75 = () => DownedBossSystem.downedCragmawMire;
			AddMiniBoss(bossChecklist, calamity, "Cragmaw Mire", 10.0f, ModContent.NPCType<CragmawMire>(), downed75, null, null, "Spawns during Acid Rain after the Aquatic Scourge has been defeated.\nStart Acid Rain with a [i:" + ModContent.ItemType<CausticTear>().ToString() + "]", CalamityUtils.ColorMessage("The Cragmaw Mire buries itself within the sand.", new Color(240, 230, 140)), () => true, null, null);

			string name8 = "硫磺火元素";
			float difficulty8 = 10.5f;
			int npcType5 = ModContent.NPCType<BrimstoneElemental>();
			Func<bool> downed8 = () => DownedBossSystem.downedBrimstoneElemental;
			object summon8 = ModContent.ItemType<CharredIdol>();
			List<int> list11 = new List<int>
			{
				ModContent.ItemType<BrimstoneElementalTrophy>(),
				ModContent.ItemType<BrimstoneWaifuMask>(),
				ModContent.ItemType<LoreAzafure>(),
				ModContent.ItemType<LoreBrimstoneElemental>(),
				ModContent.ItemType<CharredRelic>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name8, difficulty8, npcType5, downed8, summon8, list11, "在硫火之崖使用 [i:" + ModContent.ItemType<CharredIdol>().ToString() + " ] 召唤", CalamityUtils.ColorMessage("硫磺火元素重返她曾经的圣殿，如今的废墟中……", new Color(220, 20, 60)), () => true, null, null);
			string name9 = "灾厄之影";
			float difficulty9 = 11.7f;
			int npcType6 = ModContent.NPCType<CalamitasClone>();
			Func<bool> downed9 = () => DownedBossSystem.downedCalamitas;
			object summon9 = ModContent.ItemType<EyeofDesolation>();
			List<int> list12 = new List<int>
			{
				ModContent.ItemType<CalamitasCloneTrophy>(),
				ModContent.ItemType<CataclysmTrophy>(),
				ModContent.ItemType<CatastropheTrophy>(),
				ModContent.ItemType<CalamitasCloneMask>(),
				ModContent.ItemType<HoodOfCalamity>(),
				ModContent.ItemType<RobesOfCalamity>(),
				ModContent.ItemType<LoreCalamitasClone>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list15 = new List<int>
			{
				ModContent.ItemType<LeviathanTrophy>(),
				ModContent.ItemType<AnahitaTrophy>(),
				ModContent.ItemType<LeviathanMask>(),
				ModContent.ItemType<AnahitaMask>(),
				ModContent.ItemType<LoreAbyss>(),
				ModContent.ItemType<LoreLeviathanAnahita>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list16 = new List<int>
			{
				ModContent.ItemType<AstrumAureusTrophy>(),
				ModContent.ItemType<AstrumAureusMask>(),
				ModContent.ItemType<LoreAstrumAureus>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list17 = new List<int>
			{
				ModContent.ItemType<PlaguebringerGoliathTrophy>(),
				ModContent.ItemType<PlaguebringerGoliathMask>(),
				ModContent.ItemType<LorePlaguebringerGoliath>(),
				ModContent.ItemType<PlagueCaller>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list19 = new List<int>
			{
				ModContent.ItemType<RavagerTrophy>(),
				ModContent.ItemType<RavagerMask>(),
				ModContent.ItemType<LoreRavager>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list22 = new List<int>
			{
				ModContent.ItemType<AstrumDeusTrophy>(),
				ModContent.ItemType<AstrumDeusMask>(),
				ModContent.ItemType<LoreAstrumDeus>(),
				ModContent.ItemType<LoreAstralInfection>(),
				ModContent.ItemType<ChromaticOrb>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list23 = new List<int>
			{
				ModContent.ItemType<ProfanedGuardianTrophy>(),
				ModContent.ItemType<ProfanedGuardianMask>(),
				ModContent.ItemType<LoreProfanedGuardians>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list24 = new List<int>
			{
				ModContent.ItemType<DragonfollyTrophy>(),
				ModContent.ItemType<BumblefuckMask>(),
				ModContent.ItemType<LoreDragonfolly>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name17, difficulty17, npcType11, downed17, summon16, list24, "在丛林使用 [i:" + ModContent.ItemType<ExoticPheromones>().ToString() + "] 召唤", CalamityUtils.ColorMessage("失败实验体重启繁衍日程……", new Color(255, 215, 0)), () => true, null, null);
			string name18 = "亵渎天神";
			float difficulty18 = 19.01f;
			int npcType12 = ModContent.NPCType<Providence>();
			Func<bool> downed18 = () => DownedBossSystem.downedProvidence;
			object summon17 = ModContent.ItemType<ProfanedCore>();
			List<int> list25 = new List<int>
			{
				ModContent.ItemType<ProvidenceTrophy>(),
				ModContent.ItemType<ProvidenceMask>(),
				ModContent.ItemType<LoreProvidence>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list26 = new List<int>
			{
				ModContent.ItemType<CeaselessVoidTrophy>(),
				ModContent.ItemType<CeaselessVoidMask>(),
				ModContent.ItemType<AncientGodSlayerHelm>(),
				ModContent.ItemType<AncientGodSlayerChestplate>(),
				ModContent.ItemType<AncientGodSlayerLeggings>(),
				ModContent.ItemType<LoreCeaselessVoid>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name19, difficulty19, npcType13, downed19, summon18, list26, "在地牢使用 [i:" + ModContent.ItemType<RuneofKos>().ToString() + "] 召唤", CalamityUtils.ColorMessage("时空间的裂隙从你所能触及之处隐去……", new Color(75, 0, 130)), () => true, null, null);
			string name20 = "风暴编织者";
			float difficulty20 = 19.51f;
			List<int> list27 = new List<int>();
			list27.Add(ModContent.NPCType<StormWeaverHead>());
			list27.Add(ModContent.NPCType<StormWeaverBody>());
			list27.Add(ModContent.NPCType<StormWeaverTail>());
			Func<bool> downed20 = () => DownedBossSystem.downedStormWeaver;
			object summon19 = ModContent.ItemType<RuneofKos>();
			List<int> list28 = new List<int>
			{
				ModContent.ItemType<WeaverTrophy>(),
				ModContent.ItemType<StormWeaverMask>(),
				ModContent.ItemType<AncientGodSlayerHelm>(),
				ModContent.ItemType<AncientGodSlayerChestplate>(),
				ModContent.ItemType<AncientGodSlayerLeggings>(),
				ModContent.ItemType<LoreStormWeaver>(),
				ModContent.ItemType<LittleLight>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
			List<int> list29 = new List<int>
			{
				ModContent.ItemType<SignusTrophy>(),
				ModContent.ItemType<SignusMask>(),
				ModContent.ItemType<AncientGodSlayerHelm>(),
				ModContent.ItemType<AncientGodSlayerChestplate>(),
				ModContent.ItemType<AncientGodSlayerLeggings>(),
				ModContent.ItemType<LoreSignus>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name21, difficulty21, npcType14, downed21, summon20, list29, "在地狱使用 [i:" + ModContent.ItemType<RuneofKos>().ToString() + "] 召唤", CalamityUtils.ColorMessage("神使干净利落地完成了暗杀，不费吹灰之力……", new Color(186, 85, 211)), () => true, null, null);
			string name22 = "噬魂幽花";
			float difficulty22 = 20f;
			List<int> list30 = new List<int>();
			list30.Add(ModContent.NPCType<Polterghast>());
			list30.Add(ModContent.NPCType<PolterPhantom>());
			Func<bool> downed22 = () => DownedBossSystem.downedPolterghast;
			object summon21 = ModContent.ItemType<NecroplasmicBeacon>();
			List<int> list31 = new List<int>
			{
				ModContent.ItemType<PolterghastTrophy>(),
				ModContent.ItemType<PolterghastMask>(),
				ModContent.ItemType<LorePolterghast>(),
				ModContent.ItemType<ThankYouPainting>()
			};

			Func<bool> downed221 = () => DownedBossSystem.downedMauler;
			AddMiniBoss(bossChecklist, calamity, "渊海狂鲨", 20.1f, ModContent.NPCType<Mauler>(), downed221, null, null, "在噬魂幽花被击败后的酸雨期间生成。\n使用 [i: " + ModContent.ItemType<CausticTear>().ToString() + "] 召唤酸雨。", CalamityUtils.ColorMessage("饥饿的狂鲨狼吞虎咽地吃下了所有人的尸体。", new Color(240, 230, 140)), () => true, null, null);

			Func<bool> downed222 = () => DownedBossSystem.downedNuclearTerror;
			AddMiniBoss(bossChecklist, calamity, "辐核骇兽", 20.2f, ModContent.NPCType<NuclearTerror>(), downed222, null, null, "在噬魂幽花被击败的在酸雨期间生成。\n使用 [i:" + ModContent.ItemType<CausticTear>().ToString() + "] 召唤酸雨。", CalamityUtils.ColorMessage("现在你该明白那放射性怪物名副其实。", new Color(240, 230, 140)), () => true, null, null);

			AddBoss(bossChecklist, calamity, name22, difficulty22, list30, downed22, summon21, list31, "杀死30只幻魂或在地牢使用 [i:" + ModContent.ItemType<NecroplasmicBeacon>().ToString() + "] 召唤", CalamityUtils.ColorMessage("飘渺不定的幽魂恶兽消失在地牢深处……", new Color(176, 224, 230)), () => true, null, null);
			string name23 = "硫海遗爵";
			float difficulty23 = 20.5f;
			int npcType15 = ModContent.NPCType<OldDuke>();
			Func<bool> downed23 = () => DownedBossSystem.downedBoomerDuke;
			object summon22 = ModContent.ItemType<BloodwormItem>();
			List<int> list32 = new List<int>
			{
				ModContent.ItemType<OldDukeTrophy>(),
				ModContent.ItemType<OldDukeMask>(),
				ModContent.ItemType<LoreOldDuke>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name23, difficulty23, npcType15, downed23, summon22, list32, "击败噬魂幽花后的酸雨事件或使用 [i:" + ModContent.ItemType<BloodwormItem>().ToString() + "] 在硫磺海钓鱼召唤", CalamityUtils.ColorMessage("硫海遗爵消失在酸雨风暴中……", new Color(240, 230, 140)), () => true, null, null);
			string name24 = "神明吞噬者";
			float difficulty24 = 21f;
			int npcType16 = ModContent.NPCType<DevourerofGodsHead>();
			Func<bool> downed24 = () => DownedBossSystem.downedDoG;
			object summon23 = ModContent.ItemType<CosmicWorm>();
			List<int> list33 = new List<int>
			{
				ModContent.ItemType<DevourerofGodsTrophy>(),
				ModContent.ItemType<DevourerofGodsMask>(),
				ModContent.ItemType<LoreDevourerofGods>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name24, difficulty24, npcType16, downed24, summon23, list33, "使用 [i:" + ModContent.ItemType<CosmicWorm>().ToString() + "] 召唤", CalamityUtils.ColorMessage("噬神者撕裂了所有胆敢挑战神明之人，并尽情享用他们的灵魂……", new Color(0, 255, 255)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/DevourerofGods/DevourerofGods_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)(rect.Center.X - value.Width / 2), (float)(rect.Center.Y - value.Height / 2)), color);
			}, "CalamityMod/NPCs/DevourerofGods/DevourerofGodsHead_Head_Boss");
			string name25 = "犽戎";
			float difficulty25 = 22f;
			int npcType17 = ModContent.NPCType<Yharon>();
			Func<bool> downed25 = () => DownedBossSystem.downedYharon;
			object summon24 = ModContent.ItemType<YharonEgg>();
			List<int> list34 = new List<int>
			{
				ModContent.ItemType<YharonTrophy>(),
				ModContent.ItemType<YharonMask>(),
				ModContent.ItemType<LoreYharon>(),
				ModContent.ItemType<ForgottenDragonEgg>(),
				ModContent.ItemType<McNuggets>(),
				ModContent.ItemType<FoxDrive>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name25, difficulty25, npcType17, downed25, summon24, list34, "使用 [i:" + ModContent.ItemType<YharonEgg>().ToString() + "] 召唤", CalamityUtils.ColorMessage("犽戎蔑视你的弱小，并不屑于在你的墓碑边多作停留……", new Color(255, 165, 0)), () => true, null, "CalamityMod/NPCs/Yharon/Yharon_Head_Boss");
			string name26 = "星流巨械";
			float difficulty26 = 22f;
			List<int> list35 = new List<int>();
			list35.Add(ModContent.NPCType<Apollo>());
			list35.Add(ModContent.NPCType<AresBody>());
			list35.Add(ModContent.NPCType<Artemis>());
			list35.Add(ModContent.NPCType<ThanatosHead>());
			Func<bool> downed26 = () => DownedBossSystem.downedExoMechs;
			object summon25 = null;
			List<int> list36 = new List<int>
			{
				ModContent.ItemType<AresTrophy>(),
				ModContent.ItemType<ThanatosTrophy>(),
				ModContent.ItemType<ArtemisTrophy>(),
				ModContent.ItemType<ApolloTrophy>(),
				ModContent.ItemType<DraedonMask>(),
				ModContent.ItemType<AresMask>(),
				ModContent.ItemType<ThanatosMask>(),
				ModContent.ItemType<ArtemisMask>(),
				ModContent.ItemType<ApolloMask>(),
				ModContent.ItemType<LoreExoMechs>(),
				ModContent.ItemType<LoreCynosure>(),
				ModContent.ItemType<ThankYouPainting>()
			};
			AddBoss(bossChecklist, calamity, name26, difficulty26, list35, downed26, summon25, list36, "使用高科技计算机", CalamityUtils.ColorMessage("毕竟不是完美造物……真是可惜……", new Color(127, 255, 212)), () => true, delegate (SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/NPCs/ExoMechs/ExoMechs_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)rect.Center.X - (float)value.Width * 0.7f / 2f, (float)rect.Center.Y - (float)value.Height * 0.7f / 2f), null, color, 0f, Vector2.Zero, 0.7f, 0, 0f);
			}, null);
			string name27 = "至尊女巫，灾厄";
			float difficulty27 = 23f;
			int npcType18 = ModContent.NPCType<SupremeCalamitas>();
			Func<bool> downed27 = () => DownedBossSystem.downedCalamitas;
			List<int> list37 = new List<int>();
			list37.Add(ModContent.ItemType<AshesofCalamity>());
			list37.Add(ModContent.ItemType<CeremonialUrn>());
			List<int> list38 = new List<int>
			{
				ModContent.ItemType<SupremeCalamitasTrophy>(),
				ModContent.ItemType<SupremeCataclysmTrophy>(),
				ModContent.ItemType<SupremeCatastropheTrophy>(),
				ModContent.ItemType<AshenHorns>(),
				ModContent.ItemType<SCalMask>(),
				ModContent.ItemType<SCalRobes>(),
				ModContent.ItemType<SCalBoots>(),
				ModContent.ItemType<LoreCalamitas>(),
				ModContent.ItemType<LoreCynosure>(),
				ModContent.ItemType<BrimstoneJewel>(),
				ModContent.ItemType<Levi>(),
				ModContent.ItemType<ThankYouPainting>()
			};
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
