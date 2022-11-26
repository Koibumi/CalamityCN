using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.Items.Pets;
using CalamityMod.Items.SummonItems.Invasion;
using CalamityMod.NPCs.AcidRain;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CalamityCN.Translation.Patch
{
	public class BCAddEventPatch : OnPatcher
	{

		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Calamity != null && ModsCall.BossChecklist != null && ModsCall.IsCN;
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
				return type.GetMethod("AddCalamityInvasions", BindingFlags.Static | BindingFlags.NonPublic);
			}
		}

		public override Delegate Delegate
		{
			get
			{
				return new Action<BCAddEventPatch.AddCalamityInvasionsDelegate, Mod, Mod>(this.Translation);
			}
		}

		private void Translation(BCAddEventPatch.AddCalamityInvasionsDelegate orig, Mod bossChecklist, Mod calamity)
		{
			string name = "酸雨";
			float difficulty = 2.67f;
			List<int> list = new List<int>();
			list.Add(ModContent.NPCType<NuclearToad>());
			list.Add(ModContent.NPCType<AcidEel>());
			list.Add(ModContent.NPCType<Radiator>());
			list.Add(ModContent.NPCType<Skyfin>());
			Func<bool> downed = () => DownedBossSystem.downedEoCAcidRain;
			object summon = ModContent.ItemType<CausticTear>();
			List<int> list2 = new List<int>();
			list2.Add(ModContent.ItemType<RadiatingCrystal>());
			AddInvasion(bossChecklist, calamity, name, difficulty, list, downed, summon, list2, "克苏鲁之眼被击败后，使用 [i:" + ModContent.ItemType<CausticTear>().ToString() + "] 召唤，或等待自然发生", () => true, delegate(SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT1_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)rect.Center.X - (float)value.Width * 1.3f / 2f, (float)rect.Center.Y - (float)value.Height * 1.3f / 2f), null, color, 0f, Vector2.Zero, 1.3f, 0, 0f);
			}, "CalamityMod/UI/MiscTextures/AcidRainIcon");
			string name2 = "酸雨（渊海灾虫后）";
			float difficulty2 = 9.51f;
			List<int> list3 = new List<int>();
			list3.Add(ModContent.NPCType<NuclearToad>());
			list3.Add(ModContent.NPCType<AcidEel>());
			list3.Add(ModContent.NPCType<Radiator>());
			list3.Add(ModContent.NPCType<Skyfin>());
			list3.Add(ModContent.NPCType<FlakCrab>());
			list3.Add(ModContent.NPCType<Orthocera>());
			list3.Add(ModContent.NPCType<Trilobite>());
			list3.Add(ModContent.NPCType<SulphurousSkater>());
			list3.Add(ModContent.NPCType<IrradiatedSlime>());
			list3.Add(ModContent.NPCType<CragmawMire>());
			Func<bool> downed2 = () => DownedBossSystem.downedAquaticScourgeAcidRain;
			object summon2 = ModContent.ItemType<CausticTear>();
			List<int> list4 = new List<int>();
			list4.Add(ModContent.ItemType<RadiatingCrystal>());
			AddInvasion(bossChecklist, calamity, name2, difficulty2, list3, downed2, summon2, list4, "渊海灾虫被击败后，使用 [i:" + ModContent.ItemType<CausticTear>().ToString() + "] 召唤，或等待自然发生", () => true, delegate(SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT2_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)rect.Center.X - (float)value.Width * 0.9f / 2f, (float)rect.Center.Y - (float)value.Height * 0.9f / 2f), null, color, 0f, Vector2.Zero, 0.9f, 0, 0f);
			}, "CalamityMod/UI/MiscTextures/AcidRainIcon");
			string name3 = "酸雨（噬魂幽花后）";
			float difficulty3 = 20.49f;
			List<int> list5 = new List<int>();
			list5.Add(ModContent.NPCType<NuclearToad>());
			list5.Add(ModContent.NPCType<AcidEel>());
			list5.Add(ModContent.NPCType<Radiator>());
			list5.Add(ModContent.NPCType<Skyfin>());
			list5.Add(ModContent.NPCType<FlakCrab>());
			list5.Add(ModContent.NPCType<Orthocera>());
			list5.Add(ModContent.NPCType<Trilobite>());
			list5.Add(ModContent.NPCType<SulphurousSkater>());
			list5.Add(ModContent.NPCType<IrradiatedSlime>());
			list5.Add(ModContent.NPCType<CragmawMire>());
			list5.Add(ModContent.NPCType<NuclearTerror>());
			list5.Add(ModContent.NPCType<GammaSlime>());
			list5.Add(ModContent.NPCType<Mauler>());
			Func<bool> downed3 = () => DownedBossSystem.downedBoomerDuke;
			object summon3 = ModContent.ItemType<CausticTear>();
			List<int> list6 = new List<int>();
			list6.Add(ModContent.ItemType<RadiatingCrystal>());
			AddInvasion(bossChecklist, calamity, name3, difficulty3, list5, downed3, summon3, list6, "噬魂幽花被击败后，使用 [i:" + ModContent.ItemType<CausticTear>().ToString() + "] 召唤，或等待自然发生", () => true, delegate(SpriteBatch sb, Rectangle rect, Color color)
			{
				Texture2D value = ModContent.Request<Texture2D>("CalamityMod/Events/AcidRainT3_BossChecklist", (ReLogic.Content.AssetRequestMode)2).Value;
				sb.Draw(value, new Vector2((float)rect.Center.X - (float)value.Width * 0.9f / 2f, (float)rect.Center.Y - (float)value.Height * 0.9f / 2f), null, color, 0f, Vector2.Zero, 0.9f, 0, 0f);
			}, "CalamityMod/UI/MiscTextures/AcidRainIcon");
		}

		private void AddInvasion(Mod bossChecklist, Mod hostMod, string name, float difficulty, List<int> npcTypes, Func<bool> downed, object summon, List<int> collection, string instructions, Func<bool> available, Action<SpriteBatch, Rectangle, Color> portrait = null, string bossHeadTex = null)
		{
			bossChecklist.Call(new object[]
			{
				"AddEvent",
				hostMod,
				name,
				npcTypes,
				difficulty,
				downed,
				available,
				collection,
				summon,
				instructions,
				portrait,
				bossHeadTex
			});
		}

		private delegate void AddCalamityInvasionsDelegate(Mod bossChecklist, Mod calamity);
	}
}
