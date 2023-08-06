using CalamityCN.Translations.InfernumMode;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Utils
{
    public class TranslationManager : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN && ModsCall.Calamity != null && ModsCall.Infernum != null;
        }
        public override void Load()
        {
            if (Main.dedServ)
            {
                return;
            };
            if (CalamityCNConfig.Instance.InfernumCN)
            {
                InfernumPatch.Load();
            }
        }
        public override void Unload()
        {
        }

    }
}
