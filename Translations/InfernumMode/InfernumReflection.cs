using CalamityCN.Utils;
using CalamityMod.Systems;
using System;
using Microsoft.Xna.Framework;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace CalamityCN.Mods.InfernumMode
{
	public class InfernumReflection : ContentTranslation, ILoadableContent
	{
		public override bool IsTranslationEnabled
		{
			get
			{
				return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN;
			}
		}

		public override float Priority
		{
			get
			{
				return 1f;
			}
		}

		public void LoadContent()
		{
			CalamityCN.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityCN/Fonts/BossIntroScreensFont", (ReLogic.Content.AssetRequestMode)1).Value;

		}

		public void UnloadContent()
		{
		}


	}
}
