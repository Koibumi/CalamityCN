using System.Collections.Generic;

namespace CalamityCN
{
    public class ItemNameDict
    {
        public static Dictionary<string, string> ItemName;

        public static void Load()
        {
            ItemName = new Dictionary<string, string>()
            {
            };
        }
        public static void Unload()
        {
            ItemName = null;
        }
    }
}
