/*using CalamityCN.Utils;
using MonoMod.RuntimeDetour;
using Steamworks;
using System;
using System.IO;
using Terraria.ModLoader;
using Terraria.Social.Steam;

namespace CalamityCN.Systems
{
    public class DisplayLoadErrorPatch : ModSystem
    {
        private delegate void DisplayLoadErrorDelegate(string msg, Exception e, bool fatal, bool continueIsRetry);

        private Hook _displayLoadErrorHook;

        public override void Load()
        {
            _displayLoadErrorHook = new Hook(typeof(ModLoader).GetCachedMethod("DisplayLoadError"), DisplayLoadError);
            _displayLoadErrorHook.Apply();
        }

        public override void Unload()
        {
            _displayLoadErrorHook.Dispose();
            _displayLoadErrorHook = null;
        }

        private static void DisplayLoadError(DisplayLoadErrorDelegate orig, string msg, Exception e, bool fatal, bool continueIsRetry)
        {
            if (e.Data.Contains("mod") && (string)e.Data["mod"] == "CalamityCN" && e.Message.Contains("InfernumMode.Content.Items.Misc.SakuraBud"))
            {
                string path = Path.GetFullPath(WorkshopHelper.GetWorkshopFolder(new AppId_t(1281930u)));
                path = Path.Combine(path, "content", "1281930");
                string infernumPath = Path.Combine(path, "2826111637");
                string infernumMusicPath = Path.Combine(path, "2853859917");
                Terraria.Utils.OpenFolder(infernumPath);

                msg =
                    "灾厄汉化Mod加载错误，原因很可能是汉化与炼狱版本不符导致，解决方法：\n" +
                    "1. 如果你想要继续玩当前版本的炼狱，先禁用炼狱，启用灾厄汉化Mod，在其模组配置里关闭两条炼狱相关内容，再打开炼狱即可\n" +
                    $"2. 如果你想要更新炼狱，打开\"{infernumPath}\"（已为你自动打开），删除（或移走）其中的所有.tmod文件，再打开创意工坊，订阅\"Calamity Mod Infernum Mode\"并下载即可\n" +
                    $"（提示：炼狱音乐也和炼狱一同更新，若想要获取最新版本，打开\"{infernumMusicPath}\"，参照“2”中方法，删除并重新订阅\"Infernum Mode Music\"即可）\n\n" +
                    msg;
            }
            orig.Invoke(msg, e, fatal, continueIsRetry);
        }
    }
}*/