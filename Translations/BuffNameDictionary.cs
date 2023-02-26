using System.Collections.Generic;

namespace CalamityCN
{
    public class BuffNameDict
    {
        public static Dictionary<string, string> EffectName;
        public static void Load()
        {
            EffectName = new Dictionary<string, string>()
            {
            };
        }
        public static void Unload()
        {
            EffectName = null;
        }
    }
}
