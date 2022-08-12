using CalamityMod.Items.Critters;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN
{
    internal class TemporaryFile : ModPlayer
    {
        private int Timer = 0;
        public override void PostUpdateMiscEffects()
        {
            switch (Timer)
            {
                case 0:
                    Main.NewText("感谢您使用由 [c/a44d02:K][c/c67400:c][c/e6a207:o][c/ffcd00:v][c/ffcd00:i][c/ffff93:n] 制作，由[c/faca8c:灾][c/ff9173:厄][c/e34f4f:维][c/ad3446:基][c/e34f4f:汉][c/ff9173:化][c/faca8c:组]出品的 [c/FF0000:灾厄Mod-汉化补丁]！".zh());
                    break;
                case 60:
                    Main.NewText("如果您看到此消息，说明您正在使用[c/f58f9b:1.1.1.402测试版]！".zh());
                    break;
                case 120:
                    Main.NewText("当前适配的灾厄Mod版本为：[c/cccc00:2.0.0.3]。".zh());
                    break;
                case 180:
                    Main.NewText("如果适配版本落后于当前灾厄最新版本，可能出现某些文本翻译失效的情况，推荐在补丁更新前暂时停用。".zh());
                    break;
                case 240:
                    Main.NewText("[c/ff0000:警告：为了完全汉化，我们采用了某些不安全的方式进行文本插入，有可能会产生未曾设想的Bug]".zh());
                    break;
                case 300:
                    Main.NewText("[c/00ff00:Bug严重吗？]在我们的仔细检查下，几乎不可能出现影响游戏进行、使游戏崩溃的恶性Bug，顶多是字符显示错误。".zh());
                    break;
                case 360:
                    Main.NewText("[c/00ff00:我该怎么做？]请放心进行游戏。如果你发现有没有翻译或显示错误的灾厄Mod的文本，请及时告知我们。".zh());
                    break;
                case 420:
                    Main.NewText("[c/00ff00:如何联系你们？]可以直接在创意工坊作品下留言，或者[c/51c0fc:灾厄维基附属讨论群]的管理员。".zh());
                    break;
                case 480:
                    Main.NewText("[c/ff0000:如果出现了使游戏崩溃的恶性Bug，请先检查是否是模组冲突或者是灾厄本身的Bug。]".zh());
                    break;
                case 540:
                    Main.NewText("[c/ff0000:如果需要向我们反馈，请提供报错日志和模组列表。]".zh());
                    break;
                case 600:
                    Main.NewText($"[i:{ModContent.ItemType<BabyFlakCrabItem>()}]祝玩得愉快！[i:{ModContent.ItemType<PiggyItem>()}]".zh());
                    break;
                case 660:
                    Main.NewText("——From [i:3541]");
                    break;
            }
            Timer++;
        }
    }
}
