using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityCN.Translations.Patch
{
    public class TranslationManager : ModSystem
    {
        public static bool IsLanguageActive => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);
        public override void Load()
        {
            if (IsLanguageActive)
            {
                MonoModHooks.RequestNativeAccess();
                ModePatch.Load();
                UIPatch.Load();
                TextPatch.Load();
                Reflection.Load();
             }

        }
        public override void Unload()
        {
            UIPatch.Unload();
            ModePatch.Unload();
            TextPatch.Unload();
            Reflection.Unload();
        }
    }
}
