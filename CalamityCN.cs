
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using CalamityCN.Utils;

namespace CalamityCN
{
    public class CalamityCN : Mod
    {
        public CalamityCN(){CalamityCN.Instance = this; base.PreJITFilter = new DisableJIT();}
        internal static CalamityCN Instance;

        public override void PostSetupContent()
        {
            ModLoader.TryGetMod("CalamityMod", out Mod Calamity);
            ModLoader.TryGetMod("Wikithis", out Mod wikithis);
            if (wikithis != null && !Main.dedServ)
            {
                wikithis.Call(0, Calamity, "calamity.huijiwiki.com", GameCulture.CultureName.Chinese);
            }
        }
        public override void Load()
        {
            //typeof(LocalizationLoader).GetCachedMethod("Autoload").Invoke(null, new object[] { this });//强制重新加载自己Mod的hjson，因为patch加载在hjson加载后
        }
        

    }
}