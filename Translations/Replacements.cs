using System;
using Terraria;
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
using CalamityMod.Items.Armor.Vanity;
using CalamityMod.Items.Armor.Victide;
using CalamityMod.Items.Armor.Wulfrum;
using CalamityMod.Items.Accessories.Vanity;
using CalamityMod.Items.Accessories.Wings;
using CalamityMod.Items.DifficultyItems;
using CalamityMod.Items.LoreItems;
using CalamityMod.Items.Placeables.Ores;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Tools;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.Items.Weapons.Summon;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.Weapons.DraedonsArsenal;
using CalamityMod.World;
using System.Collections.Generic;
using System.Linq;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;

public class CalamityGlobalItemCN : GlobalItem
{

	public CalamityGlobalItemCN()
	{
	}

	public static bool IsPortugueseLanguageActive => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);

	public override void UpdateArmorSet(Player player, string set)
	{
		if (IsPortugueseLanguageActive)
		{
			string hotkey = CalamityMod.CalamityKeybinds.SetBonusHotKey.TooltipHotkeyString();
			if (set == "AerospecMagic")
			{
				player.setBonus = "增加5%移动速度和魔法暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害";
			}
			else if (set == "AerospecRogue")
			{
				player.setBonus = "增加5%移动速度和盗贼暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害\n不攻击时累积潜行值，移动时积累较慢，最大100点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
			}
			else if (set == "AerospecMelee")
			{
				player.setBonus = "增加5%移动速度和近战暴击率\n敌人更有可能以你为目标\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害";
			}
			else if (set == "AerospecSummon")
			{
				player.setBonus = "增加11%召唤伤害，+1召唤栏\n召唤天武神保护你\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害";
			}
			else if (set == "AerospecRanged")
			{
				player.setBonus = "增加5%移动速度和远程暴击率\n一次性受到超过25点伤害会召唤追踪羽毛从天而降\n增加下落速度，免疫摔落伤害";
			}
			else if (set == "Astral")
			{
				player.setBonus = "增加5%移动速度和3个召唤栏\n增加35%伤害和25%暴击率\n每当你暴击敌人时天空会降落坠落之星，神圣新星和星幻陨星\n此效果1秒内至多触发一次";
			}
			else if (set == "AtaxiaRanged")
			{
				player.setBonus = "增加5%远程伤害\n低于50%生命值获得狱火药水的效果\n使用远程武器时每0.33秒发射一团追踪的混沌火焰\n你受伤时有20%几率在原地产生一场烈焰爆炸";
			}
			else if (set == "AtaxiaMelee")
			{
				player.setBonus = "增加5%近战伤害\n敌人更有可能以你为目标\n低于50%生命值获得狱火药水的效果\n近战攻击和弹幕在击中敌人时喷发出混沌火焰\n你受伤时有20%几率在原地产生一场烈焰爆炸";
			}
			else if (set == "AtaxiaSummon")
			{
				player.setBonus = "增加40%召唤伤害并+2召唤栏\n低于50%生命值获得狱火药水的效果\n召唤渊泉之灵保护你\n你受伤时有20%几率在原地产生一场烈焰爆炸";
			}
			else if (set == "AtaxiaRogue")
			{
				player.setBonus = "提升5%盗贼伤害\n低于50%生命值获得狱火药水的效果\n使用盗贼武器攻击时每2.5秒会在你周围召唤8团追踪敌人的混沌火焰\n你受伤时有20%几率在原地产生一场烈焰爆炸\n不攻击时累积潜行值，移动时积累较慢，最大110点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
			}
			else if (set == "AtaxiaMagic")
			{
				player.setBonus = "增加5%魔法伤害并降低15%魔力消耗\n低于50%生命值获得狱火药水的效果\n魔法攻击产生伤害火球和治疗火球\n你受伤时有20%几率在原地产生一场烈焰爆炸";
			}
			else if (set == "AuricMelee")
			{
				player.setBonus = "近战龙蒿、血炎、弑神者套装奖励\n敌人更有可能以你为目标\n弹幕击中敌人时生成圣金源光球治疗玩家";
			}
			else if (set == "AuricRanged")
			{
				player.setBonus = "远程龙蒿、血炎、弑神者套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家";
			}
			else if (set == "AuricRogue")
			{
				player.setBonus = "盗贼龙蒿、血炎、弑神者套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n不攻击时累积潜行值，移动时积累较慢，最大130点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
			}
			else if (set == "AuricSummon")
			{
				player.setBonus = "召唤龙蒿、血炎、始源林海套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n增加5%最大奔跑速度和加速度\n+6召唤栏和75%召唤伤害";
			}
			else if (set == "AuricMagic")
			{
				player.setBonus = "魔法龙蒿、血炎、始源林海套装奖励\n弹幕击中敌人时生成圣金源光球治疗玩家\n增加5%最大奔跑速度和加速度";
			}
			else if (set == "BloodflareRogue")
			{
				player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n生命值高于80%时增加30点防御和5%盗贼伤害\n生命值低于80%时增加10%盗贼伤害\n盗贼武器暴击有50%几率治疗你\n不攻击时累积潜行值，移动时积累较慢，最大120点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
			}
			else if (set == "BloodflareSummon")
			{
				player.setBonus = "增加50%召唤伤害,+3召唤栏\n大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n召唤环绕你的幽魂雷\n生命值高于90%时增加10%召唤伤害\n生命值小于或等于50%及时获得20点防御和2点生命再生速度";
			}
			else if (set == "BloodflareRanged")
			{
				player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n按下 " + hotkey + " 键释放噬魂幽花的冤魂摧毁你的敌人\n此效果有30秒冷却时间\n远程武器每2.5秒发射出一个爆炸血炎珠";
			}
			else if (set == "BloodflareMagic")
			{
				player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n魔法武器每1.67秒会发射一个灵魂束\n魔法武器暴击产生火焰爆炸，两秒钟内至多触发一次";
			}
			else if (set == "BloodflareMelee")
			{
				player.setBonus = "大幅增加生命再生速度\n击中一个生命值低于50%的敌人会掉落红心\n击这个效果有5秒冷却时间\n血月期间击杀的敌人掉落血珠的概率大幅提高\n真近战攻击会治疗你\n使用真近战武器攻击敌人15次后进入鲜血狂怒状态，持续5秒\n此期间增加25%近战伤害和暴击率，来自敌人的接触伤害减半\n此效果有30秒冷却时间";
			}
			else if (set == "Brimflame")
			{
				player.setBonus = "额外增加15%的魔法伤害和暴击率\n按 " + hotkey + " 键进入硫火狂暴模式\n在此模式下，你造成的伤害会显著增加\n然而你的生命会快速流失，魔力值恢复速度归零\n此状态可以手动关闭\n硫火狂暴有30秒的冷却时间";
			}
			else if (set == "DaedalusMagic")
			{
				player.setBonus = "增加5%魔法伤害\n你有10%的几率吸收一次物理伤害或弹幕\n如果你成功吸收了一次攻击，你将回复相当于那次攻击的伤害值二分之一的生命值";
			}
			else if (set == "DaedalusSummon")
			{
				player.setBonus = "增加20%召唤伤害，+2召唤栏\n召唤悬浮的代达罗斯水晶保护你";
			}
			else if (set == "DaedalusMelee")
			{
				player.setBonus = "增加5%近战伤害\n敌人更有可能以你为目标\n你能够反弹弹幕\n被反弹的弹幕只会对你造成50%的伤害\n反弹效果有90秒内置冷却，冷却时间和其它效果类似的物品共享";
			}
			else if (set == "DaedalusRanged")
			{
				player.setBonus = "增加5%远程伤害\n被击中时释放出水晶碎片";
			}
			else if (set == "DaedalusRogue")
			{
				player.setBonus = "增加5%盗贼伤害\n盗贼弹幕飞行时释放水晶碎片\n不攻击时累积潜行值，移动时积累较慢，最大105点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
			}
			else if (set == "Demonshade")
			{
				player.setBonus = "增加100%召唤伤害，+10召唤栏\n所有攻击造成恶魔之炎减益\n受伤时发射暗影射线和恶魔镰刀\n召唤一只友善的红恶魔为你战斗\n按 " + hotkey + " 键以黑魔法咒语激怒周围的敌人\n这道咒语使他们对你额外造成25%伤害，同时额外受到125%伤害";
			}
			else if (set == "DesertProwler")
			{
				player.setBonus = "额外增加1点远程伤害\n远程伤害暴击时有几率在击中敌人的位置释放一束沙龙卷";
			}
			else if (set == "FathomSwarmer")
			{
				player.setBonus = "增加10%召唤伤害，+2召唤栏\n获得爬墙的能力\n浸没在液体中时增加30%召唤伤害\n在深渊中提供适量光照，一定程度减缓深渊中呼吸条消耗速度";
			}
			else if (set == "Fearmonger")
			{
				player.setBonus = "增加20%召唤伤害，+2召唤栏\n使用其他职业武器时的召唤伤害惩罚从降低50%召唤伤害变成降低25%召唤伤害\n免疫一切霜、火相关的减益\n召唤物攻击敌人会使你获得极高的生命再生速度\n在南瓜月和霜月事件期间获得15%伤害减免\n这15%伤害减免无视减伤率软上限";
			}
			else if (set == "ForbiddenCalam")
			{
				int stormMana = (int)(60f * player.manaCost);
				player.setBonus = "按下 " + hotkey + " 键可在光标位置处召唤一个远古风暴\n远古风暴消耗 " + stormMana + " 魔力值并且同时受到召唤和盗贼伤害增益\n盗贼潜伏攻击命中会召唤追踪的禁戒吞噬者\n即使拿着盗贼武器，仆从也会造成全额伤害\n盗贼和召唤攻击会随着更高的加成而减少（Rogue and summon attacks will scale off of the stat with a higher boost）\n不攻击时累积潜行值，移动时积累较慢，最大40点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            if (set == "GemTech")
            {
                player.setBonus = "红色宝石给予130最大潜行值，增加盗贼属性，并让非盗贼武器不消耗潜行值\n黄色宝石增加近战属性，让近战攻击释放宝石碎片。真近战攻击释放宝石碎片的冷却时间更少\n绿色宝石增加远程属性，并召唤飞镖弹快速向被远程弹幕击中的敌人飞去\n蓝色宝石给予4最大召唤栏，增加召唤伤害，并减少手持非召唤武器的召唤伤害降低惩罚\n紫色宝石给予100最大魔力值，增加魔法属性，并在你手持非魔法武器时为你快速回复魔力\n粉色基础宝石给予75防御，增加免伤、移动速度和跳跃速度，+2生命回复\n六个宝石碎片缓缓绕着你旋转；其中五个对应五个职业，还有一个基础宝石\n如果一次受到超过100的伤害，你会损失一个宝石。失去的宝石对应你最近一次使用的武器的职业\n如果你已经损失了那个宝石，那么这次失去的将会是基础宝石\n宝石在损失时会破碎，并向最近的敌人或boss飞去，造成40000基础伤害\n破碎的宝石需要30秒来重新凝聚\n如果所有宝石同时存在，用任何武器击中敌人会提供持续8秒的2点生命回复\n如果在这{1}秒内，你使用了另一职业的武器超过2.5秒，增加的生命回复会变成3点";
            }
            else if (set == "GodSlayerMelee")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkey + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n敌人更有可能以你为目标\n一次性受到超过80点伤害使你放出一群高伤害的弑神飞镖\n敌人碰到你时受到大量伤害\n如果一次攻击将对你造成少于80点伤害，则它改为对你造成1点伤害";
            }
            else if (set == "GodSlayerRanged")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkey + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n的远程武器射击时每2.5秒发射一枚弑神榴霰弹";
            }
            else if (set == "GodSlayerRogue")
            {
                player.setBonus = "允许你进行一次距离极长的能够选择八个方向的冲刺\n当你按着控制角色移动的按键的同时按 " + hotkey + " 键可以进行指定方向的冲刺\n被冲刺撞到的敌人会受到极高的碰撞伤害\n在冲刺过程中你免疫绝大多数减益\n弑神者冲刺有35秒冷却时间\n生命值全满时所有盗贼属性增加10%\n如果一次攻击对你造成了超过80伤害，你获得额外的无敌帧\n不攻击时累积潜行值，移动时积累较慢，最大120点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害，暴击率，移动速度越高";
            }
            else if (set == "Mollusk")
            {
                player.setBonus = "两只贝壳会在战斗中助你一臂之力\n增加10%伤害\n水平移动速度降低";
            }
            else if (set == "OmegaBlue")
            {
                player.setBonus = "增加15点护甲穿透\n增加10%伤害和暴击率，增加2召唤栏\n触手会攻击附近的敌人，偷取生命治疗你\n按 " + hotkey + " 键进入深渊狂乱状态5秒\n深渊狂乱状态会增加你的伤害和暴击率，同时触手的攻击性和攻击范围也会提升\n此效果有25秒冷却时间";
            }
            else if (set == "PlaguebringerSummon")
            {
                player.setBonus = "获得瘟疫冲刺，使敌怪被瘟疫折磨\n召唤一个小瘟疫使者来保护你，并增强附近的召唤物\n+3召唤栏";
            }
            else if (set == "PlaguebringerRanged")
            {
                player.setBonus = "减少25%弹药消耗率，增加5%飞行时间\n受瘟疫减益作用的敌人会额外受到10%远程伤害\n受到伤害会使瘟疫残渣从天而降\n按 " + hotkey + " 键使自己在5秒钟内失去视野，但大幅增加远程伤害\n此效果有25秒冷却时间";
            }
            else if (set == "Prismatic")
            {
                player.setBonus = "最大魔力值增加40，魔力消耗减少15%\n提高魔力再生速度\n按 " + hotkey + " 键在鼠标位置召唤一轮死亡激光，持续5秒\n这个技能有30秒冷却";
            }
            else if (set == "ReaverRogue")
            {
                player.setBonus = "令附近的宝藏闪闪发光\n提升物品拾取距离和物块放置距离\n在水下挖掘物块时恢复氧气\n召唤一个掠夺者毒球照亮周围区域\n降低敌人的进攻性，即便身处深渊\n在深渊中提供微量光照";
            }
            else if (set == "ReaverMelee")
            {
                player.setBonus = "+10防御力并+3生命恢复\n敌人更有可能以你为目标\n受到持续性伤害减益时的生命恢复损失降低20%\n你的任何攻击都有小概率具有生命偷取效果并且增加生命恢复速度\n减少20%的移动速度与飞行时间\n敌人会受到你的反伤，并且你被击中时召唤一束荆棘伤害敌人\n当你受伤时有25%的几率获得掠夺者之怒增益";
            }
            else if (set == "ReaverRanged")
            {
                player.setBonus = "免疫摔落伤害并允许连续跳跃\n增加10%飞行时间和水平飞行速度\n钩爪的射速和牵引速度增加10%\n降低冲刺类效果的冷却时间";
            }
            else if (set == "ShroomiteCalam")
            {
                player.setBonus = "站立不动进入射手潜行状态";
            }
            else if (set == "SilvaSummon")
            {
                player.setBonus = "增加65%召唤伤害，+5召唤栏\n所有弹幕击中敌人时生成林海光球治疗你\n增加5%最大奔跑速度和加速度\n如果你的生命值将要降至1以下，则你在8秒钟内不会因为受伤而死亡\n这个效果有5分钟冷却时间，冷却时间不会在Boss存在或事件时期计时\n召唤始源林海水晶轰击你的敌人";
            }
            else if (set == "SilvaMagic")
            {
                player.setBonus = "所有弹幕击中敌人时生成林海光球治疗你\n增加5%最大奔跑速度和加速度\n如果你的生命值将要降至1以下，则你在8秒钟内不会因为受伤而死亡\n这个效果有5分钟冷却时间，冷却时间不会在Boss存在或事件时期计时\n不能穿透的魔法弹幕击中敌人后有几率产生强大的自然能量爆炸";
            }
            else if (set == "SnowRuffian")
            {
                player.setBonus = "增加5%盗贼伤害\n你可以缓降以消除坠落伤害\n不攻击时累积潜行值，移动时积累较慢，最大50点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "StatigelMagic")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度";
            }
            else if (set == "StatigelRanged")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度";
            }
            else if (set == "StatigelMelee")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度";
            }
            else if (set == "StatigelSummon")
            {
                player.setBonus = "增加18%召唤伤害，+1召唤栏\n召唤史莱姆之神宝宝为你而战, 它的种类取决于世界邪恶类型\n当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度";
            }
            else if (set == "StatigelRogue")
            {
                player.setBonus = "当你一次性受到超过100点伤害时，获得额外的无敌帧\n增加跳跃高度，并获得一段额外跳跃\n增加12%跳跃速度\n不攻击时累积潜行值，移动时积累较慢，最大100点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "Sulfur")
            {
                player.setBonus = "攻击敌人或被敌人攻击时对其造成中毒减益\n获得一段额外跳跃，跳跃时生成硫磺泡泡\n增加水下移动力，降低硫磺海水的威胁性\n不攻击时累积潜行值，移动时积累较慢，最大95点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "TarragonMelee")
            {
                player.setBonus = "增加红心拾取范围\n敌人死亡时有几率掉落更多心\n敌人更有可能以你为目标\n在受到伤害时你有25%几率获得生命再生的增益\n按 " + hotkey + " 键将自己以生命的能量包裹，大大降低你受到的接触伤害，持续10秒\n此效果有30秒冷却时间";
            }
            else if (set == "TarragonRogue")
            {
                player.setBonus = "降低刷怪率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n使用盗贼武器暴击敌人25次后你会获得3秒无敌时间\n此效果30秒内只能发动一次\n若你受到减益影响，则提升10%暴击率\n不攻击时累积潜行值，移动时积累较慢，最大115点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "TarragonSummon")
            {
                player.setBonus = "增加50%召唤伤害，+3召唤栏\n降低敌怪生成率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n召唤围绕你的生命光环，对敌人造成伤害";
            }
            else if (set == "TarragonMagic")
            {
                player.setBonus = "降低刷怪率\n增加红心拾取范围\n敌人死亡时有几率掉落更多心\n每五次暴击时发射叶片风暴\n魔法弹幕击中敌人时有50%几率治疗你\n治疗量取决于弹幕造成的伤害";
            }
            else if (set == "TarragonRanged")
            {
                player.setBonus = "降低刷怪率\n增加心拾取范围\n敌人死亡时有几率掉落更多心\n远程弹幕在因击中敌人而消失时有几率分裂为生命能量";
            }
            else if (set == "TitanHeart")
            {
                player.setBonus = "增加15%盗贼伤害和击退\n潜伏攻击会造成两倍的击退并产生幻星爆炸\n获得击退免疫\n不攻击时累积潜行值，移动时积累较慢，最大100点。\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击。\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害，暴击率，移动速度越高。";
            }
            else if (set == "Umbraphile")
            {
                player.setBonus = "盗贼武器击中敌人时概率产生爆炸\n暴击总是产生爆炸\n半影药剂总是发挥最大功效（增加30%潜行值积累速度）\n不攻击时累积潜行值，移动时积累较慢，最大110点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "VictideRogue")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%盗贼伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度\n不攻击时累积潜行值，移动时积累较慢，最大90点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "VictideMelee")
            {
                player.setBonus = "敌人更有可能以你为目标\n在水中时增加3点生命再生速度和10%近战伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度";
            }
            else if (set == "VictideSummon")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%召唤伤害\n召唤一只海胆为你而战\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度\n+1召唤栏";
            }
            else if (set == "VictideMagic")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%魔法伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度";
            }
            else if (set == "VictideRanged")
            {
                player.setBonus = "在水中时增加3点生命再生速度和10%远程伤害\n使用任何武器时都有10%几率发射回旋贝壳弹幕\n贝壳造成真实伤害，不受任何职业伤害加成影响\n提高水下灵活性，稍微减缓深渊中呼吸条消耗速度";
            }
            else if (set == "WulfrumRanged")
            {
                player.setBonus = "增加3点防御力\n低于50%生命值时增加5点防御力";
            }
            else if (set == "WulfrumMelee")
            {
                player.setBonus = "敌人更有可能以你为目标\n增加3点防御力\n低于50%生命值时增加5点防御力";
            }
            else if (set == "WulfrumSummon")
            {
                player.setBonus = "增加3点防御力，+1召唤栏\n低于50%生命值时增加5点防御力";
            }
            else if (set == "WulfrumMagic")
            {
                player.setBonus = "增加3点防御力\n低于50%生命值时增加5点防御力";
            }
            else if (set == "WulfrumRogue")
            {
                player.setBonus = "增加3点防御力\n低于50%生命值时增加5点防御力\n不攻击时累积潜行值，移动时积累较慢，最大50点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            else if (set == "Xeroc")
            {
                player.setBonus = "增加9%盗贼伤害和盗贼弹幕飞行速度\n盗贼弹幕击中敌人产生特殊效果\n受伤时受到来自宇宙的怒火加持\n不攻击时累积潜行值，移动时积累较慢，最大115点\n一旦你的潜行值满，下一次盗贼攻击可施展潜伏攻击\n盗贼潜行值只在攻击时下降，移动时不会下降\n潜行值越高，你的盗贼伤害、暴击率、移动速度越高";
            }
            //原版
            else if (set == "SpectreHeal")
            {
                player.setBonus = "魔法伤害减少20%并将其转化为治愈力\n对敌人造成的魔法伤害将治疗生命值最低的玩家";
            }
		}
    }

	public override string IsArmorSet(Item head, Item body, Item legs)
	{
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
		if (head.type == ModContent.ItemType<ForbiddenCirclet>() && body.type == 3777 && legs.type == 3778)
		{
			return "ForbiddenCalam";
		}
		if (head.type == ModContent.ItemType<GemTechHeadgear>() && body.type == ModContent.ItemType<GemTechBodyArmor>() && legs.type == ModContent.ItemType<GemTechSchynbaulds>())
		{
			return "GemTech";
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
			return "ReaverMelee";
		}
		if (head.type == ModContent.ItemType<ReaverHeadMobility>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverRanged";
		}
		if (head.type == ModContent.ItemType<ReaverHeadExplore>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
		{
			return "ReaverRogue";
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
		if (head.type == ModContent.ItemType<WulfrumHeadRanged>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRanged";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadMelee>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMelee";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadSummon>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumSummon";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadMagic>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumMagic";
		}
		if (head.type == ModContent.ItemType<WulfrumHeadRogue>() && body.type == ModContent.ItemType<WulfrumArmor>() && legs.type == ModContent.ItemType<WulfrumLeggings>())
		{
			return "WulfrumRogue";
		}
		if (head.type == ModContent.ItemType<EmpyreanMask>() && body.type == ModContent.ItemType<EmpyreanCloak>() && legs.type == ModContent.ItemType<EmpyreanCuisses>())
		{
			return "Xeroc";
		}
		//原版
		if (head.type == ItemID.SpectreHood && body.type == ItemID.SpectreRobe && legs.type == ItemID.SpectrePants)
		{
			return "SpectreHeal";
		}
		return "";
	}
	public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
	{
	    foreach (TooltipLine line in tooltips)
		{
			if (item.type == ModContent.ItemType<Eternity>())
			{
				line.Text = line.Text.Replace("There's pictures of ponies in the book", "书内有张小马图片");
			}
			
			if (item.type == ModContent.ItemType<CosmicWorm>())
			{
				line.Text = line.Text.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "警告！某些神之仆从并没有被真正的打败，在这场战斗中他们会全力以赴！");
				line.Text = line.Text.Replace("Not consumable", "不消耗");
			}
			
			if (item.type == ModContent.ItemType<HadalStew>())
			{
				line.Text = line.Text.Replace("Only gives 37 seconds of Potion Sickness", "只造成37秒的药水疾病减益");
			}
			
			if (item.type == ModContent.ItemType<RevengeanceModeItem>())
			{
				line.Text = line.Text.Replace("Enables the Rage mechanic. When Rage is maxed press", "启用怒气机制。当怒气值满了的时候按下");
				line.Text = line.Text.Replace("to activate Rage Mode.", "键来激活暴怒模式");
				line.Text = line.Text.Replace("Enables the Adrenaline mechanic. When Adrenaline is maxed press", "启用肾上腺素机制。当肾上腺素值满了的时候按下");
				line.Text = line.Text.Replace("to activate Adrenaline Mode.", "键来激活肾上腺素");
			}
			
			if (item.type == ModContent.ItemType<SpectralVeil>())
			{
				string hotkeySpecVeil = CalamityMod.CalamityKeybinds.SpectralVeilHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeySpecVeil + " to consume 25% of your maximum stealth to perform a mid-range teleport and render you momentarily invulnerable", "按下 " + hotkeySpecVeil + " 消耗25%最大潜行值，向鼠标方向进行中距离传送");
			}
			
			if (item.type == ModContent.ItemType<SandCloak>())
			{
				string hotkeySand = CalamityMod.CalamityKeybinds.SandCloakHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeySand + " to consume 25% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", "按下 " + hotkeySand + " 消耗25%最大潜行值，召唤一个围绕你的破坏性沙漠龙卷持续15秒，并提供6点防御和+2生命恢复");
			}
			
			if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
			{
				line.Text = line.Text.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "这块水晶中的魂魄被至尊女巫的强大魔力污染了");
				line.Text = line.Text.Replace("The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations", "这块水晶中的魂魄被危险的机械造物发出的能量波干扰了");
				line.Text = line.Text.Replace("Merchants will reject a defiled soul such as this.", "商人会拒绝收购这样一个被玷污的魂魄");
				line.Text = line.Text.Replace("Transforms Magic attacks into a powerful splitting fireball for", "将魔法攻击转换为强力分裂火球，每次消耗");
				line.Text = line.Text.Replace("mana per cast", "点魔力值");
			}
			
			if (item.type == ModContent.ItemType<PlaguedFuelPack>())
			{
				string plagueHotkey = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + plagueHotkey + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", "按下 " + plagueHotkey + " 键消耗25%最大潜行值并快速斜向上喷射\n并在沿途留下大量瘟疫毒云");
			}
			
			if (item.type == ModContent.ItemType<Nanotech>() || item.type == ModContent.ItemType<RaidersTalisman>())
			{
				line.Text = line.Text.Replace("Rogue Crit Level:", "当前堆叠等级：");
			}
			
			if (item.type == ModContent.ItemType<MomentumCapacitor>())
			{
				string hotkeyCapacitor = CalamityMod.CalamityKeybinds.MomentumCapacitatorHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyCapacitor + " to consume 30% of your maximum stealth to create an energy field at the cursor position", "	按下 " + hotkeyCapacitor + " 键消耗最大潜行值的30%，在光标位置创建一个能量场");
			}
			
			if (item.type == ModContent.ItemType<CelestialJewel>())
			{
				string hotkeyCelestial = CalamityMod.CalamityKeybinds.AstralTeleportHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyCelestial + " to teleport to a random location while no bosses are alive", "没有boss存活时按下 " + hotkeyCelestial + " 键进行随机传送");
			}

			if (item.type == ModContent.ItemType<BlunderBooster>())
			{
				string hotkeyBlunder = CalamityMod.CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyBlunder + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", "按下 " + hotkeyBlunder + " 键消耗你盗贼潜行值的25%来向左上/右上方冲刺并留下追踪闪电");
			}

			if (item.type == ModContent.ItemType<AstralArcanum>())
			{
				string hotkeyArcanum = CalamityMod.CalamityKeybinds.AstralArcanumUIHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyArcanum + " to toggle teleportation UI", "按下 " + hotkeyArcanum + " 键可以打开传送UI");
			}

			if (item.type == ModContent.ItemType<AsgardianAegis>() || item.type == ModContent.ItemType<ElysianAegis>())
			{
				string hotkeyAsgard = CalamityMod.CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyAsgard + " to activate buffs to all damage, crit chance, and defense", "按下 " + hotkeyAsgard + " 键获得增加伤害、暴击率和防御的增益");
			}

			if (item.type == ModContent.ItemType<NormalityRelocator>())
			{
				string hotkeyReloc = CalamityMod.CalamityKeybinds.NormalityRelocatorHotKey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Press " + hotkeyReloc + " to teleport to the position of the mouse", "按下 " + hotkeyReloc + " 传送至鼠标位置");
			}

			if (item.type == ModContent.ItemType<MagicLevelMeter>())
			{
				line.Text = line.Text.Replace("Tells you how high your magic proficiency is", "显示你的魔法熟练度");
				line.Text = line.Text.Replace("While equipped you will gain magic proficiency faster", "装备此物品的时候更快地获得熟练度");
				line.Text = line.Text.Replace("The higher your magic level the higher your magic damage, critical strike chance, and the lower your mana cost", "魔法等级影响伤害和暴击率、降低魔力值消耗");
				line.Text = line.Text.Replace("Magic proficiency (max of 12500):", "魔法熟练度（最大值12500）：");
				line.Text = line.Text.Replace("Magic level (max of 15):", "魔法等级（最大15）：");
				line.Text = line.Text.Replace("Magic damage increase:", "魔法伤害提升：");
				line.Text = line.Text.Replace("Mana usage decrease:", "魔力值消耗降低：");
				line.Text = line.Text.Replace("Magic crit increase:", "魔法暴击率提升：");
			}
			if (item.type == ModContent.ItemType<MeleeLevelMeter>())
			{
				line.Text = line.Text.Replace("Tells you how high your melee proficiency is", "显示你的近战熟练度");
				line.Text = line.Text.Replace("While equipped you will gain melee proficiency faster", "装备此物品的时候更快地获得熟练度");
				line.Text = line.Text.Replace("The higher your melee level the higher your melee damage, speed, and critical strike chance", "近战等级影响伤害、攻击速度和暴击率");
				line.Text = line.Text.Replace("Melee proficiency (max of 12500):", "近战熟练度（最大值12500）：");
				line.Text = line.Text.Replace("Melee level (max of 15):", "近战等级（最大15）：");
				line.Text = line.Text.Replace("Melee damage increase:", "近战伤害提升：");
				line.Text = line.Text.Replace("Melee speed increase:", "近战攻速提升：");
				line.Text = line.Text.Replace("Melee crit increase:", "近战暴击率提升：");
			}
			if (item.type == ModContent.ItemType<RangedLevelMeter>())
			{
				line.Text = line.Text.Replace("Tells you how high your ranged proficiency is", "显示你的远程熟练度");
				line.Text = line.Text.Replace("While equipped you will gain ranged proficiency faster", "装备此物品的时候更快地获得熟练度");
				line.Text = line.Text.Replace("The higher your ranged level the higher your ranged damage, critical strike chance, and movement speed", "远程等级影响移动速度、伤害和暴击率");
				line.Text = line.Text.Replace("Ranged proficiency (max of 12500):", "远程熟练度（最大值12500）：");
				line.Text = line.Text.Replace("Ranged level (max of 15):", "远程等级（最大15）：");
				line.Text = line.Text.Replace("Ranged damage increase:", "远程伤害提升：");
				line.Text = line.Text.Replace("Movement speed increase:", "移动速度提升：");
				line.Text = line.Text.Replace("Ranged crit increase:", "远程暴击率提升：");
			}
			if (item.type == ModContent.ItemType<RogueLevelMeter>())
			{
				line.Text = line.Text.Replace("Tells you how high your rogue proficiency is", "显示你的盗贼熟练度");
				line.Text = line.Text.Replace("While equipped you will gain rogue proficiency faster", "装备此物品的时候更快地获得熟练度");
				line.Text = line.Text.Replace("The higher your rogue level the higher your rogue damage, critical strike chance, and velocity", "盗贼等级影响弹幕速度、伤害和暴击率");
				line.Text = line.Text.Replace("Rogue proficiency (max of 12500):", "盗贼熟练度（最大值12500）：");
				line.Text = line.Text.Replace("Rogue level (max of 15):", "盗贼等级（最大15）：");
				line.Text = line.Text.Replace("Rogue damage increase:", "盗贼伤害提升：");
				line.Text = line.Text.Replace("Rogue velocity increase:", "盗贼弹幕速度提升：");
				line.Text = line.Text.Replace("Rogue crit increase:", "盗贼暴击率提升：");
			}
			if (item.type == ModContent.ItemType<SummonLevelMeter>())
			{
				line.Text = line.Text.Replace("Tells you how high your summon proficiency is", "显示你的召唤熟练度");
				line.Text = line.Text.Replace("While equipped you will gain summon proficiency faster", "装备此物品的时候更快地获得熟练度");
				line.Text = line.Text.Replace("The higher your summon level the higher your minion damage, knockback, and slots", "召唤等级影响召唤栏位数量、伤害和击退");
				line.Text = line.Text.Replace("Summon proficiency (max of 12500):", "召唤熟练度（最大值12500）：");
				line.Text = line.Text.Replace("Summon level (max of 15):", "召唤等级（最大15）：");
				line.Text = line.Text.Replace("Minion damage increase:", "召唤物伤害提升：");
				line.Text = line.Text.Replace("Minion knockback increase:", "召唤物击退提升：");
				line.Text = line.Text.Replace("Minion slot increase:", "召唤物栏提升：");
			}
			if (item.type == ModContent.ItemType<StatMeter>())
			{
				line.Text = line.Text.Replace("Displays almost all player stats", "显示你绝大部分属性的具体数据");
				line.Text = line.Text.Replace("Offensive stats displayed vary with held item", "攻击数据可能会随着手持的物品而变化");
				line.Text = line.Text.Replace("Adrenaline Damage Boost:", "肾上腺素伤害加成：");
				line.Text = line.Text.Replace("Adrenaline DR Boost:", "肾上腺素伤害减免加成：");
				line.Text = line.Text.Replace("Rage Damage Boost:", "愤怒模式伤害加成：");
				line.Text = line.Text.Replace("Melee Damage:", "近战伤害加成：");
				line.Text = line.Text.Replace("True Melee Damage:", "真近战伤害加成：");
				line.Text = line.Text.Replace("True Danos por ataque físico:", "真实伤害:");
				line.Text = line.Text.Replace("Melee Crit Chance:", "近战暴击率：");
				line.Text = line.Text.Replace("Melee Speed Boost:", "近战攻速加成：");
				line.Text = line.Text.Replace("Ranged Damage:", "远程伤害加成：");
				line.Text = line.Text.Replace("Ranged Crit Chance:", "远程暴击率：");
				line.Text = line.Text.Replace("Ammo Consumption Chance:", "弹药消耗率：");
				line.Text = line.Text.Replace("Magic Damage:", "魔法伤害加成：");
				line.Text = line.Text.Replace("Magic Crit Chance:", "魔法暴击率：");
				line.Text = line.Text.Replace("Mana Usage:", "魔力值消耗：");
				line.Text = line.Text.Replace("Mana Regen:", "魔力值恢复速度：");
				line.Text = line.Text.Replace("Minion Damage:", "召唤伤害加成：");
				line.Text = line.Text.Replace("Minion Slots:", "召唤栏位数量：");
				line.Text = line.Text.Replace("Rogue Damage:", "盗贼伤害加成：");
				line.Text = line.Text.Replace("Rogue Crit Chance:", "盗贼暴击率：");
				line.Text = line.Text.Replace("Rogue Velocity Boost:", "盗贼弹幕飞行速度提升：");
				line.Text = line.Text.Replace("Rogue Weapon Consumption Chance:", "盗贼消耗性武器消耗率：");
				line.Text = line.Text.Replace("Max Stealth:", "最大潜行值：");
				line.Text = line.Text.Replace("Standing Regen:", "站定恢复速度：");
				line.Text = line.Text.Replace("Moving Regen:", "移动时恢复速度：");
				line.Text = line.Text.Replace("Defense:", "防御力：");
				line.Text = line.Text.Replace("DR:", "伤害减免：");
				line.Text = line.Text.Replace("Life Regen:", "生命再生速度：");
				line.Text = line.Text.Replace("Armor Penetration:", "护甲穿透：");
				line.Text = line.Text.Replace("Wing Flight Time:", "飞行时间：");
				line.Text = line.Text.Replace("seconds", "秒");
				line.Text = line.Text.Replace("Jump Speed Boost:", "跳跃速度：");
				line.Text = line.Text.Replace("Movement Speed Boost:", "移速提升：");
				line.Text = line.Text.Replace("Abyss/Cave Light Strength:", "深渊/洞穴光照强度：");
				line.Text = line.Text.Replace("Abyss Light Strength:", "深渊光照强度：");
				line.Text = line.Text.Replace("Other Abyss stats are only displayed while in the Abyss", "其他深渊状态数据只有身处深渊才会显示");
				line.Text = line.Text.Replace("Other Abyss Stats:", "其他深渊属性：");
				line.Text = line.Text.Replace("Breath Lost Per Tick:", "呼吸条消耗速率：");
				line.Text = line.Text.Replace("Breath Loss Rate:", "呼吸困难程度：");
				line.Text = line.Text.Replace("Life Lost Per Tick at Zero Breath:", "呼吸条耗尽后生命流失速度：");
				line.Text = line.Text.Replace("Defense Lost:", "防御削减：");
			}
			if (item.type == ModContent.ItemType<ExoThrone>())
			{
				string hotkeySpeedUp = CalamityMod.CalamityKeybinds.ExoChairSpeedupHotkey.TooltipHotkeyString();
				string hotkeySlowDown = CalamityMod.CalamityKeybinds.ExoChairSlowdownHotkey.TooltipHotkeyString();
				line.Text = line.Text.Replace("Hold " + hotkeySpeedUp + " while sitting in the throne to move much faster", "按住 " + hotkeySpeedUp + " 键将会飞得更快");
				line.Text = line.Text.Replace("And hold " + hotkeySlowDown + " to move much slower", "按住 " + hotkeySlowDown + " 键将会飞得更慢");
			}
			if (item.type == ModContent.ItemType<ShatteredCommunity>())
			{
				line.Text = line.Text.Replace("Current level:", "当前等级：");
				line.Text = line.Text.Replace("Rage Mode damage", "暴怒模式伤害");
				line.Text = line.Text.Replace("Progress to next level:", "距离下一等级：");
				line.Text = line.Text.Replace("Total Rage Mode damage:", "暴怒模式总伤害：");
			}
			if (item.type == ModContent.ItemType<BrokenBiomeBlade>())
			{
				line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：");
				line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：:");
				line.Text = line.Text.Replace("Pure Clarity", "纯粹的清澈");
				line.Text = line.Text.Replace("Biting Embrace", "凛冽的怀抱");
				line.Text = line.Text.Replace("Arid Grandeur", "干涸的堂皇");
				line.Text = line.Text.Replace("Decay's Retort", "朽者的反击");
				line.Text = line.Text.Replace("Grovetender's Touch", "林妖的鞭笞");
				line.Text = line.Text.Replace("None", "无");
				line.Text = line.Text.Replace("Does nothing..yet", "没有用处……还没有");
				line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出脆弱的弹幕，撕裂敌人护甲");
				line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "使用冰川凝造之刃进行三连击剑技。最终一剑将短暂冻结来敌");
				line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "令灼热的剑刃在你面前出现，并随着击打敌人而逐渐变大变强。当你在空中时，剑刃也可以用于在物块上弹跳");
				line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "使用鬼魂般高速的投影向前冲刺，并吸取击中敌人的生命值。击中敌人时，你会从敌人处弹开");
				line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "以藤鞭为绳，将刃掷出。使用尖端击中敌人必定暴击。若尖端击中物块，你也会被其拉去");
			}
			if (item.type == ModContent.ItemType<TrueBiomeBlade>())
			{
				line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：");
				line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：:");
				line.Text = line.Text.Replace("Pure Clarity", "纯粹的清澈");
				line.Text = line.Text.Replace("Biting Embrace", "凛冽的怀抱");
				line.Text = line.Text.Replace("Arid Grandeur", "干涸的堂皇");
				line.Text = line.Text.Replace("Decay's Retort", "朽者的反击");
				line.Text = line.Text.Replace("Grovetender's Touch", "林妖的鞭笞");
				line.Text = line.Text.Replace("Heaven's Might", "天堂的迫力");
				line.Text = line.Text.Replace("Extant Abhorrence", "尚存的憎恶");
				line.Text = line.Text.Replace("None", "无");
				line.Text = line.Text.Replace("Does nothing..yet", "没有用处……起码目前还没有");
				line.Text = line.Text.Replace("Repairing the blade seems to have improved its attuning capacities", "看上去，修复此剑增强了它的调谐能力");
				line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出脆弱的弹幕，撕裂敌人护甲");
				line.Text = line.Text.Replace("Landing true melee hits places a sigil of purity over the enemy. Your projectiles home onto the marked foes", "使用真近战击中敌人将置一纯净之符于其身上。你的弹幕追踪被标记的敌人");
				line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "使用冰川凝造之刃进行三连击剑技。最终一剑将短暂冻结来敌");
				line.Text = line.Text.Replace("Lingering glacial mist is released on each swing, dealing damage to enemies wandering into it", "每次挥动都会释放于空中弥漫的冰雾，对在其中徘徊的敌人造成伤害");
				line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "令灼热的剑刃在你面前出现，并随着击打敌人而逐渐变大变强。当你在空中时，剑刃也可以用于在物块上弹跳");
				line.Text = line.Text.Replace("Releasing the attack button after the blades are fully charged sends them hurtling forwards to shred your foes", "松开攻击键将会使满蓄力的剑刃向前飞驰，撕裂途径的敌人");
				line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "使用鬼魂般高速的投影向前冲刺，并吸取击中敌人的生命值。击中敌人时，你会从敌人处弹开");
				line.Text = line.Text.Replace("Landing three strikes without touching the ground changes your next attack into an empowered dash thrust", "若在触碰地面之前成功进行了三次打击，你的下一次攻击会变成强化的突刺冲锋");
				line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "以藤鞭为绳，将刃掷出。使用尖端击中敌人必定暴击。若尖端击中物块，你也会被其拉去");
				line.Text = line.Text.Replace("Spreading vines sprout from critical strikes. These vines can hit up to three targets", "暴击会使得藤蔓蔓延。藤蔓最多击中三个敌人");
				line.Text = line.Text.Replace("Hold the attack button to charge a star-piercing lunge, release to unleash the devastating blow", "按住攻击键来为一次足以穿透星辰的猛冲蓄力，松开以释放这一打击");
				line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive impact which raises otherworldly monoliths", "将此猛冲施加给地面将导致巨大的冲击，使得异界巨石破地而出");
				line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time", "按住攻击键使用回旋斩，随时间逐渐加速");
				line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. The sword then quickly returns to your hand", "松开攻击键将剑向鼠标猛投出去。剑将会迅速回到你手中");
			}
			if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
			{
				line.Text = line.Text.Replace("Active Attunement :", "核心环境调谐：");
				line.Text = line.Text.Replace("Passive Attunement :", "辅助环境调谐：");
				line.Text = line.Text.Replace("Swordsmith's Pride", "刀匠之傲");
				line.Text = line.Text.Replace("Sanguine Fury", "血红之怒");
				line.Text = line.Text.Replace("Lamentations of the Chained", "囚徒之哀");
				line.Text = line.Text.Replace("Mercurial Tides", "变幻之潮");
				line.Text = line.Text.Replace("None", "无");
				line.Text = line.Text.Replace("Does nothing..yet", "没有力量……至少现在没有");
				line.Text = line.Text.Replace("It seems that upgrading the blade expanded the scope of the previous attunements", "你对剑的升级似乎让它原有的调谐获得了强化");
				line.Text = line.Text.Replace("Your secondary attunement can now provide passive bonuses", "副环境调谐现在可以提供辅助增益");
				line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time. Sword beams are fired wildly while swinging", "按住攻击键使用回旋斩，随时间逐渐加速。挥动时，剑气束会狂暴四散");
				line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. Sword beams home onto enemies struck by the thrown sword", "松开攻击键将剑向鼠标猛投出去。剑气束将会追踪被掷出的剑击中的来敌");
				line.Text = line.Text.Replace("All attacks have a chance to fire sword beams", "所有攻击有几率射出剑气");
				line.Text = line.Text.Replace("Conjures molten blades in front of you that get larger and stronger the more you hit enemies.", "令熔岩剑刃在你面前出现，并随着击打敌人而逐渐变大变强。");
				line.Text = line.Text.Replace(" The blades can also be used to bounce off tiles when in the air", "当你在空中时，剑刃也可以用于在物块上弹跳");
				line.Text = line.Text.Replace("Releasing the attack button sends the charged blades hurtling forwards like a wheel.", "松开攻击键将会使蓄力的剑刃如车轮一般向前飞驰。");
				line.Text = line.Text.Replace(" Attacking again immediately thereafter dashes to the wheel, shredding anything in the way", "那之后立即再次攻击使你冲向剑刃，并撕裂途径的一切");
				line.Text = line.Text.Replace("Striking enemies rarely steals a small amount of life", "击中敌人有小概率为你回复一定生命值");
				line.Text = line.Text.Replace("Hold the attack button to charge a heaven-shattering lunge, release to unleash the devastating blow.", "按住攻击键来为一次足以碎裂天堂的猛冲蓄力，松开以释放这一打击。");
				line.Text = line.Text.Replace(" Shock waves are emitted as the sword charges up", "蓄力时，冲击波将不断释放");
				line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive shock wave on impact which raises a flood of monoliths", "将此猛冲施加给地面将导致巨大的冲击波，并让洪水般的幻星巨石破地而出");
				line.Text = line.Text.Replace("Periodically emit shock waves while attacking", "攻击时周期性释放冲击波");
				line.Text = line.Text.Replace("Lash out with a flurry of chained blades. Striking enemies with the tip of the blades guarantees a critical hit", "向前迅猛掷出一阵拴在锁链上的剑刃。使用刃的顶部击中敌人必定暴击");
				line.Text = line.Text.Replace("Critical strikes send out extra phantom chains which latch onto multiple targets", "暴击会送出能够锁住多个目标的幻象锁链");
				line.Text = line.Text.Replace("An enchanted chain hook floats near you. Striking enemies makes the hook whirl around you, freezing enemies", "一个附魔链钩在你附近漂浮。击中敌人会让钩子在你周围旋转，冻结敌人");
			}
			if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
			{
				line.Text = line.Text.Replace("Active Attunement :", "星系协调：");
				line.Text = line.Text.Replace("Passive Blessing :", "星系馈赠：");
				line.Text = line.Text.Replace("Phoenix's Pride", "凤凰座之桀骜");
				line.Text = line.Text.Replace("Aries' Wrath", "白羊座之盛怒");
				line.Text = line.Text.Replace("Polaris' Gaze", "北极星之凝视");
				line.Text = line.Text.Replace("Andromeda's Stride", "仙女座之冲击");
				line.Text = line.Text.Replace("Capricorn's Blessing", "摩羯座之祝福");
				line.Text = line.Text.Replace("Cancer's Blessing", "巨蟹座之馈赠");
				line.Text = line.Text.Replace("Hold the attack button to swing Galaxia around you, accelerating over time. The swirling nebula constantly emits homing cosmic bolts", "按住攻击键释放旋风阵，随时间加速。旋转的星云会持续释放追踪宙能束");
				line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor alongside a burst of 6 gigantic cosmic bolts. The sword then quickly returns to your hand", "松开攻击键将剑随六个巨大的宙能束向鼠标猛投出去。剑会在随后快速回到你手中");
				line.Text = line.Text.Replace("Throw Galaxia to your cursor, holding it in place with constellations. Galaxia follows your cursor, rapidly spinning to shred enemies", "将银河掷向鼠标，以群星将其握住。银河将跟随你的鼠标，快速旋转，解离来敌");
				line.Text = line.Text.Replace("Striking enemies causes nebulous explosions which spawn homing cosmic bolts", "击中敌人产生星云爆炸，生成追踪的宙能束");
				line.Text = line.Text.Replace("Hold the attack button to channel the Northern Star's power into a tight vortex of galactic energies, bound by concentric rings of stars.", "按住攻击键将北极星的力量引导为由星环围绕的星系能量旋涡。");
				line.Text = line.Text.Replace("The vortex powers up over time and when hitting enemies", "旋涡会随着时间和击中敌人增强");
				line.Text = line.Text.Replace("Release the attack button to fire off the charged star. Attacking again immediately thereafter dashes to the star, emitting a nova of cosmic bolts", "松开攻击键以释放蓄力的星星。释放后立即攻击会使你冲向星星，并如超新星般四散宙能束");
				line.Text = line.Text.Replace("Hold the attack button to charge a god-erasing lunge, release to unleash the devastating blow. Galaxia emits cosmic bolts while charging", "按住攻击键来为一次足以抹杀神明的猛冲蓄力，松开以释放这一打击。蓄力时，银河将四散宙能束");
				line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive impact which summons an apocalyptic storm of cosmic energies", "将此猛冲施加给地面将导致巨大的冲击，并释放如末世风暴般的宇宙能量");
				line.Text = line.Text.Replace("Periodically releases a ring of weakening stars around your cursor when attacking", "攻击时，不时向你的鼠标释放逐渐变弱的星环");
				line.Text = line.Text.Replace("The ring is repelled away from you at first, before slowing down over time", "星环会远离你，并逐渐变慢");
				line.Text = line.Text.Replace("Periodically releases a ring of lifestealing stars around yourself when attacking", "定期在你周围放出吸血的星环");
				line.Text = line.Text.Replace("The ring is attracted towards you at first, before slowing down over time", "星环会朝你飞去，之后逐渐慢下来");
			}
			if (item.type == ModContent.ItemType<FracturedArk>())
			{
				line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "右键向前伸出，击中敌人将会进行格挡，给予你短暂的无敌");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 100 less damage", "也可以格挡弹幕，并短暂让其伤害减少100");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw projectiles out", "成功格挡将会强化10次正常攻击，使其射出弹幕");
			}
			if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
			{
				line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you. Hitting an enemy with it will parry them, granting you a small window of invulnerability", "右键向前伸出，击中敌人将会进行格挡，给予你短暂的无敌");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 160 less damage", "也可以格挡弹幕，并短暂让其伤害减少160");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw stronger projectiles", "成功格挡将会强化10次正常攻击，使其伤害更高并射出更强大的弹幕");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will release all the charges in a powerful burst of energy", "处于强化攻击状态时，按住上并点右键将会以强大能量波的形式把所有蓄力一次性释放");
			}
			if (item.type == ModContent.ItemType<ArkoftheElements>())
			{
				line.Text = line.Text.Replace("Performs a combo of swings, throwing the blade out every 5 swings", "进行一套连斩，并每隔五次挥动掷出一次刀刃");
				line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap", "若在掷出剑刃时松开鼠标，则会挥出另一片刀刃，进行一次剪击");
				line.Text = line.Text.Replace("Snapping the scissors together increase their damage and empower your next two swings", "剪击会增加剪刀的伤害，并强化你下两次挥动");
				line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you", "右键向前方剪出");
				line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "剪刀击中敌人将会进行格挡，给予你短暂的无敌");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "它也可以格挡弹幕，并短暂让其伤害减少200");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "成功格挡将会强化10次正常挥动，允许你同时使用两片刀刃");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "当方舟处于强化攻击状态时，按住上并点右键将掷出两片刀刃，产生时空之中的大撕裂，并一次性释放所有蓄力");
			}
			if (item.type == ModContent.ItemType<ArkoftheCosmos>())
			{
				line.Text = line.Text.Replace("Performs a combo of swings, alternating between narrow and wide swings and throwing the blade out every 5 swings", "进行一套连斩，在横扫和劈斩之间来回切换，并每隔五次挥动掷出一次刀刃");
				line.Text = line.Text.Replace("The thrown blade is held in place by constellations and will follow your cursor", "掷出的剑刃为星系所连，随你鼠标而动");
				line.Text = line.Text.Replace("Releasing the mouse while the blade is out will throw the second half towards it, making the scissors snap and explode into stars", "若在掷出剑刃时松开鼠标，则会挥出另一片刀刃，进行一次剪击，并爆炸成群星");
				line.Text = line.Text.Replace("Using RMB will snip out the scissor blades in front of you", "右键向前方剪出");
				line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "剪刀击中敌人将会进行格挡，给予你短暂的无敌");
				line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 200 less damage", "它也可以格挡弹幕，并短暂让其伤害减少200");
				line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "成功格挡将会强化10次正常挥动，允许你同时使用两片刀刃");
				line.Text = line.Text.Replace("Using RMB and pressing up while the Ark is empowered will throw the blades in front of you to provoke a Big Rip in spacetime, using up all your charges in the process", "当方舟处于强化攻击状态时，按住上并点右键将掷出两片刀刃，产生时空之中的大撕裂，并一次性释放所有蓄力");
				line.Text = line.Text.Replace("If more than half the charges were used up, you can dash across the rip by keeping the up key pressed down", "若释放的蓄力超过一半，保持按住上键将允许你冲过撕裂");
			}

			if (item.CountsAsClass(DamageClass.Melee))
			{
				line.Text = line.Text.Replace("true melee damage", "真近战伤害");
			}
		
			if (item.DamageType.Name == "RogueDamageClass")
			{
				line.Text = line.Text.Replace("rogue damage", "盗贼伤害");
				line.Text = line.Text.Replace("stealth strike damage", "潜伏攻击伤害");
			}

			if (item.type >= 3930 && (item.Calamity()?.UsesCharge ?? false))
			{
				line.Text = line.Text.Replace("Current Charge:", "当前充能：");
			
			}
			
			if ((item.Calamity()?.UsesCharge ?? false) || item.type == ModContent.ItemType<AuricQuantumCoolingCell>() || item.type == ModContent.ItemType<PlasmaGrenade>() || item.type == ModContent.ItemType<VoltageRegulationSystem>() || item.type == ModContent.ItemType<AdvancedDisplay>())
			{
				line.Text = line.Text.Replace("You don't have sufficient knowledge to create this yet", "你没有足够的知识去制作这个");
				line.Text = line.Text.Replace("A specific schematic must be deciphered first", "必须先破译特定的原型图，去世界各地的嘉登实验室寻找这些图纸\n随后，你需要用密码破译器基站以及一些部件组装成密码破译器\n接下来消耗嘉登能源电池破译加密原型图来解锁该物品的配方\n上述物品都可以使用神秘电路与可疑镀层合成");

			}
			
			if (item.Calamity().canFirePointBlankShots)
            {
				line.Text = line.Text.Replace("Does extra damage to enemies shot at point-blank range", "对近距离敌怪射击时造成额外伤害");
            }

			if (item.Calamity().devItem)
			{
				line.Text = line.Text.Replace("Developer Item", "开发者物品");
			}

			if (item.Calamity().donorItem)
			{
				line.Text = line.Text.Replace("Donor Item", "捐赠者物品");
			}
		}
	}		
			
}	