using CalamityCN;
using Microsoft.Xna.Framework;
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
            Color Orange = Color.Orange;
            Main.NewText("额外备注：灾厄更新后天蓝矿的生成由地下转为在空岛中生成。", Orange);
        }
    }
}