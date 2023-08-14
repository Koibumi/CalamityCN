using ReLogic.Graphics;
using Terraria.ModLoader;


namespace CalamityCN.Mods.InfernumMode
{
	public class InfernumReflection : ILoadable
	{
		public bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN;
		}

		public void Load(Mod mod)
		{
			CalamityCN.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityCN/Fonts/BossIntroScreensFont", (ReLogic.Content.AssetRequestMode)1).Value;

		}

		public void Unload()
		{
		}

	}
}
