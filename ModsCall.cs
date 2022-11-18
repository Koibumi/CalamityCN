using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN
{
	internal static class ModsCall
	{
		internal static Mod Calamity
		{
			get
			{
				if (!ModLoader.TryGetMod("CalamityMod", out Mod calamity))
				{
					return null;
				}
				return calamity;
			}
		}

		internal static Mod BossChecklist
		{
			get
			{
				if (ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist))
				{
					return bossChecklist;
				}
				return null;
			}
		}

		internal static Mod Infernum
		{
            get
            {
				if(ModLoader.TryGetMod("InfernumMode", out Mod infernum))
                {
					return infernum;
                }
				return null;
            }
        }

		public static bool IsCN
		{
			get
			{
				return LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);
			}
		}

	}
}
