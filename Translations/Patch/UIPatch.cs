using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;
using CalamityMod;
using CalamityMod.Tiles.DraedonSummoner;
using CalamityMod.TileEntities;
using CalamityMod.UI.DraedonSummoning;
using CalamityMod.UI.ModeIndicator;
using CalamityMod.UI.Rippers;
using CalamityMod.UI;
using CalamityMod.UI.DraedonLogs;

namespace CalamityCN.Translations.Patch
{
    public class UIPatch
    {
        
        private static List<ILHook> ILHooks;
        private static List<string> ExoUIText;
        public static void Load()
        {

                ILHooks = new List<ILHook>();
                ExoUIText = new List<string>(new string[]
                {
                "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.",
                "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。",
                "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.",
                "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。",
                "Artemis and Apollo, a pair of extremely agile destroyers with pulse cannons.",
                "阿尔忒弥斯和阿波罗，装备了脉冲加农炮的，快如流星的一对战争机器。"
                });

                for (int i = 0; i < 3; i++)
                {
                    QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", ExoUIText[i * 2], ExoUIText[i * 2 + 1]);
                }

            //破译
            QuickTranslate(typeof(CodebreakerTile), "RightClick","No decryption computer installed", "未安装解密计算机");
            QuickTranslate(typeof(CodebreakerUI), "DisplayNotStrongEnoughErrorText","Encryption unsolveable: Upgrades required.", "解密请求失败：需要升级解码装置");
            QuickTranslate(typeof(CodebreakerUI), "DisplayCostText","Cost: ", "花费：");
            QuickTranslate(typeof(CodebreakerUI), "DrawDecryptCancelConfirmationText","Are you sure?", "确定吗？");
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton","Contact", "对话");
            QuickTranslate(typeof(TECodebreaker), "UpdateTime","You learned how to create new things!", "你学会了如何制作新的东西！");
            //难度
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", " Mode is ", "模式");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "active", "已启用");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "not active", "未启用");
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Click to select a difficulty mode]", "[c/919191:点击选择难度]");
                QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Higher difficulty modes can only be toggled in Expert Mode or above]", "[c/919191:只能在专家模式及以上时开启更高难度]");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "Currently Selected : ", "当前选择的难度：");
                QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "\n[c/737373:Hold the 'Shift' key for more information]", "\n[c/737373:按住Shift键查看更多信息]");
            //机制
            QuickTranslate(typeof(RipperUI), "Draw", "Rage: ", "怒气: ");
            QuickTranslate(typeof(RipperUI), "Draw", "Adrenaline", "肾上腺素");
            QuickTranslate(typeof(RipperUI), "Draw", "Nanomachines", "纳米机器");
            QuickTranslate(typeof(StealthUI), "Draw", "Stealth: ", "潜行值: ");
            QuickTranslate(typeof(StealthUI), "Draw", "Hold SHIFT for more information on Rogue stealth", "按住SHIFT查看更多盗贼潜行值信息");
            QuickTranslate(typeof(StealthUI), "Draw", "Rogue stealth builds while not attacking and slower while moving\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage and crit\nHaving more stealth regeneration slightly decreases the damage bonus from stealth\nThis is offset by you being able to use stealth strikes far more often", "盗贼潜行值会在玩家不攻击或缓慢移动时增加\n当潜行值达到上限时，可以进行潜伏攻击\n盗贼潜行值只会在攻击时减少，移动不会减少\n盗贼潜行值越高，盗贼武器伤害和暴击率越高\n潜行恢复速度越快会降低伤害加成\n这是为了平衡更快的使用潜伏攻击");
            //日志
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "Preserved for millennia, a paradise for the living beings who sought shelter in prehistoric seas. They remain untouched by evolution, save for their adaptations to the oxygen starved waters and dim crystals, continuing to thrive. One mystery which continues to escape my understanding however, is how large some of the creatures have become. There is a blatant lack of nutrition and oxygen in the caves, and yet...", "它被保存了几千年，是在史前海洋中寻求庇护的生物的天堂。它们没有受到进化的影响，除了适应缺氧的水域和暗淡的水晶外，它们依然在这片海域中繁衍生息。然而，仍然让我无法理解的一个谜团是，有些生物已经变得到底有多大。洞穴里明显缺乏营养和氧气，然而……");
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "A specimen which has developed a grand size, and inexplicably, impressive psychic abilities. What is most curious is its strong connection to its lesser kin. Without any noticeable communication, when it comes under threat, other mollusks rally to its aggressor and begin attacking. Is this perhaps the very first signs of a higher life form, the evolutionary link hidden away in the sunken sea? Or a self sacrificial fluke, which would lead to their destruction if they inhabited any area other than these pacified caverns.", "其中有一个标本有着异常巨大的体型，和一个无法理解且令人印象深刻的通灵能力。最令人好奇的是它和它那些体型更小的近亲之间的紧密联系。在没有任何明显的交流的情况下，当它受到威胁时，其它的软体动物会集体向攻击者发起攻击。也许这就是潜藏于沉沦之海的进化链中午的，一个更高级生命形式的最初迹象吗？又或者只是一种，会让它们在这些平静的洞穴之外的任何地区导致自身毁灭的，一种自我牺牲的侥幸呢？");
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "The marine life in these caves do have eyes though they are barely functional, dulled by lack of use and milky white upon observation. On their tough, gnarled hides, crystals find an easy purchase, and grow in great numbers, providing the creatures protection. Perhaps another adaptation to the life they have adopted. The most striking wonder is within their bodies. In specimens dissected, I have noticed that the mineral is buried into their very digestive systems, and perhaps, through some chemical process, pass nutrients into their sluggish hosts. A peculiar yet entirely beneficial interaction.", "这些洞穴中的海洋生物确实有眼睛，尽管它们几乎失去了原有的功能，由于缺乏使用而变得迟钝，在进行观察时会呈乳白色。在它们坚硬而多节的皮肤上，水晶无处不在且大量生长，为生物提供保护。也许这是他们适应这里的生活时的另一种方式。最惊人的奇迹是在他们的身体里。在解剖的标本中，我注意到这些矿物甚至被埋藏在它们的消化系统中。也许这些水晶会通过某种化学过程，将营养物质传递给它们那行动迟缓的宿主。真是一种奇特却无一害的互动。");
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "Hung low in orbit, masses of ground and various parts of the world provide a secluded and distant point for research. Undeniably optimal for the science of astronomy and otherwise. In my labs here I grow many things, testing their limits against the cold and vacuum of the stratosphere. Though not many survive, the existence of certain creatures here, confirm the capabilities of life simply given more time.", "这些悬挂在低轨道上的，大量且遍布世界各地的球体为我提供了一个隐蔽而遥远的研究点。无可否认，对于天文学和其他方面的科学来说，这里是最佳的地点。在我在这儿的实验室里，我种植了许多东西，以测试它们在在平流层的寒冷和真空中的极限。虽然存活下来的植株不多，但这个地方某些生物的存在，证实了只要提供更多的时间，生命就能在此存活。");
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "The bloated cosmic worm, though I understand why the Lord decides to employ it given he can control it, is a disgusting existence. However the idea of creating an armor suited to it in every way, was an offer I could not refuse. Forged from the cosmic steel of my own creation, it resists nearly any attack, yet allows the creature the same flexibility it would have without it, as well as augmenting its dimensional abilities. I remain pleased with the result.", "那条臃肿的宇宙巨虫，虽然我明白领主能控制它并使用它，可它对我而言，依然是个令我讨厌的存在。然而，创造一件在各方面都适合它的装甲的提案，并不容我拒绝。这件装甲由我自己创造的宇宙钢锻造而成，能几乎抵御住任何攻击，但又能让这个生物保持和没有装甲时一样的灵活性，同时还能增强它的维度能力。不管怎么说，我对这个结果仍然很满意。");
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "I do not care much for the interstellar, or the cosmos. Though I have traversed it, there is still plenty in my own world to manage and discover at this time. Even if I once inhabited a different planet, the Lord's wishes that I provide him machinery were the only condition that I needed to leave it and settle elsewhere. Once I have discovered and dissected every part of this place, perhaps then, I could look up towards the macroscopic.", "我对星际，或者说宇宙并不怎么关心。虽然我曾经在其中穿越过，但此时此刻，在我自己的世界里，依然还有很多东西需要我去管理和发现。就算我曾经居住在不同的星球上，但领主希望我为他提供机械，是我需要离开那儿到其他地方定居的唯一条件。一旦我发现并剖析了这颗星球的每一处奥秘，也许在那之后，我才会抬头看向那片宏伟的寰宇。");
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "As I record this, it would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately these labs provide everything I need in my research and more. There is no need to ever visit the surface, save for summons on the Lord's orders.", "在我记录下这段话的时候，称丛林为这个星球的中心并不为过。一切都以它为中心，它无人不知无人不晓。当我看到那些在丛林上方经过的生物的那些令人厌恶的、原始而落后的形态时，让我产生了不少的反感。幸运的是，这些实验室提供了我研究中所需要的一切，甚至还要多。除非是领主亲自下命令传唤我以外，我再也没有了去地表参观的必要。");
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "Mechanically augmented, the Queen Bee which I had prior experimented on was theoretically a perfect host for the plague virus. When the first sign of the technology bonding with the creature began however, the problems also showed immediately. The mind of the insect fought the control of the nanotechnology, nothing like the simpler creatures I had used as test subjects. It grew increasingly violent, and only once subdued did it receive simple orders. However, if we were to utilize it at all, there is no other way than to let it roam free entirely. I will consider this further.", "我之前做过实验的那个蜂后，在经过了机械强化后，理论上应该是瘟疫病毒的完美宿主。然而当科技与生物结合的第一个里程碑诞生时，问题也立刻显现出来。昆虫的思维开始对抗纳米技术的控制，这点与我之前用作实验品的那些简单生物完全不同。它变得越来越暴戾，只有在被驯服后才开始接受简单的命令。然而，如果我们想要完全发挥它的作用，除了完全放任它自由自在的游荡以外别无他法。我会进一步思考这个问题。");
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "A virus, capable of devouring and converting almost anything. And nanotechnology, constructed painstakingly for the sake of control. Development was swift, and every piece fell into place almost eerily, forming an abhorrent existence. I struggle to think of practical applications which would be friendly to common life forms. However, it is not a major concern. Many were hesitant to continue its creation, but I granted them leave if they desired. I would have no need for any who were not entirely as dedicated as my machines.", "一种能够吞噬和转化几乎一切的病毒，和为了控制它而精心构造的纳米病毒。这东西发展的速度非常快，而每一块被它污染的地方，几乎都诡异地形成了一种令人恐惧的存在。我很难想出任何它能对正常生命体友好的应用方法。然而这并不是一个主要的问题。许多人对是否应该继续对它的创造感到犹豫不决，然而我准许了他们，只要他们想，他们就可以离开。毕竟，我根本不需要任何没有我的机器那样专一的人。");
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "The entire landscape is a constant source of geothermal energy, and heat for a forge. If it was not entirely uninhabitable save for demons and spirits, I would conduct much more of my research in the bowels of the earth. Where I have actively chosen not to settle however, is in the crags of the underworld. There, the magma is... uncooperative and far more corrosive than should be possible, as it is saturated with cursed, twisted souls, courtesy of that Witch.", "整个环境就是一个可以源源不断提供地热和锻造厂需要的热能的能量来源。要不是这里完全不适合除了恶魔和灵魂以外的任何人居住，或许我还会在地底进行更多的研究。然而，我绝对不会选择去定居的地方，是在地狱的峭壁上。在那里，岩浆非常……深闭固拒，而且腐蚀性比理论上的可能要强得多。毕竟那里充满了由那个女巫造成的，被诅咒扭曲的灵魂。");
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "A blade completely inundated with my surroundings during the time of its creation. It was tempered by the fires which are fueled by spirits, and formed in the magma I draw into my laboratories. Its cutting edge, unparalleled, though its reach is limited making general usage questionable. I would consider it my very first foray into work for the sake of craftsmanship and art. If I was born synthetically, any creation which leads one to question whether I was, is a creation I may be proud of. It shows that I can after all, be graced by a muse.", "这把刀，在我创造它的时候，它完全被我的周围环境所淹没。它由灵魂燃烧所形成的火焰淬炼，在我引入实验室中的岩浆里锻造而成。它的边锋无比锋利，尽管它的挥动范围有限，使得它能否可以正常使用遭到了质疑。我愿意把它看作是我为了工艺和艺术而进行的第一次工作。假如我是被人工制造出来的，那么任何能让人怀疑这一点的作品，它都是可以让我引以为豪的作品。也就是说，无论如何，我还可以承蒙灵感的恩惠。");
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "What a terrible abomination and yet an enticing subject. Not unlike the fusion of spirits which haunts the dungeons, this entity is formed not of one, but a multitude of sinners. What holds different for it however, is that the limitations caused by the artificiality of the dungeon's existence do not apply to it. It is the laws of hell which brought them together into a single overlord of the underworld. And when an innocent life is sacrificed... Their hunger, which appears to be in tune with the afterlife, surges.", "这个融合造物，是多么可怕，却又多么诱人。与萦绕在地牢中的灵魂所融合形成的造物不同，这个生物并非是一个人，而是由众多有罪者组成的。然而对它而言不同的是，地牢存在的人为性所造成的限制并不适用于它。是地狱的法则将他们聚集在一起，成为地下世界的霸主。而当一条条无辜的生命被牺牲时……他们的饥饿感似乎与来世相通一般，汹涌澎湃。");
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "A freezing tundra, where only creatures entirely adapted to the subzero temperatures exist and thrive. It is a shocking transition from the forests of the purity and the sun baked desert. A climate like this should not exist naturally in this part of the world with ease. The weather patterns seem to shift unnaturally arounds the skies of these icy plains. There is likely a reason for this, which necessitates further research.", "在这片冰天雪地的冻土地带，只有完全适应零下温度的生物才能在这里存在和繁衍。从纯净的森林到被阳光烘烤的沙漠，气候的转变令人震惊。像这样的气候不应该会轻易地在这样的地方自然存在。在这些冰雪平原天空的周围，天气模式的转变似乎也很不自然。这很可能是有原因的，有必要进行进一步研究。");
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "I am not the only singular being to inhabit this biome. Once before, the Archmage who opposed the Lord resided here, cloaked by constant artificial blizzards of his own creation, which no longer fall. He likely chose this place as a conduit for research into his ice spells, and extended the period of time that this place remained frozen. Deep underground my research and materials lay well protected, but above in the natural storms there are traces of the prison of ice he resides in, still haunting its place of creation.", "我并不是唯一一个居住在这个生物群落的独行侠。曾经，反对领主的大法师也居住在这里，被他自己创造的持续不断的人造暴风雪所保护，而这些暴风雪现在已经消失。他很可能选择了这里作为研究他的冰系法术的渠道，并延长了这里保持冰封的时间。在地底深处，我的研究和资料依然被很好的保护着，但在上方，在那片自然产生的风暴当中，他所居住的冰之囚牢的痕迹依然存在，出没于它的诞生之地。");
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "Intriguing. Though embedded deep into the caverns of ice and worn from centuries of frost and meltwater, I have uncovered several mechanisms which once filled the tunnels here. The ingenuity present is remarkable, and I have found parallels within my own work, as well as devices even I have something to learn from. From where do these come? Why machinery so complex in so sparse and dreary a habitat? Perhaps, they are related to the unnatural conditions.", "令人好奇。尽管深埋在冰洞中，还因为几个世纪的冰霜和融水而变得破旧不堪，但我依然发现了几个曾经遍布于这些隧道的装置。这些独创的装置非凡无比，我不仅在自己的作品中发现了和这些装置的相似之处，甚至还有一些连我自己都需要向其学习的装置。这些东西从何而来？为什么在如此稀疏和沉闷的地层里会有如此复杂的机械？也许，它们与非自然条件有关。");

            //QuickTranslate(typeof(), "", "", "");

            foreach (ILHook hook in ILHooks)
                {
                    if (hook is not null)
                        hook.Apply();
                }
            
        }
        public static void Unload()
        {
            foreach (ILHook hook in ILHooks)
            {
                if (hook is not null)
                    hook.Dispose();
            }
            ILHooks = null;
            ExoUIText = null;
        }

        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooks.Add(new ILHook(
            type.GetMethod(methodName, (BindingFlags)60 | BindingFlags.Instance),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((eng) => trans);
            })));
        }

    }
}
