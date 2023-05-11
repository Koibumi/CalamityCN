using CalamityCN;
using CalamityCN.Utils;
using InfernumMode.Content.Projectiles.Pets;
using System;
using System.Reflection;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod
{
	public class HatGirlPatch : OnPatcher
	{
		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN;
			}
		}

		public override MethodInfo ModifiedMethod
		{
			get
			{
				return typeof(HatGirl).GetCachedMethod("SayThingWhileOwnerIsAlive");
			}
		}

		public override Delegate Delegate
		{
			get
			{
				return new Action<HatGirlPatch.SayThingWhileOwnerIsAliveDelegate, Player, string>(this.Translation);
			}
		}

		private void Translation(HatGirlPatch.SayThingWhileOwnerIsAliveDelegate orig, Player owner, string text)
		{
			//测试
			string text2;
			if (text == "Those crystals are equally spaced... seems like you can dodge them the same way consistently!")
            {
				text2 = "Those crystals are equally spaced... seems like you can dodge them the same way consistently!";
					goto IL_99A;
			}
			else if (text == "Those fireballs seem to only explode if they hit lava, you should probably bait them away!")
			{
				text2 = "Those fireballs seem to only explode if they hit lava, you should probably bait them away!";
					goto IL_99A;
			}
			else if (text == "It looks like Providence is preparing something!")
			{
				text2 = "看来亵渎天神，普罗维登斯在准备什么了!";
				goto IL_99A;
			}


			text2 = text;
			IL_99A:
			text = text2;
			orig(owner, text);
		}

		private delegate void SayThingWhileOwnerIsAliveDelegate(Player owner, string text);
	}
}
