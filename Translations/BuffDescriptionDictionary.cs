using System.Collections.Generic;

namespace CalamityCN
{
    public class BuffDescriptionDict
    {
        public static Dictionary<string, string> EffectDescription;
        public static void Load()
        {
            EffectDescription = new Dictionary<string, string>()
            {
            };
        }
        public static void Unload()
        {
            EffectDescription = null;
        }
    }
}
