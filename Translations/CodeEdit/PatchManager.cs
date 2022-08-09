using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace CalamityCN.Translations.CodeEdit
{
    public class PatchManager : ModSystem
    {
        public override void Load()
        {
            ChatButtonsTranslate.Load();
        }
        public override void Unload()
        {
            ChatButtonsTranslate.Unload();
        }
    }
}
