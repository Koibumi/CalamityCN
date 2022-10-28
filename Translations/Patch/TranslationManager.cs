using Terraria.ModLoader;

namespace CalamityCN.Translations.Patch
{
    public class TranslationManager : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN && ModsCall.Calamity != null;
        }
        public override void Load()
        {
                MonoModHooks.RequestNativeAccess();
                ModePatch.Load();
                UIPatch.Load();
                TextPatch.Load();
                Reflection.Load();
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
