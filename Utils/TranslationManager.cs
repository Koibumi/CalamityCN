using CalamityCN.Translations.Patch;
using Terraria.ModLoader;

namespace CalamityCN.Utils
{
    public class TranslationManager : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN;
        }
        public override void Load()
        {
            MonoModHooks.RequestNativeAccess();
            if (ModsCall.Calamity != null)
            {
                ModePatch.Load();
                UIPatch.Load();
                TextPatch.Load();
            }
            if(ModsCall.Infernum != null)
            {
                InfernumPatch.Load();
            }
        }
        public override void Unload()
        {
            UIPatch.Unload();
            ModePatch.Unload();
            TextPatch.Unload();
            if (ModsCall.Infernum != null)
            {
                InfernumPatch.Unload();
            }
        }
    }
}
