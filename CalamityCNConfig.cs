using System.ComponentModel;
using CalamityCN.Systems;
using Terraria.ModLoader.Config;

namespace CalamityCN
{

    public class CalamityCNConfig : ModConfig
    {

        public static CalamityCNConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded()
        {
            Instance = this;
        }
        [ReloadRequired]
        [Header("Conversion")]
        [DefaultValue(zhLang.zh)]
        public zhLang Lang;
    }
}
