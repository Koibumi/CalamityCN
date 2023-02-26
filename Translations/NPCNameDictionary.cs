using System.Collections.Generic;

namespace CalamityCN
{
    public class NPCNameDict
    {
        public static Dictionary<string, string> NPCName;
        public static void Load()
        {
            NPCName = new Dictionary<string, string>()
            {
            };
        }
        public static void Unload()
        {
            NPCName = null;
        }
    }
}
