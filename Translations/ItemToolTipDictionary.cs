using System.Collections.Generic;

namespace CalamityCN
{
    public class ItemToolTipDict
    {
        public static Dictionary<string, string> ItemToolTip;
        public static void Load()
        {
            ItemToolTip = new Dictionary<string, string>()
            {
            };
        }
        public static void Unload()
        {
            ItemToolTip = null;
        }
    }
}
