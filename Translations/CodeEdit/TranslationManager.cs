using Terraria.ModLoader;

namespace CalamityCN.Translations.CodeEdit
{
    public class TranslationManager : ModSystem
    {
        public override void Load()
        {
            MonoModHooks.RequestNativeAccess();

            OptimizeChineseDisplay.Load();
            ChatButtonsTranslation.Load();
            EnchantmentTranslation.Load();
            DraedonLogTranslation.Load();
            DraedonWidgetTranslation.Load();
        }
        public override void Unload()
        {
            OptimizeChineseDisplay.Unload();
            ChatButtonsTranslation.Unload();
            EnchantmentTranslation.Unload();
            DraedonLogTranslation.Unload();
            DraedonWidgetTranslation.Unload();
        }
    }
}
