using System;
using System.Linq;
using System.Reflection;
using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.UI;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Translations.Patch
{
	public class AttemptToAddBarPatch : OnPatcher
	{
		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Calamity != null && ModsCall.IsCN;
			}
		}

		public override MethodInfo ModifiedMethod
		{
			get
			{
				return typeof(BossHealthBarManager).GetCachedMethod("AttemptToAddBar");
			}
		}

		public override Delegate Delegate
		{
			get
			{
				return new Action<AttemptToAddBarPatch.AttemptToAddBarDelegate, int>(this.Translation);
			}
		}

		private void Translation(AttemptToAddBarPatch.AttemptToAddBarDelegate orig, int index)
		{
			if (BossHealthBarManager.Bars.Count >= BossHealthBarManager.MaximumBars)
			{
				return;
			}
			NPC npc = Main.npc[index];
			bool flag = npc.active && npc.life > 0 && BossHealthBarManager.Bars.All((BossHealthBarManager.BossHPUI b) => b.NPCIndex != index) && !npc.Calamity().ShouldCloseHPBar;
			string overridingName = null;
			if (npc.type == ModContent.NPCType<Artemis>())
			{
				flag = false;
			}
			if (npc.type == ModContent.NPCType<Apollo>())
			{
				overridingName = (npc.ModNPC<Apollo>().exoMechdusa ? "Eyes of XB-∞ Hekate" : "XS-01“阿尔忒弥斯”和XS-03“阿波罗”");
			}
			if (!flag)
			{
				return;
			}
			BossHealthBarManager.Bars.Add(new BossHealthBarManager.BossHPUI(index, overridingName));
		}

		private delegate void AttemptToAddBarDelegate(int index);
	}
}
