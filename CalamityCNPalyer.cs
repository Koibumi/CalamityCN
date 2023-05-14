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
        public override void OnEnterWorld(Player player)
        {
            if(ModsCall.Infernum != null)
            {
            Color Orange = Color.Orange;
            Main.NewText("[灾厄汉化补丁：如果游戏内重载模组出现Bug，尝试重启游戏。]", Orange);
			Main.NewText("[炼狱中文标题：默认已改回关，如想使用可在汉化配置中开启。]", Orange);
            }
            
        }
    }
}