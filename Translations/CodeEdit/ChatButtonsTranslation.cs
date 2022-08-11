using CalamityMod.NPCs.TownNPCs;
using MonoMod.RuntimeDetour;
using System.Collections.Generic;
using Terraria.Localization;

namespace CalamityCN.Translations.CodeEdit
{
    public class ChatButtonsTranslation
    {
        private static List<Hook> chatButton;
        public static void Load()
        {
            chatButton = new List<Hook>();
            chatButton.Add(new Hook(typeof(THIEF).GetMethod("SetChatButtons"), THIEFButton));
            chatButton.Add(new Hook(typeof(SEAHOE).GetMethod("SetChatButtons"), SEAHOEButton));
            chatButton.Add(new Hook(typeof(WITCH).GetMethod("SetChatButtons"), WITCHButton));
            chatButton.Add(new Hook(typeof(FAP).GetMethod("SetChatButtons"), FAPButton));
            foreach (Hook hook in chatButton)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
        public static void Unload()
        {
            foreach (Hook hook in chatButton)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            chatButton = null;
        }
        private static void THIEFButton(THIEF orig, ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "退款";
        }
        private static void SEAHOEButton(SEAHOE orig, ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "帮助";
        }
        private static void WITCHButton(WITCH orig, ref string button, ref string button2)
        {
            button = "咒术炼注";
        }
        private static void FAPButton(FAP orig, ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "死亡次数";
        }
    }
}
