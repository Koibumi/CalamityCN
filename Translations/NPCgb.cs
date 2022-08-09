﻿using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using CalamityMod.Items.Weapons.Rogue;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.World;
using CalamityMod.CalPlayer;
using CalamityMod;
using System.Collections.Generic;

public class NPCgb : GlobalNPC
{
	
	public static bool IsLanguageActive => LanguageManager.Instance.ActiveCulture == GameCulture.FromCultureName(GameCulture.CultureName.Chinese);

	public override void OnChatButtonClicked(NPC npc, bool firstButton)
	{
		if (IsLanguageActive)
		{		
		if (npc.type == ModContent.NPCType<FAP>() && !firstButton)
		{
			int deathCount = Main.player[Main.myPlayer].Calamity().deathCount;
			if (deathCount <= 100)
			{ 
				Main.npcChatText = "你一共死了 " + deathCount + " 次。";
			}
			else if (deathCount > 100 && deathCount <= 250)
            {
				Main.npcChatText = "你一共死了 " + deathCount + " 次。考虑降低难度吧。如果这句话让你感到恼火，那太好了。";
			}
			else if (deathCount > 250 && deathCount <= 500)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。我敬佩你不屈不挠的精神。坚持下去，你的敌人正在绞尽脑汁地想怎么对付你！";
			}
			else if (deathCount > 500 && deathCount <= 1000)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。你甚至无法规避最基本的攻击。这让我很震惊。";
			}
			else if (deathCount > 1000 && deathCount <= 2500)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。据说泰拉人的平均寿命大约是两分钟，或者更少。……嗯，可能不准确，但我感觉你会变成统计数据的一部分。";
			}
			else if (deathCount > 2500 && deathCount <= 5000)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。祝福你。即使我喝高了，我也躲的比你好。";
			}
			else if (deathCount > 5000 && deathCount <= 10000)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。我不知道这次我该说什么了。你很糟糕，并且应该感觉到自己很糟糕？然而这已经是众所周知的事情了。";
			}
			else if (deathCount > 10000)
			{
				Main.npcChatText = "你一共死了 " + deathCount + " 次。恭喜！你现在正式成为泰拉瑞亚历史上最大的loser！谁是第二？如果我知道的话。";
			}
		}

		if (npc.type == ModContent.NPCType<THIEF>() && !firstButton)
		{
			int goblinIndex = NPC.FindFirstNPC(107);
			if (goblinIndex != -1)
			{
				NPC goblin = Main.npc[goblinIndex];
				Main.npcChatText = Main.npcChatText.Replace("Want in on a little secret? Since " + goblin.GivenName + " always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.", "想听点秘密？既然 " + goblin.GivenName + " 每次都拿走你那么多钱，我其实早就盯上他了。这件事我要你保密，给，拿着。");
				Main.npcChatText = Main.npcChatText.Replace("Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?", "嘿，既然政府的人能收税，为什么我就不能？什么？你说我们完全没有可比性？");
			}
			Main.npcChatText = Main.npcChatText.Replace("Sorry, I got nothing. Perhaps you could reforge something and come back later...", "抱歉，我什么也给不了你。或许你可以尝试重铸一些东西，然后再来找我...");
		}
		if (npc.type == ModContent.NPCType<SEAHOE>() && !firstButton)
		{
			string[][] seahoeQuotes = new string[][]
			{
				new string[2]{ "Draedon's style of confrontation is very... alien and hands-off. You may be more likely to fight any one of his mechs before taking him down.",
					"嘉登的对峙风格非常……另类和旁观。你更有可能在把他打倒之前要先打败他的所有机械。"},
				new string[2]{ "Lord Yharim possesses god-like strength. He may not even fight you at full power which is fortunate for you. His attacks may just kill you in one hit, so be careful.",
					"亚利姆拥有上帝般的力量。他甚至可能不会尽全力与你战斗，这对你来说是幸运的。他的攻击可能会让你被秒杀，所以要小心。"},
				new string[2]{ "Pockets of ore have appeared once more in the land. This will allow you to create the most powerful weaponry and armor imagined!",
					"在这片土地上又出现了矿坑。这将让你创造出想象中最强大的武器和装甲！"},
				new string[2]{ "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.",
					"啊，丛林龙犽戎变化无常。你会发现，除非你有足够的力量释放日食的全部力量，否则他将拒绝使用他的全部力量"},
				new string[2]{ "The Devourer of Gods is extremely powerful. However, he is young, foolhardy, and very lazy. Perhaps if he had been given time to develop he would have turned into quite the threat.",
					"神明吞噬者非常强大。然而，他年轻，鲁莽，非常懒惰。也许，如果给他时间去发展，他就会变成真正的威胁。"},
				new string[2]{ "With the cosmic steel you can fashion many of your weapons into much more powerful forms.",
					"有了宇宙锭，你可以将你的许多武器塑造成更强大的形式。"},
				new string[2]{ "The Devourer of God's cosmic armor is unique in that it is capable of not only protecting his body from tearing itself apart when ripping through the fabric of space and time, but also allows him to control his powers.",
					"神明吞噬者的盔甲是独一无二的，它不仅能够保护他的身体在撕裂时空时自己不被撕裂，还能让他控制自己的力量。"},
				new string[2]{ "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.",
					"啊……我能感觉到天气的强烈变化。你可能想在雨中再次到硫磺海去探索一下。"},
				new string[2]{ "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.",
					"深渊中蕴藏的诸多秘密会随着时间的推移而逐渐展露出来，再次检查一下或许不是个坏主意。"},
				new string[2]{ "The Dungeon seems to be more active now. You may hear the faint whisperings of angry spirits who have not left to the Void...I would recommend searching there before taking on the Sentinels.",
					"地牢现在似乎更活跃了。你可能会听到愤怒的灵魂的微弱的低语，它们还没有离开这片空地……我建议你在与神之仆从交战之前先去那里探索一下。"},
				new string[2]{ "Ironic, is it not, that Statis was defeated by the very Sentinel his people fashioned their art of stealth from. Fate so often weaves cruel tales.",
					"具有讽刺意味的是，斯塔提斯被他的人民所创造的哨兵打败了。命运常常产生这些残酷的故事。"},
				new string[2]{ "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.",
					"宇宙符文有着亵渎天神魔法的一个重要部分，很容易区别于所有其他物品。在某些地方激活它会有一些……危险的后果。"},
				new string[2]{ "The stories have it that when Providence faced and defeated Yharim and his forces she lost a lot of energy and reverted to a more skeletal form. She's merely a fraction of the power she was before.",
					"传说中，当亵渎天神面对并击败亚利姆和他的部队时，她失去了很多能量，并恢复到一个更加空无的躯骸的形态。她只剩她以前的一小部分力量。"},
				new string[2]{ "Providence is as much the sun goddess as much as the Moon Lord is the moon god. They are two sides of the same coin, choosing to remain neutral amongst our petty squabbles.",
					"亵渎天神乃是耀日之神，一如月球领主乃是皓月之神。祂们是同一枚硬币的两面，选择在我们的争持中保持中立。"},
				new string[2]{ "Touching Providence's offerings is usually a death wish. Shame that Yharim didn't think to just mess with her things to get her out of hiding.",
					"触摸天神的祭品通常是一个死亡的愿望。真遗憾，亚利姆完全没想到只要把她的东西搞得乱作一团就能逼她现身。"},
				new string[2]{ "The Profaned Guardians will do anything to protect their goddess. Makes sense they would die for her since they can be revived just as quickly.",
					"亵渎守卫会尽一切努力保护他们的神。他们会为她而死是有道理的，因为他们可以很快复活。"},
				new string[2]{ "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.",
					"亵渎的生物现在潜伏在圣地和地狱里。如果你杀得足够多，把它们的精华聚集在一起，你就能够吸引那些亵渎守卫的注意。"},
				new string[2]{ "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.",
					"你的探险似乎集中在丛林。在它们的数量失控之前，干掉痴愚金龙和它虫潮一般的后代"},
				new string[2]{ "The plague was just one of the many experiments authorized by Yharim to raze towns to the ground. This is probably one of the few he shelved for being too terrible.",
					"就连瘟疫，也只是亚利姆授权的将城镇夷为平地的众多试验之一。这可能是他为数不多的因为太可怕而被搁置的项目之一。"},
				new string[2]{ "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.",
					"深渊比以前活跃得多。你也许可以开采其中的一些渊泉矿。"},
				new string[2]{ "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.",
					"地牢前面的人正在举行一个仪式，把月亮领主关在他的监狱里。然而，为了引起亚利姆的注意，你可能需要打败他们。"},
				new string[2]{ "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.",
					"当探索丛林神庙时要小心。你也许不想打扰蜥蜴的巨像，那就是石巨人。它有着毁灭性的力量。"},
				new string[2]{ "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.",
					"打败世纪之花和石巨人后要小心。你可能会在丛林中意外地发现一个新的威胁，而这个威胁需要被平息。"},
				new string[2]{ "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!",
					"如果你已经收集了那些用来驱动这些机械的灵魂，那么你可以再次前往丛林。你会发现一个强大的敌人与之战斗，一旦击败它将释放出丛林的全部能量。小心为好！"},
				new string[2]{ "The Brimstone Crags... Yharim despised that place, and did everything he could to raze it to the ground. It might explain a few things about him.",
					"硫火之崖……亚利姆鄙视那个地方，尽一切努力把它夷为平地。这也许可以解释一些关于他的事情。"},
				new string[2]{ "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.",
					"如果你把一个人偶带到硫火之崖边上，你也许能看到隐藏在阴影里的东西。"},
				new string[2]{ "Once those mechanical creations have been defeated you would do well to seek out the crippled clone of the witch, Calamitas. It might provide some useful weaponry.",
					"一旦那些机械造物被击败，你最好去寻找女巫的克隆体，灾厄之眼。它可能会提供一些有用的武器。"},
				new string[2]{ "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.",
					"我建议您保存一些旧的物品。你永远不知道你是否能在未来把它们改造成更强大的武器。"},
				new string[2]{ "Have you heard of the story of Archmage Permafrost? Rumor has it he's been locked away in an icy prison by Lord Yharim. Perhaps you would be able to free him if Cryogen was destroyed.",
					"你听说过Permafrost大法师的故事吗？有传言说他被亚利姆关在冰冷的监狱里。如果那被破坏了，也许你可以解救他。"},
				new string[2]{ "You will find more ores have been unlocked due to the magic sealing them away being dispelled. Some of them may require more than just the ore itself to create.",
					"你会发现更多的矿石已经被解锁，因为魔法曾将它们封印并消散。其中一些可能需要的不仅仅是矿石本身。"},
				new string[2]{ "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.",
					"这个世界中仍存有数个由嘉登一手建造的研究设施。其中陈旧的防御系统仍可能在运行，但其中贮藏的珍宝值得你去为之冒险。"},
				new string[2]{ "The Crimson used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.",
					"血腥之地过去很容易被自然所管理和控制。然而，最近的战争和污染使其失去了平衡。"},
				new string[2]{ "The Corruption used to be easily manageable and controlled by nature. However, the recent wars and pollution have tipped the balance out of favor.",
					"腐化之地过去很容易被自然所管理和控制。然而，最近的战争和污染使其失去了平衡。"},
				new string[2]{ "The dungeon is a dark place. None of us know of its true purpose, however, the ancient Eidolist cultists used it for worship before Lord Yharim took it over.",
					"地牢是一个黑暗的地方。我们谁也不知道它的存在的意义，然而，在亚利姆接管它之前，远古的教徒用它来拜教"},
				new string[2]{ "I'm assuming you've heard the legends that speak of the ninja, Statis? There are some who say that if you were able to defeat the gods which his clan once worshipped you would be able to harness some of his powers.",
					"我猜你听说过有关忍者的传说吧，斯塔提斯？有人说，如果你能打败他家族曾经崇拜的诸神，你就可以利用一些他的力量。"},
				new string[2]{ "Scattered across the lands are shrines dedicated to the gods. You can take whatever is in them, but a few items you may not be able to use until much later.",
					"散布在大地上的是供奉神灵的神龛。你可以拿走里面的所有东西，但有些东西你可能要等很久之后才能使用。"},
				new string[2]{ "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.",
					"小心你的攻击在血腥之地。你可能会暴露出比以前更大的威胁"},
				new string[2]{ "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.",
					"小心你的攻击在腐化之地。你可能会暴露出比以前更大的威胁"},
				new string[2]{ "The Sulphurous Seas were created long ago, when Yharim's dungeon could no longer hold as many corpses as it needed to. Many of the bodies were dumped into the ocean. This, along with severe pollution from the heydays of Draedon's experiments have turned a paradise into a wasteland.",
					"硫磺海是很久以前创造的，那时亚利姆的地牢已经不能容纳足够多的尸体了。许多尸体被扔进海里。这，再加上嘉登实验鼎盛时期的严重污染，把这片圣土变成了一片废土。"},
				new string[2]{ "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.",
					"硫磺海是危险的。有毒的水会灼伤你的皮肤，但如果你能勇敢地面对它们，你就能到达深渊，那里有强大的武器以及危险。"},
				new string[2]{ "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.",
					"啊，是的，深渊。那里到处都是强大的生物，它们能在一瞬间吞噬你。要是我我会先探索地牢。"},
				new string[2]{ "Have you heard of the Brimstone Crags? It was once a grand kingdom, not too different from my own. However, it also met a similar fate. I would not advise going down there, unless you seek a painful death.",
					"你听说过硫火之崖吗？它曾经是一个伟大的王国，和我的王国没有太大的不同。然而，它也遇到了类似的命运。我不建议你去那里，除非你想死得很痛苦。"},
				new string[2]{ "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.",
					"这里有矿石隐藏着。当你击败某些Boss时，你将解除隐藏这些材料的古老魔法。"}
			};
			foreach (string[] chat in seahoeQuotes)
			{
				if (!chat[1].Equals(""))
				{
					Main.npcChatText = Main.npcChatText.Replace(chat[0], chat[1]);
				}
			}
		}
		}
	}

	public override void GetChat(NPC npc, ref string chat)
	{
		if (IsLanguageActive)
		{
		int fapsol = NPC.FindFirstNPC(ModContent.NPCType<FAP>());
		int permadong = NPC.FindFirstNPC(ModContent.NPCType<DILF>());
		int seahorse = NPC.FindFirstNPC(ModContent.NPCType<SEAHOE>());
		int thief = NPC.FindFirstNPC(ModContent.NPCType<THIEF>());
		int witch = NPC.FindFirstNPC(ModContent.NPCType<WITCH>());
		int dryad = NPC.FindFirstNPC(20);
		int angelstatue = NPC.FindFirstNPC(17);
		int armsDealerIndex = NPC.FindFirstNPC(19);
		int nurseIndex = NPC.FindFirstNPC(18);
		int tavernKeep = NPC.FindFirstNPC(550);
		int waifu = NPC.FindFirstNPC(353);
		int partyGirl = NPC.FindFirstNPC(208);
		int lilBitch = NPC.FindFirstNPC(369);
		int pirate = NPC.FindFirstNPC(229);
		int princess = NPC.FindFirstNPC(663);
		int demolitionist = NPC.FindFirstNPC(38);


		string[] givenNames = new string[16];
		for (int j = 0; j < givenNames.Length; j++)
		{
			givenNames[j] = "";
		}
		if (nurseIndex != -1)
		{
			givenNames[0] = Main.npc[nurseIndex].GivenName;
		}
		if (armsDealerIndex != -1)
		{
			givenNames[1] = Main.npc[armsDealerIndex].GivenName;
		}
		if (fapsol != -1)
		{
			givenNames[2] = Main.npc[fapsol].GivenName;
		}
		if (angelstatue != -1)
		{
			givenNames[3] = Main.npc[angelstatue].GivenName;
		}
		if (lilBitch != -1)
		{
			givenNames[4] = Main.npc[lilBitch].GivenName;
		}
		if (partyGirl != -1)
		{
			givenNames[5] = Main.npc[partyGirl].GivenName;
		}
		if (waifu != -1)
		{
			givenNames[6] = Main.npc[waifu].GivenName;
		}
		if (permadong != -1)
		{
			givenNames[7] = Main.npc[permadong].GivenName;
		}
		if (tavernKeep != -1)
		{
			givenNames[8] = Main.npc[tavernKeep].GivenName;
		}
		if (dryad != -1)
		{
			givenNames[9] = Main.npc[dryad].GivenName;
		}
		if (seahorse != -1)
		{
			givenNames[10] = Main.npc[seahorse].GivenName;
		}
		if (thief != -1)
		{
			givenNames[11] = Main.npc[thief].GivenName;
		}
		if (pirate != -1)
		{
			givenNames[12] = Main.npc[pirate].GivenName;
        }
        if (princess != -1)
        {
            givenNames[13] = Main.npc[princess].GivenName;
        }
		if (demolitionist != -1)
		{
			givenNames[14] = Main.npc[demolitionist].GivenName;
        }
		if (witch != -1)
		{
			givenNames[15] = Main.npc[witch].GivenName;
		}

		string fabSpecialQuote = "You're all pretty good!";
		string[][] translatedChat = new string[][] {

			//海王
			new string[2]{
				"How much more has the world fallen to ruin? Even the Tyrant’s empire...",
				"这个世界还有多少地方沦为废墟？甚至是暴君的帝国..."
			},
			new string[2]{
				"Thank you for your service, my child, but I am afraid I am without a home now.",
				"谢谢你的款待，孩子，但是我现在恐怕没有家了。"
			},
			new string[2]{
				"My home may have been destroyed and my people lost... But I will assist you to honor their memory.",
				"我的家园已经毁灭，我的子民也都死了...但为了缅怀它们，我会协助你的。"
			},
			new string[2]{
				"How odd it is, that your people leave the care of those yet to be born to the females. Our males carry the eggs until they hatch.",
				"多么稀奇啊，你们人类会把那些尚未出生的人类幼崽留给雌性人类。我们之中雄性会带着卵子，直到它们孵化。"
			},
			new string[2]{
				"How can I survive on land? Ah, that is a secret. No, actually... I can breathe air like you!",
				"我怎样才能在陆地上生存？啊，那是个秘密。不，事实上...我可以像你一样呼吸空气！"
			},
			new string[2]{
				"Ah, if only you could have seen the beauty of a kingdom submerged in water. The way the light refracted and shone over our coral homes...",
				"啊，如果你能看到海底王国的美丽就好了。光线透过海水照射到我们居住的珊瑚中，多么美好啊..."
			},
			new string[2]{
				"There lurk horrifying creatures beyond the light of our homes. You should take care.",
				"有一些可怕的生物潜伏在我们的家园中阳光照射不到的地方。你要当心。"
			},
			new string[2]{
				"My eyes are not well suited to bright lights after so many years of darkness. The peace of the night is welcome.",
				"经过这么多年的黑暗，我的眼睛已经不太适应明亮的灯光了。宁静的夜晚是值得期待的。"
			},
			new string[2]{
				"Oh, me? I do not sleep, it is part of my nature.",
				"哦，我？我不睡觉，这是我天生的。"
			},
			new string[2]{
				"Since ancient times people have said that deities cause celestial events. Which one then, is the cause for these?",
				"自古以来，人们就说神明会导致天文事件的发生。那么是哪一个导致了这次事件的发生呢？"
			},
			new string[2]{
				"I'm never keen on these nights. They're so violent.",
				"我从不喜欢这些夜晚。这太暴力了。"
			},
			new string[2]{
				"Your presence is now known to a great many things. It is unlikely that they will be as friendly towards you as I have been.",
				"你的存在以及为很多东西所熟知了。他们可不会像我一样对你这么友好。"
			},
			new string[2]{
				"Hm... The veil has fallen, and the world begins to show its true colors. I hope you will trek a righteous path, though even I am not sure what that may be.",
				"嗯……帷幕以及拉下，世界开始展现它的真面目了。我希望你会踏向正义之路，尽管我不知道你可能要面对什么。"
			},
			new string[2]{
				"These days, the night sky feels... just a little less oppressive now.",
				"这几天，夜空给人的感觉……只是少了一些压迫感。"
			},
			new string[2]{
				"Some of these beings I had thought previously to be only legends. To see them in all their glory... what a macabre privilege.",
				"其中一些生物，我以前以为它们只存在于传说中。看到它们的所有荣耀后...多么可怕的荣耀啊。"
			},
			new string[2]{
				"To see that Tyrant’s serpent free of its shackles. It gave me chills.",
				"看到暴君的蛇摆脱了束缚，这让我心寒。"
			},
			new string[2]{
				"Meet me at " + givenNames[4] + "'s house at night. We will throw him to the Trashers.",
				"今晚在" + givenNames[4] + "的房子见我。我们一起去把他丢进硫磺海喂捣鱼。"
			},
			new string[2]{
				"Not sure how " + givenNames[4] + " has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.",
				"我不确定" + givenNames[4] + "在硫酸海中徘徊了这么久现在还没有被烤熟和消化。或许只剩头了"
			},
			new string[2]{
				givenNames[5] + " asked if my nose could be used as a vuvuzela. What is a vuvuzela?",
				givenNames[5] + "问我，我的鼻子是否可以当呜呜祖拉。什么是呜呜祖拉？"
			},
			new string[2]{
				"Rumor has it " + givenNames[2] + " drinks to forget her troubled past.",
				"传言" + givenNames[2] + "为了忘记她过去的烦恼而喝酒。"
			},
			new string[2]{
				"I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.",
				"我承认，至尊女巫的存在让我很不安。但这么多年过去了，她也遭受了很多苦难。"
			},

			//强盗
			new string[2]{
				"Anything is a weapon if you throw it hard enough.",
				"只要够大力，任何物品都能当作武器。"
			},
			new string[2]{
				"That's your chucking arm? You need to work out more.",
				"就凭你这小胳膊也想投掷武器？去健健身吧。"
			},
			new string[2]{
				"Listen here. It's all in the wrist, the wrist! Oh, forget it.",
				"看好了，全靠手腕的巧劲，巧劲！哦，就当无事发生过。"
			},
			new string[2]{
				"Eh you know how it goes; steal from the rich, give to the poor, but I do take a cut of the profit.",
				"你知道我是做什么的；劫富济贫。当然我也会从中分一杯羹。"
			},
			new string[2]{
				"Snakes! Why does it always have to be snakes!",
				"蛇！为什么总要是有蛇！"
			},
			new string[2]{
				"It's super nice you know, to just have everything you want. Some people never got that luxury.",
				"你知道，拥有你想要的一切事物是超级好的，有些人从来没有过这种奢华的体验。"
			},
			new string[2]{
				"It's not stealing! I'm just borrowing it until I die!",
				"这才不是偷！我只不过是借，死的时候再还DA☆ZE！"
			},
			new string[2]{
				"Hm, the stars are too bright tonight. Makes sneaking around a little more difficult.",
				"呃，今晚的星星太亮了，这让偷偷摸摸变得更加困难。"
			},
			new string[2]{
				"You think those stars that fall occasionally would make good throwing weapons?",
				"你觉得时不时从天上掉下来的那些落星会不会是很好的投掷武器？"
			},
			new string[2]{
				"Oy, watch where you're going or I might just use you for dart practice.",
				"嘿，走路瞧着点，我的飞镖可不长眼睛！"
			},
			new string[2]{
				"Bet you'd look good as a pincushion, amiright?",
				"你站在那肯定是想被扎成刺猬，是吧？"
			},
			new string[2]{
				"Zombies don't dodge very well. Maybe you'll do a bit better.",
				"僵尸们不怎么擅长躲避，但愿你比它们强一点。"
			},
			new string[2]{
				"Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.",
				"嘿，别靠近那边！我刚刚做了点手脚，踏错一步你下一秒可能就躺地板上了。"
			},
			new string[2]{
				"Where is my party hat? Well, I stole it of course.",
				"我的派对帽去哪了？对，就是我偷来的那顶。"
			},
			new string[2]{
				"The nice thing about maps is I can track anything that has fallen.",
				"地图最棒的一点是，如果天上有什么东西掉下来能够第一时间找到。"
			},
			new string[2]{
				"Imagine how fast you could throw if you just had more hands.",
				"想象一下，要是多几只手那得能扔的多快啊！"
			},
			new string[2]{
				"Usually I only think of animals as food or target practice, but dragons are an exception.",
				"通常来说动物只是食物或者活靶子，但龙是个例外。"
			},
			new string[2]{
				"I also take food for currency.",
				"你没钱的话，给点吃的也行。"
			},
			new string[2]{
				"I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.",
				"早知道我就不来这的。这地方氛围很糟糕你知道吗？我想起了一些不愉快的回忆。"
			},
			new string[2]{
				"Wouldn't be the first time I used my friends' remains as weapons.",
				"我也不是第一次用我朋友的遗骸当作武器了。"
			},
			new string[2]{
				"All sorts of new weapons to be found and looted. Get to that, and I'll share some of my collection too!",
				"各种新型武器被发现和抢夺。你去搞一点过来，我也会分享一些我的收藏品的！"
			},
			new string[2]{
				"There's so much scrap around this land with valuable parts to them. Makes you wonder who could afford to leave em all around.",
				"这片土地周围有很多废弃物，其中有一些贵重的零件，这让你不禁思考谁会负把它们到处乱扔的责任。"
			},
			new string[2]{
				"Crypts, tombs, dungeons, those're all just treasure troves to me. The dead are dead, they've got nothing to do with it.",
				"墓穴，坟场，地牢，这些对我来说都只是宝库。那些死人以及死了，跟这些宝藏无关。"
			},
			new string[2]{
				"If you find anything cool, make sure to drop by and show it to me, I promise I’ll keep my hands off it.",
				"如果你发现了一些很酷的东西，一定要拿过来让我瞧瞧，我保证会把手从那东西上面拿开的。"
			},
			new string[2]{
				"So many new things to steal, I can’t think of where to start!",
				"这么多新的东西要偷，我都不知道哪一个开始了。"
			},
			new string[2]{
				"If I end up angering some deities or whatever, would you mind taking the blame for me?",
				"如果我最终惹恼了一些神明或者什么的，你介意为我负责吗？"
			},
			new string[2]{
				"Oh man, did you rip that off a shark!? Now that's a weapon!",
				"哦老兄，你把这玩意从鲨鱼身上扯下来了！？现在它是一把武器了！"
			},
			new string[2]{
				"Don't tell " + givenNames[3] + ", but I took some of his stuff and replaced it with Angel Statues.",
				"别告诉" + givenNames[3] + "，我把他的一些货物换成天使雕像了。"
			},
			new string[2]{
				"Hey, hey, has Calamitas seriously moved in here with us? Why???",
				"嘿，嘿，灾厄真的搬进来和我们一起住了吗？为什么？为什么？？？"
			},
			new string[2]{
				"Don't tell " + givenNames[0] + " that I was responsible for " + givenNames[1] + "'s injuries.",
				"别告诉" + givenNames[0] + "其实" + givenNames[1] + "身上那么多伤口我也有责任。"
			},
			new string[2]{
				"I learned never to steal " + givenNames[2] + "'s drinks. She doesn't appreciate me right now, so I'll go back to hiding.",
				"我从不敢偷" + givenNames[2] + "的饮料。她不是很喜欢我，好了，我得继续回去躲着了。"
			},

			//醉仙女
			new string[2]{
				"I could smell my vodka from MILES away!",
				"我在几英里外闻到我的伏特加味！"
			},
			new string[2]{
				"Have any spare rooms available? Preferably candle-lit with a hefty supply of booze?",
				"有空房吗？最好是点着蜡烛有很多很多酒的。"
			},
			new string[2]{
				"I HATE WALMART! ...Anyway, what do you want this time?",
				"我讨厌沃尔玛！...先不说这个，这次你想要什么？"
			},
			new string[2]{
				"Deals so good I'll [$$!$] myself! ...Sorry, just had a minor stroke!",
				"交易这么好，我会[$$!$]我自己！...骚瑞，我只是中风了！"
			},
			new string[2]{
				"Did anyone ever tell you that large assets cause back pain? Well, they were right.",
				"有人告诉过你有钱会引起痛苦吗？嗯，他们是对的。"
			},
			new string[2]{
				"Drink something that turns you into a magical flying unicorn so you can be just like me.",
				"喝一点可以让你变成神奇的飞行独角兽的东西，你就可以变得跟我一样了。"
			},
			new string[2]{
				"I'm literally balls drunk off my sass right now, what do you want?",
				"我现在简直是喝得烂醉如泥，你想要什么？"
			},
			new string[2]{
				"I'm either laughing because I'm drunk or because I've lost my mind, probably both.",
				"我不是因为喝醉了才笑，是因为我疯了。或者可能两者都有。"
			},
			new string[2]{
				"When I'm drunk I'm way happier... at least until the talking worms start to appear.",
				"当我喝醉的时候，我会更快乐……至少直到话痨虫出现之前。"
			},
			new string[2]{
				"I should reprogram the whole mod, while drunk, then send it back to the testers.",
				"我应该在喝醉的时候重新编程整个游戏，然后把它送回测试人员那里。"
			},
			new string[2]{
				"A perfect night to light some candles, drink some wine and relax.",
				"一个完美的夜晚，就要点一些蜡烛，喝一点酒，尽情放松。"
			},
			new string[2]{
				"Here's a challenge... take a shot for every time you've had to look at the wiki. Oh wait, you'd die.",
				"来点挑战……每次你不得不看wiki的时候就扎自己一针。哦等等，这样你会死的。"
			},
			new string[2]{
				"Yes, everyone knows the mechworm is buggy. Well, not anymore, but still.",
				"是的，所有人都知道机械蠕虫是神经病。好吧，现在不是了，但不完全不是。"
			},
			new string[2]{
				"You lost or something? I don't mind company, but I'd rather be left alone at night.",
				"你是打输了还是怎么了？我不介意有人陪着，但我更愿意晚上一个人待着。"
			},
			new string[2]{
				"Are you sure you're 21? ...Alright, fine, but don't tell anyone I sold you these.",
				"你确定你21岁了？……好吧，好吧，但别告诉任何人我卖给你这个。"
			},
			new string[2]{
				"I'm gonna make some Bloody Marys to relax, celery included. Want one?",
				"我要去调配一些血腥玛丽放松一下，里面有一些芹菜。要来一杯吗？"
			},
			new string[2]{
				"If you're too lazy to craft potions normally, try Blood Orbs. Blood is fuel, dumbass.",
				"如果你无法顺利炼药，试试血珠。血珠就是药材，笨蛋。"
			},
			new string[2]{
				"I'm trying to not be bitchy tonight, but it's hard when everyone else won't shut up.",
				"今晚我尽量控制自己不发脾气，但其他人都不闭嘴的话，这很难办到。"
			},
			new string[2]{
				"Sorry, I have no moral compass at the moment.",
				"对不起，现在的我没有道德底线。"
			},
			new string[2]{
				"You'll always find me at parties where booze is involved... well, you'll always find BOOZE where I'M involved!",
				"你总是会在涉及到喝酒的聚会上找到我...嗯，你也总是会在我参加聚会的地方找到酒精！"
			},
			new string[2]{
				"I'm melting! Put a stop to this inclement weather this instant before it ruins my hair!",
				"我要融化了！在它毁掉我的头发之前，赶紧停止这种恶劣的天气！"
			},
			new string[2]{
				"You should probably deal with those ayy lmaos before anything else, but whatever.",
				"也许你应该先和那些外星人打好交道。不管怎么都是。"
			},
			new string[2]{
				"Why are you talking to me right now? Shouldn't you be bumbling around and dying for my amusement?",
				"你为什么在跟我说话？你难道不应该到处闲逛，然后为了我的快乐而惨死吗？"
			},
			new string[2]{
				"God I can't wait to smash some ice again! ...For drinks, of course.",
				"天哪，我等不及要搞点冰了！...当然，是为了饮料。"
			},
			new string[2]{
				"How could you murder such a beautiful creature!? ...The blue sexy one, not the obese cucumber.",
				"你怎么忍心杀害这么漂亮的生物？...是性感的蓝色的那个，而不是那个肥胖的黄瓜。"
			},
			new string[2]{
				"I saw a ghost down by the old train tracks back at my homeland once, flailing wildly at the lily pads... frightening times those were.",
				"有一次，我看见一个鬼魂从废弃火车轨道上下来，在百合花丛疯狂舞蹈。就是那些日子。"
			},
			new string[2]{
				"I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!",
				"I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!(这是个梗)"
			},
			new string[2]{
				"Tell " + givenNames[8] + " to stop calling me. He's not wanted.",
				"告诉" + givenNames[8] + "别再找我了，他不合我的口味"
			},
			new string[2]{
				"I've had to tell baldie where my eyes are so many times that I've lost count.",
				"我不得不多次告诉那个秃头我的眼睛在哪儿，我都数不清我说了多少次了。"
			},
			new string[2]{
				"My booze will always be better than " + givenNames[8] + "'s, and nobody can convince me otherwise.",
				"我的酒可比" + givenNames[8] + "的好多了，关于这个事实没人说服得了我。"
			},
			new string[2]{
				"You can't stop me from trying to move in with " + givenNames[6] + ".",
				"你不能阻止我和" + givenNames[6] + "住在一起。"
			},
			new string[2]{
				"I love it when " + givenNames[6] + "'s hands get sticky from all that... wax.",
				"我非常享受" + givenNames[6] + "的手沾上了那些黏黏的浓稠的……发蜡的时候。"
			},
			new string[2]{
				givenNames[6] + " works wonders for my hair... among other things.",
				givenNames[6] + "对我的头发...还有其他的东西都有奇效。"
			},
			new string[2]{
				"Ever since " + givenNames[6] + " moved in I haven't been drinking as much... a strange but not unwelcome feeling.",
				"当" + givenNames[6] + "搬进来后，我就没有喝多过了...这种感觉很奇怪。"
			},
			new string[2]{
				"I should watch some movies with " + givenNames[6] + " tonight. You could come too, but only if you bring snacks for us.",
				"今晚我应该和" + givenNames[6] + "看电影。你也可以来，前提是你得给我们带点零食。"
			},
			new string[2]{
				"The abuse Calamitas went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.",
				givenNames[15] + "经历了我难以想象的苦难。我想要给她一杯酒，但我想她不会喜欢的"
			},
			new string[2]{
				"I never realized how well-endowed " + givenNames[7] + " was. It had to be the largest icicle I'd ever seen.",
				"我从来没意识到" + givenNames[7] + "有多么幸运。这是我这辈子见过最大的冰柱。"
			},
			new string[2]{
				givenNames[6] + " helped me learn to accept my past. It's been rough, but I think I'm on the right track now.",
				givenNames[6] + "帮助我学会了接受我的过去。虽然他教的很粗略，但我想我现在正走在正确的道路上。"
			},
			new string[2]{
				"Might go out for a jog later with " + givenNames[6] + ". Nice day for it.",
				"以后可以和 " + givenNames[6] + " 出去慢跑了。真是美好的一天。",
			},
			new string[2]{
				"I drink to forget certain... things. What things, you might ask? Well, the point is to forget them, isn't it?",
				"我喝酒是为了忘记一些事情...你可能会问“什么事情啊”，但重点是忘记它们，忘记，懂吗？",
			},
			new string[2]{
				"What a great day! Might just drink so much that I get poisoned again.",
				"多么美好的一天，可能我喝得太多了，我又中毒了。"
			},
			new string[2]{
				"Ever wondered why the Moon Lord needed so many tentacles? Uh... on second thought, I won't answer that.",
				"为什么一个生物需要那么多触手...事实上，不要回答这个问题。"
			},
			new string[2]{
				"Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.",
				"哦，是的，现在你喝的是好东西！你喜欢吗？我把仙尘、水晶和其他魔法物质混合在一起创造了这个配方。"
			},
			new string[2]{
				"The hell is that? Looks like something I'd carry around if I was 5 years old.",
				"地狱就这？看上去像我5岁的时候会随身拿着玩的东西。"
			},
			new string[2]{
				"Nice scales... is it hot in here or is it just me?",
				"真好看的鳞片...这里面很热吗？还是说只有我这样觉得？"
			},
			new string[2]{
				"So... you found my special bottle. Hope you enjoy it, I know I will.",
				"所以...你找到了我特别的瓶子。希望你能喜欢它，我知道我会的。"
			},
			new string[2]{
				"Be sure to dismount me once in a while, I get tired. And besides, I can't rip you off-I mean offer you excellent deals you won't find anywhere else if you're riding me 24/7.",
				"我很肯定我累的感觉快要被拆掉了。另外，我不会把你撕碎——我的意思是我可以给你一个很棒的，在其它地方都找不到的交易，你可以永远骑着我。"
			},
			new string[2]{
				"Before you ask, no, I do NOT have a heart on my butt while in human form. Don't question my transformation preferences!",
				"在你提问之前，不，我的屁股上没有爱心。不要质疑我的嗜好！"
			},

			//大法师
			new string[2]{
				"I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...",
				"我非常感谢你把我从冰冻的城堡里解救出来。已经过去很多年了……"
			},
			new string[2]{
				"I have not seen such a sky in decades. Who are you, to so brazenly march against that Tyrant?",
				"我已经很久没有见过这样的天空的。你究竟是谁？你是怎么敢如此明目张胆地反抗那个暴君的？"
			},
			new string[2]{
				"The tundra’s unnatural state is not all my doing. Decades ago, I came across it and amplified the climate with my magic.",
				"冻土带的反常气候并不完全是我造成的。几十年前，我偶然发现了这件事儿，并用我的魔法将气候变得更加舒适。"
			},
			new string[2]{
				"If you have a request, make it quick. I am in the process of weaving a spell, which requires great focus.",
				"如果你找我有事儿，那就赶紧说。我正在准备一个新的咒语，这需要极高的专注度。"
			},
			new string[2]{
				"You have the makings of a gifted mage. Tell me, what do you think of ice magic?",
				"你很有法师的天赋和气质啊。告诉我，你觉得冰魔法怎么样？"
			},
			new string[2]{
				"Flowers and the like don’t hold a candle to the beauty of intricately formed ice.",
				"花卉和其它类似的东西根本无法与变化万象的冰的美丽相提并论。."
			},
			new string[2]{
				"The sun beats down harshly upon my creations here. If you would allow me to conjure a blizzard every now and then...",
				"阳光猛烈地照耀在大地上。如果你愿意的话，我可以时不时地召唤一场暴风雪……"
			},
			new string[2]{
				"I must admit, I’m not quite used to this weather. It's far too warm for my tastes...",
				"我必须承认，我不太习惯这种天气。这对我来说实在是过于暖和了……"
			},
			new string[2]{
				"Nightfall is a good time for practicing magic. We mages often rely on celestial bodies and their fragments to enhance our mana.",
				"黄昏时分是练习魔法的好时机。我们魔法师经常依靠天体以及它们的碎片来增强我们的法力。"
			},
			new string[2]{
				"Necromancy was never a field I found interesting. Why utilize the rotting corpses of people, when you could form far more elegant servants of ice?",
				"我从来都不会对死灵魔法这种东西感兴趣。既然你可以利用更加优雅的冰块为你服务，那么为什么还要用腐烂的尸体呢？"
			},
			new string[2]{
				"Sometimes... I feel like all I'm good for during these events is making ice cubes and slushies.",
				"有时候……我觉得在这些活动中我能做的就是做冰块和冰泥。"
			},
			new string[2]{
				"If your blood were to thoroughly freeze, it would be quite fatal.",
				"如果你的血液完全冻结，那将会致命。"
			},
			new string[2]{
				"The undead which roam tonight are still monsters of blood and guts, but they seem... fresher.",
				"今晚夜里游荡的亡灵依然是血肉与内脏组成的，但它们看上去似乎是……新鲜的？"
			},
			new string[2]{
				"It is shocking, to see you have come so far. I wish you the best of luck on your future endeavours.",
				"看到你走了这么长的路，真令人震撼啊。祝你在今后的努力中取得好运。"
			},
			new string[2]{
				"You, having bested so many beings, even deities, I wonder if I have anything left to offer you.",
				"你，战胜了那么多人，甚至是众神，我想知道我是否还有什么可以帮到你的。"
			},
			
			//灾厄
			new string[2]{
				"I'm considering moving back to that old cave of mine.",
				"我正在考虑搬回那个老山洞里去。"
			},
			new string[2]{
				"I certainly can't return to the Tyrant's old dwellings now, have you got any places to stay?",
				"我现在肯定不能再回魔君哪儿去了。你这儿有地方住吗？"
			},
			new string[2]{
				"I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?",
				"我付不起房租，但如果你有什么已逝的亲人，你也想让我试试……什么，你没有吗？"
			},
			new string[2]{
				"One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning.",
				"有一天，我想用地狱旧都的花建一个花园。清晨的硫磺火散发的味道令我沉醉。"
			},
			new string[2]{
				"I think I've settled comfortably, thank you very much.",
				"我想我已经安顿好了，非常感谢。"
			},
			new string[2]{
				"Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger...",
				"自从我第一次与魔君见面以来四季轮转，岁月变迁，直到现在我才挣脱了束缚。希望我能够更加坚强……"
			},
			new string[2]{
				"If you've got any curses you want dispelled... well I'm not your person.",
				"如果你想要驱散什么诅咒的话……那你就找错人了。"
			},
			new string[2]{
				"These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?",
				"那些亡灵生物太可怕了，我简直无法直视它们。为什么有人会有这样的业余爱好呢？"
			},
			new string[2]{
				"I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once.",
				"我一点儿也不觉得说占星术是无稽之谈是夸大其词……但我曾经是一个占星爱好者。"
			},
			new string[2]{
				"Such an unnatural shade of red. Nothing like my brimstone flames.",
				"这非自然的血红夜幕啊。没有什么红色比得上我的硫磺火焰了。"
			},
			new string[2]{
				"I can't work with nights like these. The stars seem to have shrunk away in fear.",
				"我无法在这样的夜晚工作。星星似乎都因为恐惧而缩小了。"
			},
			new string[2]{
				"If another person asks me if I can dance or not, I will light their hat on fire.",
				"如果有人问我会不会跳舞，我会让他们的帽子在火焰中跳舞。"
			},
			new string[2]{
				"I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.",
				"我无法理解海王。他似乎并不希望让我死。我无法理解他对我有如此深的同情。"
			},
			new string[2]{
				"That frosty old man... even if you ignore our brands of magic and our old alliances, I doubt I'd ever get along with him.",
				"那个老冰男……即使你忽视我们的魔法类型和老盟友，我也会怀疑我是否能和他和睦相处。"
			},
			new string[2]{
				"I wonder if Cirrus ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.",
				"考虑到" + givenNames[2] + "的衣着如此暴露，我想知道，她是否觉得冷过。也许她应该多穿一点。"
			},
			new string[2]{
				"Mrrp is cringe.",
				"Mrrp真是胆小鬼。\n哈？你不知道他是谁？就写背景故事的那家伙啊！！"
			},

			//原版
			//渔夫
			new string[2]{
				"Someone tell " + givenNames[10] + " to quit trying to throw me out of town, it's not going to work.",
				"有人说" + givenNames[10] + "想把我赶出镇子，那是不存在的。"
			},

			//军火商
			new string[2]{
				"That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.",
				"那是我见过的最大的蛾子。你得需要一把大枪才能把它们给射下来。"
			},
			new string[2]{
				"Is it me or are your weapons getting bigger and bigger?",
				"是我越来越小，还是你的武器越来越大？"
			},

			//服饰商
			new string[2]{
				"Houston, we've had a problem.",
				"休斯顿，我们遇上麻烦了。"
			},
			new string[2]{
				"Who you gonna call?",
				"你想叫谁？"
			},
			new string[2]{
				"Those screams...I'm not sure why, but I feel like a nameless fear has awoken in my heart.",
				"那些尖叫……不知道为什么，但我觉得一种莫名的恐惧已经在我的心中醒来。"
			},
			new string[2]{
				"I can faintly hear ghostly shrieks from the dungeon...and not ones I'm familiar with at all. Just what is going on in there?",
				"我能隐约听到地牢里的鬼哭嚎叫……而我根本不熟悉这些。那里发生了什么？"
			},
			new string[2]{
				"Whatever that thing was, I'm glad it's gone now.",
				"不管那东西是什么，我很高兴它现在没了。"
			},

			//机器人
			new string[2]{
				"All these moments will be lost in time. Like tears...in the rain.",
				"所有这一刻都将随着时间流逝而消失。就像雨中的……眼泪。"
			},
			new string[2]{
				"Always shoot for the moon! It has clearly worked before.",
				"总是朝月亮开枪！很明显，这以前起过作用。"
			},
			new string[2]{
				"Draedon? He's...a little 'high octane' if you know what I mean.",
				"嘉登？如果你懂我的意思，我说他有点“高辛烷值”。"
			},
			new string[2]{
				"Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!",
				"那些吓人的丛林里的大虫子……你当然可以把他们干掉了！"
			},

			//爆破商
			new string[2]{
				"God Slayer Dynamite? Boy do I like the sound of that!",
				"弑神者雷管？我喜欢那声音！"
			},

			//森林女神
			new string[2]{
				"There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?",
				"这段时间出现的飞蛾散发出一种黑暗的太阳能量。啊，飞蛾随着你的发展也变得越来越强大……嗯……犽戎之前没有使出他的全部力量？"
			},
			new string[2]{
				"That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?",
				"那星辉瘟疫像水泡一样存在于这片土地上。难道世界上还有更多邪恶地形吗"
			},
			new string[2]{
				"\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.",
				"\u0093我才不想呆在这！我在这是为了捡蘑菇，呃，留着以后用。"
			},
			new string[2]{
				givenNames[2] + " put me up to this.",
				givenNames[2] + " 让我来。"
			},
			new string[2]{
				"My ancestor was lost here long ago. I must pay my respects to her.",
				"我的祖辈很久以前就走了。我必须向她表示敬意。"
			},

			//染料商
			new string[2]{
				"Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!",
				"你看到洞穴里那些宝石生物了吗？它们的颜色简直令人叹为观止！"
			},
			new string[2]{
				"Do you think " + givenNames[7] + " knows how to 'let it go?'",
				"你认为" + givenNames[7] + "知道怎样“随它吧”？'"
			},

			//哥布林工匠
			new string[2]{
				"Hey, is it just me or have my pockets gotten lighter ever since " + givenNames[11] + " arrived?",
				"嘿，是我减肥了，还是我的钱包在" + givenNames[11] + "到达后变轻了？"
			},
			new string[2]{
				"You know...we haven't had an invasion in a while...",
				"你知道...我们已经有一段时间没有入侵了..."
			},

			//向导
			new string[2]{
				"Could you be so kind as to, ah...check hell for me...? I left someone I kind of care about down there.",
				"你能不能发点好心，额...帮我查一下地狱...？我把一个我关心的人留在下面了。"
			},
			new string[2]{
				"I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.",
				"我的脊椎突然颤抖起来，就像流星落下，成千上万无辜的生物变成了来自群星的怪物。"
			},
			new string[2]{
				"The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.",
				"地牢似乎比平时更不安宁，小心里面强大的憎恨之物激起的怒火。"
			},
			new string[2]{
				"Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!",
				"就好像那只扑火的蝴蝶使它的生命渗入了圣域，试着窥视那里，看看你能找到什么！"
			},
			new string[2]{
				"I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!",
				"我听说有一个反物质之门吸收了它在地牢里看到的一切，试试在那里使用宇宙符文吧！"
			},

			//机械师
			new string[2]{
				"What do you mean your traps aren't making the cut? Don't look at me!",
				"你说你的机关没成功是什么意思？和我没关系！"
			},
			new string[2]{
				"Um...should my nightlight be on?",
				"呃……我的夜灯需要开着吗？"
			},
			new string[2]{
				"Well, I like " + givenNames[2] + ", but I, ah...I have my eyes on someone else.",
				"嗯，我喜欢" + givenNames[2] + "，但是我，呃...心里已有他人"
			},
			new string[2]{
				"Maybe I should've waterproofed my gadgets... They're starting to corrode.",
				"也许我应该给我的小玩意儿加入防水功能...它们已经开始被腐蚀了。"
			},

			//商人
			new string[2]{
				"Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.",
				"每天晚上似乎都比昨天更不祥。你的一举一动让我感到不可思议的恐惧。"
			},
			new string[2]{
				"Are you daft?! Turn off those lamps!",
				"你制杖吗？！快把那些破灯关掉！"
			},
			new string[2]{
				"If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!",
				"如果这场酸雨持续下去，很快就会出现土块短缺的情况！"
			},
			new string[2]{
				"I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?",
				"我现在拥有好几个天使雕像，那可真是稀世珍品啊！你要来一个吗？"
			},
			new string[2]{
				"The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.",
				"最近洞穴里越来越黑了，如果你有钱，我这有一些特殊火把存货"
			},

			//护士
			new string[2]{
				"Now is not the time!",
				"现在不是治疗的时候！"
			},

			//画家
			new string[2]{
				"A little sickness isn't going to stop me from doing my work as an artist!",
				"一点点的不舒服无法阻止我身为画家的工作！"
			},
			new string[2]{
				"There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!",
				"这个地区有一种惊人的艺术。这种感觉令人感到震撼。它鼓舞了我！"
			},
			new string[2]{
				"Think " + givenNames[7] + " would let me paint him like one of his French girls?!",
				"以为" + givenNames[7] + "会让我把他画得像个法国女孩？！"
			},
			new string[2]{
				"I'm not exactly suited for this cold weather. Still looks pretty, though.",
				"我不适应这种寒冷的天气。不过，看起来还是挺漂亮的。"
			},
			new string[2]{
				"I hate sand. It's coarse, and rough and gets in my paint.",
				"我讨厌沙子。它很不平滑，很粗糙，会沾到我的油漆里。"
			},
			new string[2]{
				"Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.",
				"你认为独角兽的血可以用作一种好的颜料色素吗？不，我不会自己去找的。"
			},
			new string[2]{
				"I can't work in this environment. All of my paint just floats off.",
				"我无法在这种环境下工作。我所有的油漆都掉了。"
			},
			new string[2]{
				"Painting the tortoises in a still life isn't going so well.",
				"在静物画中画乌龟不太好。"
			},
			new string[2]{
				"I can't paint a still life if the fruit grows legs and walks away.",
				"如果水果长腿跑路了，我就不能画静物画了。"
			},
			new string[2]{
				"On the canvas, things get heated around here all the time. Like the environment!",
				"在画布上，任何时候东西都会被加热，就像环境一样！"
			},
			new string[2]{
				"Sorry, I'm all out of watercolors. They keep evaporating.",
				"不好意思，水彩画脱销了，它们总是在被热卖。"
			},
			new string[2]{
				"Roses, really? That's such an overrated thing to paint.",
				"玫瑰，是吗？那画起来确实很难。"
			},
			new string[2]{
				"Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?",
				"有趣的事实！硫磺曾经被用作颜料！还是朱砂来着？"
			},
			new string[2]{
				"Easiest landscape I've ever painted in my life.",
				"这是我这辈子画过的最简单的风景画。."
			},

			//派对女孩
			new string[2]{
				"I have a feeling we're going to have absolutely fantastic parties with " + givenNames[2] + " around!",
				"我有种感觉我们会在" + givenNames[2] + "周围举办非常棒的派对！"
			},
			new string[2]{
				"I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.",
				"我想我的灯光变成了个意料之外的机器。但至少，怪物们会喜欢它的。"
			},
			new string[2]{
				"Ooh! I love parties where everyone wears a scary costume!",
				"哦！我爱这样每个人都穿着奇服异装的派对！"
			},

			//海盗
			new string[2]{
				"Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.",
				"是的，我听说有一种神秘的海洋生物，用迷人的声音唱歌。在外面钓鱼时要小心。"
			},
			new string[2]{
				"I have to thank ye again for takin' care of that sea serpent. Or was that another one...",
				"我要再次感谢你们照顾那条海蛇。或者那是另一条..."
			},
			new string[2]{
				"I remember legends about that " + givenNames[10] + ". He ain't quite how the stories make him out to be though.",
				"我记得关于" + givenNames[10] + "的传说，不过他不是很明白那些故事是怎么出来的。"
			},
			new string[2]{
				"Twenty-nine bottles of beer on the wall...",
				"二十九瓶啤酒在墙上..."
			},
			new string[2]{
				"Now this is a scene that I can admire any time! I feel like something is watching me though.",
				"现在这一幕我可以随时欣赏！但我觉得好像有什么东西在看着我。"
			},
			new string[2]{
				"It ain't much of a sight, but there's still life living in these waters.",
				"虽然表面上一片死寂，但在这些水域里仍然有生命。"
			},
			new string[2]{
				"Me ship might just sink from the acid alone.",
				"我的船可能会因为酸性而沉没。"
			},

			//骷髅商人
			new string[2]{
				"What'dya buyin'?",
				"你买啥？"
			},

			//蒸汽朋克人
			new string[2]{
				"Just what is that contraption? It makes my Teleporters look like child's play!",
				"那是什么玩意儿？它使我的传送机看起来像个儿童玩具！"
			},
			new string[2]{
				"Yep! I'm also considering being a space pirate now.",
				"是的！我现在也在考虑当一名太空大盗。"
			},
			new string[2]{
				"Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here",
				"由于星辉瘟疫，我的一些机器开始出故障。我可能本不该在这里修建的。"
			},
			new string[2]{
				"I'm sorry I really don't have any Unicorn proof tech here, you're on your own.",
				"对不起，我这里真的没有独角兽保护技术，你自己来吧。"
			},

			//发型师
			new string[2]{
				"Please don't catch space lice. Or " + "Crimson" + " lice. Or just lice in general.",
				"请不要抓太空虱子，或者血腥虱子，或者仅仅是普通的虱子。."
			},
			new string[2]{
				"Please don't catch space lice. Or " + "Corruption" + " lice. Or just lice in general.",
				"请不要抓太空虱子，或者腐化虱子，或者仅仅是普通的虱子。"
			},
			new string[2]{
				"Sometimes I catch " + givenNames[2] + " sneaking up from behind me.",
				"有时我发现" + givenNames[2] + "从我背后偷偷跟上来。"
			},
			new string[2]{
				givenNames[2] + " is always trying to brighten my mood...even if, deep down, I know she's sad.",
				givenNames[2] + "总是想让我心情愉快……即使，我知道她的内心深处很伤心。"
			},
			new string[2]{
				"They look so cute and yet, I can feel their immense power just by being near them. What are you?",
				"它们看上去如此可爱，然而一靠近它们，我就能感受到它们恐怖的力量。你怎么看？"
			},
			new string[2]{
				"I hate to break it to you, but you don't have hair to cut or style, hun.",
				"我不想打发你走，但是你的头发确实不需要剪，也没有发型。嗯。"
			},
			new string[2]{
				"Aww, they're so cute, do they have names?",
				"哇偶，它们太可爱了，你为它们起名字了吗？"
			},

			//酒保
			new string[2]{
				"Care for a little Moonshine?",
				"想要一些私酿吗？"
			},
			new string[2]{
				"Sheesh, " + givenNames[2] + " is a little cruel, isn't she? I never claimed to be an expert on anything but ale!",
				"先生，" + givenNames[2] + "有那么点无情，不是吗？我从来没有声称自己是除了啤酒以外的任何东西的专家！"
			},

			//税收官
			new string[2]{
				"BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!",
				"呸！好像我没必要因镇上的债务争吵了！"
			},
			new string[2]{
				"Where and how are you getting all of this money?",
				"这些钱你到底是怎么弄来的？"
			},
			new string[2]{
				"Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!",
				"也许你有时间可以去检查一下那些古老的遗迹？对你来说那里会有有价值的东西！"
			},
			new string[2]{
				"Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!",
				"你说什么吞噬者？资金吞噬者，如果它的工资能是任何东西！"
			},
			new string[2]{
				"Goodness! That cane has swagger!",
				"我的天！那根拐杖太装逼了！"
			},

			//旅商
			new string[2]{
				"Tell " + givenNames[2] + " I'll take up her offer and meet with her at the back of " + givenNames[3] + "'s house.",
				"去告诉" + givenNames[2] + "，我会接受她的建议并且会和她在" + givenNames[3] + "的房子那儿见面。"
			},

			//松露人
			new string[2]{
				"I don't feel very safe; I think there's pigs following me around and it frightens me.",
				"我感到不太安全，我觉得这有贪婪之物正在跟着我，这让我害怕。"
			},
			new string[2]{
				"Sometimes, " + givenNames[2] + " just looks at me funny and I'm not sure how I feel about that.",
				"有时，" + givenNames[2] + "只看着我很有趣而我不知道我对此有何感受。"
			},

			//巫医
			new string[2]{
				"My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...",
				"我这里的家有着悠久的历史和神秘的过去。你很快就会发现它有多么广博..."
			},
			new string[2]{
				"I have unique items if you show me that you have bested the guardian of this jungle.",
				"如果你打败了这片丛林的守护者，我会给你展示我独特的物品。"
			},
			new string[2]{
				"This is as good a time as any to pick up the best ingredients for potions.",
				"这是一个很好的时间来挑选最好的药水成分。"
			},

			//法师
			new string[2]{
				"Space just got way too close for comfort.",
				"这空间太小了，让人感到难受"
			},
			new string[2]{
				"I'd let " + givenNames[7] + " coldheart MY icicle.",
				"我想让" + givenNames[7] + "冰冷的心成为我的冰柱"
			},

		};
		bool found = false;
		int i = 0;
		if (chat.EndsWith(fabSpecialQuote))
		{
			chat = chat.Replace("Hey ", "嘿 ").Replace(" and ", " 和 ").Replace(fabSpecialQuote, "你们都好棒!");
			found = true;
		}
		while (i < translatedChat.Length && !found)
		{
			if (chat.Equals(translatedChat[i][0]) && !translatedChat[i][1].Equals(""))
			{
				chat = translatedChat[i][1];
				found = true;
			}
			i++;
		}
	}
	}	
}