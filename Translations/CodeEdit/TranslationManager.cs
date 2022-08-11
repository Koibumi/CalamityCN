using Terraria.ModLoader;

namespace CalamityCN.Translations.CodeEdit
{
    public class TranslationManager : ModSystem
    {
        public override void Load()
        {
            MonoModHooks.RequestNativeAccess();

            OptimizeVanillaChineseDisplay.Load();
            ChatButtonsTranslation.Load();
            EnchantmentTranslation.Load();
            DraedonLogTranslation.Load();
            DraedonComputerTranslation.Load();
        }
        public override void Unload()
        {
            OptimizeVanillaChineseDisplay.Unload();
            ChatButtonsTranslation.Unload();
            EnchantmentTranslation.Unload();
            DraedonLogTranslation.Unload();
            DraedonComputerTranslation.Unload();
        }
    }
}
