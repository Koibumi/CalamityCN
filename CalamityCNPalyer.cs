using CalamityCN;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN
{
    public class CalamityCNPlayer : ModPlayer
    {
        
         public override void OnEnterWorld()
        {
            if(ModsCall.Infernum != null)
            {
            Color Orange = Color.Orange;
			Main.NewText("[炼狱汉化暂不支持]", Orange);
            }
            
        }
        
    }
}