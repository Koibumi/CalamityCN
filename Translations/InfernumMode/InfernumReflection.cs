using CalamityCN.Utils;
using CalamityMod.Systems;
using ReLogic.Graphics;
using Terraria.ModLoader;

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
			DifficultyModeSystem.Difficulties[4].Name = "炼狱";
			DifficultyModeSystem.Difficulties[4].ShortDescription = "[c/B32E81:对于追求比死亡模式更高难度人来说，这是一个独特的挑战。]\n[c/B32E81:此模式未适配多人，也不适用于大师，FTW和永恒模式。]";
			CalamityCN.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityCN/Fonts/BossIntroScreensFont", (ReLogic.Content.AssetRequestMode)1).Value;
		}

		public void UnloadContent()
		{
		}
	}
}
