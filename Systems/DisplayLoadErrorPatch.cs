using System;
using System.Linq;
using System.Reflection;
using CalamityCN.Utils;
using Microsoft.VisualBasic;
using MonoMod.RuntimeDetour;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Systems;

public class DisplayLoadErrorPatch : ILoadable
{
    //public override MethodInfo ModifiedMethod => typeof(ModLoader).GetCachedMethod("DisplayLoadError");

    //public override Delegate Delegate => new Action<DisplayLoadErrorDelegate, string, Exception, bool, bool>(DisplayLoadError);

    private Hook _displayLoadErrorHook;

    public void Load(Mod mod)
    {
        _displayLoadErrorHook = new Hook(typeof(ModLoader).GetCachedMethod("DisplayLoadError"), DisplayLoadError);
        _displayLoadErrorHook.Apply();
    }

    public void Unload()
    {
        _displayLoadErrorHook.Dispose();
        _displayLoadErrorHook = null;
    }

    private static void DisplayLoadError(DisplayLoadErrorDelegate orig, string msg, Exception e, bool fatal, bool continueIsRetry)
    {
        if (e.Data.Contains("mod") && (string)e.Data["mod"] == "CalamityCN" && e.Message.Contains("InfernumMode.Content.Items.Misc.SakuraBud"))
        {
            msg = "请更新炼狱版本\n" + msg;
        }

        orig.Invoke(msg, e, fatal, continueIsRetry);
    }

    private delegate void DisplayLoadErrorDelegate(string msg, Exception e, bool fatal, bool continueIsRetry);
}