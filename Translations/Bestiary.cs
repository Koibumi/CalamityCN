using System;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.AcidRain;
using CalamityMod.NPCs.AdultEidolonWyrm;
using CalamityMod.NPCs.AquaticScourge;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.AstrumAureus;
using CalamityMod.NPCs.AstrumDeus;
using CalamityMod.NPCs.BrimstoneElemental;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.Calamitas;
using CalamityMod.NPCs.CeaselessVoid;
using CalamityMod.NPCs.Crabulon;
using CalamityMod.NPCs.Crags;
using CalamityMod.NPCs.Cryogen;
using CalamityMod.NPCs.DesertScourge;
using CalamityMod.NPCs.DevourerofGods;
using CalamityMod.NPCs.DraedonLabThings;
using CalamityMod.NPCs.ExoMechs;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.GreatSandShark;
using CalamityMod.NPCs.HiveMind;
using CalamityMod.NPCs.Leviathan;
using CalamityMod.NPCs.NormalNPCs;
using CalamityMod.NPCs.OldDuke;
using CalamityMod.NPCs.Perforator;
using CalamityMod.NPCs.PlaguebringerGoliath;
using CalamityMod.NPCs.PlagueEnemies;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityMod.NPCs.Providence;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Signus;
using CalamityMod.NPCs.SlimeGod;
using CalamityMod.NPCs.StormWeaver;
using CalamityMod.NPCs.SulphurousSea;
using CalamityMod.NPCs.SunkenSea;
using CalamityMod.NPCs.SupremeCalamitas;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.NPCs.Yharon;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityCN
{

	public class Bestiary : GlobalNPC
	{
	    public static bool IsLanguageActive => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);

		public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
		{
			if (IsLanguageActive)
			{	
			int type = npc.type;
			if (type == ModContent.NPCType<AcidEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在其脊柱有一个隆起的背鳍，这允许它们在水下冲向猎物时可以很好地利用此流线型的身形。".zh()));
			}
			if (type == ModContent.NPCType<AdultEidolonWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("早在“巨龙的黄金年代”之前就已经能在历史中发现它们的踪迹了......它们很有可能只是大自然鬼斧神工的冰山一角。".zh()));
			}
			if (type == ModContent.NPCType<AeroSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("史莱姆会根据自身的所处环境而发生变化，这些个体在吞噬了天蓝矿后便长出了翅膀。".zh()));
			}
			if (type == ModContent.NPCType<Anahita>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这个元素生物以其对水的精确操控和在自己主场的无穷力量而闻名，但那早以成了年久日深的往事。".zh()));
			}
			if (type == ModContent.NPCType<AnthozoanCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这只螃蟹驮着一个坚固的石头结构。它会向侵犯其领地者投掷巨石来彰显自己强大的力量。".zh()));
			}
			if (type == ModContent.NPCType<AquaticAberration>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("头也好胃也罢，它的所有器官都只为吞噬大片鱼群而存在。".zh()));
			}
			if (type == ModContent.NPCType<AquaticScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个象征着灾害的种族。常年在硫磺海中进行的狩猎在锻炼出坚硬外骨骼的同时也磨去了它们的棱角，它们的双颚也浸满了硫磺海的剧毒。".zh()));
			}
			if (type == ModContent.NPCType<AquaticUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("遥远海洋中普通海胆的远亲，硫磺海水让它们的刺变得又坚硬又带有剧毒，最好不要被它们打到。".zh()));
			}
			if (type == ModContent.NPCType<Aries>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("就生物学上而言，这个生物遭受着巨大的苦痛。它的腿没法让它休息，只能在那块污染之地无休止地跳跃下去。然而它的意志早以灰飞烟灭，因而它会毫不在意地跳跃下去直至死亡到来。".zh()));
			}
			if (type == ModContent.NPCType<ArmoredDiggerHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些自动化的机械蠕虫在过去负责挖出洞穴以方便实验室的建造。值得庆幸的是，几十年来未曾得到维护的它们早已不再处于曾经的高效状态。".zh()));
			}
			if (type == ModContent.NPCType<AstralProbe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种被星体感染吞噬的小动物。病毒在感染后会保留并与彼此分享吞噬其他类似生物的经验，因此所有的宿主都形成了相同的外壳。".zh()));
			}
			if (type == ModContent.NPCType<AstralSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它并没有表现出与任何同族不同的行为，因此这类适应性强的生物可能是唯一以自己的方式对抗感染的存在。".zh()));
			}
			if (type == ModContent.NPCType<AstralachneaGround>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种被感染的蛛形纲动物。由于其腹部寄生了无数的星状物，它早已失去了织网的能力。".zh()));
			}
			if (type == ModContent.NPCType<AstrumAureus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个有着许多条腿的机械巨兽，它的存在本身就体现了星辉瘟疫极为强大的控制力：即使是机械也无法抵御它的侵蚀。".zh()));
			}
			if (type == ModContent.NPCType<AstrumDeusHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("星神的尸体碎片仍然保持着自己以前的一部分力量，就算祂屈服于那黑暗的瘟疫，而后又被一条后起之秀撕成了碎片，祂依然寻求着有朝一日可以重返群星之间。".zh()));
			}
			if (type == ModContent.NPCType<Atlas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在其无节制的生长中，其中一个附属物从另一个当中夺走了营养与材料，使其达到了肌肉力量的极致。它的一次攻击就足以粉碎一块巨石。".zh()));
			}
			if (type == ModContent.NPCType<AuroraSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("那些在暴风雪中死去之人的灵魂。它们现在正在寻找其他人，想让他们像自己那样因受冻而亡。".zh()));
			}
			if (type == ModContent.NPCType<BabyFlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("奇怪的是，在它们足够小的时候捕获一只的话，这些似乎足够聪明的生物会给你打上父母的烙印，并在之后永远伴随着你!".zh()));
			}
			if (type == ModContent.NPCType<BabyGhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("就像它们的成年体一样，这些生物会轻轻闪烁着。如果周围的棱镜还不够亮的话，它们就能成为十分有用的光源。或许有什么办法能让你随身携带一个。".zh()));
			}
			if (type == ModContent.NPCType<BelchingCoral>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种罕见的珊瑚物种，它能够处理硫磺海水并从中汲取营养物质，这个过程会产生大量挥发性气体。".zh()));
			}
			if (type == ModContent.NPCType<BigSightseer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("病毒会在它们的壳里产生一种危险的化合物。当一只监星眼接近敌人时，它会从下颚吐出这种可以能融化目标肉体的物质。".zh()));
			}
			if (type == ModContent.NPCType<BlindedAngler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("鮟鱇的一个分支。这些鱼类的头部早已失去了可供辨识的特征。利用一种原始的类似于鲨鱼的电感应，它们得以缓慢而有条不紊地猎取猎物。".zh()));
			}
			if (type == ModContent.NPCType<Bloatfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些重而巨大的鱼类可以轻松抵御深海的压迫和任何试图刺穿其坚硬皮肤的武器。".zh()));
			}
			if (type == ModContent.NPCType<BloodwormNormal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一条看起来很美味的虫子，它大到可以卷住你的手臂。只有一条足够疯狂或足够聪明的鱼才会去追猎这些东西。".zh()));
			}
			if (type == ModContent.NPCType<BloomSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("凭借着亵渎天神的毁灭所释放的太阳能，龙蒿得以在丛林的泥土中，以及居住于其中的史莱姆体内发芽生长。".zh()));
			}
			if (type == ModContent.NPCType<BobbitWormHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它对于那些敢于冒险进入深海的人来说是一个巨大的威胁。它待机时不动声色，攻击时快如雷霆，其下颚可以轻松咬穿超过半英尺厚的铁板。".zh()));
			}
			if (type == ModContent.NPCType<Bohldohr>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("那些洞穴中浑身覆盖着宝石的蜥蜴的远亲。这类生物用神庙的光滑砖块覆盖自己，蜷缩成球状进行运动。".zh()));
			}
			if (type == ModContent.NPCType<BoxJellyfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些看似笨拙的胶状动物绝非无害。即便是让任意一条拖曳的触角拂过你，你也会受到严重的感染。".zh()));
			}
			if (type == ModContent.NPCType<Brimling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("硫磺火元素的碎片，拥有硫磺火石砖一样的外壳。它们的眼睛总是无意识地盯着远方，寻找着可以燃烧的目标。".zh()));
			}
			if (type == ModContent.NPCType<BrimstoneElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一位早已无人崇拜的堕落女神。她仇视着任何对她产生怜悯的生命。".zh()));
			}
			if (type == ModContent.NPCType<CalamitasClone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个只在夜间出现的神秘的燃烧怪物。被硫磺火包裹着的它思维扭曲，对自己的能力有着莫名的自豪感。".zh()));
			}
			if (type == ModContent.NPCType<CalamityEye>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然这些敌人不比恶魔之眼有多危险，但有人说它们最初是从那些曾居住在首都的，灵魂被朱红色火焰诅咒的人的眼眶中出现的。".zh()));
			}
			if (type == ModContent.NPCType<Cataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("自己的影子，只识燃烧与杀戮。".zh()));
			}
			if (type == ModContent.NPCType<SupremeCataclysm>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("有着人的外貌不代表有着人的思考。它只有暴力。".zh()));
			}
			if (type == ModContent.NPCType<Catastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("暴力而愚昧的造物，让死者复生不可能有好结果。".zh()));
			}
			if (type == ModContent.NPCType<SupremeCatastrophe>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("灾厄的亡灵法术无人能敌，但没有人能够真正使亡者起死回生。".zh()));
			}
			if (type == ModContent.NPCType<Catfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种天然适应了剧毒水域的动物。它用自己的胡须来寻找道路与躲在阴暗深处的猎物。".zh()));
			}
			if (type == ModContent.NPCType<CeaselessVoid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("当宇宙的结构被干涉——尤其是被那些没有经验的生命所干涉——时，造成不可挽回的损害的风险非常非常高。".zh()));
			}
			if (type == ModContent.NPCType<ChaoticPuffer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("无序的小型恶魔。它们会吞下大量的水来使自己刚硬的身体膨胀起来。被杀死时，它们体内的水会沸腾并迸发为滚烫的毒气。".zh()));
			}
			if (type == ModContent.NPCType<CharredSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("熔岩史莱姆是唯一能在炎热地狱中生存的史莱姆，只不过这些存在用液态的岩石代替了熔岩。尽管如此，它们的举止依然相同，那就是寻找并吞噬任何可以吞噬的东西。".zh()));
			}
			if (type == ModContent.NPCType<Clam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些迟钝的软体动物会从咸水中过滤出养分。它们的壳像石头一样坚硬，但肉精致而多汁。".zh()));
			}
			if (type == ModContent.NPCType<ThiccWaifu>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("过去，人们在天空中建立了前哨站，以便对蕴藏在云层的力量进行崇拜并取悦他们。在前哨站被遗弃的现在，这些神灵同样也被激怒了。".zh()));
			}
			if (type == ModContent.NPCType<Cnidrion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种奇怪的生物。它们与许多其他沙漠生物具有相同的特征，但似乎能够在体内储存大量的水。".zh()));
			}
			if (type == ModContent.NPCType<ColossalSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们那充满压迫性的触手有两个成年男子身高加在一起那么长，再加上带毒的黑色墨水，它们无愧是一种可怕的掠食者。".zh()));
			}
			if (type == ModContent.NPCType<CorruptSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些迅速扇动着由膜化的凝胶与刺状的硬化粘液所组成的翅膀的生物会不停地追捕你。".zh()));
			}
			if (type == ModContent.NPCType<CosmicElemental>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个奇怪的构造物。虽然起源不详，但有一点肯定，那就是它的身体核心所通向的地方不属于我们的世界。".zh()));
			}
			if (type == ModContent.NPCType<CosmicGuardianHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("神明吞噬者的跨维度创造物。它从自己的主维度带来它们以协助自己战斗。与它的使徒相比，这些蠕虫的力量远远不够。".zh()));
			}
			if (type == ModContent.NPCType<CosmicLantern>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些灯笼可以让使用者看穿一切黑暗，但通常不会把它们用于战斗。".zh()));
			}
			if (type == ModContent.NPCType<CrabShroom>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("只生长在菌生蟹壳上的蘑菇，以壳中的营养物质为食。菌生蟹会通过颠簸自己的身体，把这些东西甩出去以进行防御。".zh()));
			}
			if (type == ModContent.NPCType<Crabulon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在蘑菇洞穴的球茎生长物中并不难发现蜕皮的壳。但它们对于这个环境中任何常见的十足目动物而言都太大了。".zh()));
			}
			if (type == ModContent.NPCType<CragmawMire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在那违背了硫磺海内一切逻辑所形成的钙化外壳内，有一个搅动着的胶状身体。其中还寄生着另一个长长的类钩爪生物，它帮助其抓住猎物以换取保护。".zh()));
			}
			if (type == ModContent.NPCType<CrimsonSlimeSpawn>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("刺激性的史莱姆状物。如果它们沾到了你的眼睛你就会失去视力。请不惜一切代价避免这些为史莱姆之神传播死亡的生物。".zh()));
			}
			if (type == ModContent.NPCType<CrimsonSlimeSpawn2>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些史莱姆的体内嵌入了血化史莱姆的碎片，其中流淌着一种可以损害视力的毒素。".zh()));
			}
			if (type == ModContent.NPCType<CrimulanBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("	看起来这些都是被一个更加高级的存在所祝福过的史莱姆。他们寻找与吞噬他物的行为并非是为了自己，这在史莱姆中并不常见。".zh()));
			}
			if (type == ModContent.NPCType<CryoSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("当极地之灵魔法的释放解冻了地下的冰冻金属时产生的融水形成了这些史莱姆。寒元矿的残余物仍然存在于其中。".zh()));
			}
			if (type == ModContent.NPCType<Cryogen>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个棱镜状的活体冰晶。虽然通常只能在严寒的暴风雪瞥见其一角。可若是在难得的晴天里看到它，它的身体就会闪烁一种致命而美丽的蓝色。".zh()));
			}
			if (type == ModContent.NPCType<Cryon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在它们的八面体内可以找到雕刻在那些不会融化的冰晶上的古老符文。是谁创造了它们？".zh()));
			}			
			if (type == ModContent.NPCType<CrawlerAmber>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerAmethyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerCrystal>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerDiamond>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerEmerald>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerRuby>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerSapphire>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CrawlerTopaz>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("其实这些爬虫是一种背部长满了水晶的蜥蜴，它们很容易受到惊吓。这些水晶为它们提供保护的同时，也可以作为这些稀有宝石的来源之一。".zh()));
			}
			if (type == ModContent.NPCType<CultistAssassin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虔诚的信徒，它们的思想迷失在硫磺火的汹涌与憎恨之中。没有人见过他们兜帽下面的真面目，也没人能见过。".zh()));
			}
			if (type == ModContent.NPCType<Cuttlefish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("如果你在深渊深处感觉到有什么东西在洗刷你的腿，这玩意很可能就是那期待在水下品尝猎物的罪魁祸首。".zh()));
			}
			if (type == ModContent.NPCType<DankCreeper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然它们的核心与腐化球相同，但其由暗影鳞片组成的装甲外壳使它们不那么容易死亡。它们体内还有一种带毒的气体。".zh()));
			}
			if (type == ModContent.NPCType<DarkEnergy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("无尽虚空在空间结构中所创造的无数裂缝的其中一个。有人说如果你凝视它，你甚至可以瞥见另一个世界。".zh()));
			}
			if (type == ModContent.NPCType<DarkHeart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它的内部充斥着粘稠而恶臭的腐败之水，而当它飞过你的头顶时就会将这些倾泻下来。无论这些水落在哪里，附近的有机物都会被慢慢腐蚀。".zh()));
			}
			if (type == ModContent.NPCType<DesertNuisanceHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("荒漠灾虫那饥饿的后代。就像沙漠里的食人鱼一样，它们可以在几秒钟内成群结队撕碎较小的猎物。".zh()));
			}
			if (type == ModContent.NPCType<DesertScourgeHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("如果你曾在沙漠中看到一座座沙丘如海中的波浪一样起伏，罪魁祸首一定是这些在地底穿梭的生物。".zh()));
			}
			if (type == ModContent.NPCType<DespairStone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一块凝结而不稳定的，由硫磺石砖所构成的石头。据说它会撕裂地面的原因，是因为有许多被困在里面的灵魂试图从中挣扎脱出。".zh()));
			}
			if (type == ModContent.NPCType<DevilFish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种在深渊中度过了漫长的时间的，十分坚固的鱼。雄性通过其向前的角来辨别，而雌性则通过其卷曲的角来识别。".zh()));
			}
			if (type == ModContent.NPCType<DevilFishAlt>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种在深渊中度过了漫长的时间的，十分坚固的鱼。雄性通过其向前的角来辨别，而雌性则通过其卷曲的角来识别。".zh()));
			}
			if (type == ModContent.NPCType<DevourerofGodsHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它那无人能比的自傲，和在战斗中经常夸耀的无与伦比的压倒性力量一道，为人所知。诚然，它是为数不多的能够名副其实的存在之一。".zh()));
			}
			if (type == ModContent.NPCType<WildBumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然这些生物可能看起来很可爱，但它们其实是一种极为恶劣的入侵物种。如果不能迅速处理，它们很可能会使附近的一切都灭绝。".zh()));
			}
			if (type == ModContent.NPCType<Draedon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("那位值得受到尊敬的科学家本人。他的AI被上传到了一个足以远离一切伤害的数据库中，因此摧毁他的那些侦察机体也没有任何意义。".zh()));
			}
			if (type == ModContent.NPCType<Bumblefuck>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们因在丛林中的聚群而闻名。它们几乎算是最令人恐惧的存在，因为尽管它们可能不及其他势力那样危险，可它们没有主人。".zh()));
			}
			if (type == ModContent.NPCType<Horse>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("文明的目标是控制自然，而这就是这种征服的结果——一个依靠发条齿轮运作的人造元素。".zh()));
			}
	        if (type == ModContent.NPCType<EbonianBlightSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("看起来这些都是被一个更加高级的存在所祝福过的史莱姆。他们寻找与吞噬他物的行为并非是为了自己，这在史莱姆中并不常见。".zh()));
			}
			if (type == ModContent.NPCType<Eidolist>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些十分精通法术的神秘生物似乎像哨兵一样站在那儿看守着什么。靠近它们中的其中一个，你也许能听到一些无法理解的低语。".zh()));
			}
			if (type == ModContent.NPCType<EidolonWyrmHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在有史以来的任何生物中，只有它们最超脱我们的理解。如此的力量，如此的神秘...".zh()));
			}
			if (type == ModContent.NPCType<EutrophicRay>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种大部分时间都呆在沉沦之海岩石地面上的温顺貂鱼。它会储存自己的能量并在遇到危险时于短时间内将其释放出去。".zh()));
			}
			if (type == ModContent.NPCType<FearlessGoldfishWarrior>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("头顶锡帽，手携金匕，雨中行进，随时战斗。".zh()));
			}
			if (type == ModContent.NPCType<FlakCrab>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("除了壳以外从各方面来看算正常的螃蟹。它已经学会了将周围的水聚集起来，并在处理后通过自己的漏斗强行排出一种十分危险的混合物。".zh()));
			}
			if (type == ModContent.NPCType<Flounder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些生物并不主动寻找食物，而是等待着食物自己送上门来。如果你冒险进入硫磺海，请注意自己的脚步。".zh()));
			}
			if (type == ModContent.NPCType<Frogfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("埋伏着等待猎物的捕食者。它们并不算特别强壮，哪怕你遇到一个也能轻松干掉。".zh()));
			}
			if (type == ModContent.NPCType<FusionFeeder>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("	一只被星辉瘟疫感染的沙鲨。由于不熟悉病毒的起源，它的大脑中充斥着在整个宇宙中收集的信息，并因此渴求着遥远星球的脉冲。".zh()));
			}
			if (type == ModContent.NPCType<GammaSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("随着硫磺海水中的毒素不断恶化，以及从中汲取水分的云层变得危险，这些史莱姆也越来越强大了。".zh()));
			}
			if (type == ModContent.NPCType<GhostBell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虚无缥缈的水母，漂浮在沉沦之海的静水中。不知为何它们的身体带着电流。".zh()));
			}
			if (type == ModContent.NPCType<GiantClam>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这种超大的蛤蜊足以把一个乃至两个人整个夹住。值得庆幸的是，它只在沉沦之海的最底层区域安家。".zh()));
			}
			if (type == ModContent.NPCType<GiantSquid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种巨大的乌贼，由于其栖息地猎物丰富且竞争不激烈而长成了如今的尺寸。其眼睛特别适用于在黑暗中寻找猎物。".zh()));
			}
			if (type == ModContent.NPCType<Gnasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种乌龟，它的壳早以被硫磺海的污物所包裹。它的下颚有着完全和体型不匹配的巨大咬合力。".zh()));
			}
			if (type == ModContent.NPCType<GreatSandShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("见到这样的生物不禁让人产生疑问：鲨鱼在寻求生存中的坚持过程是否有极限？它们甚至征服了与通常生活的气候完全相反的地方。鲨鱼还没长出翅膀也真是奇迹。".zh()));
			}
			if (type == ModContent.NPCType<ProfanedGuardianCommander>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("每次把燃烧的长矛转向目标时，它那简单的头脑总是有且只有一个明确的目标：彻底消灭敌人。".zh()));
			}
			if (type == ModContent.NPCType<ProfanedGuardianDefender>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它的身体拥有一个经受过太阳火焰洗礼与锤炼的石之外壳，很少有人能完全击碎它的防御。".zh()));
			}
			if (type == ModContent.NPCType<ProfanedGuardianHealer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("从它身上突出的水晶能够恢复对其同族造成的伤害，并将这种伤害转化为耀斑可以窃取生命的耀斑。".zh()));
			}
			if (type == ModContent.NPCType<GulperEelHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("无论是从长度还是宽度，这类鳗鱼都很出众。它居住在深渊中更深的洞穴里。其下颚有一种奇怪的能力，可以过度伸展并吞下几乎所有它所瞄准的猎物。".zh()));
			}
			if (type == ModContent.NPCType<Hadarian>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们翅膀的薄膜出乎意料地特别坚韧。其翅膀也因它们在无情撕咬敌人时保护它们免受烧伤和射弹伤害而闻名。".zh()));
			}
			if (type == ModContent.NPCType<HeatSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个人类的灵魂，其思想被自己居住地的炽热橙色火焰所迷惑，会寻找并试图消除任何它能检测到的进入地狱世界的水分来源。".zh()));
			}
			if (type == ModContent.NPCType<HiveEnemy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些存在似乎是从星辉之地的洞穴本身中喷发出来的。无数宿主的肉体被扭曲成了这样一个螺旋形的，脉动着的蜂巢肉体。".zh()));
			}
			if (type == ModContent.NPCType<HiveBlob>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个由肉与腐烂物质组成的球体，被腐巢思维作为传递污染的饲料抛向它的敌人，会侵蚀任何挡在它们前面的人。".zh()));
			}
			if (type == ModContent.NPCType<HiveCyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("寄宿着的超级有机体中的污秽之物，大量的有机物像心脏一样跳动。其增长是腐化生物共同融合所形成的结果。".zh()));
			}
			if (type == ModContent.NPCType<HiveMind>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在腐化的深沟中，受感染的生物聚集在一起以表现出它们自己的神性。与其他小型生物聚集保护彼此的情况不同，这完全是一种进攻性的行为。".zh()));
			}
			if (type == ModContent.NPCType<Hiveling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这类小形生物除了从宿主蜂巢中取出的一小块有机物核心以外，完全是属于星辉瘟疫本身的存在。它们很容易被摧毁，但在濒临全灭的情况下也会成群结队。".zh()));
			}
			if (type == ModContent.NPCType<IceClasper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一类在猎物方面从不挑剔的敌人。它们以其在低能见度暴风雪中冻结和捕食旅行者而闻名。其受害者的下场无从知悉。".zh()));
			}
			if (type == ModContent.NPCType<ImpiousImmolator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个从不考虑也不认可自身周遭环境的燃烧的灵魂。任何闯入亵渎天神圣地的人都将化为灰烬。".zh()));
			}
			if (type == ModContent.NPCType<IrradiatedSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("被从硫磺海中慢慢蒸发出来的污物包裹着的史莱姆，它们实际上是在大气层上部的酸雨中形成然后落回地面的。".zh()));
			}
			if (type == ModContent.NPCType<Yharon>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("也许……这只是它的种族中的最后一个。只要它想，它可以在一瞬间毁灭整个丛林。然而它似乎一直都在很小心地让自己不这么做。".zh()));
			}
			if (type == ModContent.NPCType<Laserfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它的眼睛被聚集在其头部气囊中的细菌所蒙蔽。当它依靠原始的回声定位在水中游动时，这些细菌能够释放出震荡性爆炸来清除它路上的敌人。".zh()));
			}
			if (type == ModContent.NPCType<Leviathan>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种巨大的海洋爬行动物，她在海洋深处潜伏了近一千年之久，尚不知道她是否是她的种族中的最后一个，虽然说出来很无耻，我们最好祈祷她就是最后一个。".zh()));
			}
			if (type == ModContent.NPCType<LeviathanStart>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它似乎在用一种极具魅惑力的声音呼唤你，牵动着你关于海洋那从未切身体验过的舒适回忆。".zh()));
			}
			if (type == ModContent.NPCType<LuminousCorvina>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这种鱼有一种奇特的防御机制。当像你这样的威胁进入它的视野时，它就会释放出尖锐的脉冲，提醒其他生物注意你的存在——而不是它的。".zh()));
			}
			if (type == ModContent.NPCType<Mantis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这是一种灵活的星辉感染生物，它的多条腿使其能够快速穿越几乎任何被感染吞噬的地形。通过高速挥动前爪，它可以释放出带有伤害的能量叶片。".zh()));
			}
			if (type == ModContent.NPCType<MantisShrimp>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("如果它用那圆形的前爪攻击你，你就会粉身碎骨。不用说，请不惜一切代价避免这种情况。".zh()));
			}
			if (type == ModContent.NPCType<Mauler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("鲨鱼也许是我们星球历史上最有具有适应性的物种之一。这些顶级捕食者在如此的海洋中茁壮成长也并不奇怪。".zh()));
			}
			if (type == ModContent.NPCType<Melter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它的脸部被瘟疫纳米机器人的腐蚀所扭曲和软化。在自己和瘟疫的双重意志下，它试图将这一令人不适的命运传递给其它生物。".zh()));
			}
			if (type == ModContent.NPCType<MirageJelly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在深渊无处不在的黑暗中看到的一种似乎无视所有物理边界的漂移的紫色光亮，很可能就是这些生物中的一个。许多人甚至怀疑它们的存在，并将其归咎于深渊的狂欢。".zh()));
			}
			if (type == ModContent.NPCType<MorayEel>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们的眼睛闪烁着饥饿的光芒，休息时栖息在水下结构的岩石上，只是偶尔在开放的水域游荡。".zh()));
			}
			if (type == ModContent.NPCType<Nova>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("星辉瘟疫强制生物变异的过程十分有效，但副产品也同样十分不稳定。大多数生物会逐渐排出这种化学物质--但新星就会储存这些。".zh()));
			}
			if (type == ModContent.NPCType<NuclearTerror>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("有可能它以前只是一只简单的螃蟹，也有可能依然还有很多像它这样的家伙潜伏在深海里。但无论哪个答案都不会让你想着再次踏入硫磺海。".zh()));
			}
			if (type == ModContent.NPCType<NuclearToad>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在水下受到威胁时，它们会迅速充气并浮到到水面上。作为最后的手段，它们会强行把自己撑爆。它们那无私的目标是让自己的同族可以长期生存下去。".zh()));
			}
			if (type == ModContent.NPCType<OarfishHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种奇特的骨鱼。许多人可能只见过那些被冲上岸的尸体，但其实它们在平日生活的水柱中漂流时，红色的鱼鳍会在其身后如丝般飘动。".zh()));
			}
			if (type == ModContent.NPCType<OldDuke>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("外表的衰老并没能妨碍它对生存的追求。尽管并非直接诞生于污染之海，但它早已作为顶级捕食者主宰了此处。".zh()));
			}
			if (type == ModContent.NPCType<Orthocera>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在硫磺海的淤泥中发现遥远过去的生物其实并不罕见。这些生物的身体就完全保存了下来。看来并非所有的生物都只是简单地消失了。".zh()));
			}
			if (type == ModContent.NPCType<OverloadedSoldier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在这个被复仇之灵魂所复活的生物于洞穴跋涉的过程中，幻影从腐蚀的盔甲中隆起，取代了早以糜烂的肉体。".zh()));
			}
			if (type == ModContent.NPCType<PerennialSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些在灌木丛中晃动的史莱姆充满了营养，可以很好地维持植物的生命。它们中的许多都接纳了这些植物，比如它们头顶上的花。".zh()));
			}
			if (type == ModContent.NPCType<PerforatorCyst>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一团跳动的眼睛和牙齿。毫无章法可言。它是猩红血肉的终点，应该不惜一切代价避开它。".zh()));
			}
			if (type == ModContent.NPCType<PerforatorHeadLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("每一条寄生者都长有致命而各不相同的口器，可以承担不同的分工。一个用于刺穿，一个用于撕裂，而最后一个仅仅用于吞噬。".zh()));
			}
			if (type == ModContent.NPCType<PerforatorHeadMedium>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("每一条寄生者都长有致命而各不相同的口器，可以承担不同的分工。一个用于刺穿，一个用于撕裂，而最后一个仅仅用于吞噬。".zh()));
			}
			if (type == ModContent.NPCType<PerforatorHeadSmall>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("每一条寄生者都长有致命而各不相同的口器，可以承担不同的分工。一个用于刺穿，一个用于撕裂，而最后一个仅仅用于吞噬。".zh()));
			}
			if (type == ModContent.NPCType<PerforatorHive>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一团跳动的眼睛和牙齿。毫无章法可言。它是猩红血肉的终点，应该不惜一切代价避开它。".zh()));
			}
			if (type == ModContent.NPCType<PestilentSlime>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种被瘟疫纳米机器人感染的史莱姆。瘟疫无法直接使用任何指令控制它。所以它只是继续自己正常的生活，除了会腐蚀所有接近它的东西这一点。".zh()));
			}
			if (type == ModContent.NPCType<PhantomSpirit>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在无谓无欲的狂热中彼此残杀和吞噬的幽灵。过去曾有这样一个先例：有一个吞噬了足够多其他幽灵的存在，其力量的增长已经达到了令人震惊的地步。".zh()));
			}
			if (type == ModContent.NPCType<PhantomSpiritL>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在无谓无欲的狂热中彼此残杀和吞噬的幽灵。过去曾有这样一个先例：有一个吞噬了足够多其他幽灵的存在，其力量的增长已经达到了令人震惊的地步。".zh()));
			}
			if (type == ModContent.NPCType<PhantomSpiritM>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在无谓无欲的狂热中彼此残杀和吞噬的幽灵。过去曾有这样一个先例：有一个吞噬了足够多其他幽灵的存在，其力量的增长已经达到了令人震惊的地步。".zh()));
			}
			if (type == ModContent.NPCType<PhantomSpiritS>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在无谓无欲的狂热中彼此残杀和吞噬的幽灵。过去曾有这样一个先例：有一个吞噬了足够多其他幽灵的存在，其力量的增长已经达到了令人震惊的地步。".zh()));
			}
			if (type == ModContent.NPCType<Piggy>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("小猪猪是贪心的牲口。哪怕是遇到了你根本不觉得猪猪会下口的食物，猪猪也会在一眨眼的功夫就将其囫囵吞下。".zh()));
			}
			if (type == ModContent.NPCType<PlagueCharger>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然黄蜂本身就以积极捍卫自己的领地而闻名。但被瘟疫扭曲的它们领土意识只会更进一步。".zh()));
			}
			if (type == ModContent.NPCType<PlagueChargerLarge>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然黄蜂本身就以积极捍卫自己的领地而闻名。但被瘟疫扭曲的它们领土意识只会更进一步。".zh()));
			}
			if (type == ModContent.NPCType<PlaguebringerMiniboss>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("以皇家蜂蜜为食的蜂王将会成为整个族群的首脑。可一旦在这个过程中她们为瘟疫所劫持，这副凄惨的模样就只能让外人来回忆她们本该成为的样子了。".zh()));
			}
			if (type == ModContent.NPCType<PlaguebringerGoliath>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这只蜂王本来的外形早以因机械的改造和纳米机器的感染而不复存在。不禁让人好奇从头制造一个效率会不会更高。".zh()));
			}
			if (type == ModContent.NPCType<Plagueshell>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("事实上，一旦一只丛林陆龟沾染了瘟疫，它原来的外壳就会解体，而其现在背上的荆棘盾牌完全由强化过的纳米机器构成。".zh()));
			}
			if (type == ModContent.NPCType<Polterghast>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("伴随着尖啸与哭号，痛苦的灵魂在地牢狭窄的走廊里横冲直撞，只为寻找更多的灵魂——无论死活——来扩大它们的族群。".zh()));
			}
			if (type == ModContent.NPCType<PrismBack>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些游泳速度相当慢的家伙是少数需要繁殖的生物之一。它们会定期游到栖息地的上层下蛋。".zh()));
			}
			if (type == ModContent.NPCType<ProfanedEnergyBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个紧邻亵渎天神之心的活祭坛。火焰从其支架上的水晶中向世界扑去，焚尽那些不忠之人。".zh()));
			}
			if (type == ModContent.NPCType<Providence>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一位石与火构成的神祗。她的火焰只为一个原因而燃烧--净化世界的罪恶与生活于其中的生命。".zh()));
			}
			if (type == ModContent.NPCType<Radiator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("就和许多其他的海蛞蝓一样，它会从环境中摄取毒素，然后转化成华丽的荧光投射在整个背部，只是硫磺海中的毒素要比其他的地方强上那么一点。".zh()));
			}
			if (type == ModContent.NPCType<RavagerBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在一个看起来几乎早以腐烂的堡垒处，火焰从护栏之中咆哮而出。只要站在顺风处，你仅凭气味就能知道它是否正在接近。".zh()));
			}
			if (type == ModContent.NPCType<ReaperShark>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("进化就像一位奇怪的妇人，在深渊的深处尤其如此。对其中一些家伙来说，她把它们引向了一条明确的生命之路；而对另一些家伙来说，她把它们武装到了牙齿。".zh()));
			}
			if (type == ModContent.NPCType<RepairUnitCritter>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("多亏了这些小家伙，尘封的实验室才得以能屹立不倒，只不过它们似乎没法处理生锈的问题。".zh()));
			}
			if (type == ModContent.NPCType<Rimehound>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种巨大而笨重的猎犬，在结成冰霜的毛发上几乎形成了冰柱。被它抓到一定很痛苦。".zh()));
			}
			if (type == ModContent.NPCType<Rotdog>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种充斥着恶意的生物。铁齿铜牙的它们造成的所有伤口都会导致大量出血。请尽快处理伤口。".zh()));
			}
			if (type == ModContent.NPCType<ScornEater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("亵渎天神的造物与奉献者野蛮的一面。他们的下颚充满了锋利的水晶和炙热的圣火。".zh()));
			}
			if (type == ModContent.NPCType<Scryllar>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("过去那些来到硫火之崖遗迹试图捡漏的人，此地的低语影响了他们，最后只留下了此般扭曲的残渣".zh()));
			}
			if (type == ModContent.NPCType<SeaFloaty>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("奇怪但令人着迷的生物，似乎还没长成熟的它们一见到掠食者就会立即躲起来。".zh()));
			}
			if (type == ModContent.NPCType<SeaMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("虽然处在食物链的底层，但它们也占据了这片海域生物量的80%。它们会啃食从上方的地下沙漠中掉下来的尸体。".zh()));
			}
			if (type == ModContent.NPCType<SeaSerpent1>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些鳗鱼基本处于被动状态，只是无精打采地漂流在沉沦之海的静水中。可一旦被激怒，它们也不会视若不见。".zh()));
			}
			if (type == ModContent.NPCType<SeaUrchin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种带刺的动物，会为了保卫自己的领地而四处乱窜。哪怕它们不小心飞上了陆地——尽管没东西能帮助它们——它们也能想办法自己回到海洋。".zh()));
			}
			if (type == ModContent.NPCType<SepulcherHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这可能是这个领域中最邪恶的亡灵混合物。灾坟虫本身对物理伤害完全免疫，只有破坏它的那些悬浮器官才能杀死它。".zh()));
			}
			if (type == ModContent.NPCType<ShockstormShuttle>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("宇宙中存在生命的证明，这些早已落后于自身所属文明的飞行物在遥远的过去很可能是战争兵器。它们会继续在宇宙中寻找适合居住的星球，并对其进行攻击。".zh()));
			}
			if (type == ModContent.NPCType<Signus>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这个黑影的过去远比它所身披的长袍更为黑暗。尽管关于它的传言数不胜数，但其实没人知道它的真实形态。".zh()));
			}
			if (type == ModContent.NPCType<Skyfin>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们的鳍同时适应了空气与水，哪怕哪一次鲁莽的冲刺让它们不得不短暂滞留在陆地上，片刻之间它们也会飞到空中。".zh()));
			}
			if (type == ModContent.NPCType<SlimeGodCore>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这种生物很容易被混淆为一种巨大的变形虫。多亏了它所包含的那些紧凑的生物质，它的发展远超一般史莱姆的限制。".zh()));
			}
			if (type == ModContent.NPCType<SplitEbonianSlimeGod>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们环绕在自己创造者的身边以作为其身体的衍生，这些象征了整个世界的邪恶中最集中而扭曲的部分的每一个都会利用腐蚀来吞噬和同化那些反对它的人。".zh()));
			}
			if (type == ModContent.NPCType<SplitCrimulanSlimeGod>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们环绕在自己创造者的身边以作为其身体的衍生，这些象征了整个世界的邪恶中最集中而扭曲的部分的每一个都会利用腐蚀来吞噬和同化那些反对它的人。".zh()));
			}
			if (type == ModContent.NPCType<SmallSightseer>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("病毒会在它们的壳里产生一种危险的化合物。当一只监星眼接近敌人时，它会从下颚吐出这种可以能融化目标肉体的物质。".zh()));
			}
			if (type == ModContent.NPCType<SoulSeeker>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("被灾厄之眼聚集在一起的守护者，保护着它的身体免受攻击。它们有可能是一种被不同于硫磺火的另类魔法所强化和奴役的灵魂饮食者。".zh()));
			}
			if (type == ModContent.NPCType<SoulSeekerSupreme>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("如食尸鬼般不完整的头颅。它们有限的形式下付出的是无限的奉献。很可能它们中的每个个体都渴望能有一个属于自己的完整的灵魂，无论那灵魂是由灾厄给予的还是从它们杀死的敌人身上扯下来的。".zh()));
			}
			if (type == ModContent.NPCType<SoulSlurper>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个灵魂的残渣。它在此之前早以吞噬，被吞噬，并最终成为了其他灵魂的一部分。没有人知道这个循环从何处开始的，你也不会想成为知道的那个人的。".zh()));
			}
			if (type == ModContent.NPCType<StellarCulex>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这种突变怪物的头部有许多钳状器官。它会试图附着在其他有机生物上，并将嘴插入它们的肉体以进食。".zh()));
			}
			if (type == ModContent.NPCType<StormWeaverHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它居住在平流层的高处，以飞龙和风暴遨游者为食。这使它拥有强大的电动力。".zh()));
			}
			if (type == ModContent.NPCType<Stormlion>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些生物似乎以沙漠上酝酿的电风暴为食。当天空变暗时，它们会把下颚向上伸去用以引雷。".zh()));
			}
			if (type == ModContent.NPCType<SulphurousSharkron>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些硫海遗爵的子嗣腐烂如尸体。只要是在硫磺海中，即使从出生开始，它们的外表也是糜烂而衰败。".zh()));
			}
			if (type == ModContent.NPCType<SulphurousSkater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("从下面看，它们的腿尖几乎没有穿透水面，因此很难从雨水的水面中分辨出它们的动作。".zh()));
			}
			if (type == ModContent.NPCType<Sunskater>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一些掠过我们大气层边缘的生物往往比其他生物能更好地吸收和引导太阳光。无论如何这是一种被动的生物。它对你没有恶意，你应该给予回报。".zh()));
			}
			if (type == ModContent.NPCType<SupremeCalamitas>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("硫火女巫施展的魔法映射了她艰苦的生活，无常、强大，与优雅相去甚远。据说她的脾气火爆到足以烧毁一整个王国。".zh()));
			}
			if (type == ModContent.NPCType<ToxicMinnow>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它把大部分时间都花在寻找那些最令其它动物反感和不快的植物上。在处理用于自卫的化学物质时，它们的肚子会发出绿色的光芒。".zh()));
			}
			if (type == ModContent.NPCType<Trasher>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("巨大的短吻鳄适应了在硫磺海中捡漏的生活，它们会用巨大的下颚从海底刮取食物的碎片。但别搞错了，那些软弱无力的生物也位于它们的菜单之列。".zh()));
			}
			if (type == ModContent.NPCType<Trilobite>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它们的外壳十分坚硬，其重量也与石头相同。而它们能够像这样甩动自己也恰恰体现了它们的力量之大。".zh()));
			}
			if (type == ModContent.NPCType<Twinkler>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("星辉瘟疫创造无害生物的罕见案例，你不是唯一认为它们的闪烁十分动人的人。它们同样也是很有用的鱼饵。".zh()));
			}
			if (type == ModContent.NPCType<Viperfish>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一种典型的温顺动物，大部分时间都在沉沦之海的岩石上徘徊。可一旦接近它，它也会变得相当有攻击性。".zh()));
			}
			if (type == ModContent.NPCType<Viruling>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("被瘟疫感染后，跳跳兽也失去了那双被视作障碍的双腿，它们再也没法高高兴兴地到处乱跳了。".zh()));
			}
			if (type == ModContent.NPCType<WaterLeech>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("它在很远的地方就能闻到肉的气味，并急切地向其蠕动。一旦附着在宿主身上，它们就会迅速吸血并注入毒液，对它的猎物而言无论哪个都不算好消息。".zh()));
			}
			if (type == ModContent.NPCType<WulfrumDrone>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("毫无目的游荡着的它们，在发现潜在的入侵者闯入一个早已不存在的预定领土时，也会旋转起自己的小框架向其俯冲。".zh()));
			}
			if (type == ModContent.NPCType<WulfrumGyrator>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个由钨钢组成的球体。它如何行动这一点依然成谜，这有可能与它的陀螺式旋转有关。它们会将自己的身体甩向敌人以进行攻击。".zh()));
			}
			if (type == ModContent.NPCType<WulfrumHovercraft>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("悬浮力载着它们，让它们能在地面上轻松行进以寻找入侵者，尽管它们的分析可能会随着时间的推移变得越发迟钝。".zh()));
			}
			if (type == ModContent.NPCType<WulfrumAmplifier>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个静止不动但十分危险的敌人。在它的影响下，其他钨钢造物会变得明显更为强大，它们内部的奇怪能量也会溢出。".zh()));
			}
			if (type == ModContent.NPCType<WulfrumRover>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个来历不明的古老的自动机器人。它们带着无尽的责任感与破旧的框架在这片土地上搜寻。它们的灯闪耀着奇怪的能量。".zh()));
			}
			if (type == ModContent.NPCType<AresBody>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("作为嘉登机器中最张扬的那一个，它似乎距离真正完成还差一口气，不过这丝毫不影响它的杀戮潜力。".zh()));
			}
			if (type == ModContent.NPCType<ThanatosHead>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这台机器的每块装甲板下都有一台先进的武器。以机器的耐久作为代价，它在大规模屠戮方面十分高效。".zh()));
			}
			if (type == ModContent.NPCType<Artemis>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("星流双子是终极侦察单位。它们甚至能够探测到我们浑然不知的各种波长的光，在它们面前一切都无所遁形。".zh()));
			}
			if (type == ModContent.NPCType<Apollo>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("在它的内部燃烧着如希腊火焰般狂暴的化学物质。从之前的双子眼球设计中高度提炼后，它现在能够在空中进行十分出色的移动。".zh()));
			}
			if (type == ModContent.NPCType<DILF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("他这张饱经沧桑的脸不仅展现着他的年迈，同样也蕴含了他的智慧。这位大法师曾因为与魔君对立而付出了代价。他会出售各种冰霜制品，但当然，最强大的那些法术只留给他自己。".zh()));
			}
			if (type == ModContent.NPCType<FAP>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("没有人知道她从哪儿来，也没人在乎。这家伙能处，你甚至可以和她一起喝酒，只要不把她惹毛的话。".zh()));
			}
			if (type == ModContent.NPCType<SEAHOE>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一位大海之王，来自一个早已消失在时间与风沙中的古老文明。活了很久的他能够为你的周遭提供有用的建议。以及，他以前还挺喜欢蛤的。".zh()));
			}
			if (type == ModContent.NPCType<THIEF>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一个在面对面的战斗中有些胆小的偷窃狂。无论是把自己卷进危险还是从中抽身，她都很在行。".zh()));
			}
			if (type == ModContent.NPCType<WITCH>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("看到这名强大的敌人与那些友好的面孔生活在一起令人十分惊讶。历史是否会重演？她能否真正成功从魔君的掌控中解脱出来？".zh()));
			}
			
			//c2.2
			if (type == ModContent.NPCType<Androomba>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Slowly moving back and forth, these contraptions operate endlessly with the fruitless goal of cleaning the now long abandoned labs.".zh()));
			}
			if (type == ModContent.NPCType<AndroombaFriendly>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Easily reversed engineered, these robots can be made to spread whatever you put into them, giving them a new purpose.".zh()));
			}
			if (type == ModContent.NPCType<Nanodroid>())
			{
				bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
				bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("Not every creation has to be large and flashy to be a success, sometimes it's good to take a step back and appreciate how much that smaller things such as these devices contribute.".zh()));
			}
			}
		}
	}
}
