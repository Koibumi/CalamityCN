using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using CalamityMod.UI.DraedonSummoning;
using CalamityMod.UI.ModeIndicator;
using CalamityMod.UI.Rippers;
using CalamityMod.UI;
using CalamityMod.UI.DraedonLogs;
using CalamityMod.UI.DraedonsArsenal;
using CalamityMod.UI.CalamitasEnchants;
using CalamityMod.UI.SulphurousWaterMeter;
using CalamityCN.Utils;

namespace CalamityCN.Translations.Patch
{
    public class UIPatch
    {
        
        private static List<ILHook> ILHooks;
        public static void Load()
        {

                ILHooks = new List<ILHook>();
                
            //嘉登
            QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets.", "塔纳托斯，一条装备着厚重铠甲、搭载了无数机关炮的恐怖巨蟒。".zh());
            QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", "Ares, a heavyweight, diabolical monstrosity with four Exo superweapons.", "阿瑞斯，一个搭载着四台超级星流武器的庞然巨物。".zh());
            QuickTranslate(typeof(ExoMechSelectionUI), "HandleInteractionWithButton", "Artemis and Apollo, a pair of extremely persistent automatons with unstable energy reserves.", "阿尔忒弥斯和阿波罗，一对能量储备十分不稳定的超耐久自动机器。".zh());
            //破译
            QuickTranslate(typeof(DraedonSchematicSunkenSeaGUI), "GetTextByPage", "The weaponry I supply to the workers of the laboratories is weak. Hardly suited for battle.\nHowever, they suffice for self defense against any lab mechanisms or creations which may have gone rogue.\nAddendum: For those who think themselves powerful, search the upper bounds of this planet's atmosphere for a structure similar to that of the Sunken Seas.\nI will know by the end if you are worthy of battling my creations.\n", "众多设备和武器的精细图示在全息屏幕上飞舞。\n我提供给实验室工人们的武器装备很弱，几乎不适合战斗。\n然而，这些东西足以让他们自卫，抵御所有实验室的攻击机制或可能叛逃的创造物。\n后附：妄自尊大的人啊，你可以前往这颗星球的大气层的上界，寻找类似于沉沦之海实验室的结构。\n走到最后，我就会知道你是否值得与我的创造物战斗。\n".zh());
            QuickTranslate(typeof(DraedonSchematicPlanetoidGUI), "GetTextByPage", "Within an army, as weapons do, the soldiers serve different purposes.\nThat distinction is crucial, as the wrong tool in the wrong hands—no matter how potent—may as well be a wooden club.\nAddendum: Seek out my base of operations closest to the Lihzahrd's home.\nI wish you the best of luck with all sincerity, for it has been a long time since I have had a worthy test subject.", "在一支军队中，士兵就如同武器一样有着不同的用途。\n它们的区别至关重要，毕竟如果错误的工具在错误的人手中的话——无论那些工具有多么厉害——可能也就和一根木头球棒差不多。\n附录：去寻找距离蜥蜴神庙最近的行动基地。\n我真诚地祝愿你好运，毕竟我已经很久没有遇到过如此有价值的实验对象了。".zh());
            QuickTranslate(typeof(DraedonSchematicJungleGUI), "GetTextByPage", "As rank progresses, so often does the lethality of equipment. In the hands of competent soldiers, the weapons have the ability to make change.\nHowever, competent soldiers take no action but orders from above.\nAddendum: If you read this, you have come far. Do not disappoint.\nGo now to Hell, for the next component stored in what were once my forges.", "随着军衔的提高，装备的杀伤力也会增长。在有能力的士兵手里，这些武器也确实可以带来改变。\n可惜，这些有能力的士兵除了遵循上头的命令外根本不会自己行动。\n附录：如果你读到了这里，就说明你已经取得了不小的成果。\n不要灰心，现在出发前往地狱，在那个曾是我的铸造厂的地方寻找储存在那里的下一个部件。".zh());
            QuickTranslate(typeof(DraedonSchematicHellGUI), "GetTextByPage", "Only the highest ranking in the battalions of the Yharim's army held these weapons.\nHowever these are still not my most potent tools. Those...characters could not be trusted with them.\nAddendum: The final piece remains. Travel now from the hottest fire this land has to offer, to the most frigid cold. I cannot deny having some sense of poetic symmetry.", "在亚利姆的军队中，只有那些军衔最高的人员才可以持有这些武器。\n然而它们仍然不是我最得意的工具。那些......角色根本没有得到足够的信任去使用它们。\n附录：还剩下最后一块，现在就从这片大陆上最热的领域，去往这片大陆上最冷的土地。好吧，我不能否认我灵感乍现来了点对仗。".zh());
            QuickTranslate(typeof(DraedonSchematicIceGUI), "GetTextByPage", "I have since made progress to even greater weapons than these, but they remain creations to be proud of.\nNo progress can be made without a desire that comes from dissatisfaction.\nAddendum: The time has come. You are ready.", "之后我还制作出过比这些东西更为强大的武器，但这并不能否认我依然为这些造物感到骄傲。\n毕竟如果没有源于不满的渴望，我也没法取得突破。\n附录：时机已到，你已经准备好了。".zh());
            QuickTranslate(typeof(CodebreakerUI), "DisplayNotStrongEnoughErrorText","Encryption unsolveable: Upgrades required.", "解密请求失败：需要升级解码装置".zh());
            QuickTranslate(typeof(CodebreakerUI), "DisplayCostText","Cost: ", "花费：".zh());
            QuickTranslate(typeof(CodebreakerUI), "DrawDecryptCancelConfirmationText","Are you sure?", "确定吗？".zh());
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton","Contact", "对话".zh());
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton","Summon", "召唤".zh());
            QuickTranslate(typeof(CodebreakerUI), "HandleDraedonSummonButton","Evoke", "唤醒".zh());
            QuickTranslate(typeof(CodebreakerUI), "get_InquiryText", "...", "……".zh());
            QuickTranslate(typeof(CodebreakerUI), "get_InquiryText", "State your inquiry.", "陈述你的访问原因。".zh());
            //日志
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "A hub of diverse ocean life, and all that remains of Ilmeris that is unscorched. Once its rural outskirts, it is now the final fragment of a once powerful kingdom. It is fortunate that the Witch only focused on attacking the cities proper, and spared some amount of the sea from the Incineration. I have long yearned to research these waters in great depth, yet was never able due to the ongoing conflict. Although many species went extinct in the devastation, many still thrive down here in its depths. It is in this lab that I may finally study the aquatic life properly and learn of their nature.",
                "一个多样化海洋生物的中心，同时也是伊尔梅里斯遗迹中所有未遭受炙烤的部分。这里曾经只是一个强大王国的郊区，现在却成为了它最后的碎片。幸运的是，女巫当初只专注于攻击城市本身，在焚烧中放过了海洋的其它部分。我长期以来一直渴望对这些水域进行深入研究，但持续不断的冲突阻挠了我。尽管许多物种在那场焚烧中灭绝，但依然有不少物种仍在这里的深处繁衍生息。正是在这个实验室里，我得以正确地研究这些水生生物，了解它们的本质。".zh());
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "Of the specimens here, the abnormally large clams capture my interest the most. Many times larger than the average person, their weight is so great that they lack the ability to move via the same methods as their smaller counterparts. Instead, they rely on teleportation to transport their hulking, heavily armored bodies. They seem to have once possessed further magical powers according to scouts. However, as they were seen only from afar, their reports could have easily been mistaken. Alternatively, their source of power simply could have faded after Ilmeris’ downfall. It is unwise to entirely discount the latter possibility.",
                "在这里所有的样本中，最吸引我的是这些异常巨大的蛤，它们要比普通的人类还要大上好几倍。它们的重量如此之大，以至于它们无法像那些较小的同类那样使用相同的方法进行移动。相反，它们依靠传送来转运它们那巨大的，覆盖着重装甲的身体。据侦察员报告，它们似乎还拥有更进一步的魔力。然而，由于侦查员们只是远远地观测这些蛤，他们提交的报告很可能有被某些其它因素所误导。只不过，伊尔梅里斯的陨落也并不意味着它们力量来源的彻底消退。作为学者，完全否定后一种可能性并不算得上明智。".zh());
            QuickTranslate(typeof(DraedonLogSunkenSeaGUI), "GetTextByPage", "Although the marine life in these caves do have eyes, some of their eyes are weak and process few colors. All they are made to see is the light of the sea prisms that surround them, with many creatures relying on them to guide their way through the submerged caverns. Their tough, gnarled hides possess crystal growths that I had originally assumed were the prisms settling on their backs. However, dissection results reveal that they instead possess these crystals internally, and the growths are a result of internal sea prisms bursting out of their hides. The growth of these crystals reaches such an extent that some creatures are more geological than biological in certain areas.",
                "虽然这些洞穴中的海洋生物确实拥有眼睛，但其中一些生物的眼睛非常弱，只能处理很少的颜色。它们完全依靠周围的海棱晶散发出来的光才能看清东西，许多生物也正是依靠海棱晶的指引来寻找在水下洞穴中的道路。它们坚韧而虬结的体表上也有晶体生长，我原本以为这些是沉淀在它们背上的海棱晶，然而解剖结果却显示，这些晶体甚至存在于它们的内部，体外晶体的生长也正是海棱晶从这些生物的体表中迸发钻出的结果。这些晶体的生长已经到了如此的地步，以至于在特定地区的某些生物，它们身上的地质特征远多于生物特征。".zh());
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "High above even the sky islands upheaved long ago lies a fascinating geological phenomenon. Though, unlike the islands, their airborne nature appears to have formed more naturally. I speculate that they formed long ago when the world was in its infancy judging by soil samples I have taken while testing high atmosphere plant growth. Perhaps these “planetoids”, as many refer to them as, formed via meteor strikes tossing matter high into the atmosphere. This would simultaneously explain many geological oddities I have found on the world’s surface.",
                "远在天空之岛拔地而起之前，在更高的地方就已经出现了更令人着迷的地质现象。尽管如此，它们与天空岛不同，其悬浮性质的形成似乎更加自然。根据我在高空测试植物生长时采集的土壤样本，我推测它们早在世界处于起步阶段时就已经出现了。也许就如许多人所说的那样，这些“行星”是由于流星撞击地表而将物质抛向大气层才形成的。这也能同时解释我在世界表面发现的许多异常地质现象。".zh());
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "A request from Yharim has been delivered. An inquiry to create a suit of armor for the serpent that has joined his forces recently, the “Devourer of Gods” as the serpent calls himself. He is a bothersome yet fascinating being. And so, I have taken the opportunity so that I may learn more of his home dimension. Using materials from his place of origin, I have forged armor of immense size and durability yet extreme flexibility. It is certainly one of the most unique materials I have worked with and has advanced my knowledge greatly. Though, I have learned more than I expected to about the cosmic beast from this. Perhaps more than he wished for me to.",
                "我收到了来自亚利姆的请求，他希望我为最近加入他军队的巨蛇制作一套盔甲。巨蛇自称“神明吞噬者”，它既令我懊恼又让我着迷。正因如此，我抓住了这个机会，以便我可以更好了解他的故乡次元。我使用来自他家乡的材料，锻造出了尺寸巨大、高度耐用且极其灵活的铠甲。这无疑是我使用过的最独特的材料之一，使用这些材料也大大促进了我的知识。不仅如此，我从中对这头星际巨兽的了解比我所预期的要多不少。甚至有可能比他所希望的，我对他的了解还要多。".zh());
            QuickTranslate(typeof(DraedonLogPlanetoidGUI), "GetTextByPage", "Travel between worlds is a fascination of mine. The planets within reasonable distance to this provide no use to me in terms of materials or study opportunities they could provide. And so, I wish to go further beyond this mere cluster of planets some day. It will likely take many more decades of technological progress, however, as travel between worlds would take years even at the maximum speed physical matter can currently go. Perhaps I will find a way to shatter this limit once this world holds my interest no longer.",
                "在不同世界之间穿越旅行十分吸引我。与之相比，合理范围内的任何行星能为我提供的材料或研究机会我都瞧不上。因此，我希望有一天能抵达这片单纯行星群以外的地方。然而，这可能需要几十年甚至更久的技术进步。因为即便是以目前物理物质所能抵达的最大速度行进，不同世界之间的旅行也需要花费数载。或许，如果哪一天这个世界不再有能令我感兴趣的事物，我会找到一种方法来突破这个桎梏。".zh());
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "It would not be a stretch to call the jungle the hub of this planet. All is centered around it, and none know not of it. It brings me no small amount of unease to see the uncomfortable, raw forms of the living beings who pass through on their journeys above. Fortunately, these labs provide everything I need in my research and more. There is little need to visit the surface, save for Yharim’s summons.",
                "把丛林称为这颗星球的心脏也不为过。它是一切的中心，没有人不知道它的存在。尽管看着那些令人不适的原始生命在空中熙熙攘攘让我感到不安，但好在这些实验室提供了我在研究中所需要的一切，甚至更多。只要亚利姆不传唤我，我几乎都没有访问地面的必要。".zh());
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "Continued experiments have led to significant results. With a mechanically modified Queen Bee as a primary host, it may act as the core of a hive mind of those my plague has touched. However, Yharim was outraged upon learning of my experiments here and decried them as inhumane. After a brief verbal conflict, he wordlessly left and I have not heard from him since. Fortunately, I need not rely on the slayer of gods any longer, nor have I needed to for years.",
                "持续的实验得到了相当大的进展。有了经过机械改造的蜂王作为主要宿主，那些接触了我的瘟疫的生物都会与之相连，令其作为蜂巢思维的核心来控制它们。然而亚利姆却对我在这里的实验感到非常愤怒，他谴责这些实验完全不人道。在短暂的争辩后，他一言不发地离开了，那也是我最后一次得知他的消息。好在我已经不再需要依赖这位弑神者了，正如我这么多年来也从来不需要他一样。".zh());
            QuickTranslate(typeof(DraedonLogJungleGUI), "GetTextByPage", "Few travel down here, with far fewer making the expedition to reach as far down as this research station. As such, I have taken to using this isolation to develop advanced nanotechnology for use in controlling the minds of biologicals. I yearn for it to be capable of spreading from organism to organism, a perfected blend of a virus and nanotechnology. Yet, it has been an arduous task even with my newly developed technologies. Further experimentation and research are required.",
                "很少能有人深入此地，能深入探索发现这个实验室的人更是屈指可数。因此，我开始利用这个与世隔绝的地方来开发先进的纳米技术，以控制生物体的思想。我希望它能够在生物体之间传播，成为病毒和纳米技术的完美结合。然而，即使搭配上我新开发的技术，这依然是一项艰巨的任务。我需要进行进一步的实验和研究。".zh());
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "The Underworld is a realm with history dating back more than a millenia when the Crags were first settled, and acts as a glance into both the modern and ancient world simultaneously. Prior to my joining of Yharim’s forces, Azafure was the center of scientific advancement in this world. Explosives, firearms, smithing techniques, and even entire schools of magic have roots in the city. It is doubtless that the city has been largely aided by the fact that forging is trivial in the Underworld, along with an abundance of food due to Silva’s essence dripping down from the Abyss above. Due to this, it has prospered even with the occasional attack from Demons.",
                "地狱拥有悠久的历史，最早可以追溯到一千年前首次有人定居硫火之崖之时，并成为了古代与现代社会交融一体的缩影。早在我加入亚利姆之前，阿萨福勒就已经是这个世界科学进步的中心。爆破、火器、冶炼技术乃至整个魔法学校都在这座城市生根发芽。毫无疑问，这座城市显著受益于在地狱普及的锻造技术，以及从上方深渊滴落的席尔瓦之精粹所带来的充足食物。也正因如此，尽管恶魔时常会袭击这里，但它依然欣欣向荣。".zh());
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "A particular being here has been the subject of my interest: a massive wall created from biological material lies in this place created many years ago by the greatest mages Azafure has to offer. It is a living being, though only just. It lacks both pain and emotion, and brings terror to all who lay their eyes upon it. It is kept protected via high security by the city, and so few aside from the Godseeker’s closest allies have had the opportunity to observe it. For as long as Azafure continues to stand, it is unlikely to ever be truly released. Yet, I do not deny that I would be fascinated to see the effects its release would have on the world.",
                "这里有一个特殊的生物引起了我的兴趣：一面多年以前由阿萨福勒最伟大的魔法师利用此地的生物质所创造的巨大墙壁。它不识痛苦，没有情感，只是令每一个看到它的人都感到恐惧。它受到这座城市层层的严格保护，所以除去寻神者最亲密的盟友，很少有人能有机会观察它。只要阿萨福勒一刻存在于此，它就不可能被释放出来。然而，我也并不会否认，我对它被释放后对世界所产生的影响十分好奇。".zh());
            QuickTranslate(typeof(DraedonLogHellGUI), "GetTextByPage", "Azafure has not existed without consequence, of course. Any society on such a large scale leaves an ecological footprint behind. This can be seen most clearly in the sea far above the city, appropriately known as the Sulphurous Sea. Brimstone fumes became intense enough in the city that they began rising up through the Abyss via a process akin to osmosis, and eventually reached the sea. Reducing the pollution the city creates, particularly from forging, is a goal Yharim wishes for me to prioritize. I see little need in it, yet it is a field of study few in this world have delved into. I refuse to squander an opportunity for scientific breakthrough.",
                "当然，阿萨福勒的繁荣并非没有代价，任何一个有如此规模的社会都不可能不对生态造成影响，这点在远在城市上方的海洋中展露无遗。那片海拥有一个很适合它的名称：硫磺海。硫磺的烟雾在城市中堆积过于密集，以至于它们开始通过一个类似于渗透的过程进入深渊，并最终到达海中。亚利姆希望我优先考虑减少城市造成的污染，特别是来自锻造的污染。我不认为这有什么必要，但这个世界上鲜有会深入研究这个领域的人。而我最不可能拒绝的，恰恰就是这样一个引发科学突破的机会。".zh());
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "A freezing tundra, where only creatures that have adapted to the subzero temperatures thrive. Few sapient beings have ever permanently resided here, save for miners and the Archmage. With this fact in mind, Yharim has requested I observe this place for oddities due to the armies largely having glossed over this location. Additionally, I have been requested by the Archmage to perform studies on his frigid metals. There is little else to do in this frozen wasteland, and so his request has been accepted.",
                "只有能适应零度以下温度的生物才能在这片冰冷的苔原中生存。除去少数矿工和大法师，很少能有活物长期居住于此。考虑到这一事实，亚利姆要求我观察这个地方的怪异之处，毕竟军队在很大程度上也忽略了这个地方。另外，大法师还要求我对他的冰冷金属进行研究。毕竟在这片冰冻的荒地上几乎没有其他事情可做，我接受了他的请求。".zh());
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "As described earlier, Cryonic Ore was developed by the Archmage, Permafrost. Despite his position as the mage of mages, he has little will to engage in combat. He instead acts as advisor to Yharim, assisting in much of the management of cities and towns taken by or sided with the Godkiller. In addition, he seems to have bonded with the girl who arrived seeking Yharim some months ago, acting as a fatherly figure to her. I myself have taken an interest in her immense natural power.",
                "如前所述，寒元矿是由大法师永冻开发的。尽管他堪称法师中的法师，他本人却并不热衷于斗争。因此，他转为担任亚利姆的顾问，协助管理那些被弑神者占领或归附于他的城市与城镇的大部分事务。此外，他似乎已经与几个月前前来寻找亚利姆的女孩建立了联系，充当她的父亲。我本人也对那女孩巨大的自然力量产生了兴趣。".zh());
            QuickTranslate(typeof(DraedonLogSnowBiomeGUI), "GetTextByPage", "Cryonic Ore, as the Archmage simply calls it, is a material seemingly akin to iced over glass. One would assume it is a fragile material at a glance, yet upon testing it is clear that is not the case. Plating made out of it has been found to be more durable and resilient than mythril alloy via flexural and tensile testing, followed by destruction attempts. Yet, it is but a fraction of the weight. Perhaps mass amounts of this material could be used to forge armor for units who disdain for the usual burden of metal plating. I will likely inquire further about the creation methods of Cryonic Ore to achieve this.",
                "寒元矿这一大法师如此称呼的矿石，乍一看似乎是一种类似于冰冻玻璃的材料。任何人在看到它的第一眼都会以为它十分脆弱，但测试表明事实并非如此。通过弯曲、拉伸，以及随后的破坏测试，我们发现用它制成的镀层要比秘银合金更加柔韧。这甚至只是这些材料的一小部分。这些材料大量投入使用的话，或许可以用于为那些将寻常金属镀层视作负担的人锻造盔甲。我很可能会进一步询问寒元矿的制造方法以实现这一目标。".zh());
           //难度
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", " Mode is ", "模式".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "active", "已启用".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyStatus", "not active", "未启用".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Click to select a difficulty mode]", "[c/919191:点击选择难度]".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetLockStatus", "[c/919191:Higher difficulty modes can only be toggled in Expert Mode or above]", "[c/919191:只能在专家模式及以上时开启更高难度]".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "Currently Selected : ", "当前选择的难度：".zh());
            QuickTranslate(typeof(ModeIndicatorUI), "GetDifficultyText", "\n[c/737373:Hold the 'Shift' key for more information]", "\n[c/737373:按住Shift键查看更多信息]".zh());
            //机制
            QuickTranslate(typeof(ChargeMeterUI), "Draw", "Current Charge: ", "当前充能：".zh());
            QuickTranslate(typeof(RipperUI), "Draw", "Rage: ", "怒气: ".zh());
            QuickTranslate(typeof(RipperUI), "Draw", "Adrenaline", "肾上腺素".zh());
            QuickTranslate(typeof(RipperUI), "Draw", "Nanomachines", "纳米机器".zh());
            QuickTranslate(typeof(StealthUI), "Draw", "Stealth: ", "潜行值: ".zh());
            QuickTranslate(typeof(StealthUI), "Draw", "Hold SHIFT for more information on Rogue stealth", "按住SHIFT查看更多盗贼潜行值信息".zh());
            QuickTranslate(typeof(StealthUI), "Draw", "Rogue stealth builds while not attacking and slower while moving\nOnce you have built max stealth, you will be able to perform a Stealth Strike\nRogue stealth only reduces when you attack, it does not reduce while moving\nThe higher your rogue stealth the higher your rogue damage and crit\nHaving more stealth regeneration slightly decreases the damage bonus from stealth\nThis is offset by you being able to use stealth strikes far more often", "盗贼潜行值会在玩家不攻击或缓慢移动时增加\n当潜行值达到上限时，可以进行潜伏攻击\n盗贼潜行值只会在攻击时减少，移动不会减少\n盗贼潜行值越高，盗贼武器伤害和暴击率越高\n潜行恢复速度越快会降低伤害加成\n这是为了平衡更快的使用潜伏攻击".zh());
            QuickTranslate(typeof(SulphurousWaterMeterUI), "Draw", "Sulphuric Poisoning: ", "硫磺海水腐蚀：".zh());
            //炼注
            QuickTranslate(typeof(CalamitasEnchantUI), "DrawEnchantmentCost", "Cost: ", "花费：".zh());
            //酸雨
            QuickTranslate(typeof(AcidRainUI), "get_InvasionName", "Acid Rain", "酸雨".zh());
            //选择
            QuickTranslate(typeof(AstralArcanumUI), "UpdateAndDraw", "Select", "选择".zh());

            //QuickTranslate(typeof(), "", "", "".zh());

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
        }

        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooks.Add(new ILHook(
            type.GetCachedMethod(methodName),
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
