using CalamityCN;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN {
    public class CalamityCNPlayer : ModPlayer {
        public override void OnEnterWorld() {
            if (ModsCall.Infernum != null && !CalamityCNConfig.Instance.InfernumCNFont) {
                Color Orange = Color.Orange;
                Main.NewText("[炼狱中文标题：默认为关，如想使用可在灾厄汉化配置中开启。]", Orange);
            }
        }
    }
}