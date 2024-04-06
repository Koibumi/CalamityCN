﻿using CalamityCN.Translations.Patch;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Utils
{
    public class TranslationManager : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN && ModsCall.Calamity != null;
        }
        public override void Load()
        {
            if (Main.dedServ)
            {
                return;
            };
            BossLoot.Load();
        }
        public override void Unload()
        {
        }

    }
}
