using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Utils
{
	public class LangLoader : ContentTranslation, ILoadableContent
	{
		public override bool IsTranslationEnabled
		{
			get
			{
				return ModsCall.IsCN;
			}
		}

		public override float Priority
		{
			get
			{
				return 0.9f;
			}
		}

		public void LoadContent()
		{
			FieldInfo field = typeof(LocalizationLoader).GetField("translations", BindingFlags.Static | BindingFlags.NonPublic);
			LangLoader.Translations = (Dictionary<string, LocalizedText>)((field != null) ? field.GetValue(CalamityCN.Instance) : null);
		}

		public void UnloadContent()
		{
			LangLoader.Translations = null;
		}

		public static Dictionary<string, LocalizedText> Translations;
	}
}
