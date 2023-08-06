using System;
using System.Reflection;
using CalamityCN.Utils;
using InfernumMode.Content.BossIntroScreens;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
	public class BaseIntroScreenPatch : OnPatcher
	{
		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCNFont;
			}
		}

		public override MethodInfo ModifiedMethod
		{
			get
			{
				return typeof(BaseIntroScreen).GetCachedMethod("get_FontToUse");
			}
		}

		public override Delegate Delegate
		{
			get
			{
				return new Func<BaseIntroScreenPatch.FontToUseDelegate, DynamicSpriteFont>(this.Translation);
			}
		}

		private DynamicSpriteFont Translation(BaseIntroScreenPatch.FontToUseDelegate orig)
		{
			return CalamityCN.Instance.BossIntroScreensFont;
		}

		private delegate DynamicSpriteFont FontToUseDelegate();
	}
}
