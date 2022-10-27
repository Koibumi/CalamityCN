using CalamityCN;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Armor;
using CalamityMod.Items.Armor.Aerospec;
using CalamityMod.Items.Armor.Astral;
using CalamityMod.Items.Armor.Auric;
using CalamityMod.Items.Armor.Bloodflare;
using CalamityMod.Items.Armor.Brimflame;
using CalamityMod.Items.Armor.Daedalus;
using CalamityMod.Items.Armor.Demonshade;
using CalamityMod.Items.Armor.DesertProwler;
using CalamityMod.Items.Armor.Empyrean;
using CalamityMod.Items.Armor.FathomSwarmer;
using CalamityMod.Items.Armor.Fearmonger;
using CalamityMod.Items.Armor.GemTech;
using CalamityMod.Items.Armor.GodSlayer;
using CalamityMod.Items.Armor.Hydrothermic;
using CalamityMod.Items.Armor.Mollusk;
using CalamityMod.Items.Armor.OmegaBlue;
using CalamityMod.Items.Armor.Plaguebringer;
using CalamityMod.Items.Armor.PlagueReaper;
using CalamityMod.Items.Armor.Prismatic;
using CalamityMod.Items.Armor.Reaver;
using CalamityMod.Items.Armor.Silva;
using CalamityMod.Items.Armor.SnowRuffian;
using CalamityMod.Items.Armor.Statigel;
using CalamityMod.Items.Armor.Sulphurous;
using CalamityMod.Items.Armor.Tarragon;
using CalamityMod.Items.Armor.TitanHeart;
using CalamityMod.Items.Armor.Umbraphile;
using CalamityMod.Items.Armor.Victide;
using CalamityMod.Items.Armor.Wulfrum;
using CalamityMod.Items.Armor.MarniteArchitect;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Fishing.BrimstoneCragCatches;
using CalamityMod.Items.Fishing.SunkenSeaCatches;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.Placeables.Furniture;	
using CalamityMod.Items.Placeables.FurnitureAbyss;
using CalamityMod.Items.Placeables.FurnitureAcidwood;
using CalamityMod.Items.Placeables.FurnitureAncient;
using CalamityMod.Items.Placeables.FurnitureAshen;
using CalamityMod.Items.Placeables.FurnitureCosmilite;
using CalamityMod.Items.Placeables.FurnitureExo;
using CalamityMod.Items.Placeables.FurnitureMonolith;
using CalamityMod.Items.Placeables.FurnitureOtherworldly;
using CalamityMod.Items.Placeables.FurnitureProfaned;
using CalamityMod.Items.Placeables.FurnitureStatigel;
using CalamityMod.Items.Placeables.FurnitureStratus;
using CalamityMod.Items.Placeables.FurnitureVoid;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Weapons.DraedonsArsenal;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

public class Itemgb : GlobalItem
{

    public static bool IsLanguageActive => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);

    public override void AnglerChat(int type, ref string chat, ref string catchLocation)
    {
        if (IsLanguageActive)
        {
            if (type == ModContent.ItemType<EutrophicSandfish>())
            {
                chat = "你知道沙漠里的蜥蜴往地下钻的太深会发生什么吗？我知道，它们超酷的！可惜它们太滑了我没抓住。 你，现在就去把它抓来，这样我就有新的宠物了！".zh();
                catchLocation = "抓捕位置：沉沦之海".zh();
                return;
            }
            if (type == ModContent.ItemType<Serpentuna>())
            {
                chat = "海蛇其实还是很漂亮的，只要你不贸然侵入他们的领地。现在我命令你给我抓一条来作为给我的惊喜，限你一天之内完成！".zh();
                catchLocation = "抓捕位置：沉沦之海".zh();
                return;
            }
            if (type == ModContent.ItemType<SurfClam>())
            {
                chat = "你知道蛤很美味吗?流言说沙漠地下住着一大群蛤，光是说说就觉得饿了。给我抓一只来，让我练习练习烹饪技巧，也顺便解解馋。".zh();
                catchLocation = "抓捕位置：沉沦之海".zh();
                return;
            }
            if (type == ModContent.ItemType<Brimlish>())
            {
                chat = "在你击败硫磺火元素后，她的孩子们掉进了地狱的岩浆中。据说他们都化作了鱼，现在我要你给我搞到一条，这样我新准备的岩浆鱼缸就能派上用场了！".zh();
                catchLocation = "抓捕位置：硫火之崖".zh();
                return;
            }
            if (type == ModContent.ItemType<Slurpfish>())
            {
                chat = "我知道我知道，要你去远古地狱遗迹的岩浆里钓鱼简直是不讲道理。我正准备这样做。还不快去？鱼可不会自己上钩！".zh();
                catchLocation = "抓捕位置：硫火之崖".zh();
            }
        }
    }

    public override void UpdateArmorSet(Player player, string set)
    {
        if (IsLanguageActive)
        {
            string hotkey = CalamityMod.CalamityKeybinds.SetBonusHotKey.TooltipHotkeyString();
            string hotkeyGods = CalamityKeybinds.GodSlayerDashHotKey.TooltipHotkeyString();
            #region 灾厄套装
            if (set == "AerospecMagic")
            {
                player.setBonus = "增加5%移动速度和魔法暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害".zh();
            }
            else if (set == "AerospecRogue")
            {
                player.setBonus = "增加5%移动速度和盗贼暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害\n增加100点最大潜行值".zh();
            }
            else if (set == "AerospecMelee")
            {
                player.setBonus = "增加5%移动速度和近战暴击率\n敌人更有可能以你为目标\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害".zh();
            }
            else if (set == "AerospecSummon")
            {
                player.setBonus = "增加11%召唤伤害，+1召唤栏\n召唤天武神保护你\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害".zh();
            }
            else if (set == "AerospecRanged")
            {
                player.setBonus = "增加5%移动速度和远程暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害".zh();
            }
            else if (set == "Astral")
            {
                player.setBonus = "增加5%移动速度和3个召唤栏\n增加35%伤害和25%暴击率\n每当你暴击敌人时天空会降落坠落之星，神圣新星和星幻陨星\n此效果1秒内至多触发一次".zh();
            }
            else if (set == "AtaxiaRanged")
            {
                player.setBonus = "增加5%远程伤害\n低于50%生命值获得狱火药水的效果\n使用远程武器时每0.33秒发射一团追踪的混沌火焰\n你受伤时会在原地产生一场烈焰爆炸".zh();
            }
            else if (set == "AtaxiaMelee")
            {
                player.setBonus = "增加5%近战伤害\n敌人更有可能以你为目标\n低于50%生命值获得狱火药水的效果\n近战攻击和弹幕在击中敌人时喷发出混沌火焰\n你受伤时会在原地产生一场烈焰爆炸".zh();
            }
            else if (set == "AtaxiaSummon")
            {
                player.setBonus = "增加40%召唤伤害并+2召唤栏\n低于50%生命值获得狱火药水的效果\n召唤渊泉之灵保护你\n你受伤时会在原地产生一场烈焰爆炸".zh();
            }
            else if (set == "AtaxiaRogue")
            {
                player.setBonus = "提升5%盗贼伤害\n低于50%生命值获得狱火药水的效果\n使用盗贼武器攻击时每2.5秒会在你周围召唤8团追踪敌人的混沌火焰\n你受伤时会在原地产生一场烈焰爆炸\n增加110点最大潜行值".zh();
            }
            else if (set == "AtaxiaMagic")
            {
                player.setBonus = "增加5%魔法伤害并降低15%魔力消耗\n低于50%生命值获得狱火药水的效果\n魔法攻击产生伤害火球和治疗火球\n你受伤时会在原地产生一场烈焰爆炸".zh();
            }
            else if (set == "AuricMelee")
            {
                player.setBonus = "近战龙蒿、血炎、弑神者套装奖励\n敌人更有可能以你为目标\n弹幕击中敌人时生成圣金源光球治疗玩家".zh();
            }
            else if (set == "AuricRanged")
            {
                player.setBonus = "远程龙蒿、血炎、弑神者套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家".zh();
            }
            else if (set == "AuricRogue")
            {
                player.setBonus = "盗贼龙蒿、血炎、弑神者套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n增加130点最大潜行值".zh();
            }
            else if (set == "AuricSummon")
            {
                player.setBonus = "召唤龙蒿、血炎、始源林海套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n增加5%最大奔跑速度和加速度\n+6召唤栏和75%召唤伤害".zh();
            }
            else if (set == "AuricMagic")
            {
                player.setBonus = "魔法龙蒿、血炎、始源林海套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n增加5%最大奔跑速度和加速度".zh();
            }
            else if (set == "BloodflareRogue")
            {
                player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n生命值高于80%时增加30点防御和5%盗贼暴击率\n生命值低于80%时增加10%盗贼伤害\n盗贼武器暴击有50%几率治疗你\n增加120点最大潜行值".zh();
            }
            else if (set == "BloodflareSummon")
            {
                player.setBonus = "增加50%召唤伤害,+3召唤栏\n大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n召唤环绕你的幽魂雷\n生命值高于90%时增加10%召唤伤害\n生命值小于或等于50%及时获得20点防御和2点生命再生速度".zh();
            }
            else if (set == "BloodflareRanged")
            {
                player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n按下 " + hotkey + " 键释放噬魂幽花的冤魂摧毁你的敌人\n此效果有30秒冷却时间\n远程武器每2.5秒发射出一个爆炸血炎珠".zh();
            }
            else if (set == "BloodflareMagic")
            {
                player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n魔法武器每1.67秒会发射一个灵魂束\n魔法武器暴击产生火焰爆炸，两秒钟内至多触发一次".zh();
            }
            else if (set == "BloodflareMelee")
            {
                player.setBonus = "大幅增加生命再生速度\n敌人更有可能以你为目标\n击中一个生命值低于50%的敌人会掉落红心\n击这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n真近战攻击会治疗你\n使用真近战武器攻击敌人15次后进入鲜血狂怒状态，持续5秒\n此期间增加25%近战伤害和暴击率，来自敌人的接触伤害减半\n此效果有30秒冷却时间".zh();
            }
            else if (set == "Brimflame")
            {
                player.setBonus = "额外增加15%的魔法伤害和暴击率\n按 " + hotkey + " 键进入硫火狂暴模式\n在此模式下，你造成的伤害会显著增加\n然而你的生命会快速流失，魔力值恢复速度归零\n此状态可以手动关闭\n硫火狂暴有30秒的冷却时间".zh();
            }
            else if (set == "DaedalusMagic")
            {
                player.setBonus = "增加5%魔法伤害\n你有10%的几率吸收一次物理伤害或弹幕\n如果你成功吸收了一次攻击，你将回复相当于那次攻击的伤害值二分之一的生命值".zh();
            }
            else if (set == "DaedalusSummon")
            {
                player.setBonus = "增加20%召唤伤害，+2召唤栏\n召唤悬浮的代达罗斯水晶保护你".zh();
            }
            else if (set == "DaedalusMelee")
            {
                player.setBonus = "增加5%近战伤害\n敌人更有可能以你为目标\n你能够反弹弹幕\n被反弹的弹幕只会对你造成50%的伤害\n反弹效果有90秒内置冷却，冷却时间和其它效果类似的物品共享".zh();
            }
            else if (set == "DaedalusRanged")
            {
                player.setBonus = "增加5%远程伤害\n被击中时释放出水晶碎片".zh();
            }
            else if (set == "DaedalusRogue")
            {
                player.setBonus = "增加5%盗贼伤害\n盗贼弹幕飞行时释放水晶碎片\n增加105点最大潜行值".zh();
            }
            else if (set == "Demonshade")
            {
                player.setBonus = "增加100%召唤伤害，+10召唤栏\n所有攻击造成恶魔之炎减益\n受伤时发射暗影射线和恶魔镰刀\n召唤一只友善的红恶魔为你战斗\n按 " + hotkey + " 键以黑魔法咒语激怒周围的敌人10秒\n这道咒语使他们对你额外造成25%伤害，同时额外受到125%伤害".zh();
            }
            else if (set == "DesertProwler")
            {
                player.setBonus = "额外增加1点远程伤害".zh();
            }
            else if (set == "FathomSwarmer")
            {
                player.setBonus = "增加10%召唤伤害，+2召唤栏\n获得爬墙的能力\n浸没在液体中时增加30%召唤伤害\n在深渊中提供适量光照，一定程度减缓深渊中呼吸条消耗速度".zh();
            }
            else if (set == "Fearmonger")
            {
                player.setBonus = "增加20%召唤伤害，+2召唤栏\n使用其他职业武器时的召唤伤害惩罚从降低50%召唤伤害变成降低25%召唤伤害\n免疫一切霜、火相关的减益\n召唤物攻击敌人会使你获得极高的生命再生速度\n在南瓜月和霜月事件期间获得15%伤害减免\n这15%伤害减免无视减伤率软上限".zh();
            }
            else if (set == "ForbiddenCalam")
            {
                int stormMana = (int)(60f * player.manaCost);
                player.setBonus = "按下 " + hotkey + " 键可在光标位置处召唤一个远古风暴\n远古风暴消耗 " + stormMana + " 魔力值并且同时受到召唤和盗贼伤害增益\n盗贼潜伏攻击命中会召唤追踪的禁戒吞噬者\n即使拿着盗贼武器，仆从也会造成全额伤害\n盗贼和召唤攻击将会按比例增加伤害\n增加40点最大潜行值".zh();
            }
            else if (set == "GodSlayerMelee")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkeyGods + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n敌人更有可能以你为目标\n一次性受到超过80点伤害使你放出一群高伤害的弑神飞镖\n敌人碰到你时受到大量伤害\n如果一次攻击将对你造成少于80点伤害，则它改为对你造成1点伤害".zh();
            }
            else if (set == "GodSlayerRanged")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkeyGods + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n你的远程武器射击时每2.5秒发射一枚弑神榴霰弹".zh();
            }
            else if (set == "GodSlayerRogue")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkeyGods + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n生命值全满时所有盗贼属性增加10%\n如果一次攻击对你造成了超过80伤害，你获得额外的无敌帧\n增加120点最大潜行值".zh();
            }
            else if (set == "Mollusk")
            {
                player.setBonus = "两只贝壳会在战斗中助你一臂之力\n增加10%伤害\n水平移动速度降低".zh();
            }
            else if (set == "OmegaBlue")
            {
                player.setBonus = "增加15点护甲穿透\n增加10%伤害和暴击率，增加2召唤栏\n触手会攻击附近的敌人，偷取生命治疗你\n按 " + hotkey + " 键进入深渊狂乱状态5秒\n深渊狂乱状态会增加你的伤害和暴击率，同时触手的攻击性和攻击范围也会提升\n此效果有25秒冷却时间".zh();
            }
            else if (set == "PlaguebringerSummon")
            {
                player.setBonus = "获得瘟疫冲刺，使敌怪被瘟疫折磨\n召唤一个小瘟疫使者来保护你，并增强附近的召唤物\n+3召唤栏".zh();
            }
            else if (set == "PlaguebringerRanged")
            {
                player.setBonus = "减少25%弹药消耗率，增加5%飞行时间\n受瘟疫减益作用的敌人会额外受到10%远程伤害\n受到伤害会使瘟疫残渣从天而降\n按 " + hotkey + " 键使自己在5秒钟内失去视野，但大幅增加远程伤害\n此效果有25秒冷却时间".zh();
            }
            else if (set == "Prismatic")
            {
                player.setBonus = "最大魔力值增加40，魔力消耗减少15%\n提高魔力再生速度\n按 " + hotkey + " 键在鼠标位置召唤一轮死亡激光，持续5秒\n这个技能有30秒冷却".zh();
            }
            else if (set == "ReaverExp")
            {
                player.setBonus = "令附近的宝藏闪闪发光\n提升物品拾取距离和物块放置距离\n在水下挖掘物块时恢复氧气\n召唤一个掠夺者毒球照亮周围区域\n降低敌人的进攻性，即便身处深渊\n在深渊中提供少量光照".zh();
            }
            else if (set == "ReaverTan")
            {
                player.setBonus = "+10防御力并+3生命恢复\n敌人更有可能以你为目标\n受到持续性伤害减益时的生命恢复损失降低20%\n你的任何攻击都有小概率具有生命偷取效果并且增加生命恢复速度\n减少20%的移动速度与飞行时间\n敌人会受到你的反伤，并且你被击中时召唤一束荆棘伤害敌人\n当你受伤时有25%的几率获得掠夺者之怒增益".zh();
            }
            else if (set == "ReaverMob")
            {
                player.setBonus = "免疫摔落伤害并允许连续跳跃\n增加10%飞行时间和水平飞行速度\n钩爪的射速和牵引速度增加10%\n降低冲刺类效果的冷却时间".zh();
            }
            else if (set == "ShroomiteCalam")
            {
                player.setBonus = "站立不动进入射手潜行状态".zh();
            }
            else if (set == "SilvaSummon")
            {
                player.setBonus = "增加65%召唤伤害，+5召唤栏\n所有弹幕击中敌人时生成林海光球治疗你\n增加5%最大奔跑速度和加速度\n如果你的生命值将要降至1以下，则你在8秒钟内不会因为受伤而死亡\n这个效果有5分钟冷却时间，冷却时间不会在Boss存在或事件时期计时\n召唤始源林海水晶轰击你的敌人".zh();
            }
            else if (set == "SilvaMagic")
            {
                player.setBonus = "所有弹幕击中敌人时生成林海光球治疗你\n增加5%最大奔跑速度和加速度\n如果你的生命值将要降至1以下，则你在8秒钟内不会因为受伤而死亡\n这个效果有5分钟冷却时间，冷却时间不会在Boss存在或事件时期计时\n不能穿透的魔法弹幕击中敌人后有几率产生强大的自然能量爆炸".zh();
            }
            else if (set == "SnowRuffian")
            {
                player.setBonus = "增加5%盗贼伤害\n你可以缓降以消除坠落伤害\n增加50点最大潜行值".zh();
            }
            else if (set == "StatigelMagic")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度".zh();
            }
            else if (set == "StatigelRanged")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度".zh();
            }
            else if (set == "StatigelMelee")
            {
                player.setBonus = "敌人更有可能以你为目标\n当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度".zh();
            }
            else if (set == "StatigelSummon")
            {
                player.setBonus = "增加18%召唤伤害，+1召唤栏\n召唤史莱姆之神宝宝为你而战, 它的种类取决于世界邪恶类型\n当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度".zh();
            }
            else if (set == "StatigelRogue")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度\n增加100点最大潜行值".zh();
            }
            else if (set == "Sulfur")
            {
                player.setBonus = "攻击敌人或被敌人攻击时对其造成中毒减益\n获得一段额外跳跃，跳跃时生成硫磺泡泡\n增加水下移动力，降低硫磺海水的威胁性\n增加95点最大潜行值".zh();
            }
            else if (set == "TarragonMelee")
            {
                player.setBonus = "增加红心拾取范围\n敌人死亡时有几率掉落更多心\n敌人更有可能以你为目标\n在受到伤害时你有25%几率获得生命再生的增益\n按 " + hotkey + " 键将自己以生命的能量包裹，大大降低你受到的接触伤害，持续10秒\n此效果有30秒冷却时间".zh();
            }
            else if (set == "TarragonRogue")
            {
                player.setBonus = "降低刷怪率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n使用盗贼武器暴击敌人25次后你会获得3秒无敌时间\n此效果30秒内只能发动一次\n若你受到减益影响，则提升10%暴击率\n增加115点最大潜行值".zh();
            }
            else if (set == "TarragonSummon")
            {
                player.setBonus = "增加50%召唤伤害，+3召唤栏\n降低敌怪生成率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n召唤围绕你的生命光环，对敌人造成伤害".zh();
            }
            else if (set == "TarragonMagic")
            {
                player.setBonus = "降低刷怪率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n每五次暴击时发射叶片风暴\n魔法弹幕击中敌人时有50%几率治疗你\n治疗量取决于弹幕造成的伤害".zh();
            }
            else if (set == "TarragonRanged")
            {
                player.setBonus = "降低刷怪率\n增加心拾取范围\n敌人死亡时有几率掉落更多心\n远程弹幕在因击中敌人而消失时有几率分裂为生命能量".zh();
            }
            else if (set == "TitanHeart")
            {
                player.setBonus = "增加15%盗贼伤害和击退\n潜伏攻击会造成两倍的击退并产生幻星爆炸\n获得击退免疫\n增加100点最大潜行值".zh();
            }
            else if (set == "Umbraphile")
            {
                player.setBonus = "盗贼武器击中敌人时概率产生爆炸\n暴击总是产生爆炸\n半影药剂总是发挥最大功效（增加30%潜行值积累速度）\n增加110点最大潜行值".zh();
            }
            else if (set == "VictideRogue")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%盗贼伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度\n增加90点最大潜行值".zh();
            }
            else if (set == "VictideMelee")
            {
                player.setBonus = "敌人更有可能以你为目标\n在水中时增加3点生命再生速度和10%近战伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度".zh();
            }
            else if (set == "VictideSummon")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%召唤伤害\n召唤一只海胆为你而战\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度\n+1召唤栏".zh();
            }
            else if (set == "VictideMagic")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%魔法伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度".zh();
            }
            else if (set == "VictideRanged")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%远程伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度".zh();
            }

            else if (set == "Xeroc")
            {
                player.setBonus = "增加9%盗贼伤害和盗贼弹幕飞行速度\n盗贼弹幕击中敌人产生特殊效果\n受伤时受到来自宇宙的怒火加持\n增加115点最大潜行值".zh();
            }

            else if (set == "Wulfrum")
            {
                player.setBonus = "增加1召唤栏".zh();
            }

            #endregion

            #region 原版套装
            else if (set == "SpectreHeal")
            {
                player.setBonus = "魔法伤害减少20%并将其转化为治愈力\n对敌人造成的魔法伤害将治疗生命值最低的玩家".zh();
            }
            #endregion
        }
    }

    public override string IsArmorSet(Item head, Item body, Item legs)
    {
        #region 灾厄套装
        if (head.type == ModContent.ItemType<AerospecHat>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
        {
            return "AerospecMagic";
        }
        if (head.type == ModContent.ItemType<AerospecHeadgear>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
        {
            return "AerospecRogue";
        }
        if (head.type == ModContent.ItemType<AerospecHelm>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
        {
            return "AerospecMelee";
        }
        if (head.type == ModContent.ItemType<AerospecHelmet>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
        {
            return "AerospecSummon";
        }
        if (head.type == ModContent.ItemType<AerospecHood>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
        {
            return "AerospecRanged";
        }
        if (head.type == ModContent.ItemType<AstralHelm>() && body.type == ModContent.ItemType<AstralBreastplate>() && legs.type == ModContent.ItemType<AstralLeggings>())
        {
            return "Astral";
        }
        if (head.type == ModContent.ItemType<HydrothermicHeadRanged>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
        {
            return "AtaxiaRanged";
        }
        if (head.type == ModContent.ItemType<HydrothermicHeadMelee>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
        {
            return "AtaxiaMelee";
        }
        if (head.type == ModContent.ItemType<HydrothermicHeadSummon>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
        {
            return "AtaxiaSummon";
        }
        if (head.type == ModContent.ItemType<HydrothermicHeadRogue>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
        {
            return "AtaxiaRogue";
        }
        if (head.type == ModContent.ItemType<HydrothermicHeadMagic>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
        {
            return "AtaxiaMagic";
        }
        if (head.type == ModContent.ItemType<AuricTeslaRoyalHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
        {
            return "AuricMelee";
        }
        if (head.type == ModContent.ItemType<AuricTeslaHoodedFacemask>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
        {
            return "AuricRanged";
        }
        if (head.type == ModContent.ItemType<AuricTeslaPlumedHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
        {
            return "AuricRogue";
        }
        if (head.type == ModContent.ItemType<AuricTeslaSpaceHelmet>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
        {
            return "AuricSummon";
        }
        if (head.type == ModContent.ItemType<AuricTeslaWireHemmedVisage>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
        {
            return "AuricMagic";
        }
        if (head.type == ModContent.ItemType<BloodflareHeadRogue>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
        {
            return "BloodflareRogue";
        }
        if (head.type == ModContent.ItemType<BloodflareHeadSummon>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
        {
            return "BloodflareSummon";
        }
        if (head.type == ModContent.ItemType<BloodflareHeadRanged>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
        {
            return "BloodflareRanged";
        }
        if (head.type == ModContent.ItemType<BloodflareHeadMagic>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
        {
            return "BloodflareMagic";
        }
        if (head.type == ModContent.ItemType<BloodflareHeadMelee>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
        {
            return "BloodflareMelee";
        }
        if (head.type == ModContent.ItemType<BrimflameScowl>() && body.type == ModContent.ItemType<BrimflameRobes>() && legs.type == ModContent.ItemType<BrimflameBoots>())
        {
            return "Brimflame";
        }
        if (head.type == ModContent.ItemType<DaedalusHeadMagic>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
        {
            return "DaedalusMagic";
        }
        if (head.type == ModContent.ItemType<DaedalusHeadSummon>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
        {
            return "DaedalusSummon";
        }
        if (head.type == ModContent.ItemType<DaedalusHeadMelee>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
        {
            return "DaedalusMelee";
        }
        if (head.type == ModContent.ItemType<DaedalusHeadRanged>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
        {
            return "DaedalusRanged";
        }
        if (head.type == ModContent.ItemType<DaedalusHeadRogue>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
        {
            return "DaedalusRogue";
        }
        if (head.type == ModContent.ItemType<DemonshadeHelm>() && body.type == ModContent.ItemType<DemonshadeBreastplate>() && legs.type == ModContent.ItemType<DemonshadeGreaves>())
        {
            return "Demonshade";
        }
        if (head.type == ModContent.ItemType<DesertProwlerHat>() && body.type == ModContent.ItemType<DesertProwlerShirt>() && legs.type == ModContent.ItemType<DesertProwlerPants>())
        {
            return "DesertProwler";
        }
        if (head.type == ModContent.ItemType<FathomSwarmerVisage>() && body.type == ModContent.ItemType<FathomSwarmerBreastplate>() && legs.type == ModContent.ItemType<FathomSwarmerBoots>())
        {
            return "FathomSwarmer";
        }
        if (head.type == ModContent.ItemType<FearmongerGreathelm>() && body.type == ModContent.ItemType<FearmongerPlateMail>() && legs.type == ModContent.ItemType<FearmongerGreaves>())
        {
            return "Fearmonger";
        }
        if (head.type == ModContent.ItemType<ForbiddenCirclet>() && body.type == ItemID.AncientBattleArmorShirt && legs.type == ItemID.AncientBattleArmorPants)
        {
            return "ForbiddenCalam";
        }
        if (head.type == ModContent.ItemType<GodSlayerHeadMelee>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
        {
            return "GodSlayerMelee";
        }
        if (head.type == ModContent.ItemType<GodSlayerHeadRanged>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
        {
            return "GodSlayerRanged";
        }
        if (head.type == ModContent.ItemType<GodSlayerHeadRogue>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
        {
            return "GodSlayerRogue";
        }
        if (head.type == ModContent.ItemType<MolluskShellmet>() && body.type == ModContent.ItemType<MolluskShellplate>() && legs.type == ModContent.ItemType<MolluskShelleggings>())
        {
            return "Mollusk";
        }
        if (head.type == ModContent.ItemType<OmegaBlueHelmet>() && body.type == ModContent.ItemType<OmegaBlueChestplate>() && legs.type == ModContent.ItemType<OmegaBlueTentacles>())
        {
            return "OmegaBlue";
        }
        if (head.type == ModContent.ItemType<PlaguebringerVisor>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
        {
            return "PlaguebringerSummon";
        }
        if (head.type == ModContent.ItemType<PlagueReaperMask>() && body.type == ModContent.ItemType<PlagueReaperVest>() && legs.type == ModContent.ItemType<PlagueReaperStriders>())
        {
            return "PlaguebringerRanged";
        }
        if (head.type == ModContent.ItemType<PrismaticHelmet>() && body.type == ModContent.ItemType<PrismaticRegalia>() && legs.type == ModContent.ItemType<PrismaticGreaves>())
        {
            return "Prismatic";
        }
        if (head.type == ModContent.ItemType<ReaverHeadTank>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
        {
            return "ReaverTan";
        }
        if (head.type == ModContent.ItemType<ReaverHeadMobility>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
        {
            return "ReaverMob";
        }
        if (head.type == ModContent.ItemType<ReaverHeadExplore>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
        {
            return "ReaverExp";
        }
        if (head.type == ModContent.ItemType<ShroomiteVisage>() && body.type == ItemID.ShroomiteBreastplate && legs.type == ItemID.ShroomiteLeggings)
        {
            return "ShroomiteCalam";
        }
        if (head.type == ModContent.ItemType<SilvaHeadSummon>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
        {
            return "SilvaSummon";
        }
        if (head.type == ModContent.ItemType<SilvaHeadMagic>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
        {
            return "SilvaMagic";
        }
        if (head.type == ModContent.ItemType<SnowRuffianMask>() && body.type == ModContent.ItemType<SnowRuffianChestplate>() && legs.type == ModContent.ItemType<SnowRuffianGreaves>())
        {
            return "SnowRuffian";
        }
        if (head.type == ModContent.ItemType<StatigelHeadMagic>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
        {
            return "StatigelMagic";
        }
        if (head.type == ModContent.ItemType<StatigelHeadRanged>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
        {
            return "StatigelRanged";
        }
        if (head.type == ModContent.ItemType<StatigelHeadMelee>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
        {
            return "StatigelMelee";
        }
        if (head.type == ModContent.ItemType<StatigelHeadSummon>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
        {
            return "StatigelSummon";
        }
        if (head.type == ModContent.ItemType<StatigelHeadRogue>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
        {
            return "StatigelRogue";
        }
        if (head.type == ModContent.ItemType<SulphurousHelmet>() && body.type == ModContent.ItemType<SulphurousBreastplate>() && legs.type == ModContent.ItemType<SulphurousLeggings>())
        {
            return "Sulfur";
        }
        if (head.type == ModContent.ItemType<TarragonHeadMelee>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
        {
            return "TarragonMelee";
        }
        if (head.type == ModContent.ItemType<TarragonHeadRogue>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
        {
            return "TarragonRogue";
        }
        if (head.type == ModContent.ItemType<TarragonHeadSummon>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
        {
            return "TarragonSummon";
        }
        if (head.type == ModContent.ItemType<TarragonHeadMagic>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
        {
            return "TarragonMagic";
        }
        if (head.type == ModContent.ItemType<TarragonHeadRanged>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
        {
            return "TarragonRanged";
        }
        if (head.type == ModContent.ItemType<TitanHeartMask>() && body.type == ModContent.ItemType<TitanHeartMantle>() && legs.type == ModContent.ItemType<TitanHeartBoots>())
        {
            return "TitanHeart";
        }
        if (head.type == ModContent.ItemType<UmbraphileHood>() && body.type == ModContent.ItemType<UmbraphileRegalia>() && legs.type == ModContent.ItemType<UmbraphileBoots>())
        {
            return "Umbraphile";
        }
        if (head.type == ModContent.ItemType<VictideHeadRogue>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
        {
            return "VictideRogue";
        }
        if (head.type == ModContent.ItemType<VictideHeadMelee>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
        {
            return "VictideMelee";
        }
        if (head.type == ModContent.ItemType<VictideHeadSummon>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
        {
            return "VictideSummon";
        }
        if (head.type == ModContent.ItemType<VictideHeadMagic>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
        {
            return "VictideMagic";
        }
        if (head.type == ModContent.ItemType<VictideHeadRanged>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
        {
            return "VictideRanged";
        }

        if (head.type == ModContent.ItemType<EmpyreanMask>() && body.type == ModContent.ItemType<EmpyreanCloak>() && legs.type == ModContent.ItemType<EmpyreanCuisses>())
        {
            return "Xeroc";
        }

        if (head.type == ModContent.ItemType<WulfrumHat>() && body.type == ModContent.ItemType<WulfrumJacket>() && legs.type == ModContent.ItemType<WulfrumOveralls>())
        {
            return "Wulfrum";
        }

        #endregion

        #region 原版套装
        if (head.type == ItemID.SpectreHood && body.type == ItemID.SpectreRobe && legs.type == ItemID.SpectrePants)
        {
            return "SpectreHeal";
        }
        #endregion
        return "";
    }

    //修改描述	
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (IsLanguageActive)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (item.type == ModContent.ItemType<Eternity>())
                {
                    line.Text = line.Text.Replace("There's pictures of ponies in the book", "书内有张小马图片".zh());
                }

                if (item.type == ModContent.ItemType<CosmicWorm>())
                {
                    line.Text = line.Text.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "警告！某些神之仆从并没有被真正的打败，在这场战斗中他们会全力以赴！".zh());
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                }

                if (item.type == ModContent.ItemType<HadalStew>())
                {
                    line.Text = line.Text.Replace("Only gives 37 seconds of Potion Sickness", "只造成37秒的药水疾病减益".zh());
                }

                if (item.type == ModContent.ItemType<SpectralVeil>())
                {
                    string hotkeySpecVeil = CalamityMod.CalamityKeybinds.SpectralVeilHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeySpecVeil + " to consume 25% of your maximum stealth to perform a mid-range teleport and render you momentarily invulnerable", "按下 ".zh() + hotkeySpecVeil + " 消耗25%最大潜行值，向鼠标方向进行中距离传送".zh());
                }

                if (item.type == ModContent.ItemType<SandCloak>())
                {
                    string hotkeySand = CalamityMod.CalamityKeybinds.SandCloakHotkey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeySand + " to consume 10% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", "按下 ".zh() + hotkeySand + " 消耗10%最大潜行值，召唤一个围绕你的破坏性沙漠龙卷持续15秒，并提供6点防御和+2生命恢复".zh());
                }

                if (item.type == ModContent.ItemType<TheCommunity>())
                {
                    line.Text = line.Text.Replace("Max health increased by", "最大生命增加".zh());
                    line.Text = line.Text.Replace("Melee speed increased by", "近战攻速增加".zh());
                    line.Text = line.Text.Replace("Life regeneration increased by", "生命再生速度增加".zh());
                    line.Text = line.Text.Replace("Critical strike chance increased by", "暴击率增加".zh());
                    line.Text = line.Text.Replace("Damage increased by", "伤害增加".zh());
                    line.Text = line.Text.Replace("Damage reduction increased by", "伤害减免增加".zh());
                    line.Text = line.Text.Replace("Defense increased by", "防御增加".zh());
                    line.Text = line.Text.Replace("Minion knockback increased by", "召唤物击退增加".zh());
                    line.Text = line.Text.Replace("Movement speed increased by", "移速增加".zh());
                    line.Text = line.Text.Replace("Flight time increased by", "飞行时间增加".zh());
                }

                if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
                {
                    line.Text = line.Text.Replace("Requires 10 minion slots to use in order to grant the following effects", "需要10个召唤栏以启用以下所有效果：".zh());
                    line.Text = line.Text.Replace("All non-summon weapons are converted into powerful summon variations", "所有非召唤攻击都被转换为强力的召唤变种".zh());
                    line.Text = line.Text.Replace("Falling below 50% life will empower these attacks", "掉到50%血量以下会强化这些攻击".zh());
                    line.Text = line.Text.Replace("Transforms Melee attacks into a barrage of spears", "将近战攻击转换为一波投矛".zh());
                    line.Text = line.Text.Replace("Transforms Magic attacks into a powerful splitting fireball for", "将魔法攻击转换为强力分裂火球，每次消耗".zh());
                    line.Text = line.Text.Replace("mana per cast", "点魔力值".zh());
                    line.Text = line.Text.Replace("Transforms Ranged attacks into a flurry of fireballs and meteors", "将远程攻击转换为一阵火球与陨石".zh());
                    line.Text = line.Text.Replace("Transforms Rogue attacks into a deadly crystalline spiral", "将盗贼攻击转换为死亡水晶螺旋".zh());
                    line.Text = line.Text.Replace("Summons and empowers the profaned babs to fight alongside you", "召唤并强化三个亵渎守卫为你而战".zh());
                    line.Text = line.Text.Replace("You are no longer affected by burn out when hit", "受伤时不再受到灼伤减益".zh());
                    line.Text = line.Text.Replace("Provides buffs depending on the time of day", "基于所处的时间给予增益".zh());
                    line.Text = line.Text.Replace("Thinking back, it was a boring life", "我的人生平淡无奇，索然无味".zh());
                    line.Text = line.Text.Replace("And so we burn it all in the name of purity", "现在我们以纯化之名将其燃烧殆尽".zh());
                    line.Text = line.Text.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "这块水晶中的魂魄被至尊女巫的强大魔力污染了".zh());
                    line.Text = line.Text.Replace("The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations", "这块水晶中的魂魄被危险的机械造物发出的能量波干扰了".zh());
                    line.Text = line.Text.Replace("Merchants will reject a defiled soul such as this.", "商人会拒绝收购这样一个被玷污的魂魄".zh());

                }

                if (item.type == ModContent.ItemType<PlaguedFuelPack>())
                {
                    string plagueHotkey = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + plagueHotkey + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", "按下 ".zh() + plagueHotkey + " 键消耗25%最大潜行值并快速斜向上喷射\n并在沿途留下大量瘟疫毒云".zh());
                }

                if (item.type == ModContent.ItemType<CelestialJewel>())
                {
                    string hotkeyCelestial = CalamityMod.CalamityKeybinds.AstralTeleportHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyCelestial + " to teleport to a random location while no bosses are alive", "没有Boss存活时按下 ".zh() + hotkeyCelestial + " 键进行随机传送".zh());
                }

                if (item.type == ModContent.ItemType<BlunderBooster>())
                {
                    string hotkeyBlunder = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyBlunder + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", "按下 ".zh() + hotkeyBlunder + " 键消耗你盗贼潜行值的25%来向左上/右上方冲刺并留下追踪闪电".zh());
                }

                if (item.type == ModContent.ItemType<AstralArcanum>())
                {
                    string hotkeyArcanum = CalamityMod.CalamityKeybinds.AstralArcanumUIHotkey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyArcanum + " to toggle teleportation UI while no bosses are alive", "没有Boss存活时按下 ".zh() + hotkeyArcanum + " 键可以打开传送UI".zh());
                }

                if (item.type == ModContent.ItemType<AsgardianAegis>())
                {
                    string hotkeyAsgard = CalamityMod.CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyAsgard + " to activate buffs to all damage, crit chance, and defense", "按下 ".zh() + hotkeyAsgard + " 键获得增加伤害、暴击率和防御的增益".zh());
                }

                if (item.type == ModContent.ItemType<ElysianAegis>())
                {
                    string hotkeyElysian = CalamityMod.CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyElysian + " to activate buffs to all damage, crit chance and defense", "按下 ".zh() + hotkeyElysian + " 键获得增加伤害、暴击率和防御的增益".zh());
                }

                if (item.type == ModContent.ItemType<NormalityRelocator>())
                {
                    string hotkeyReloc = CalamityMod.CalamityKeybinds.NormalityRelocatorHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyReloc + " to teleport to the position of the mouse", "按下 ".zh() + hotkeyReloc + " 传送至鼠标位置".zh());
                }

                if (item.type == ModContent.ItemType<AngelicAlliance>())
                {
                    string hotkeyAngelic = CalamityKeybinds.AngelicAllianceHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyAngelic + " to grace yourself in divinity for 15 seconds", "按下 ".zh() + hotkeyAngelic + " 键获得15秒神之祝福".zh());
                }
                if (item.type == ModContent.ItemType<StatMeter>())
                {
                    line.Text = line.Text.Replace("Displays almost all player stats", "显示你绝大部分属性的具体数据".zh());
                    line.Text = line.Text.Replace("Offensive stats displayed vary with held item", "攻击数据可能会随着手持的物品而变化".zh());
                    line.Text = line.Text.Replace("Adrenaline Damage Boost:", "肾上腺素伤害加成：".zh());
                    line.Text = line.Text.Replace("Adrenaline DR Boost:", "肾上腺素伤害减免加成：".zh());
                    line.Text = line.Text.Replace("Rage Damage Boost:", "愤怒模式伤害加成：".zh());
                    line.Text = line.Text.Replace("True Melee ", "真近战".zh());
                    line.Text = line.Text.Replace("True Danos por ataque físico:", "真实伤害:".zh());
                    line.Text = line.Text.Replace("Ammo Consumption Chance:", "弹药消耗率：".zh());
                    line.Text = line.Text.Replace("Mana Usage:", "魔力值消耗：".zh());
                    line.Text = line.Text.Replace("Mana Regen:", "魔力值恢复速度：".zh());
                    line.Text = line.Text.Replace("Minion Slots:", "召唤栏位数量：".zh());
                    line.Text = line.Text.Replace("Rogue Velocity Boost:", "盗贼弹幕飞行速度提升：".zh());
                    line.Text = line.Text.Replace("Rogue Weapon Consumption Chance:", "盗贼消耗性武器消耗率：".zh());
                    line.Text = line.Text.Replace("Melee ", "近战".zh());
                    line.Text = line.Text.Replace("Magic ", "魔法".zh());
                    line.Text = line.Text.Replace("Ranged ", "远程".zh());
                    line.Text = line.Text.Replace("Minion ", "召唤".zh());
                    line.Text = line.Text.Replace("Rogue ", "盗贼".zh());
                    line.Text = line.Text.Replace("Averaged ", "无职业".zh());
                    line.Text = line.Text.Replace("Unsupported ", "未支持职业".zh());
                    line.Text = line.Text.Replace("Averaged ", "无职业".zh());
					line.Text = line.Text.Replace("Whip ", "鞭子".zh());
                    line.Text = line.Text.Replace("Damage", "伤害加成".zh());
                    line.Text = line.Text.Replace("Crit Chance", "暴击率".zh());
                    line.Text = line.Text.Replace("Attack Speed", "攻速".zh());
                    line.Text = line.Text.Replace("Max Stealth:", "最大潜行值：".zh());
                    line.Text = line.Text.Replace("Standing Regen:", "站定恢复速度：".zh());
                    line.Text = line.Text.Replace("Moving Regen:", "移动时恢复速度：".zh());
                    line.Text = line.Text.Replace("Defense:", "防御力：".zh());
                    line.Text = line.Text.Replace("DR:", "伤害减免：".zh());
                    line.Text = line.Text.Replace("Life Regen:", "生命再生速度：".zh());
                    line.Text = line.Text.Replace("Armor Penetration:", "护甲穿透：".zh());
                    line.Text = line.Text.Replace("Wing Flight Time:", "飞行时间：".zh());
                    line.Text = line.Text.Replace("seconds", "秒".zh());
                    line.Text = line.Text.Replace("sec", "秒".zh());
					line.Text = line.Text.Replace("from melee", "来自近战".zh());
                    line.Text = line.Text.Replace("Jump Boost:", "跳跃提升：".zh());
                    line.Text = line.Text.Replace("Move Speed:", "移速：".zh());
                    line.Text = line.Text.Replace("Luck:", "幸运值：".zh());
                    line.Text = line.Text.Replace("Abyss/Cave Light Strength:", "深渊/洞穴光照强度：".zh());
                    line.Text = line.Text.Replace("Abyss Light Strength:", "深渊光照强度：".zh());
                    line.Text = line.Text.Replace("Other Abyss stats are only displayed while in the Abyss", "其他深渊状态数据只有身处深渊才会显示".zh());
                    line.Text = line.Text.Replace("Other Abyss Stats:", "其他深渊属性：".zh());
                    line.Text = line.Text.Replace("Breath Lost Per Tick:", "呼吸条消耗速率：".zh());
                    line.Text = line.Text.Replace("Breath Loss Rate:", "呼吸困难程度：".zh());
                    line.Text = line.Text.Replace("Life Lost Per Tick at Zero Breath:", "呼吸条耗尽后生命流失速度：".zh());
                    line.Text = line.Text.Replace("Defense Lost From Pressure:", "防御削减：".zh());
                }
                if (item.type == ModContent.ItemType<ExoThrone>())
                {
                    line.Text = line.Text.Replace("Hold ", "坐在飞椅上时按住 ".zh());
                    line.Text = line.Text.Replace("while sitting in the throne to move slower for more precision", "键将会精确减速".zh());
                }
                if (item.type == ModContent.ItemType<ShatteredCommunity>())
                {
                    line.Text = line.Text.Replace("Current level:", "当前等级：".zh());
                    line.Text = line.Text.Replace("Rage Mode damage", "暴怒模式伤害".zh());
                    line.Text = line.Text.Replace("Progress to next level:", "距离下一等级：".zh());
                    line.Text = line.Text.Replace("Total ", "总".zh());
                }
                if (item.type == ModContent.ItemType<BrokenBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：".zh());
                    line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：".zh());
                    line.Text = line.Text.Replace("Pure Clarity", "澄澈之纯净".zh());
                    line.Text = line.Text.Replace("Biting Embrace", "拥怀之凛冽".zh());
                    line.Text = line.Text.Replace("Arid Grandeur", "伟岸之枯涸".zh());
                    line.Text = line.Text.Replace("Decay's Retort", "反抗之衰朽".zh());
                    line.Text = line.Text.Replace("Grovetender's Touch", "林妖之轻抚".zh());
                    line.Text = line.Text.Replace("None", "无调谐".zh());
                    line.Text = line.Text.Replace("Does nothing..yet", "似乎没什么用".zh());
                    line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出薄弱的弹幕，它将击碎敌怪的防御".zh());
                    line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "以冰川凝结为剑身，施行三连剑技，其最终一剑将冻结敌怪".zh());
                    line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "于面前召唤多把炙热的剑刃，且击中敌怪次数越多，它们将愈加庞大而锋利。你在半空时，剑刃也能用于在物块之间弹跳".zh());
                    line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "依靠幽魅的剑影向前冲锋，汲取击中敌怪的生命，并从其身上弹开".zh());
                    line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "将剑刃绑在藤蔓一端，挥舞藤鞭。刃尖击中敌怪必定暴击，而击中物块时将把你拉去".zh());
                }
                if (item.type == ModContent.ItemType<TrueBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：".zh());
                    line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：".zh());
                    line.Text = line.Text.Replace("Pure Clarity", "澄澈之纯净".zh());
                    line.Text = line.Text.Replace("Biting Embrace", "拥怀之凛冽".zh());
                    line.Text = line.Text.Replace("Arid Grandeur", "伟岸之枯涸".zh());
                    line.Text = line.Text.Replace("Decay's Retort", "反抗之衰朽".zh());
                    line.Text = line.Text.Replace("Grovetender's Touch", "林妖之轻抚".zh());
                    line.Text = line.Text.Replace("Heaven's Might", "天国之神威".zh());
                    line.Text = line.Text.Replace("Extant Abhorrence", "嫌恶之永存".zh());
					line.Text = line.Text.Replace("Gesture for the Drowned", "溺死之亡姿".zh());
                    line.Text = line.Text.Replace("None", "无调谐".zh());
                    line.Text = line.Text.Replace("Does nothing..yet", "暂无所长，静待调谐。".zh());
                    line.Text = line.Text.Replace("Repairing the blade seems to have improved its attuning capacities", "似乎你对它的修复增强了它的调谐能力".zh());
                    line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出薄弱的弹幕，它将击碎敌怪的防御".zh());
                    line.Text = line.Text.Replace("Landing true melee hits places a sigil of purity over the enemy. Your projectiles home onto the marked foes", "剑刃本身将以纯净之符标记命中的敌怪，被标记者会被剑气追踪".zh());
                    line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "以冰川凝结为剑身，施行三连剑技，其最终一剑将冻结敌怪".zh());
                    line.Text = line.Text.Replace("Lingering glacial mist is released on each swing, dealing damage to enemies wandering into it", "挥舞时，极寒之雾将从剑身涌出，在空中弥漫，并挫伤其中的生灵".zh());
                    line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "于面前召唤多把炙热的剑刃，且击中敌怪次数越多，它们将愈加庞大而锋利。你在半空时，剑刃也能用于在物块之间弹跳".zh());
                    line.Text = line.Text.Replace("Releasing the attack button after the blades are fully charged sends them hurtling forwards to shred your foes", "剑刃蓄力达到巅峰时，停止攻击，它们将向前飞驰，撕碎敌怪".zh());
                    line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "依靠幽魅的剑影向前冲锋，汲取击中敌怪的生命，并从其身上弹开".zh());
                    line.Text = line.Text.Replace("Landing three strikes without touching the ground changes your next attack into an empowered dash thrust", "命中三次攻击而不落地，下一剑将变为强化的突刺冲锋".zh());
                    line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "将剑刃绑在藤蔓一端，挥舞藤鞭。刃尖击中敌怪必定暴击，而击中物块时将把你拉去".zh());
                    line.Text = line.Text.Replace("Spreading vines sprout from critical strikes. These vines can hit up to three targets", "暴击使藤蔓蔓延，它最多可以击中三个目标".zh());
                    line.Text = line.Text.Replace("Hold the attack button to charge a star-piercing lunge, release to unleash the devastating blow", "按住攻击，为贯穿星辰的冲锋蓄力，松开以释放这一毁灭性打击".zh());
                    line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive impact which raises otherworldly monoliths", "撞击地面将引起地动山摇，异界巨石破土而出".zh());
                    line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time", "使用回旋斩，随按住时间增加旋转速度".zh());
                    line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. The sword then quickly returns to your hand", "使用回旋斩时松开攻击将剑掷出，它会在这之后快速回到你手中".zh());
					line.Text = line.Text.Replace("Shoot out two water balls at your sides. On ground contact the water balls will turn into small waves that ride along the ground", "向两侧投放水球，它们落地后会激发小型海浪沿地面滑行".zh());
					line.Text = line.Text.Replace("Waves fired while underwater or that touch water will become much larger and faster", "若水球接触到水，它激起的浪花将变得巨大且飞快".zh());
                }
                if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Active Attunement :", "主环境调谐：".zh());
                    line.Text = line.Text.Replace("Passive Attunement :", "副环境调谐：".zh());
                    line.Text = line.Text.Replace("Swordsmith's Pride", "刀匠之傲".zh());
                    line.Text = line.Text.Replace("Sanguine Fury", "血红之怒".zh());
                    line.Text = line.Text.Replace("Lamentations of the Chained", "囚徒之哀".zh());
                    line.Text = line.Text.Replace("Mercurial Tides", "变幻之潮".zh());
                    line.Text = line.Text.Replace("None", "无调谐".zh());
                    line.Text = line.Text.Replace("Does nothing..yet", "暂无所长，静待调谐。".zh());
                    line.Text = line.Text.Replace("It seems that upgrading the blade expanded the scope of the previous attunements", "你对剑的升级似乎让它原有的调谐获得了强化".zh());
                    line.Text = line.Text.Replace("Your secondary attunement can now provide passive bonuses", "副环境调谐现在可以提供辅助增益".zh());
                    line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time. Sword beams are fired wildly while swinging", "按住攻击键使用回旋斩，随时间逐渐加速。挥动时，剑气束会狂暴四散".zh());
                    line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. Sword beams home onto enemies struck by the thrown sword", "松开攻击键将剑向鼠标猛投出去。剑气束将会追踪被掷出的剑击中的来敌".zh());
                    line.Text = line.Text.Replace("All attacks have a chance to fire sword beams", "所有攻击有几率射出剑气".zh());
                    line.Text = line.Text.Replace("Conjures molten blades in front of you that get larger and stronger the more you hit enemies.", "令熔岩剑刃在你面前出现，并随着击打敌人而逐渐变大变强。".zh());
                    line.Text = line.Text.Replace(" The blades can also be used to bounce off tiles when in the air", "当你在空中时，剑刃也可以用于在物块上弹跳".zh());
                    line.Text = line.Text.Replace("Releasing the attack button sends the charged blades hurtling forwards like a wheel.", "松开攻击键将会使蓄力的剑刃如车轮一般向前飞驰。".zh());
                    line.Text = line.Text.Replace(" Attacking again immediately thereafter dashes to the wheel, shredding anything in the way", "那之后立即再次攻击使你冲向剑刃，并撕裂途径的一切".zh());
                    line.Text = line.Text.Replace("Striking enemies rarely steals a small amount of life", "击中敌人有小概率为你回复一定生命值".zh());
                    line.Text = line.Text.Replace("Hold the attack button to charge a heaven-shattering lunge, release to unleash the devastating blow.", "按住攻击键来为一次足以碎裂天堂的猛冲蓄力，松开以释放这一打击。".zh());
                    line.Text = line.Text.Replace(" Shock waves are emitted as the sword charges up", "蓄力时，冲击波将不断释放".zh());
                    line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive shock wave on impact which raises a flood of monoliths", "将此猛冲施加给地面将导致巨大的冲击波，并让洪水般的幻星巨石破地而出".zh());
                    line.Text = line.Text.Replace("Periodically emit shock waves while attacking", "攻击时周期性释放冲击波".zh());
                    line.Text = line.Text.Replace("Lash out with a flurry of chained blades. Striking enemies with the tip of the blades guarantees a critical hit", "向前迅猛掷出一阵拴在锁链上的剑刃。使用刃的顶部击中敌人必定暴击".zh());
                    line.Text = line.Text.Replace("Critical strikes send out extra phantom chains which latch onto multiple targets", "暴击会送出能够锁住多个目标的幻象锁链".zh());
                    line.Text = line.Text.Replace("An enchanted chain hook floats near you. Striking enemies makes the hook whirl around you, freezing enemies", "一个附魔链钩在你附近漂浮。击中敌人会让钩子在你周围旋转，冻结敌人".zh());
                }
                if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
                {
                    line.Text = line.Text.Replace("Active Attunement :", "星系调谐：".zh());
                    line.Text = line.Text.Replace("Passive Blessing :", "星系馈赠：".zh());
                    line.Text = line.Text.Replace("Phoenix's Pride", "凤凰座之桀骜".zh());
                    line.Text = line.Text.Replace("Aries' Wrath", "白羊座之盛怒".zh());
                    line.Text = line.Text.Replace("Polaris' Gaze", "北极星之凝视".zh());
                    line.Text = line.Text.Replace("Andromeda's Stride", "仙女座之冲击".zh());
                    line.Text = line.Text.Replace("Capricorn's Blessing", "摩羯座之祝福".zh());
                    line.Text = line.Text.Replace("Cancer's Blessing", "巨蟹座之馈赠".zh());
                    line.Text = line.Text.Replace("Hold the attack button to swing Galaxia around you, accelerating over time. The swirling nebula constantly emits homing cosmic bolts", "按住攻击键释放旋风阵，随时间加速。旋转的星云会持续释放追踪宙能束".zh());
                    line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor alongside a burst of 6 gigantic cosmic bolts. The sword then quickly returns to your hand", "松开攻击键将剑随六个巨大的宙能束向鼠标猛投出去。剑会在随后快速回到你手中".zh());
                    line.Text = line.Text.Replace("Throw Galaxia to your cursor, holding it in place with constellations. Galaxia follows your cursor, rapidly spinning to shred enemies", "将银河掷向鼠标，以群星将其握住。银河将跟随你的鼠标，快速旋转，解离来敌".zh());
                    line.Text = line.Text.Replace("Striking enemies causes nebulous explosions which spawn homing cosmic bolts", "击中敌人产生星云爆炸，生成追踪的宙能束".zh());
                    line.Text = line.Text.Replace("Hold the attack button to channel the Northern Star's power into a tight vortex of galactic energies, bound by concentric rings of stars.", "按住攻击键将北极星的力量引导为由星环围绕的星系能量旋涡。".zh());
                    line.Text = line.Text.Replace("The vortex powers up over time and when hitting enemies", "旋涡会随着时间和击中敌人增强".zh());
                    line.Text = line.Text.Replace("Release the attack button to fire off the charged star. Attacking again immediately thereafter dashes to the star, emitting a nova of cosmic bolts", "松开攻击键以释放蓄力的星星。释放后立即攻击会使你冲向星星，并如超新星般四散宙能束".zh());
                    line.Text = line.Text.Replace("Hold the attack button to charge a god-erasing lunge, release to unleash the devastating blow. Galaxia emits cosmic bolts while charging", "按住攻击键来为一次足以抹杀神明的猛冲蓄力，松开以释放这一打击。蓄力时，银河将四散宙能束".zh());
                    line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive impact which summons an apocalyptic storm of cosmic energies", "将此猛冲施加给地面将导致巨大的冲击，并释放如末世风暴般的宇宙能量".zh());
                    line.Text = line.Text.Replace("Periodically releases a ring of weakening stars around your cursor when attacking", "攻击时，不时向你的鼠标释放逐渐变弱的星环".zh());
                    line.Text = line.Text.Replace("The ring is repelled away from you at first, before slowing down over time", "星环会远离你，并逐渐变慢".zh());
                    line.Text = line.Text.Replace("Periodically releases a ring of lifestealing stars around yourself when attacking", "定期在你周围放出吸血的星环".zh());
                    line.Text = line.Text.Replace("The ring is attracted towards you at first, before slowing down over time", "星环会朝你飞去，之后逐渐慢下来".zh());
                }
                if (item.type == ModContent.ItemType<FracturedArk>())
                {
                    line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "右键向前伸出，击中敌人将会进行格挡，给予你短暂的无敌".zh());
                    line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 100 less damage", "也可以格挡弹幕，并短暂让其伤害减少100".zh());
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw projectiles out", "成功格挡将会强化10次正常攻击，使其射出弹幕".zh());
                }
                if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
                {
                    line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "右键向前伸出，击中敌人将会进行格挡，给予你短暂的无敌".zh());
                    line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 160 less damage", "也可以格挡弹幕，并短暂让其伤害减少160".zh());
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw stronger projectiles", "成功格挡将会强化10次正常攻击，使其伤害更高并射出更强大的弹幕".zh());
                    line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will release all the charges in a powerful burst of energy", "处于强化攻击状态时，按住上并点右键将会以强大能量波的形式把所有蓄力一次性释放".zh());
                }
                if (item.type == ModContent.ItemType<ArkoftheElements>())
                {
                    line.Text = line.Text.Replace("Performs a combo of swings, throwing the blade out every 5 swings", "进行一套连斩，并每隔五次挥动掷出一次刀刃".zh());
                    line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap", "若在掷出剑刃时松开鼠标，则会挥出另一片刀刃，进行一次剪击".zh());
                    line.Text = line.Text.Replace("Snapping the scissors together increase their damage and empower your next two swings", "剪击会增加剪刀的伤害，并强化你下两次挥动".zh());
                    line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you", "右键向前方剪出".zh());
                    line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "剪刀击中敌人将会进行格挡，给予你短暂的无敌".zh());
                    line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "它也可以格挡弹幕，并短暂让其伤害减少200".zh());
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "成功格挡将会强化10次正常挥动，允许你同时使用两片刀刃".zh());
                    line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "当方舟处于强化攻击状态时，按住上并点右键将掷出两片刀刃，产生时空之中的大撕裂，并一次性释放所有蓄力".zh());
                }
                if (item.type == ModContent.ItemType<ArkoftheCosmos>())
                {
                    line.Text = line.Text.Replace("Performs a combo of swings, alternating between narrow and wide swings and throwing the blade out every 5 swings", "进行一套连斩，在横扫和劈斩之间来回切换，并每隔五次挥动掷出一次刀刃".zh());
                    line.Text = line.Text.Replace("The thrown blade is held in place by constellations and will follow your cursor", "掷出的剑刃为星系所连，随你鼠标而动".zh());
                    line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap and explode into stars", "若在掷出剑刃时松开鼠标，则会挥出另一片刀刃，进行一次剪击，并爆炸成群星".zh());
                    line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you", "右键向前方剪出".zh());
                    line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "剪刀击中敌人将会进行格挡，给予你短暂的无敌".zh());
                    line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "它也可以格挡弹幕，并短暂让其伤害减少200".zh());
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "成功格挡将会强化10次正常挥动，允许你同时使用两片刀刃".zh());
                    line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "当方舟处于强化攻击状态时，按住上并点右键将掷出两片刀刃，产生时空之中的大撕裂，并一次性释放所有蓄力".zh());
                    line.Text = line.Text.Replace("If more than half the charges were used up, you can dash across the rip by keeping the up key pressed down", "若释放的蓄力超过一半，保持按住上键将允许你冲过撕裂".zh());
                }

                if (item.CountsAsClass(DamageClass.Melee))
                {
                    line.Text = line.Text.Replace("true melee damage", "真近战伤害".zh());
                }

                if (item.DamageType.Name == "RogueDamageClass")
                {
                    line.Text = line.Text.Replace("rogue damage", "盗贼伤害".zh());
                    line.Text = line.Text.Replace("stealth strike damage", "潜伏攻击伤害".zh());
                }

                if (item.DamageType.Name == "AverageDamageClass")
                {
                    line.Text = line.Text.Replace("average damage", "无职业伤害".zh());
                }

                if (item.type >= ItemID.Celeb2 && (item.Calamity()?.UsesCharge ?? false))
                {
                    line.Text = line.Text.Replace("Current Charge:", "当前充能：".zh());

                }

                if ((item.Calamity()?.UsesCharge ?? false) || item.type == ModContent.ItemType<AuricQuantumCoolingCell>() || item.type == ModContent.ItemType<PlasmaGrenade>() || item.type == ModContent.ItemType<VoltageRegulationSystem>() || item.type == ModContent.ItemType<AdvancedDisplay>() || item.type == ModContent.ItemType<LongRangedSensorArray>() || item.type == ModContent.ItemType<DecryptionComputer>())
                {
                    line.Text = line.Text.Replace("You don't have sufficient knowledge to create this yet", "你没有足够的知识去制作这个".zh());
                    line.Text = line.Text.Replace("The Sunken Sea schematic must be deciphered first", "需要先获取沉沦之海原型图".zh());
                    line.Text = line.Text.Replace("The Planetoid schematic must be deciphered first", "需要先破译小行星原型图".zh());
                    line.Text = line.Text.Replace("The Jungle schematic must be deciphered first", "需要先破译丛林原型图".zh());
                    line.Text = line.Text.Replace("The Underworld schematic must be deciphered first", "需要先破译地狱原型图".zh());
                    line.Text = line.Text.Replace("The Ice biome schematic must be deciphered first", "需要先破译雪原原型图".zh());

                }

                if (item.Calamity().canFirePointBlankShots)
                {
                    line.Text = line.Text.Replace("Does extra damage to enemies shot at point-blank range", "对近距离敌怪射击时造成额外伤害".zh());
                }

                if (item.Calamity().devItem)
                {
                    line.Text = line.Text.Replace("Developer Item", "开发者物品".zh());
                }

                if (item.Calamity().donorItem)
                {
                    line.Text = line.Text.Replace("Donor Item", "捐赠者物品".zh());
                }
                if (item.accessory && !item.social && item.prefix > 0)
                {
                    line.Text = line.Text.Replace("damage reduction", "伤害减免".zh());
                    line.Text = line.Text.Replace("stealth generation", "潜行值恢复速度".zh());

                }

                if (item.type == ModContent.ItemType<WulfrumHat>() || item.type == ModContent.ItemType<WulfrumJacket>() || item.type == ModContent.ItemType<WulfrumOveralls>())
                {
                    line.Text = line.Text.Replace("Wulfrum Bastion - Double tap DOWN while dismounted to equip wulfrum power armor", "钨钢阵线 - 不在坐骑上时双击下键以装备钨钢能量装甲".zh());
                    line.Text = line.Text.Replace("While the armor is active, you can only use the integrated fusion cannon, but your defensive stats are increased", "当能量装甲激活时，你只能使用聚变炮，但防御力提升".zh());
                    line.Text = line.Text.Replace("Calling down the armor consumes one piece of wulfrum metal scrap, and the armor will lose durability faster when hit", "召唤装甲消耗一块钨钢金属废料，且装甲在被击中时会更快失去耐久".zh());
                    line.Text = line.Text.Replace("Hold SHIFT to see the stats of the fusion cannon", "按住SHIFT视察聚变炮的属性".zh());
                }

                if (item.type == ModContent.ItemType<MarniteArchitectHeadgear>() || item.type == ModContent.ItemType<MarniteArchitectToga>())
                {
                    line.Text = line.Text.Replace("Marnite Lift - You can summon a lift under your feet to reach higher up", "合成岩悬浮平台-你可以在你的脚下召唤一个悬浮平台以够到更高的地方".zh());
                    line.Text = line.Text.Replace("The lift gets summoned when the mount hotkey gets pressed", "悬浮平台会在按下坐骑按钮时被召唤".zh());
                    line.Text = line.Text.Replace("without any mounts equipped", "前提是没有装备任何坐骑".zh());
                    line.Text = line.Text.Replace("Using the Up and Down keys can change the lift's height", "使用上下键改变悬浮平台的高度".zh());
                }

                if (item.type == ModContent.ItemType<DesertProwlerHat>() || item.type == ModContent.ItemType<DesertProwlerPants>() || item.type == ModContent.ItemType<DesertProwlerShirt>())
                {
                    line.Text = line.Text.Replace("Sandsmoke Bomb - Double tap DOWN to shroud yourself in a small cloud of sand", "沙尘覆盖-双击下键将自己笼罩在一小片沙尘之中".zh());
                    line.Text = line.Text.Replace("While the sand cloud is active, gain increased mobility but heavily reduced defense", "当在沙尘之中，获得更高的机动性，但防御力大大降低".zh());
                    line.Text = line.Text.Replace("Using a ranged weapon instantly dispels the sand cloak, but guarantees a supercrit for 200% damage", "使用远程攻击会立刻驱散沙尘，但会造成200%的超级暴击伤害".zh());
                    line.Text = line.Text.Replace("The super crit applies only as long as the resulting hit wouldn't exceed 100 damage", "超级暴击只在造成的伤害不超过100点时才有效".zh());
                    line.Text = line.Text.Replace("Landing the killing blow on an enemy with this shot shortens the ability's cooldown to 1.5 seconds", "此次攻击击杀敌人，冷却时间缩短到1.5秒".zh());
                }

                if (item.type == ModContent.ItemType<GemTechHeadgear>() || item.type == ModContent.ItemType<GemTechSchynbaulds>() || item.type == ModContent.ItemType<GemTechBodyArmor>())
                {
                    line.Text = line.Text.Replace("Power Gems - Six gem fragments idly orbit you; one for each class, and a base gem", "能量宝石 - 六个宝石碎片缓缓绕着你旋转；其中五个对应五个职业，还有一个基础宝石".zh());
                    line.Text = line.Text.Replace("Each active gem provides a bonus for its respective class, while the defensive gem grants defensive boosts", "每种宝石提供一种对应职业奖励，防御宝石会给予大量防御提升".zh());
                    line.Text = line.Text.Replace("Powerful enemy hits will dislodge gems, launching them into the nearest enemy for huge damage", "受到大量伤害宝石会破碎，并攻击附近敌怪造成大量伤害".zh());
                    line.Text = line.Text.Replace("Lost gems regenerate after a while", "失去的宝石需要时间来重新凝聚".zh());
                    line.Text = line.Text.Replace("The lost gem is the same class as the weapon you are using, so better prepare for some weapon switching action!", "失去的宝石对应你最近一次使用的武器的职业！".zh());
                    line.Text = line.Text.Replace("Hold SHIFT to see an expanded description", "按住Shift查看更多信息".zh());
                    line.Text = line.Text.Replace("A gem is lost when you take more than ", "如果一次受到超过".zh());
                    line.Text = line.Text.Replace(" damage in a single hit. The type of gem lost is the same as the class of the previous when you used", "点伤害，你会失去一个宝石。失去的宝石对应你最近一次使用的武器的职业".zh());
                    line.Text = line.Text.Replace("If said gem has already been lost, the base gem is lost instead", "如果你已经失去了那个宝石，那么这次失去的将会是基础宝石".zh());
                    line.Text = line.Text.Replace("When a gem is lost, it breaks off and homes towards the nearest enemy or boss, if one is present, dealing a base of ", "宝石在失去时会破碎，并向最近的敌人或boss飞去，造成".zh());
                    line.Text = line.Text.Replace("Gems have a ", "破碎的宝石需要".zh());
                    line.Text = line.Text.Replace(" second delay before they appear again", "秒来重新凝聚".zh());
                    line.Text = line.Text.Replace("The red gem grants ", "红色宝石给予".zh());
                    line.Text = line.Text.Replace(" maximum stealth, increased rogue stats, and makes stealth only consumable by rogue weapons", "点最大潜行值，增加盗贼属性，并让非盗贼武器不消耗潜行值".zh());
                    line.Text = line.Text.Replace("The yellow gem provides increased melee stats and makes melee attacks release shards on hit with a cooldown. This cooldown is shorter for true melee attacks", "黄色宝石增加近战属性，让近战攻击释放宝石碎片。真近战攻击释放宝石碎片的冷却时间更少".zh());
                    line.Text = line.Text.Replace("The green gem provides increased ranged stats and causes flechettes to fly swiftly towards targets when they are damaged by a ranged projectile", "绿色宝石增加远程属性，并召唤飞镖弹快速向被远程弹幕击中的敌人飞去".zh());
                    line.Text = line.Text.Replace("The blue gem grants ", "蓝色宝石给予".zh());
                    line.Text = line.Text.Replace(" extra maximum minions, increased minion damage, and reduces the penalty for summoner items while holding a non-summoner weapon", "最大召唤栏，增加召唤伤害，并减少手持非召唤武器的召唤伤害降低惩罚".zh());
                    line.Text = line.Text.Replace("The violet gem grants ", "紫色宝石给予".zh());
                    line.Text = line.Text.Replace(" extra maximum mana, increased magic stats, and makes mana rapidly regenerate when holding a non-magic weapon", "点魔力上限，增加魔法属性，并在你手持非魔法武器时为你快速回复魔力".zh());
                    line.Text = line.Text.Replace("The pink base gem grants ", "粉色基础宝石给予".zh());
                    line.Text = line.Text.Replace(" extra defense, extra damage reduction, increased movement speed, jump speed, and +", "点防御力，增加免伤、移动速度和跳跃速度，增加".zh());               
                    line.Text = line.Text.Replace("When all gems exist simultaneously, hitting a target with any weapon grants you +", "如果所有宝石同时存在，使用任意武器击中敌人会给予你".zh());
                    line.Text = line.Text.Replace(" life regen for ", "点生命恢复持续".zh());
                    line.Text = line.Text.Replace("This is increased to +3 life regen if a weapon of another class is used during that 8 second period for 2.5 seconds", "持续期间使用另一职业的武器超过2.5秒，生命恢复增加至3点".zh());
					line.Text = line.Text.Replace(" damage", "基础伤害".zh());
                    line.Text = line.Text.Replace(" life regen", "生命回复".zh());
                    line.Text = line.Text.Replace(" seconds", "秒".zh());
                }

                if (item.type == ModContent.ItemType<RuneofKos>())
                {
                    line.Text = line.Text.Replace("Summons the Storm Weaver", "召唤风暴编织者".zh());
                    line.Text = line.Text.Replace("Summons the Signus, Envoy of the Devourer", "召唤神之使徒，西格纳斯".zh());
                    line.Text = line.Text.Replace("Summons the Ceaseless Void", "召唤无尽虚空".zh());
                    line.Text = line.Text.Replace("Enrages on the surface", "在地表上狂暴".zh());
                }

                if (item.type == ModContent.ItemType<CalamityMod.Items.Accessories.Wings.HadarianWings>())
                {
                    line.Text = line.Text.Replace("Hold ", "按住".zh());
                    line.Text = line.Text.Replace(" and ", "和".zh());
                    line.Text = line.Text.Replace(" to hover", "可以悬浮".zh());
                    line.Text = line.Text.Replace("Press ", "按下".zh());
                    line.Text = line.Text.Replace(" to toggle hover\nPress ", "可切换悬停\n按下".zh());
                    line.Text = line.Text.Replace(" to deactivate hover", "可停用悬停".zh());
                }

                if (item.type == ModContent.ItemType<EncryptedSchematicSunkenSea>() || item.type == ModContent.ItemType<EncryptedSchematicPlanetoid>() || item.type == ModContent.ItemType<EncryptedSchematicJungle>() || item.type == ModContent.ItemType<EncryptedSchematicIce>() || item.type == ModContent.ItemType<EncryptedSchematicHell>())
                {
                    line.Text = line.Text.Replace("Has already been decrypted.", "已经破解该原型图".zh());
                    line.Text = line.Text.Replace("Click to view its contents.", "点击查看内容".zh());
                    line.Text = line.Text.Replace("Unlocked recipes:", "解锁配方：".zh());
                    line.Text = line.Text.Replace("Gauss Dagger", "高斯短匕".zh());
                    line.Text = line.Text.Replace("Taser", "泰瑟枪".zh());
                    line.Text = line.Text.Replace("Pulse Pistol", "脉冲手枪".zh());
                    line.Text = line.Text.Replace("Star Swallower Containment Unit", "噬星者控制元件".zh());
                    line.Text = line.Text.Replace("Tracking Disk", "逐影飞盘".zh());
                    line.Text = line.Text.Replace("Decryption Computer", "解密计算机".zh());
                    line.Text = line.Text.Replace("Hydraulic Volt Crasher", "液压伏冲器".zh());
                    line.Text = line.Text.Replace("Matter Modulator", "物质调谐器".zh());
                    line.Text = line.Text.Replace("Gauss Pistol", "高斯手枪".zh());
                    line.Text = line.Text.Replace("Mounted Scanner", "架式扫射机".zh());
                    line.Text = line.Text.Replace("Frequency Manipulator", "变频器".zh());
                    line.Text = line.Text.Replace("Long Ranged Sensor Array", "远程传感器阵列".zh());
                    line.Text = line.Text.Replace("Galvanizing Glaive", "磁能分割刀".zh());
                    line.Text = line.Text.Replace("Gauss Rifle", "高斯来复枪".zh());
                    line.Text = line.Text.Replace("Gatling Laser", "激光加特林".zh());
                    line.Text = line.Text.Replace("Pulse Turret Remote", "脉冲炮塔遥控装置".zh());
                    line.Text = line.Text.Replace("System Bane", "神经系统紊乱装置".zh());
                    line.Text = line.Text.Replace("Advanced Display", "高级显示屏".zh());
                    line.Text = line.Text.Replace("Phaseslayer", "相位剑".zh());
                    line.Text = line.Text.Replace("Pulse Rifle", "脉冲步枪".zh());
                    line.Text = line.Text.Replace("The Anomaly's Nanogun", "异象纳米枪".zh());
                    line.Text = line.Text.Replace("Tesla Cannon", "特斯拉巨炮".zh());
                    line.Text = line.Text.Replace("Pole Warper", "电极解离机".zh());
                    line.Text = line.Text.Replace("Plasma Grenade", "等离子手雷".zh());
                    line.Text = line.Text.Replace("Auric Quantum Cooling Cell", "金源量子冷却电池".zh());
                    line.Text = line.Text.Replace("Pulse Dragon", "脉冲龙链枷".zh());
                    line.Text = line.Text.Replace("Heavy Laser Rifle", "重型激光步枪".zh());
                    line.Text = line.Text.Replace("Plasma Caster", "等离子液铸器".zh());
                    line.Text = line.Text.Replace("Snake Eyes", "蛇眼".zh());
                    line.Text = line.Text.Replace("Wave Pounder", "震波炸弹".zh());
                    line.Text = line.Text.Replace("Voltage Regulation System", "电压校准系统".zh());
                    
                }

                #region 不能直接翻译的家具(恼
                //星流家具
                if (item.type == ModContent.ItemType<ExoChair>())
                {
                    line.Text = line.Text.Replace("Exo Chair", "星流椅".zh());
                }
                if (item.type == ModContent.ItemType<ExoBathtub>())
                {
                    line.Text = line.Text.Replace("Exo Bathtub", "星流浴缸".zh());
                }
                if (item.type == ModContent.ItemType<ExoBed>())
                {
                    line.Text = line.Text.Replace("Exo Bed", "星流床".zh());
                }
                if (item.type == ModContent.ItemType<ExoBookcase>())
                {
                    line.Text = line.Text.Replace("Exo Bookcase", "星流书架".zh());
                }
                if (item.type == ModContent.ItemType<ExoCandelabra>())
                {
                    line.Text = line.Text.Replace("Exo Candelabra", "星流烛台".zh());
                }
                if (item.type == ModContent.ItemType<ExoCandle>())
                {
                    line.Text = line.Text.Replace("Exo Candle", "星流蜡烛".zh());
                }
                if (item.type == ModContent.ItemType<ExoChandelier>())
                {
                    line.Text = line.Text.Replace("Exo Chandelier", "星流吊灯".zh());
                }
                if (item.type == ModContent.ItemType<ExoChest>())
                {
                    line.Text = line.Text.Replace("Exo Chest", "星流箱".zh());
                }
                if (item.type == ModContent.ItemType<ExoClock>())
                {
                    line.Text = line.Text.Replace("Exo Clock", "星流钟".zh());
                }
                if (item.type == ModContent.ItemType<ExoDoor>())
                {
                    line.Text = line.Text.Replace("Exo Door", "星流门".zh());
                }
                if (item.type == ModContent.ItemType<ExoDresser>())
                {
                    line.Text = line.Text.Replace("Exo Dresser", "星流梳妆台".zh());
                }
                if (item.type == ModContent.ItemType<ExoKeyboard>())
                {
                    line.Text = line.Text.Replace("Exo Keyboard", "星流键盘".zh());
                }
                if (item.type == ModContent.ItemType<ExoLamp>())
                {
                    line.Text = line.Text.Replace("Exo Lamp", "星流灯".zh());
                }
                if (item.type == ModContent.ItemType<ExoLantern>())
                {
                    line.Text = line.Text.Replace("Exo Lantern", "星流灯笼".zh());
                }
                if (item.type == ModContent.ItemType<ExoPlatform>())
                {
                    line.Text = line.Text.Replace("Exo Platform", "星流平台".zh());
                }
                if (item.type == ModContent.ItemType<ExoPrismPlatform>())
                {
                    line.Text = line.Text.Replace("Exo Prism Platform", "星流棱晶平台".zh());
                }
                if (item.type == ModContent.ItemType<ExoSink>())
                {
                    line.Text = line.Text.Replace("Exo Sink", "星流水槽".zh());
                }
                if (item.type == ModContent.ItemType<ExoSofa>())
                {
                    line.Text = line.Text.Replace("Exo Sofa", "星流沙发".zh());
                }
                if (item.type == ModContent.ItemType<ExoTable>())
                {
                    line.Text = line.Text.Replace("Exo Table", "星流桌".zh());
                }
                if (item.type == ModContent.ItemType<ExoToilet>())
                {
                    line.Text = line.Text.Replace("Exo Toilet", "星流马桶".zh());
                }
                if (item.type == ModContent.ItemType<ExoWorkbench>())
                {
                    line.Text = line.Text.Replace("Exo Work Bench", "星流工作台".zh());
                }
                //酸腐木家具
                if (item.type == ModContent.ItemType<AcidwoodBathtub>())
                {
                    line.Text = line.Text.Replace("Acidwood Bathtub", "酸腐木浴缸".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodBed>())
                {
                    line.Text = line.Text.Replace("Acidwood Bed", "酸腐木床".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodBench>())
                {
                    line.Text = line.Text.Replace("Acidwood Bench", "酸腐木长凳".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodBookcase>())
                {
                    line.Text = line.Text.Replace("Acidwood Bookcase", "酸腐木书架".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodCandelabra>())
                {
                    line.Text = line.Text.Replace("Acidwood Candelabra", "酸腐木烛台".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodCandle>())
                {
                    line.Text = line.Text.Replace("Acidwood Candle", "酸腐木蜡烛".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodChair>())
                {
                    line.Text = line.Text.Replace("Acidwood Chair", "酸腐木椅子".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodChandelier>())
                {
                    line.Text = line.Text.Replace("Acidwood Chandelier", "酸腐木吊灯".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodChest>())
                {
                    line.Text = line.Text.Replace("Acidwood Chest", "酸腐木箱".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodClock>())
                {
                    line.Text = line.Text.Replace("Acidwood Clock", "酸腐木钟".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodDoor>())
                {
                    line.Text = line.Text.Replace("Acidwood Door", "酸腐木门".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodDresser>())
                {
                    line.Text = line.Text.Replace("Acidwood Dresser", "酸腐木梳妆台".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodLamp>())
                {
                    line.Text = line.Text.Replace("Acidwood Lamp", "酸腐木灯".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodLantern>())
                {
                    line.Text = line.Text.Replace("Acidwood Lantern", "酸腐木灯笼".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodPiano>())
                {
                    line.Text = line.Text.Replace("Acidwood Piano", "酸腐木钢琴".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodPlatform>())
                {
                    line.Text = line.Text.Replace("Acidwood Platform", "酸腐木平台".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodSink>())
                {
                    line.Text = line.Text.Replace("Acidwood Sink", "酸腐木水槽".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodTable>())
                {
                    line.Text = line.Text.Replace("Acidwood Table", "酸腐木桌子".zh());
                }
                if (item.type == ModContent.ItemType<AcidwoodWorkBench>())
                {
                    line.Text = line.Text.Replace("Acidwood Work Bench", "酸腐木工作台".zh());
                }
                //星石家具
                if (item.type == ModContent.ItemType<MonolithBathtub>())
                {
                    line.Text = line.Text.Replace("Monolith Bathtub", "星石浴缸".zh());
                }
                if (item.type == ModContent.ItemType<MonolithBed>())
                {
                    line.Text = line.Text.Replace("Monolith Bed", "星石床".zh());
                }
                if (item.type == ModContent.ItemType<MonolithBench>())
                {
                    line.Text = line.Text.Replace("Monolith Bench", "星石长凳".zh());
                }
                if (item.type == ModContent.ItemType<MonolithBookcase>())
                {
                    line.Text = line.Text.Replace("Monolith Bookcase", "星石书架".zh());
                }
                if (item.type == ModContent.ItemType<MonolithCandelabra>())
                {
                    line.Text = line.Text.Replace("Monolith Candelabra", "星石烛台".zh());
                }
                if (item.type == ModContent.ItemType<MonolithCandle>())
                {
                    line.Text = line.Text.Replace("Monolith Candle", "星石蜡烛".zh());
                }
                if (item.type == ModContent.ItemType<MonolithChair>())
                {
                    line.Text = line.Text.Replace("Monolith Chair", "星石椅".zh());
                }
                if (item.type == ModContent.ItemType<MonolithChandelier>())
                {
                    line.Text = line.Text.Replace("Monolith Chandelier", "星石吊灯".zh());
                }
                if (item.type == ModContent.ItemType<MonolithChest>())
                {
                    line.Text = line.Text.Replace("Monolith Chest", "星石箱".zh());
                }
                if (item.type == ModContent.ItemType<MonolithClock>())
                {
                    line.Text = line.Text.Replace("Monolith Clock", "星石钟".zh());
                }
                if (item.type == ModContent.ItemType<MonolithDoor>())
                {
                    line.Text = line.Text.Replace("Monolith Door", "星石门".zh());
                }
                if (item.type == ModContent.ItemType<MonolithDresser>())
                {
                    line.Text = line.Text.Replace("Monolith Dresser", "星石梳妆台".zh());
                }
                if (item.type == ModContent.ItemType<MonolithLamp>())
                {
                    line.Text = line.Text.Replace("Monolith Lamp", "星石灯".zh());
                }
                if (item.type == ModContent.ItemType<MonolithLantern>())
                {
                    line.Text = line.Text.Replace("Monolith Lantern", "星石灯笼".zh());
                }
                if (item.type == ModContent.ItemType<MonolithPiano>())
                {
                    line.Text = line.Text.Replace("Monolith Piano", "星石钢琴".zh());
                }
                if (item.type == ModContent.ItemType<MonolithPlatform>())
                {
                    line.Text = line.Text.Replace("Monolith Platform", "星石平台".zh());
                }
                if (item.type == ModContent.ItemType<MonolithSink>())
                {
                    line.Text = line.Text.Replace("Monolith Sink", "星石水槽".zh());
                }
                if (item.type == ModContent.ItemType<MonolithTable>())
                {
                    line.Text = line.Text.Replace("Monolith Table", "星石桌".zh());
                }
                if (item.type == ModContent.ItemType<MonolithWorkBench>())
                {
                    line.Text = line.Text.Replace("Monolith Work Bench", "星石工作台".zh());
                }
                //异域家具
                if (item.type == ModContent.ItemType<OtherworldlyBathtub>())
                {
                    line.Text = line.Text.Replace("Otherworldly Bathtub", "异域浴缸".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyBed>())
                {
                    line.Text = line.Text.Replace("Otherworldly Bed", "异域床".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyBookcase>())
                {
                    line.Text = line.Text.Replace("Otherworldly Bookcase", "异域书架".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyCandelabra>())
                {
                    line.Text = line.Text.Replace("Otherworldly Candelabra", "异域烛台".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyCandle>())
                {
                    line.Text = line.Text.Replace("Otherworldly Candle", "异域蜡烛".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyChair>())
                {
                    line.Text = line.Text.Replace("Otherworldly Chair", "异域椅".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyChandelier>())
                {
                    line.Text = line.Text.Replace("Otherworldly Chandelier", "异域吊灯".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyChest>())
                {
                    line.Text = line.Text.Replace("Otherworldly Chest", "异域箱".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyClock>())
                {
                    line.Text = line.Text.Replace("Otherworldly Clock", "异域钟".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyDoor>())
                {
                    line.Text = line.Text.Replace("Otherworldly Door", "异域门".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyDresser>())
                {
                    line.Text = line.Text.Replace("Otherworldly Dresser", "异域梳妆台".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyLamp>())
                {
                    line.Text = line.Text.Replace("Otherworldly Lamp", "异域灯".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyLantern>())
                {
                    line.Text = line.Text.Replace("Otherworldly Lantern", "异域灯笼".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyPiano>())
                {
                    line.Text = line.Text.Replace("Otherworldly Piano", "异域钢琴".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyPlatform>())
                {
                    line.Text = line.Text.Replace("Otherworldly Platform", "异域平台".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlySink>())
                {
                    line.Text = line.Text.Replace("Otherworldly Sink", "异域水槽".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlySofa>())
                {
                    line.Text = line.Text.Replace("Otherworldly Sofa", "异域沙发".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyStone>())
                {
                    line.Text = line.Text.Replace("Otherworldly Stone", "异域石".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyTable>())
                {
                    line.Text = line.Text.Replace("Otherworldly Table", "异域桌".zh());
                }
                if (item.type == ModContent.ItemType<OtherworldlyWorkBench>())
                {
                    line.Text = line.Text.Replace("Otherworldly Work Bench", "异域工作台".zh());
                }
                //其他家具
                if (item.type == ModContent.ItemType<VoidBathtub>())
                {
                    line.Text = line.Text.Replace("Void Bathtub", "虚空浴缸".zh());
                }
                if (item.type == ModContent.ItemType<VoidObelisk>())
                {
                    line.Text = line.Text.Replace("Void Obelisk", "虚空钟".zh());
                }
                if (item.type == ModContent.ItemType<VoidWorkbench>())
                {
                    line.Text = line.Text.Replace("Void Work Bench", "虚空工作台".zh());
                }
                if (item.type == ModContent.ItemType<AshenBathtub>())
                {
                    line.Text = line.Text.Replace("Ashen Bathtub", "灰烬浴缸".zh());
                }
                if (item.type == ModContent.ItemType<AshenPipeOrgan>())
                {
                    line.Text = line.Text.Replace("Ashen Pipe Organ", "灰烬钢琴".zh());
                }
                if (item.type == ModContent.ItemType<AshenWorkBench>())
                {
                    line.Text = line.Text.Replace("Ashen Work Bench", "灰烬工作台".zh());
                }
                if (item.type == ModContent.ItemType<AncientBathtub>())
                {
                    line.Text = line.Text.Replace("Ancient Bathtub", "远古浴缸".zh());
                }
                if (item.type == ModContent.ItemType<AncientPipeOrgan>())
                {
                    line.Text = line.Text.Replace("Ancient Pipe Organ", "远古钢琴".zh());
                }
                if (item.type == ModContent.ItemType<AncientWorkBench>())
                {
                    line.Text = line.Text.Replace("Ancient Work Bench", "远古工作台".zh());
                }
                if (item.type == ModContent.ItemType<AbyssBathtub>())
                {
                    line.Text = line.Text.Replace("Abyss Bathtub", "深渊浴缸".zh());
                }
                if (item.type == ModContent.ItemType<AbyssSynth>())
                {
                    line.Text = line.Text.Replace("Abyss Synth", "深渊钢琴".zh());
                }
                if (item.type == ModContent.ItemType<AbyssWorkBench>())
                {
                    line.Text = line.Text.Replace("Abyss Work Bench", "深渊工作台".zh());
                }
                if (item.type == ModContent.ItemType<StatigelBathtub>())
                {
                    line.Text = line.Text.Replace("Statigel Bathtub", "斯塔提斯浴缸".zh());
                }
                if (item.type == ModContent.ItemType<StatigelWorkbench>())
                {
                    line.Text = line.Text.Replace("Statigel Work Bench", "斯塔提斯工作台".zh());
                }
                if (item.type == ModContent.ItemType<ProfanedBathtub>())
                {
                    line.Text = line.Text.Replace("Profaned Bathtub", "渎神浴缸".zh());
                }
                if (item.type == ModContent.ItemType<ProfanedWorkbench>())
                {
                    line.Text = line.Text.Replace("Profaned Work Bench", "渎神工作台".zh());
                }
                if (item.type == ModContent.ItemType<CosmiliteBathtub>())
                {
                    line.Text = line.Text.Replace("Cosmilite Bathtub", "宇宙浴缸".zh());
                }
                if (item.type == ModContent.ItemType<CosmiliteWorkBench>())
                {
                    line.Text = line.Text.Replace("Cosmilite Work Bench", "宇宙工作台".zh());
                }
                if (item.type == ModContent.ItemType<StratusWorkbench>())
                {
                    line.Text = line.Text.Replace("Stratus Work Bench", "幻云工作台".zh());
                }

                #endregion

                /*		
                            if (item.type == ModContent.ItemType<>())
                            {
                                line.Text = line.Text.Replace("", "".zh());
                            }	
                */
                //-原版物品-
                #region 武器
                if (item.type == ItemID.DeathSickle)
                {
                    line.Text = line.Text.Replace("Inflicts Whispering Death on hit", "命中造成死亡低语减益".zh());
                }

                if (item.type == ItemID.Excalibur || item.type == ItemID.TrueExcalibur || item.type == ItemID.Gungnir)
                {
                    line.Text = line.Text.Replace("Inflicts Holy Flames", "命中造成神圣之火减益".zh());
                    line.Text = line.Text.Replace("Deals double damage to enemies above 75% life", "对75%生命值以上的敌怪造成双倍伤害".zh());
                }

                if (item.type == 46 || item.type == 273 || item.type == 675 || item.type == 162 || item.type == 3279)
                {
                    line.Text = line.Text.Replace("Inflicts Shadowflame on hit", "命中造成暗影焰减益".zh());
                }

                if (item.type == 2608)
                {
                    line.Text = line.Text.Replace("Holding this item grants +20% increased movement speed", "手持此物品时会获得20%移动速度加成".zh());
                }
                
                if (item.type == 426 || item.type == 1166 || item.type == 3772)
                {
                    line.Text = line.Text.Replace("Ignores 50% of enemy defense", "无视敌怪50%的防御力".zh());
                }

                if (item.type == 795 || item.type == 801 || item.type == 802 || item.type == 3280)
                {
                    line.Text = line.Text.Replace("Inflicts Burning Blood on hit", "命中造成沸腾之血减益".zh());
                }

                if (item.type == 483 || item.type == 537)
                {
                    line.Text = line.Text.Replace("Decreases enemy defense by 25% on hit", "命中时减少敌人25%防御".zh());
                }

                if (item.type == 1185 || item.type == 1186)
                {
                    line.Text = line.Text.Replace("Increases life regen on hit", "命中时增加生命恢复速度".zh());
                }

                if (item.type == 484 || item.type == 390)
                {
                    line.Text = line.Text.Replace("Decreases enemy contact damage by 10% on hit", "命中时减少敌人10%接触伤害".zh());
                }

                if (item.type == 1192 || item.type == 1193)
                {
                    line.Text = line.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "命中时增加山铜套触发效果".zh());
                }

                if (item.type == 406 || item.type == 482)
                {
                    line.Text = line.Text.Replace("Slows enemies on hit", "命中时减速敌人".zh());
                }

                if (item.type == 3065 || item.type == 1947 || item.type == 3106)
                {
                    line.Text = line.Text.Replace("Receives 33% benefit from melee speed bonuses", "只能享受33%近战攻速加成效果".zh());
                }

                if (item.type == 3859)
                {
                    line.Text = line.Text.Replace("Shoots splitting arrows", "射出分裂的箭".zh());
                }

                if (item.type == 1199 || item.type == 1200)
                {
                    line.Text = line.Text.Replace("Deals increased damage to enemies with high knockback resistance", "对高击退抗性的敌人造成更多伤害".zh());
                }

                List<int> i100ed = new List<int>() { 3352, 198, 199, 200, 201, 202, 203, 3764, 3765, 3766, 3767, 3768, 3769, 4258, 4259 };
                if (i100ed.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Ignores 100% of enemy defense", "无视敌怪100%的防御力".zh());
                }
                #endregion

                #region 工具
                if (item.type == 367 || item.type == 787)
                {
                    line.Text = line.Text.Replace("Demon Altars now drop Souls of Night instead of generating ores when destroyed", "摧毁恶魔祭坛获得暗影之魂，而不是新三矿".zh());
                    line.Text = line.Text.Replace("Hardmode ores now generate after defeating Mechanical Bosses for the first time", "新三矿仅在击败每个机械Boss后生成".zh());
                }

                if (item.type == 1294)
                {
                    line.Text = line.Text.Replace("Can mine Scoria Ore located in the Abyss", "可开采深渊中的熔渣矿".zh());
                }

                if (item.type == 2776 || item.type == 2781 || item.type == 2786 || item.type == 3466)
                {
                    line.Text = line.Text.Replace("Can mine Uelibloom Ore", "可开采龙蒿矿".zh());
                }
                #endregion

                #region 饰品
                if (item.type == ItemID.TerrasparkBoots)
                {
                    line.Text = line.Text.Replace("Immunity to the On Fire! debuff", "免疫着火了减益".zh());
                }
                if (item.type == ItemID.Magiluminescence)
                {
                    line.Text = line.Text.Replace("Increases movement acceleration and deceleration by 1.25x", "移动加速度和减速度增加1.25倍".zh());
                    line.Text = line.Text.Replace("Increases movement speed by 1.05x. This bonus applies to running boot accessories", "移动速度增加1.05倍。该效果适用于移动饰品".zh());
                }

                if (item.type == ItemID.YoYoGlove || item.type == ItemID.YoyoBag)
                {
                    line.Text = line.Text.Replace("Yoyos will do 33% less damage", "悠悠球伤害减少33%".zh());
                }

                if (item.type == ItemID.ArmorPolish || item.type == ItemID.ArmorBracing)
                {
                    line.Text = line.Text.Replace("and Armor Crunch", "免疫碎甲减益".zh());
                }

                if (item.type == ItemID.AnkhShield)
                {
                    line.Text = line.Text.Replace("including Mighty Wind", "包括强风".zh());
                }

                if (item.type == ItemID.BlackBelt || item.type == ItemID.MasterNinjaGear || item.type == ItemID.BrainOfConfusion)
                {
                    line.Text = line.Text.Replace("Grants the ability to dodge attacks", "获得闪避能力".zh());
                    line.Text = line.Text.Replace("The dodge has a 90 second cooldown which is shared with all other dodges and reflects", "闪避有90秒冷却，且与其他闪避和反弹效果共享冷却".zh());
                }

                if (item.type == ItemID.FleshKnuckles || item.type == ItemID.BerserkerGlove || item.type == ItemID.HeroShield)
                {
                    line.Text = line.Text.Replace("Max life increased by 45", "最大生命增加45".zh());
                }

                if (item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.BerserkerGlove)
                {
                    line.Text = line.Text.Replace("10% increased true melee damage", "真近战伤害增加10%".zh());
                }

                if (item.type == ItemID.FireGauntlet)
                {
                    line.Text = line.Text.Replace("14% increased melee damage and speed", "近战伤害和攻速增加14%".zh());
                    line.Text = line.Text.Replace("10% increased true melee damage", "真近战伤害增加10%".zh());
                }

                if (item.type == ItemID.SunStone)
                {
                    line.Text = line.Text.Replace("Grants immunity to Holy Flames", "免疫神圣之火减益".zh());
                }

                if (item.type == ItemID.MoonStone)
                {
                    line.Text = line.Text.Replace("Grants immunity to Nightwither", "免疫夜魇减益".zh());
                }

                if (item.type == ItemID.CelestialStone || item.type == ItemID.CelestialShell)
                {
                    line.Text = line.Text.Replace("Grants immunity to Nightwither and Holy Flames", "免疫夜魇和神圣之火减益".zh());
                }

                if (item.type == ItemID.DivingHelmet || item.type == ItemID.ArcticDivingGear || item.type == ItemID.CelestialShell)
                {
                    line.Text = line.Text.Replace("Moderately reduces breath loss in the abyss", "适当缓解深渊造成的呼吸困难".zh());
                }

                if (item.type == ItemID.JellyfishNecklace || item.type == ItemID.JellyfishDivingGear || item.type == ItemID.ArcticDivingGear || item.type == ItemID.ShadowOrb || item.type == ItemID.CrimsonHeart || item.type == ItemID.MagicLantern || item.type == ItemID.Magiluminescence || item.type==ItemID.MiningHelmet)
                {
                    line.Text = line.Text.Replace("Provides a small amount of light in the abyss", "在深渊中提供少量光照".zh());
                }

                if (item.type == ItemID.FairyBell || item.type == ItemID.DD2PetGhost || item.type == ItemID.ShinePotion)
                {
                    line.Text = line.Text.Replace("Provides a moderate amount of light in the abyss", "在深渊中提供适量光照".zh());
                }

                if (item.type == ItemID.WispinaBottle || item.type == ItemID.SuspiciousLookingTentacle || item.type == ItemID.GolemPetItem || item.type == ItemID.FairyQueenPetItem || item.type == ItemID.PumpkingPetItem)
                {
                    line.Text = line.Text.Replace("Provides a large amount of light in the abyss", "在深渊中提供大量光照".zh());
                }

                if (item.type == ItemID.EmpressFlightBooster)
                {
                    line.Text = line.Text.Replace("Increases wing flight time by 25%", "翅膀飞行时间增加25%".zh());
                    line.Text = line.Text.Replace("Increases movement and jump speed by 10% and acceleration by 1.1x", "移动和跳跃速度提高10%，加速度提高1.1倍".zh());
                }

                if (item.type == 3991 || item.type == 4000)
                {
                    line.Text = line.Text.Replace("12% reduced mana usage", "减少12%魔力消耗".zh());
                }

                if (item.type == 1321)
                {
                    line.Text = line.Text.Replace("Increases arrow damage by 5% and greatly increases arrow speed", "增加5%的箭矢伤害，并大幅提高箭矢速度".zh());
                }

                if (item.type == 4002)
                {
                    line.Text = line.Text.Replace("Increases arrow damage by 7% and greatly increases arrow speed", "增加7%的箭矢伤害，并大幅提高箭矢速度".zh());
                    line.Text = line.Text.Replace("and all arrows inflict Hellfire", "所有箭矢造成狱火减益".zh());
                }

                if (item.type == 1858)
                {
                    line.Text = line.Text.Replace("7% increased ranged damage and critical strike chance", "提高7%远程伤害和暴击率".zh());
                }

                if (item.type == 1921)
                {
                    line.Text = line.Text.Replace("Provides a regeneration boost while wearing the Snow armor", "穿着全套的防雪盔甲时额外提升2点生命再生速度".zh());
                }

                if (item.type == 4874)
                {
                    line.Text = line.Text.Replace("Multiplies all fire-based debuff damage by 1.5", "所有火焰类减益伤害乘于1.5".zh());
                    line.Text = line.Text.Replace("All attacks inflict Hellfire", "所有攻击造成狱火减益".zh());
                }

                if (item.type == 3993)
                {
                    line.Text = line.Text.Replace("Fairies can spawn at any time on the surface and spawn far more frequently", "大幅度提升仙灵的生成概率，在白天地表也能自然生成".zh());
                    line.Text = line.Text.Replace("Nearby fairies grant increased life regen, defense and movement speed", "靠近仙灵获得生命恢复，防御与移动速度".zh());
                    line.Text = line.Text.Replace("Fairies are immune to damage and will no longer flee", "仙灵免疫敌怪的伤害并能跟随你".zh());
                }

                if (item.type == 492)
                {
                    line.Text = line.Text.Replace("5% increased damage and critical strike chance", "提高5%伤害和暴击率".zh());
                }

                if (item.type == 493)
                {
                    line.Text = line.Text.Replace("+20 max life, +10 defense and +2 life regen", "+20最大生命值，+10防御力和2点生命恢复".zh());
                }

                if (item.type == 1162)
                {
                    line.Text = line.Text.Replace("+5 defense, 5% increased damage reduction,", "穿着提基盔甲提高5防御力和5%减伤".zh());
                    line.Text = line.Text.Replace("and permanent Dryad's Blessing while wearing the Tiki Armor", "并永久获得树妖祝福".zh());
                }

                if (item.type == 2494)
                {
                    line.Text = line.Text.Replace("Gills effect and you can move freely through liquids", "具有鱼鳃效果且允许在液体中快速移动".zh());
                    line.Text = line.Text.Replace("You fall faster while submerged in liquid", "液体中下落速度加快".zh());
                }

                if (item.type == 1515)
                {
                    line.Text = line.Text.Replace("Permanently gives the Honey buff", "任何时候都会给予蜂蜜buff".zh());
                }

                if (item.type == 749)
                {
                    line.Text = line.Text.Replace("+20 max mana, 5% decreased mana usage,", "+20最大魔力值，减少5%魔力消耗".zh());
                    line.Text = line.Text.Replace("5% increased magic damage and magic critical strike chance", "提高5%魔法伤害和魔法暴击率".zh());
                }

                if (item.type == 761)
                {
                    line.Text = line.Text.Replace("+60 max life", "+60最大生命值".zh());
                }

                if (item.type == 1165)
                {
                    line.Text = line.Text.Replace("At night or during an eclipse, you will gain the following boosts:", "在夜晚或日食期间，你将获得以下加成：".zh());
                    line.Text = line.Text.Replace("7% increased damage and 3% increased critical strike chance", "增加7%伤害和3%暴击率".zh());
                }

                if (item.type == 785)
                {
                    line.Text = line.Text.Replace("20% increased movement speed", "提高20%移动速度".zh());
                    line.Text = line.Text.Replace("With Harpy Ring or Angel Treads equipped, most attacks sometimes launch feathers", "在装备女妖指环或天使之靴时大多数攻击会释放羽毛".zh());
                }

                if (item.type == 786)
                {
                    line.Text = line.Text.Replace("10% increased movement speed, ranged damage and critical strike chance", "穿着死灵盔甲时提高10%移动速度，提高10%远程伤害和远程暴击率".zh());
                    line.Text = line.Text.Replace("and +30 defense while wearing the Necro Armor", "提高30点防御力".zh());
                }

                if (item.type == 2770)
                {
                    line.Text = line.Text.Replace("+5 defense and 5% increased damage", "增加5防御力，提高5%伤害".zh());
                }

                if (item.type == 822)
                {
                    line.Text = line.Text.Replace("2% increased melee and ranged damage", "穿着寒霜盔甲时".zh());
                    line.Text = line.Text.Replace("and 1% increased melee and ranged critical strike chance", "提高2%近战和远程伤害".zh());
                    line.Text = line.Text.Replace("while wearing the Frost Armor", "提高1%近战和远程暴击率".zh());
                }

                if (item.type == 821)
                {
                    line.Text = line.Text.Replace("5% increased melee damage and critical strike chance", "提高5%近战伤害和近战暴击率".zh());
                }

                if (item.type == 823)
                {
                    line.Text = line.Text.Replace("+10 defense and 5% increased damage reduction while wearing the Spectre Hood set", "穿着幽灵盔甲配幽灵兜帽时提高10防御力和5%减伤".zh());
                    line.Text = line.Text.Replace("5% increased magic damage and critical strike chance while wearing the Spectre Mask set", "穿着幽灵盔甲配幽灵面具时提高5%魔法伤害和魔法暴击率".zh());
                }

                if (item.type == 2280)
                {
                    line.Text = line.Text.Replace("+10 defense and 5% increased damage reduction while wearing the Beetle Shell set", "穿着甲虫盔甲配甲虫壳时增加10防御力和5%减伤".zh());
                    line.Text = line.Text.Replace("5% increased melee damage and critical strike chance while wearing the Beetle Scale Mail set", "穿着甲虫盔甲配甲虫铠甲时提高5%近战伤害和近战暴击率".zh());
                }

                if (item.type == 1866)
                {
                    line.Text = line.Text.Replace("10% increased weapon-type damage while wearing the Shroomite Armor", "穿着蘑菇矿盔甲时提高10%弓、枪械、火箭发射器或火焰喷射器的伤害".zh());
                    line.Text = line.Text.Replace("The weapon type boosted matches which Shroomite helmet is worn", "加成武器类型取决于戴的蘑菇矿头盔".zh());
                }

                if (item.type == 1871)
                {
                    line.Text = line.Text.Replace("+40 max life", "+40最大生命值".zh());
                    line.Text = line.Text.Replace("Ornaments rain down as you fly", "飞行时掉落装饰品".zh());
                }

                if (item.type == 1830)
                {
                    line.Text = line.Text.Replace("Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "穿着阴森盔甲时提高召唤物击退和5%召唤伤害".zh());
                }

                if (item.type == 1797)
                {
                    line.Text = line.Text.Replace("5% increased damage and critical strike chance", "提高5%伤害和暴击率".zh());
                }

                if (item.type == 948)
                {
                    line.Text = line.Text.Replace("+8 defense, 10% increased movement speed,", "+8防御力和10%移速".zh());
                    line.Text = line.Text.Replace("4% increased damage, and 2% increased critical strike chance", "并提高4%伤害和2%暴击率".zh());
                }

                if (item.type == 3470)
                {
                    line.Text = line.Text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "穿着星云盔甲时+20最大魔力值".zh());
                    line.Text = line.Text.Replace("and 5% decreased mana usage while wearing the Nebula Armor", "提高5%魔法伤害和魔法暴击率减少5%魔力消耗".zh());
                }

                if (item.type == 3469)
                {
                    line.Text = line.Text.Replace("3% increased ranged damage and 7% increased ranged critical strike chance", "穿着星旋盔甲时".zh());
                    line.Text = line.Text.Replace("while wearing the Vortex Armor", "提高3%远程伤害和7%远程暴击率".zh());
                }

                if (item.type == 3471)
                {
                    line.Text = line.Text.Replace("10% increased minion damage while wearing the Stardust Armor", "穿着星尘盔甲时增加10%召唤伤害".zh());
                }

                if (item.type == 3468)
                {
                    line.Text = line.Text.Replace("7% increased melee damage and 3% increased melee critical strike chance", "穿着耀斑盔甲时".zh());
                    line.Text = line.Text.Replace("while wearing the Solar Flare Armor", "提高7%近战伤害和3%近战暴击率".zh());
                }

                List<int> wings = new List<int>() { 4978, 492, 493, 1162, 761, 2494, 822, 785, 748, 665, 1583, 1584, 1585, 1586, 3228, 3580, 3582, 3588, 3592, 3924, 3928, 4730, 4746, 4750, 4754, 1165, 1515, 749, 821, 823, 1866, 786, 2770, 823, 2280, 1871, 1830, 1797, 948, 3883, 4823, 2609, 3470, 3469, 3468, 3471, 4954 };
                if (wings.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Horizontal speed", "水平飞行速度".zh());
                    line.Text = line.Text.Replace("Acceleration multiplier", "加速倍率".zh());
                    line.Text = line.Text.Replace("Bad vertical speed", "糟糕的垂直飞行速度".zh());
                    line.Text = line.Text.Replace("Average vertical speed", "普通的垂直飞行速度".zh());
                    line.Text = line.Text.Replace("Good vertical speed", "不错的垂直飞行速度".zh());
                    line.Text = line.Text.Replace("Great vertical speed", "较强的垂直飞行速度".zh());
                    line.Text = line.Text.Replace("Excellent vertical speed", "优异的垂直飞行速度".zh());
                    line.Text = line.Text.Replace("Flight time", "飞行时间".zh());
                }

                List<int> grappins = new List<int>() { 84, 1236, 1237, 1238, 1239, 1240, 1241, 939, 1273, 2585, 2360, 185, 1800, 1915, 437, 3021, 3023, 3020, 3022, 2800, 1829, 1916, 3572, 3623, 4257, 4759, 4980 };
                if (grappins.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Reach", "长度".zh());
                    line.Text = line.Text.Replace("tiles", "图格".zh());
                    line.Text = line.Text.Replace("Launch Velocity", "发射速度".zh());
                    line.Text = line.Text.Replace("Reelback Velocity", "回收速度".zh());
                    line.Text = line.Text.Replace("Pull Velocity", "牵引速度".zh());
                }
                #endregion

                #region 盔甲
                if (item.type == 89 || item.type == 80 || item.type == 76)
                {
                    line.Text = line.Text.Replace("Increases all damage by", "所有伤害增加".zh());
                    line.Text = line.Text.Replace("increased movement speed", "移速增加".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                    line.Text = line.Text.Replace("5% increased damage", "伤害增加5%".zh());
                    line.Text = line.Text.Replace("3% increased critical strike chance", "暴击率增加3%".zh());
                }
                if (item.type == 123 || item.type == 124 || item.type == 125)
                {
                    line.Text = line.Text.Replace("太空枪不消耗魔力", "减少太空枪50%魔力消耗".zh());
                }
                if (item.type == 687 || item.type == 688 || item.type == 689)
                {
                    line.Text = line.Text.Replace("Increases armor penetration by 5", "增加5点护甲穿透".zh());
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                    line.Text = line.Text.Replace("4% increased critical strike chance", "暴击率增加4%".zh());
                    line.Text = line.Text.Replace("10% increased movement speed", "移速增加10%".zh());
                }
                if (item.type == 954 || item.type == 90 || item.type == 81 || item.type == 77)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by", "伤害减免".zh());
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == 690 || item.type == 691 || item.type == 692)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by", "伤害减免".zh());
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                    line.Text = line.Text.Replace("Grants immunity to knockback", "免疫击退".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == 91 || item.type == 82 || item.type == 78)
                {
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                    line.Text = line.Text.Replace("10% increased movement speed", "移速增加10%".zh());
                    line.Text = line.Text.Replace("6% increased critical strike chance", "暴击率增加6%".zh());
                    line.Text = line.Text.Replace("Two seconds after getting hit for 20 or more damage, you heal for 10", "受到20点以上的伤害两秒后，你会恢复10点生命".zh());
                    line.Text = line.Text.Replace("Getting hit again resets the timer, delaying the heal", "如果期间再受到伤害会重新计时2秒".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == 693 || item.type == 694 || item.type == 695)
                {
                    line.Text = line.Text.Replace("7% increased damage", "伤害增加7%".zh());
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                    line.Text = line.Text.Replace("10% increased movement speed", "移速增加10%".zh());
                    line.Text = line.Text.Replace("Increases your critical strike chance by 100% of the knockback of your held weapon", "根据武器的击退增加暴击率".zh());
                    line.Text = line.Text.Replace("This effect caps at Insane knockback, which gives 10% increased critical strike chance", "上限增加为10%暴击率".zh());
                    line.Text = line.Text.Replace("Increases all knockback by 33%, this counts for the above boost", "所有击退增加33%,也算".zh());
                    line.Text = line.Text.Replace("Current bonus:", "当前奖励:".zh());
                    line.Text = line.Text.Replace("critical strike chance from", "暴击率来自".zh());
                    line.Text = line.Text.Replace("knockback", "击退".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == 955 || item.type == 92 || item.type == 83 || item.type == 79)
                {
                    line.Text = line.Text.Replace("6% increased damage", "伤害增加6%".zh());
                    line.Text = line.Text.Replace("Reduces damage taken by", "伤害减免".zh());
                    line.Text = line.Text.Replace("12% increased movement speed", "移速增加12%".zh());
                    line.Text = line.Text.Replace("All enemies have a 4% chance to drop 1 gold. All bosses killed drop 3 gold", "所有敌人有4%几率掉落1金币，Boss掉落3金币".zh());
                    line.Text = line.Text.Replace("You gain 1% critical strike chance for every 5 gold in your inventory, capped at 10%", "背包中每有5金币增加1%暴击率，上限为10%".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == ItemID.PlatinumHelmet || item.type == ItemID.PlatinumChainmail || item.type == ItemID.PlatinumGreaves)
                {
                    line.Text = line.Text.Replace("6% increased damage", "伤害增加6%".zh());
                    line.Text = line.Text.Replace("5% increased critical strike chance", "暴击率增加5%".zh());
                    line.Text = line.Text.Replace("12% increased movement speed", "移速增加12%".zh());
                    line.Text = line.Text.Replace("Every 15 defense gives you +1 life regen", "每15点防御力增加1生命再生".zh());
                    line.Text = line.Text.Replace("Every 15 defense gives you 1% increased critical strike chance", "每15点防御力增加1%暴击率".zh());
                    line.Text = line.Text.Replace("These effects both cap at 45 defense", "上限45点防御".zh());
                    line.Text = line.Text.Replace("25% increased mining speed", "挖掘速度增加25%".zh());
                }
                if (item.type == 3266 || item.type == 3267 || item.type == 3268)
                {
                    line.Text = line.Text.Replace("Set Bonus:", "套装奖励：".zh());
                    line.Text = line.Text.Replace("Increases whip range by 50% and speed by 35%", "增加50%鞭子范围和35%速度".zh());
                    line.Text = line.Text.Replace("Increases minion damage by 15%", "增加15%召唤伤害".zh());
                    line.Text = line.Text.Replace("Grants immunity to fire blocks and temporary immunity to lava", "免疫火块和短暂免疫岩浆".zh());
                }
                if (item.type == 956 || item.type == 957 || item.type == 958 || item.type == 102 || item.type == 101 || item.type == 100)
                {
                    line.Text = line.Text.Replace("Set bonus:", "套装奖励：".zh());
                    line.Text = line.Text.Replace("15% increased max movement speed and acceleration", "最大移速和加速度提高15%".zh());
                    line.Text = line.Text.Replace("5% increased damage and 7% increased jump speed", "增加5%伤害和7%跳跃速度".zh());
                }
                if (item.type == 231 || item.type == 232 || item.type == 233)
                {
                    line.Text = line.Text.Replace("20% extra true melee damage", "增加20%额外真近战伤害".zh());
                    line.Text = line.Text.Replace("Grants immunity to fire blocks and temporary immunity to lava", "免疫火块和短暂免疫岩浆".zh());
                }
                if (item.type == 792 || item.type == 793 || item.type == 794)
                {
                    line.Text = line.Text.Replace("life regen", "生命再生速度".zh());
                }
                if (item.type == 3187 || item.type == 3188 || item.type == 3189)
                {
                    line.Text = line.Text.Replace("3% increased rogue damage", "增加3%盗贼伤害".zh());
                    line.Text = line.Text.Replace("3% increased rogue critical strike chance", "增加3%盗贼暴击率".zh());
                    line.Text = line.Text.Replace("3% increased rogue velocity", "增加3%盗贼弹幕速度".zh());
                    line.Text = line.Text.Replace("+3 defense", "套装效果：+3 防御力".zh());
                    line.Text = line.Text.Replace("5% increased rogue damage and 10% increased velocity", "增加5%盗贼伤害和10%盗贼弹幕速度".zh());
                    line.Text = line.Text.Replace("+60 maximum stealth", "增加60最大潜行值".zh());

                }
                if (item.type == 1001 || item.type == 1002 || item.type == 1003 || item.type == 1004 || item.type == 1005)
                {
                    line.Text = line.Text.Replace("Summons a powerful leaf crystal to shoot pulses of life every 5 seconds", "召唤叶状水晶，每5秒发射一次生命脉冲".zh());
                    line.Text = line.Text.Replace("The pulses do a base damage of 300 to enemies within its range", "脉冲对范围内的敌人造成300基础伤害".zh());
                    line.Text = line.Text.Replace("The pulses also provide a 10 health boost to you and all players on your team", "并治疗范围内的友军10点生命".zh());
                    line.Text = line.Text.Replace("Players healed by pulses cannot be healed by another pulse until 4.5 seconds have passed", "4.5秒内玩家只会受到一个水晶治疗".zh());
                    line.Text = line.Text.Replace("Both the health boost and the damage scale based on your strongest class", "伤害和治疗值均受玩家最强职业加成".zh());
                }
                if (item.type == 371 || item.type == 372 || item.type == 373 || item.type == 374 || item.type == 375)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 60", "增加60最大魔力值".zh());
                    line.Text = line.Text.Replace("10% increased max speed and acceleration", "最大移速和加速度提高10%".zh());
                    line.Text = line.Text.Replace("You gain a damage and critical strike chance boost relative to your current movement speed, up to 10%", "基于移速提高伤害和暴击率，上限10%".zh());
                }
                if (item.type == 376 || item.type == 377 || item.type == 378 || item.type == 379 || item.type == 380)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 80", "增加80最大魔力值".zh());
                    line.Text = line.Text.Replace("12% increased damage", "伤害增加12%".zh());
                    line.Text = line.Text.Replace("14% increased critical strike chance", "暴击率增加14%".zh());
                    line.Text = line.Text.Replace("Enemy hits release mythril flares, which home in on enemies after a short delay", "击中敌怪时释放秘银火焰，一段时间后会追踪敌怪".zh());
                    line.Text = line.Text.Replace("Once a flare is created, there is a 9 frame delay before another one can appear", "秘银火焰造成生成它的弹幕40%伤害，上限105点。秘银火焰生成间隔为9帧".zh());
                }
                if (item.type == 400 || item.type == 401 || item.type == 402 || item.type == 403 || item.type == 404)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 100", "增加100最大魔力值".zh());
                    line.Text = line.Text.Replace("Half of your current DR is added to your critical strike chance", "基于伤害减免的一半增加暴击率".zh());
                    line.Text = line.Text.Replace("Continuously doing damage makes you gradually gain more and more defense, up to a maximum of 30", "持续造成伤害会提升防御，至多30点".zh());
                    line.Text = line.Text.Replace("When not doing damage, this bonus gradually decays", "如果不造成伤害，增加的防御会降低".zh());
                    line.Text = line.Text.Replace("This added defense can be broken by defense damage", "也受防御损伤影响".zh());
                }
                if (item.type == 4982 || item.type == 4983 || item.type == 4984)
                {
                    line.Text = line.Text.Replace("Allows the ability to dash", "获得冲刺能力".zh());
                }
                if (item.type == 803 || item.type == 804 || item.type == 805 || item.type == 978 || item.type == 979 || item.type == 980)
                {
                    line.Text = line.Text.Replace("Multiplies all cold-based debuff damage by 1.25", "所有冷系减益对敌人多造成25%伤害".zh());
                    line.Text = line.Text.Replace("Cold enemies will deal reduced contact damage to the player", "冷系敌人对玩家造成的伤害减少".zh());
                    line.Text = line.Text.Replace("Provides immunity to the Frostburn and Glacial State debuffs", "免疫霜冻和冰河时代减益".zh());
                }
                if (item.type == 1208 || item.type == 1209)
                {
                    line.Text = line.Text.Replace("7% increased damage", "伤害增加7%".zh());
                }
                if (item.type == 1213)
                {
                    line.Text = line.Text.Replace("10% increased critical strike chance", "暴击率增加10%".zh());
                }
                if (item.type == 3776 || item.type == 3777 || item.type == 3778)
                {
                    line.Text = line.Text.Replace("The minion damage nerf is reduced while wielding magic weapons", "使用魔法武器时减少召唤伤害".zh());
                }
                if (item.type == 3800 || item.type == 3801 || item.type == 3802)
                {
                    line.Text = line.Text.Replace("10% increased minion and melee damage", "增加10%召唤和近战伤害".zh());
                    line.Text = line.Text.Replace("5% increased minion damage and melee critical strike chance", "增加5%召唤伤害和近战暴击率".zh());
                    line.Text = line.Text.Replace("15% increased movement speed", "移速增加15%".zh());
                    line.Text = line.Text.Replace("Increases your life regeneration", "增加生命再生速度".zh());
                    line.Text = line.Text.Replace("15% increased minion damage and 10% increased melee critical strike chance", "增加15%召唤伤害和10%近战暴击率".zh());
                }
                if (item.type == 3803 || item.type == 3804 || item.type == 3805)
                {
                    line.Text = line.Text.Replace("10% increased minion and ranged damage", "增加10%召唤和远程伤害".zh());
                    line.Text = line.Text.Replace("10% chance to not consume ammo", "10%几率不消耗弹药".zh());
                }
                if (item.type == 3806 || item.type == 3807 || item.type == 3808)
                {
                    line.Text = line.Text.Replace("Increases your max number of sentries by 1 and increases melee attack speed by 10%", "增加1最大哨兵栏，增加10%近战攻速".zh());
                    line.Text = line.Text.Replace("10% increased minion and melee damage", "增加10%召唤和近战伤害".zh());
                    line.Text = line.Text.Replace("5% increased minion damage and melee critical strike chance", "增加5%召唤伤害和近战暴击率".zh());
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%".zh());
                    line.Text = line.Text.Replace("10% increased melee speed, crit, and damage", "增加10%近战攻速，暴击率和伤害".zh());
                    line.Text = line.Text.Replace("15% increased minion damage", "增加15%召唤伤害".zh());
                }
                if (item.type == 3797 || item.type == 3798 || item.type == 3799)
                {
                    line.Text = line.Text.Replace("5% increased minion damage and magic critical strike chance", "增加5%召唤伤害和魔法暴击率".zh());
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%".zh());
                    line.Text = line.Text.Replace("5% increased minion damage and 15% increased magic critical strike chance", "增加5%召唤伤害和15%魔法暴击率".zh());
                }
                if (item.type == 3871 || item.type == 3872 || item.type == 3873)
                {
                    line.Text = line.Text.Replace("30% increased minion damage and increased life regeneration", "增加30%召唤伤害，提高生命再生速度".zh());
                    line.Text = line.Text.Replace("10% increased minion damage and melee critical strike chance", "增加10%召唤伤害和近战暴击率".zh());
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%".zh());
                    line.Text = line.Text.Replace("Massively increased life regeneration", "较大提高生命再生速度".zh());
                }
                if (item.type == 3880 || item.type == 3881 || item.type == 3882)
                {
                    line.Text = line.Text.Replace("Increases your max number of sentries by 2", "增加2最大哨兵栏".zh());
                    line.Text = line.Text.Replace("10% increased melee and minion damage", "增加10%召唤和近战伤害".zh());
                    line.Text = line.Text.Replace("10% increased minion damage and melee speed", "增加10%召唤伤害和近战攻速".zh());
                    line.Text = line.Text.Replace("5% increased melee critical strike chance", "(增加5%近战暴击率)".zh());
                    line.Text = line.Text.Replace("10% increased minion damage and melee critical strike chance", "增加10%召唤伤害和近战暴击率".zh());
                    line.Text = line.Text.Replace("30% increased movement speed", "(移速增加30%)".zh());
                    line.Text = line.Text.Replace("10% increased melee damage, melee critical strike chance and melee speed", "增加10%近战攻速，暴击率和伤害".zh());
                    line.Text = line.Text.Replace("30% increased minion damage", "增加30%召唤伤害".zh());
                }
                if (item.type == 3877 || item.type == 3878 || item.type == 3879)
                {
                    line.Text = line.Text.Replace("15% increased minion and ranged damage and 20% chance to not consume ammo", "增加15%召唤和远程伤害,20%几率不消耗弹药".zh());
                    line.Text = line.Text.Replace("10% increased minion and ranged damage", "增加10%召唤和远程伤害".zh());
                }
                if (item.type == 3874 || item.type == 3875 || item.type == 3876)
                {
                    line.Text = line.Text.Replace("20% increased movement speed", "(移速增加20%)".zh());
                    line.Text = line.Text.Replace("10% increased minion damage and magic critical strike chance", "增加5%召唤伤害和魔法暴击率".zh());
                    line.Text = line.Text.Replace("10% increased minion damage and 15% increased magic critical strike chance", "增加10%召唤伤害和15%魔法暴击率".zh());
                }
                #endregion

                #region 物品
                if (item.type == ItemID.SlimeCrown || item.type == ItemID.GoblinBattleStandard || item.type == ItemID.SnowGlobe || item.type == ItemID.PumpkinMoonMedallion || item.type == ItemID.NaughtyPresent || item.type == ItemID.SolarTablet || item.type == ItemID.CelestialSigil || item.type == ItemID.PirateMap || item.type == ItemID.BloodMoonStarter)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                }
                if (item.type == ItemID.SuspiciousLookingEye)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used during nighttime", "在夜晚使用".zh());
                    line.Text = line.Text.Replace("Enrages during the day", "白天会狂暴".zh());
                }
                if (item.type == ItemID.Abeemination)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used in the Jungle", "在丛林使用".zh());
                    line.Text = line.Text.Replace("Enrages outside the Underground Jungle", "在地下丛林外会狂暴".zh());
                }
                if (item.type == ItemID.BloodySpine)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used in the Crimson", "在血腥之地使用".zh());
                    line.Text = line.Text.Replace("Enrages outside the Underground Crimson", "在地下血腥外会狂暴".zh());
                }
                if (item.type == ItemID.WormFood)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used in the Corruption", "在腐化之地使用".zh());
                    line.Text = line.Text.Replace("Enrages outside the Underground Corruption", "在地下腐化外会狂暴".zh());
                }
                if (item.type == ItemID.LihzahrdPowerCell)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("to summon the Golem", "在神庙使用".zh());
                    line.Text = line.Text.Replace("Enrages outside the Jungle Temple", "在丛林神庙外会狂暴".zh());
                }
                if (item.type == ItemID.MechanicalEye || item.type == ItemID.MechanicalWorm || item.type == ItemID.MechanicalSkull)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used during nighttime", "在夜晚使用".zh());
                    line.Text = line.Text.Replace("Enrages during the day", "白天会狂暴".zh());
                }
                if (item.type == ItemID.TruffleWorm)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("Summons Duke Fishron if used as bait in the Ocean", "在海洋钓一条猪鲨".zh());
                    line.Text = line.Text.Replace("Enrages outside the Ocean", "海洋群系外会狂暴".zh());
                }
                if (item.type == ItemID.QueenSlimeCrystal)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used in the Hallow", "在神圣之地使用".zh());
                }
                if (item.type == ItemID.DeerThing)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗".zh());
                    line.Text = line.Text.Replace("when used in the Snow or Ice biome", "在雪原群系使用".zh());
                }
                if (item.type == ItemID.GuideVoodooDoll)
                {
                    line.Text = line.Text.Replace("Summons the Wall of Flesh if thrown into lava in the underworld while the Guide is alive", "向导存活时将娃娃扔进地狱的岩浆中召唤肉山".zh());
                }
                if (item.type == ItemID.ClothierVoodooDoll)
                {
                    line.Text = line.Text.Replace("While equipped, summons Skeletron when the Clothier is killed during nighttime", "装备后在夜晚杀死服饰商召唤骷髅王".zh());
                    line.Text = line.Text.Replace("Enrages during the day", "白天会狂暴".zh());
                }
                if (item.type == ItemID.MagicMirror || item.type == ItemID.IceMirror || item.type == ItemID.CellPhone || item.type == ItemID.RecallPotion)
                {
                    line.Text = line.Text.Replace("Cannot be used while you have the Boss Effects buff", "Boss战期间无法使用".zh());
                }
                if (item.type == ItemID.Ale || item.type == ItemID.Sake)
                {
                    line.Text = line.Text.Replace("Increases melee damage and speed by 10% and reduces defense by 10%", "增加10%近战伤害和攻速，减少10%防御".zh());
                }
                if (item.type == ItemID.GillsPotion)
                {
                    line.Text = line.Text.Replace("Greatly reduces breath loss in the abyss", "大大缓解深渊造成的呼吸困难".zh());
                }
                if (item.type == ItemID.BottledHoney)
                {
                    line.Text = line.Text.Replace("Grants the Honey buff for 2 minutes", "给予2分钟蜂蜜增益".zh());
                }
                if (item.type == ItemID.ArcheryPotion)
                {
                    line.Text = line.Text.Replace("20% increased arrow speed and 5% increased arrow damage", "增加20%箭矢速度和5%箭矢伤害".zh());
                }
                if (item.type == ItemID.EndurancePotion)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by 5%", "减少5%受到的伤害".zh());
                }
                if (item.type == ItemID.MagicPowerPotion)
                {
                    line.Text = line.Text.Replace("10% increased magic damage", "增加10%魔法伤害".zh());
                }
                if (item.type == ItemID.SwiftnessPotion)
                {
                    line.Text = line.Text.Replace("15% increased movement speed", "增加15%移速".zh());
                }
                if (item.type == ItemID.RodofDiscord)
                {
                    line.Text = line.Text.Replace("Teleportation is disabled while Chaos State is active", "混乱状态下禁用传送".zh());
                }
                if (item.type == ItemID.EmptyBucket)
                {
                    line.Text = line.Text.Replace("Cannot be used in the Abyss", "无法在深渊使用".zh());
                }
                if (item.type == ItemID.DD2ElderCrystal)
                {
                    line.Text = line.Text.Replace("Once placed you can right click the crystal to skip waves or increase the spawn rate of the invaders", "放置后你可以通过右键水晶跳过波数等待或加快刷怪速度".zh());
                }
                #endregion

                //偷懒
                line.Text = line.Text.Replace("Otherworldly Stone Wall", "异域石墙".zh());
                line.Text = line.Text.Replace("Eutrophic Shelf", "富养制造架".zh());
                line.Text = line.Text.Replace("Monolith Amalgam", "星幻柱综合体".zh());
                line.Text = line.Text.Replace("Profaned Crucible", "亵渎坩埚".zh());
                line.Text = line.Text.Replace("Effulgent Manipulator", "闪耀操纵机".zh());
                
                line.Text = line.Text.Replace("You have already consumed this item", "你已经使用过这个".zh());
                line.Text = line.Text.Replace("Restores", "恢复".zh());
                line.Text = line.Text.Replace("life", "生命".zh());
            }
        }
    }
}
