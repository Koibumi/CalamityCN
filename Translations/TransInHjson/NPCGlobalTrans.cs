using CalamityCN;
using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.Polterghast;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.NPCs.Yharon;
using System;
using Terraria;
using Terraria.ModLoader;

public class NPCGlobalTrans : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.IsCN && ModsCall.Calamity != null;
    }

    public override void ModifyTypeName(NPC npc, ref string typeName)
    {
        if (npc.type == ModContent.NPCType<Yharon>())
        {
            typeName = typeName.Replace("Yharon, Resplendent Phoenix", LangHelper.GetText("CalamityMod.NPCs.Name.Yharon"));
        }
        if (npc.type == ModContent.NPCType<Apollo>())
        {
            typeName = typeName.Replace("Corrosive Eye of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.0"));
            typeName = typeName.Replace("XS-03 Apollo", LangHelper.GetText("CalamityMod.NPCs.Name.Apollo"));
        }
        if (npc.type == ModContent.NPCType<AresBody>())
        {
            typeName = typeName.Replace("XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.1"));
        }
        if (npc.type == ModContent.NPCType<AresGaussNuke>())
        {
            typeName = typeName.Replace("XB-∞ Hekate Gauss Nuke", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.2"));
        }
        if (npc.type == ModContent.NPCType<AresLaserCannon>())
        {
            typeName = typeName.Replace("XB-∞ Hekate Laser Cannon", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.3"));
        }
        if (npc.type == ModContent.NPCType<AresPlasmaFlamethrower>())
        {
            typeName = typeName.Replace("XB-∞ Hekate Plasma Flamethrower", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.4"));
        }
        if (npc.type == ModContent.NPCType<AresTeslaCannon>())
        {
            typeName = typeName.Replace("XB-∞ Hekate Tesla Cannon", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.5"));
        }
        if (npc.type == ModContent.NPCType<ThanatosBody1>())
        {
            typeName = typeName.Replace("Spine of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.6"));
        }
        if (npc.type == ModContent.NPCType<ThanatosBody2>())
        {
            typeName = typeName.Replace("Spine of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.6"));
        }
        if (npc.type == ModContent.NPCType<ThanatosHead>())
        {
            typeName = typeName.Replace("Spine of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.6"));
        }
        if (npc.type == ModContent.NPCType<ThanatosTail>())
        {
            typeName = typeName.Replace("Spine of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.6"));
        }
        if (npc.type == ModContent.NPCType<Artemis>())
        {
            typeName = typeName.Replace("Blazing Eye of XB-∞ Hekate", LangHelper.GetText("CalamityMod.NPCs.Name.Hekate.7"));
            typeName = typeName.Replace("XS-01 Artemis", LangHelper.GetText("CalamityMod.NPCs.Name.Artemis"));
        }
        if (npc.type == ModContent.NPCType<Polterghast>())
        {
            typeName = typeName.Replace("Necroghast", LangHelper.GetText("CalamityMod.NPCs.Name.Polterghast.0"));
        }
        if (npc.type == ModContent.NPCType<Polterghast>())
        {
            typeName = typeName.Replace("Necroplasm", LangHelper.GetText("CalamityMod.NPCs.Name.Polterghast.1"));
        }
        if (npc.type == ModContent.NPCType<Polterghast>())
        {
            typeName = typeName.Replace("Polterghast", LangHelper.GetText("CalamityMod.NPCs.Name.Polterghast.2"));
        }
        /*
        if (npc.type == ModContent.NPCType<>())
        {
            typeName = typeName.Replace("", LangHelper.GetText("CalamityMod.NPCs.Name."));
        }
        */
    }
    public override void OnChatButtonClicked(NPC npc, bool firstButton)
    {
            if (npc.type == ModContent.NPCType<FAP>() && !firstButton)
            {
                int dc = CalamityUtils.Calamity(Main.player[Main.myPlayer]).deathCount;
                if (dc <= 100)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.1", dc);
                }
                else if (dc > 100 && dc <= 250)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.2", dc);
                }
                else if (dc > 250 && dc <= 500)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.3", dc);
                }
                else if (dc > 500 && dc <= 1000)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.4", dc);
                }
                else if (dc > 1000 && dc <= 2500)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.5", dc);
                }
                else if (dc > 2500 && dc <= 5000)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.6", dc);
                }
                else if (dc > 5000 && dc <= 10000)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.7", dc);
                }
                else if (dc > 10000)
                {
                    Main.npcChatText = LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.Death.8", dc);
                }
            }

            if (npc.type == ModContent.NPCType<THIEF>() && !firstButton)
            {
                int goblinIndex = NPC.FindFirstNPC(107);
                if (goblinIndex != -1)
                {
                    NPC goblin = Main.npc[goblinIndex];
                    Main.npcChatText = Main.npcChatText.Replace("Want in on a little secret? Since " + goblin.GivenName + " always gets so much cash from you, I've been stealing some of it as we go. I need you to keep quiet about it, so here.", LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.1", goblin.GivenName));
                    Main.npcChatText = Main.npcChatText.Replace("Hey, if government officials can get tax, why can't I? The heck do you mean that these two things are nothing alike?", LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.2", Array.Empty<object>()));
            }
                Main.npcChatText = Main.npcChatText.Replace("Sorry, I got nothing. Perhaps you could reforge something and come back later...", LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.3", Array.Empty<object>()));
        }
            if (npc.type == ModContent.NPCType<SEAHOE>() && !firstButton)
            {
                string[][] seahoeQuotes = new string[][]
                {
                new string[2]{ "Draedon isn't a frontline fighter; he is a scientist and inventor. He is unlikely to face you directly, and will likely have his creations confront you instead. Be prepared for anything that blasphemous machine could throw at you.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.1", Array.Empty<object>())},
                new string[2]{ "The Golden Heretic, Yharim, possesses strength that may just surpass all of the Gods. When you face him, be well prepared for the battle of your life.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.2", Array.Empty<object>())},
                new string[2]{ "Auric is near impossible to work with without being attuned to a Dragon or using the claimed soul of a Dragon to perform a \"mock\" attunement. However, if one can work with it truly powerful things can be created; enough so that using it in anything was deemed heretical by the Gods.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.3", Array.Empty<object>())},
                new string[2]{ "Ah, the dragon Yharon is fickle. You may find that he will refuse to use his full power unless you are strong enough to unleash the power of the Dark Sun.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.4", Array.Empty<object>())},

                new string[2]{ "The Devourer of Gods is truly an enigma. Some say it's not even from this world at all. What is known is that he is a being that can devour the essence of Gods entirely, leaving absolutely nothing left. It's no wonder Yharim recruited that monster.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.5", Array.Empty<object>())},
                new string[2]{ "With the cosmic steel you can fashion many of your weapons into much more powerful forms.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.6", Array.Empty<object>())},
                new string[2]{ "The Devourer's armor was specially made by Draedon. Extremely flexible yet durable and massive, it may be one of his most impressive creations. I shudder to think of what unholy things he may be able to create now, if his research has not stopped.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.7", Array.Empty<object>())},

                new string[2]{ "Ah...I can sense a powerful change in the weather. You may want to venture to the Sulphurous Seas once more during the rain to experience it.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.8", Array.Empty<object>())},
                new string[2]{ "The Abyss holds many secrets revealed with time. Checking it out again may not be a bad idea.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.9", Array.Empty<object>())},

                new string[2]{ "I do wonder what has happened to Braelor and Statis. I have heard or seen very little of either. In my days, both were great heroes to those who worshiped the Gods. Have they been killed, captured, or are they simply in hiding?",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.10", Array.Empty<object>())},
                new string[2]{ "Have you ever heard of the Archmage, Permafrost? Once an advisor to Yharim, he one day vanished and Calamitas abandoned Yharim's cause soon after. From what I know, Permafrost was akin to a father to her. Perhaps if she had something to do with his disappearance, he may yet live...?",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.11", Array.Empty<object>())},
                new string[2]{ "The Rune of Kos holds a significant portion of Providence's brand of magic, easily distinguishable from all others. Activating it in certain places would have some...risky consequences.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.12", Array.Empty<object>())},

                new string[2]{ "Providence was a great threat to Yharim and his army. She would appear out of seemingly thin air, wreck havoc, and vanish before much damage could be done to her. Perhaps she would be overconfident in facing but a single warrior.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.14", Array.Empty<object>())},
                new string[2]{ "Providence can likely be drawn out for combat by using the relic her Guardians left behind. I wonder... Why has Yharim not challenged her? Is he simply that negligent now?",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.15", Array.Empty<object>())},
                new string[2]{ "The Profaned Guardians serve Providence, one of the few Gods even I despise. The Guardians attempt to eliminate threats to their Goddess preemptively, and it is likely that their next target is you.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.16", Array.Empty<object>())},
                new string[2]{ "Profaned creatures now lurk in the Hallow and in Hell. If you destroy enough and gather their essence together you shall be able to capture the attention of the Profaned Guardians.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.17", Array.Empty<object>())},
                new string[2]{ "Your adventure focuses to the jungle it seems. The Dragonfolly and its swarming offspring should be eliminated before their numbers spiral out of control.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.18", Array.Empty<object>())},

                new string[2]{ "The nature of this plague in the jungle bothers me; it certainly is not the average infection. From afar they seem normal, yet up close it is obvious that the infected creatures are equipped with lights and metallic plating. Whatever it may be, it certainly isn't natural.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.19", Array.Empty<object>())},
                new string[2]{ "The Abyss has become far more active than before. You might be able to mine some of the volcanic rubble contained within.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.20", Array.Empty<object>())},
                new string[2]{ "The men at the front of the dungeon are performing a ritual to keep the Moon Lord contained in his prison. In order to gain Yharim's attention, however, you may need to defeat them.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.21", Array.Empty<object>())},

                new string[2]{ "When exploring the jungle temple be careful. You may not wish to disturb the Lihzard's idol, the Golem. It's quite the destructive force.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.23", Array.Empty<object>())},
                new string[2]{ "Be careful when defeating Plantera and the Golem. You might accidentally unleash a new threat in the jungle that needs to be quelled.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.24", Array.Empty<object>())},
                new string[2]{ "If you've gathered the souls used to power those automatons head once more to the jungle. You will find a powerful enemy to fight, which will unleash the full fervor of the jungle once defeated. Do not underestimate it!",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.25", Array.Empty<object>())},
                new string[2]{ "Azafure, the city founded in the Brimstone Crags, was one of the first places to support Yharim in his war. Now, it is nothing more than ruins... Just what happened there?",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.26", Array.Empty<object>())},
                new string[2]{ "If you take an idol down to the Brimstone Crags you might be able to see just what is lurking in the shadows.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.27", Array.Empty<object>())},
                new string[2]{ "I would recommend saving some of your old items. You never know if you can engineer them into stronger weapons in the future.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.29", Array.Empty<object>())},

                new string[2]{ "Throughout the world lie various structures left behind by Draedon. Archaic defenses may remain, but the goods inside may be worth your while.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.31", Array.Empty<object>())},
                new string[2]{ "The Crimson is a relatively recent development in the world, and its formation marked the start of Yharim's treacherous war. Although the source of its growth would be sealed away, nothing was ever done about the original manifestations.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.32", Array.Empty<object>())},
                new string[2]{ "The Corruption is a relatively recent development in the world, and its formation marked the start of Yharim's treacherous war. Although the source of its growth would be sealed away, nothing was ever done about the original manifestations.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.33", Array.Empty<object>())},
                new string[2]{ "I assume you have heard of the legendary ninja, Statis? He and his clan worshiped the God of slime, who may be a survivor of the war due to its trickery and knowing when to hide or flee.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.34", Array.Empty<object>())},
                new string[2]{ "Scattered across the lands are shrines dedicated to the gods. They contain powerful gear that may help you on your adventures.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.35", Array.Empty<object>())},
                new string[2]{ "Be careful what you attack in the Crimson. You might just unveil a greater threat than what was there before.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.36", Array.Empty<object>())},
                new string[2]{ "Be careful what you attack in the Corruption. You might just unveil a greater threat than what was there before.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.37", Array.Empty<object>())},
                new string[2]{ "The Sulphurous Sea was created more than a millenia ago, but it has gotten truly unbearable in the past decades. It's the fault of that accursed robot, Draedon, dumping waste and abandoned projects in there constantly. It's viler than it's ever been, thanks to him.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.38", Array.Empty<object>())},
                new string[2]{ "The Sulphurous Seas are dangerous. The toxic waters will burn your skin, but if you can brave them you will be able to reach the Abyss, where there are powerful weapons and dangers aplenty.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.39", Array.Empty<object>())},
                new string[2]{ "Ah yes, the Abyss. That trench is full of powerful creatures that could devour you in a heartbeat. I would explore the dungeon first.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.40", Array.Empty<object>())},
                new string[2]{ "Have you heard of the city in the Brimstone Crags? It lies in the Underworld, and was constructed beneath the Abyss. It was once the oldest and largest city in the world, though it seems nothing but danger lies there now. It would be wise to avoid it.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.41", Array.Empty<object>())},
                new string[2]{ "There are rumors of ores that lay in latency. When you defeat certain bosses you will undo the ancient magic which conceals those materials.",
                    LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.Help.42", Array.Empty<object>())}
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

    public override void GetChat(NPC npc, ref string chat)
    {
            int fapsol = NPC.FindFirstNPC(ModContent.NPCType<FAP>());
            int permadong = NPC.FindFirstNPC(ModContent.NPCType<DILF>());
            int seahorse = NPC.FindFirstNPC(ModContent.NPCType<SEAHOE>());
            int thief = NPC.FindFirstNPC(ModContent.NPCType<THIEF>());
            int witch = NPC.FindFirstNPC(ModContent.NPCType<WITCH>());
            int dryad = NPC.FindFirstNPC(20);
            int merchant = NPC.FindFirstNPC(17);
            int armsDealerIndex = NPC.FindFirstNPC(19);
            int nurseIndex = NPC.FindFirstNPC(18);
            int tavernKeep = NPC.FindFirstNPC(550);
            int stylist = NPC.FindFirstNPC(353);
            int partyGirl = NPC.FindFirstNPC(208);
            int anlger = NPC.FindFirstNPC(369);
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
            if (merchant != -1)
            {
                givenNames[3] = Main.npc[merchant].GivenName;
            }
            if (anlger != -1)
            {
                givenNames[4] = Main.npc[anlger].GivenName;
            }
            if (partyGirl != -1)
            {
                givenNames[5] = Main.npc[partyGirl].GivenName;
            }
            if (stylist != -1)
            {
                givenNames[6] = Main.npc[stylist].GivenName;
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
                "How much more has the world fallen to ruin? Even the Tyrant's empire...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.1", Array.Empty<object>())
            },
            new string[2]{
                "Thank you for your service, my child, but I am afraid I am without a home now.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.2", Array.Empty<object>())
            },
            new string[2]{
                "My home may have been destroyed and my people lost... But I will assist you to honor their memory.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.3", Array.Empty<object>())
            },
            new string[2]{
                "How odd it is, that your people leave the care of those yet to be born to the females. Our males carry the eggs until they hatch.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.4", Array.Empty<object>())
            },
            new string[2]{
                "How can I survive on land? Ah, that is a secret. No, actually... I can breathe air like you!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.5", Array.Empty<object>())
            },
            new string[2]{
                "Ah, if only you could have seen the beauty of a kingdom submerged in water. The way the light refracted and shone over our coral homes...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.6", Array.Empty<object>())
            },
            new string[2]{
                "There lurk horrifying creatures beyond the light of our homes. You should take care.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.7", Array.Empty<object>())
            },
            new string[2]{
                "My eyes are not well suited to bright lights after so many years of darkness. The peace of the night is welcome.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.8", Array.Empty<object>())
            },
            new string[2]{
                "Oh, me? I do not sleep, it is part of my nature.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.9", Array.Empty<object>())
            },
            new string[2]{
                "Since ancient times people have said that deities cause celestial events. Which one then, is the cause for these?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.10", Array.Empty<object>())
            },
            new string[2]{
                "I'm never keen on these nights. They're so violent.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.11", Array.Empty<object>())
            },
            new string[2]{
                "Your presence is now known to a great many things. It is unlikely that they will be as friendly towards you as I have been.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.12", Array.Empty<object>())
            },
            new string[2]{
                "Hm... The veil has fallen, and the world begins to show its true colors. I hope you will trek a righteous path, though even I am not sure what that may be.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.13", Array.Empty<object>())
            },
            new string[2]{
                "These days, the night sky feels... just a little less oppressive now.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.14", Array.Empty<object>())
            },
            new string[2]{
                "Some of these beings I had thought previously to be only legends. To see them in all their glory... what a macabre privilege.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.15", Array.Empty<object>())
            },
            new string[2]{
                "To see that Tyrant's serpent free of its shackles. It gave me chills.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.16", Array.Empty<object>())
            },
            new string[2]{
                "Meet me at " + givenNames[4] + "'s house at night. We will throw him to the Trashers.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.17", givenNames[4])
            },
            new string[2]{
                "Not sure how " + givenNames[4] + " has not been roasted and digested by now, hanging around the sulphuric seas for so long. Perhaps it got to his head.",
                 LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.18", givenNames[4])
            },
            new string[2]{
                givenNames[5] + " asked if my nose could be used as a vuvuzela. What is a vuvuzela?",
                 LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.19", givenNames[5])
            },
            new string[2]{
                "Rumor has it " + givenNames[2] + " drinks to forget her troubled past.",
                 LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.20", givenNames[2])
            },
            new string[2]{
                "I must admit, the Witch's presence is unsettling to me. But so many years have passed, and she too has suffered much.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.21", Array.Empty<object>())
            },
            new string[2]{
                "My home may have been destroyed and my people lost... But I will assist you to honor their memory.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SEAHOE.22", Array.Empty<object>())
            },
            
            //强盗
			new string[2]{
                "Anything is a weapon if you throw it hard enough.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.4", Array.Empty<object>())
            },
            new string[2]{
                "That's your chucking arm? You need to work out more.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.5", Array.Empty<object>())
            },
            new string[2]{
                "Listen here. It's all in the wrist, the wrist! Oh, forget it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.6", Array.Empty<object>())
            },
            new string[2]{
                "Eh you know how it goes; steal from the rich, give to the poor, but I do take a cut of the profit.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.7", Array.Empty<object>())
            },
            new string[2]{
                "Snakes! Why does it always have to be snakes!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.8", Array.Empty<object>())
            },
            new string[2]{
                "It's super nice you know, to just have everything you want. Some people never got that luxury.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.9", Array.Empty<object>())
            },
            new string[2]{
                "It's not stealing! I'm just borrowing it until I die!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.10", Array.Empty<object>())
            },
            new string[2]{
                "Hm, the stars are too bright tonight. Makes sneaking around a little more difficult.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.11", Array.Empty<object>())
            },
            new string[2]{
                "You think those stars that fall occasionally would make good throwing weapons?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.12", Array.Empty<object>())
            },
            new string[2]{
                "Oy, watch where you're going or I might just use you for dart practice.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.13", Array.Empty<object>())
            },
            new string[2]{
                "Bet you'd look good as a pincushion, amiright?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.14", Array.Empty<object>())
            },
            new string[2]{
                "Zombies don't dodge very well. Maybe you'll do a bit better.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.15", Array.Empty<object>())
            },
            new string[2]{
                "Hey, careful over there. I've rigged the place. One wrong step and you're going to get a knife in your forehead.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.16", Array.Empty<object>())
            },
            new string[2]{
                "Where is my party hat? Well, I stole it of course.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.17", Array.Empty<object>())
            },
            new string[2]{
                "The nice thing about maps is I can track anything that has fallen.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.18", Array.Empty<object>())
            },
            new string[2]{
                "Imagine how fast you could throw if you just had more hands.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.19", Array.Empty<object>())
            },
            new string[2]{
                "Usually I only think of animals as food or target practice, but dragons are an exception.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.20", Array.Empty<object>())
            },
            new string[2]{
                "I also take food for currency.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.21", Array.Empty<object>())
            },
            new string[2]{
                "I'd rather not be here. This place has bad vibes, y'know? It brings back some unpleasant memories.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.22", Array.Empty<object>())
            },
            new string[2]{
                "Wouldn't be the first time I used my friends' remains as weapons.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.23", Array.Empty<object>())
            },
            new string[2]{
                "All sorts of new weapons to be found and looted. Get to that, and I'll share some of my collection too!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.24", Array.Empty<object>())
            },
            new string[2]{
                "There's so much scrap around this land with valuable parts to them. Makes you wonder who could afford to leave em all around.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.25", Array.Empty<object>())
            },
            new string[2]{
                "Crypts, tombs, dungeons, those're all just treasure troves to me. The dead are dead, they've got nothing to do with it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.26", Array.Empty<object>())
            },
            new string[2]{
                "If you find anything cool, make sure to drop by and show it to me, I promise I'll keep my hands off it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.27", Array.Empty<object>())
            },
            new string[2]{
                "So many new things to steal, I can't think of where to start!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.28", Array.Empty<object>())
            },
            new string[2]{
                "If I end up angering some deities or whatever, would you mind taking the blame for me?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.29", Array.Empty<object>())
            },
            new string[2]{
                "Oh man, did you rip that off a shark!? Now that's a weapon!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.30", Array.Empty<object>())
            },
            new string[2]{
                "Don't tell " + givenNames[3] + ", but I took some of his stuff and replaced it with Angel Statues.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.31", givenNames[3])
            },
            new string[2]{
                "Hey, hey, has Calamitas seriously moved in here with us? Why???",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.32", Array.Empty<object>())
            },
            new string[2]{
                "Don't tell " + givenNames[0] + " that I was responsible for " + givenNames[1] + "'s injuries.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.33", givenNames[0], givenNames[1])
            },
            new string[2]{
                "I learned never to steal " + givenNames[2] + "'s drinks. She doesn't appreciate me right now, so I'll go back to hiding.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.THIEF.34", givenNames[2])
            },

            //醉仙女
			new string[2]{
                "I could smell my vodka from MILES away!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.1", Array.Empty<object>())
            },
            new string[2]{
                "Have any spare rooms available? Preferably candle-lit with a hefty supply of booze?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.2", Array.Empty<object>())
            },
            new string[2]{
                "I HATE WALMART! ...Anyway, what do you want this time?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.3", Array.Empty<object>())
            },
            new string[2]{
                "Deals so good I'll [$$!$] myself! ...Sorry, just had a minor stroke!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.4", Array.Empty<object>())
            },
            new string[2]{
                "Did anyone ever tell you that large assets cause back pain? Well, they were right.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.5", Array.Empty<object>())
            },
            new string[2]{
                "Drink something that turns you into a magical flying unicorn so you can be just like me.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.6", Array.Empty<object>())
            },
            new string[2]{
                "I'm literally balls drunk off my sass right now, what do you want?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.7", Array.Empty<object>())
            },
            new string[2]{
                "I'm either laughing because I'm drunk or because I've lost my mind, probably both.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.8", Array.Empty<object>())
            },
            new string[2]{
                "When I'm drunk I'm way happier... at least until the talking worms start to appear.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.9", Array.Empty<object>())
            },
            new string[2]{
                "I should reprogram the whole mod, while drunk, then send it back to the testers.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.10", Array.Empty<object>())
            },
            new string[2]{
                "A perfect night to light some candles, drink some wine and relax.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.11", Array.Empty<object>())
            },
            new string[2]{
                "Here's a challenge... take a shot for every time you've had to look at the wiki. Oh wait, you'd die.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.12", Array.Empty<object>())
            },
            new string[2]{
                "Yes, everyone knows the mechworm is buggy. Well, not anymore, but still.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.13", Array.Empty<object>())
            },
            new string[2]{
                "You lost or something? I don't mind company, but I'd rather be left alone at night.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.14", Array.Empty<object>())
            },
            new string[2]{
                "Are you sure you're 21? ...Alright, fine, but don't tell anyone I sold you these.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.15", Array.Empty<object>())
            },
            new string[2]{
                "I'm gonna make some Bloody Marys to relax, celery included. Want one?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.16", Array.Empty<object>())
            },
            new string[2]{
                "If you're too lazy to craft potions normally, try Blood Orbs. Blood is fuel, dumbass.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.17", Array.Empty<object>())
            },
            new string[2]{
                "I'm trying to not be bitchy tonight, but it's hard when everyone else won't shut up.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.18", Array.Empty<object>())
            },
            new string[2]{
                "Sorry, I have no moral compass at the moment.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.19", Array.Empty<object>())
            },
            new string[2]{
                "You'll always find me at parties where booze is involved... well, you'll always find BOOZE where I'M involved!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.20", Array.Empty<object>())
            },
            new string[2]{
                "I'm melting! Put a stop to this inclement weather this instant before it ruins my hair!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.21", Array.Empty<object>())
            },
            new string[2]{
                "You should probably deal with those ayy lmaos before anything else, but whatever.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.22", Array.Empty<object>())
            },
            new string[2]{
                "Why are you talking to me right now? Shouldn't you be bumbling around and dying for my amusement?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.23", Array.Empty<object>())
            },
            new string[2]{
                "God I can't wait to smash some ice again! ...For drinks, of course.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.24", Array.Empty<object>())
            },
            new string[2]{
                "How could you murder such a beautiful creature!? ...The blue sexy one, not the obese cucumber.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.25", Array.Empty<object>())
            },
            new string[2]{
                "I saw a ghost down by the old train tracks back at my homeland once, flailing wildly at the lily pads... frightening times those were.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.26", Array.Empty<object>())
            },
            new string[2]{
                "I hear it's amazing when the famous Devourer of Gods out in flap-jaw space, with the tuning fork, does a raw blink on Hara-kiri rock. I need scissors! 61!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.27", Array.Empty<object>())
            },
            new string[2]{
                "Tell " + givenNames[8] + " to stop calling me. He's not wanted.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.28", givenNames[8])
            },
            new string[2]{
                "I've had to tell baldie where my eyes are so many times that I've lost count.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.29", Array.Empty<object>())
            },
            new string[2]{
                "My booze will always be better than " + givenNames[8] + "'s, and nobody can convince me otherwise.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.30", givenNames[8])
            },
            new string[2]{
                "You can't stop me from trying to move in with " + givenNames[6] + ".",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.31", givenNames[6])
            },
            new string[2]{
                "I love it when " + givenNames[6] + "'s hands get sticky from all that... wax.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.32", givenNames[6])
            },
            new string[2]{
                givenNames[6] + " works wonders for my hair... among other things.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.33", givenNames[6])
            },
            new string[2]{
                "Ever since " + givenNames[6] + " moved in I haven't been drinking as much... a strange but not unwelcome feeling.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.34", givenNames[6])
            },
            new string[2]{
                "I should watch some movies with " + givenNames[6] + " tonight. You could come too, but only if you bring snacks for us.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.35", givenNames[6])
            },
            new string[2]{
                "The abuse Calamitas went through is something I can hardly comprehend. I'd offer her a drink, but I don't think she'd enjoy it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.36", givenNames[15])
            },
            new string[2]{
                "I never realized how well-endowed " + givenNames[7] + " was. It had to be the largest icicle I'd ever seen.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.37", givenNames[7])
            },
            new string[2]{
                givenNames[6] + " helped me learn to accept my past. It's been rough, but I think I'm on the right track now.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.38", givenNames[6])
            },
            new string[2]{
                "Might go out for a jog later with " + givenNames[6] + ". Nice day for it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.39", givenNames[6])
            },
            new string[2]{
                "I drink to forget certain... things. What things, you might ask? Well, the point is to forget them, isn't it?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.40", Array.Empty<object>())
            },
            new string[2]{
                "What a great day! Might just drink so much that I get poisoned again.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.41", Array.Empty<object>())
            },
            new string[2]{
                "Ever wondered why the Moon Lord needed so many tentacles? Uh... on second thought, I won't answer that.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.42", Array.Empty<object>())
            },
            new string[2]{
                "Oh yeah, now you're drinking the good stuff! Do you like it? I created the recipe by mixing fairy dust, crystals and other magical crap.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.43", Array.Empty<object>())
            },
            new string[2]{
                "The hell is that? Looks like something I'd carry around if I was 5 years old.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.44", Array.Empty<object>())
            },
            new string[2]{
                "Nice scales... is it hot in here or is it just me?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.45", Array.Empty<object>())
            },
            new string[2]{
                "So... you found my special bottle. Hope you enjoy it, I know I will.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.46", Array.Empty<object>())
            },
            new string[2]{
                "Be sure to dismount me once in a while, I get tired. And besides, I can't rip you off-I mean offer you excellent deals you won't find anywhere else if you're riding me 24/7.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.47", Array.Empty<object>())
            },
            new string[2]{
                "Before you ask, no, I do NOT have a heart on my butt while in human form. Don't question my transformation preferences!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.FAP.48", Array.Empty<object>())
            },
            
            //大法师
			new string[2]{
                "I deeply appreciate you rescuing me from being trapped within my frozen castle... It's been many, many years...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.1", Array.Empty<object>())
            },
            new string[2]{
                "I have not seen such a sky in decades. Who are you, to so brazenly march against that Tyrant?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.2", Array.Empty<object>())
            },
            new string[2]{
                "If you have a request, make it quick. I am in the process of weaving a spell, which requires great focus.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.4", Array.Empty<object>())
            },
            new string[2]{
                "You have the makings of a gifted mage. Tell me, what do you think of ice magic?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.5", Array.Empty<object>())
            },
            new string[2]{
                "Flowers and the like don't hold a candle to the beauty of intricately formed ice.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.6", Array.Empty<object>())
            },
            new string[2]{
                "The sun beats down harshly upon my creations here. If you would allow me to conjure a blizzard every now and then...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.7", Array.Empty<object>())
            },
            new string[2]{
                "I must admit, I'm not quite used to this weather. It's far too warm for my tastes...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.8", Array.Empty<object>())
            },
            new string[2]{
                "Nightfall is a good time for practicing magic. We mages often rely on celestial bodies and their fragments to enhance our mana.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.9", Array.Empty<object>())
            },
            new string[2]{
                "Necromancy was never a field I found interesting. Why utilize the rotting corpses of people, when you could form far more elegant servants of ice?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.10", Array.Empty<object>())
            },
            new string[2]{
                "Sometimes... I feel like all I'm good for during these events is making ice cubes and slushies.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.11", Array.Empty<object>())
            },
            new string[2]{
                "If your blood were to thoroughly freeze, it would be quite fatal.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.12", Array.Empty<object>())
            },
            new string[2]{
                "The undead which roam tonight are still monsters of blood and guts, but they seem... fresher.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.13", Array.Empty<object>())
            },
            new string[2]{
                "It is shocking, to see you have come so far. I wish you the best of luck on your future endeavours.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.14", Array.Empty<object>())
            },
            new string[2]{
                "You, having bested so many beings, even deities, I wonder if I have anything left to offer you.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DILF.15", Array.Empty<object>())
            },
			
			//女巫
			new string[2]{
                "I'm considering moving back to that old cave of mine.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.1", Array.Empty<object>())
            },
            new string[2]{
                "I certainly can't return to the Yharim's old dwellings now, have you got any places to stay?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.2", Array.Empty<object>())
            },
            new string[2]{
                "I can't pay rent, but if you've got any dead relative you want me to try and... what? You don't?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.3", Array.Empty<object>())
            },
            new string[2]{
                "One of these days, I was thinking of starting a garden with the flowers from the old capitol of hell. I love the smell of brimstone in the morning.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.4", Array.Empty<object>())
            },
            new string[2]{
                "I think I've settled comfortably, thank you very much.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.5", Array.Empty<object>())
            },
            new string[2]{
                "Many seasons have gone by since I first met with the Tyrant, and only now did I break free. I wish I'd been stronger...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.6", Array.Empty<object>())
            },
            new string[2]{
                "If you've got any curses you want dispelled... well I'm not your person.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.7", Array.Empty<object>())
            },
            new string[2]{
                "These undead are horrific, I can't stand to look at them. How could anyone be satisfied with such amateur work?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.8", Array.Empty<object>())
            },
            new string[2]{
                "I don't think it's a stretch to say that astrology is utter nonsense... but it was a hobby of mine once.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.9", Array.Empty<object>())
            },
            new string[2]{
                "Such an unnatural shade of red. Nothing like my brimstone flames.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.10", Array.Empty<object>())
            },
            new string[2]{
                "I can't work with nights like these. The stars seem to have shrunk away in fear.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.11", Array.Empty<object>())
            },
            new string[2]{
                "If another person asks me if I can dance or not, I will light their hat on fire.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.12", Array.Empty<object>())
            },
            new string[2]{
                "I cannot understand the Sea King. He does not seem to want me dead. That amount of compassion I just can't understand.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.13", Array.Empty<object>())
            },
            new string[2]{
                "I wonder if Cirrus ever feels cold given how revealing her dress is. Perhaps she should cover up a bit more.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.15", givenNames[2])
            },
            new string[2]{
                "Mrrp is cringe.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WITCH.16", Array.Empty<object>())
            },

            //原版
			//渔夫
			new string[2]{
                "Someone tell " + givenNames[10] + " to quit trying to throw me out of town, it's not going to work.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Angler", givenNames[10])
            },

			//军火商
			new string[2]{
                "That's the biggest moth I've ever seen for sure. You'd need one big gun to take one of those down.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.ArmsDealer.1", Array.Empty<object>())
            },
            new string[2]{
                "Is it me or are your weapons getting bigger and bigger?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.ArmsDealer.2", Array.Empty<object>())
            },
            new string[2]{
                "That old man left a cranky old gun on his deathbed. You catching my drift?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.ArmsDealer.3", Array.Empty<object>())
            },
            new string[2]{
                "Hah! Look at that rusty old shotty. It looks straight out of the 70's!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.ArmsDealer.4", Array.Empty<object>())
            },

			//服饰商
			new string[2]{
                "Houston, we've had a problem.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Clothier.1", Array.Empty<object>())
            },
            new string[2]{
                "Who you gonna call?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Clothier.2", Array.Empty<object>())
            },
            new string[2]{
                "Those screams... I'm not sure why, but I feel like a nameless fear has awoken in my heart.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Clothier.3", Array.Empty<object>())
            },
            new string[2]{
                "I can faintly hear ghostly shrieks from the dungeon... and not ones I'm familiar with at all. Just what is going on in there?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Clothier.4", Array.Empty<object>())
            },
            new string[2]{
                "Whatever that thing was, I'm glad it's gone now.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Clothier.5", Array.Empty<object>())
            },

			//机器人
			new string[2]{
                "All these moments will be lost in time. Like tears... in the rain.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Cyborg.1", Array.Empty<object>())
            },
            new string[2]{
                "Always shoot for the moon! It has clearly worked before.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Cyborg.2", Array.Empty<object>())
            },
            new string[2]{
                "Draedon? He's... a little 'high octane' if you know what I mean.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Cyborg.3", Array.Empty<object>())
            },
            new string[2]{
                "Those oversized bugs terrorizing the jungle... Surely you of all people could shut them down!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Cyborg.4", Array.Empty<object>())
            },

			//爆破商
			new string[2]{
                "God Slayer Dynamite? Boy do I like the sound of that!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Demolitionist", Array.Empty<object>())
            },

			//森林女神
			new string[2]{
                "There's a dark solar energy emanating from the moths that appear during this time. Ah, the moths as you progress further get more powerful...hmm...what power was Yharon holding back?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Dryad.1", Array.Empty<object>())
            },
            new string[2]{
                "That starborne illness sits upon this land like a blister. Do even more vile forces of corruption exist in worlds beyond?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Dryad.2", Array.Empty<object>())
            },
            new string[2]{
                "\u0093I'm not here for any reason! Just picking up mushrooms for uh, later use.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Dryad.3", Array.Empty<object>())
            },
            new string[2]{
                givenNames[2] + " put me up to this.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Dryad.4", givenNames[2])
            },
            new string[2]{
                "My ancestor was lost here long ago. I must pay my respects to her.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Dryad.5", Array.Empty<object>())
            },

			//染料商
			new string[2]{
                "Have you seen those gemstone creatures in the caverns? Their colors are simply breathtaking!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DyeTrader.1", Array.Empty<object>())
            },
            new string[2]{
                "Do you think " + givenNames[7] + " knows how to 'let it go?'",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.DyeTrader.2", givenNames[7])
            },

			//哥布林工匠
			new string[2]{
                "Hey, is it just me or have my pockets gotten lighter ever since " + givenNames[11] + " arrived?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.GoblinTinkerer.1", givenNames[11])
            },
            new string[2]{
                "You know... we haven't had an invasion in a while...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.GoblinTinkerer.2", Array.Empty<object>())
            },

			//向导
			new string[2]{
                "Could you be so kind as to, ah... check hell for me...? I left someone I kind of care about down there.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Guide.1", Array.Empty<object>())
            },
            new string[2]{
                "I have this sudden shiver up my spine, like a meteor just fell and thousands of innocent creatures turned into monsters from the stars.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Guide.2", Array.Empty<object>())
            },
            new string[2]{
                "The dungeon seems even more restless than usual, watch out for the powerful abominations stirring up in there.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Guide.3", Array.Empty<object>())
            },
            new string[2]{
                "Seems like extinguishing that butterfly caused its life to seep into the hallowed areas, try taking a peek there and see what you can find!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Guide.4", Array.Empty<object>())
            },
            new string[2]{
                "I've heard there is a portal of antimatter absorbing everything it can see in the dungeon, try using the Rune of Kos there!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Guide.5", Array.Empty<object>())
            },

			//机械师
			new string[2]{
                "What do you mean your traps aren't making the cut? Don't look at me!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Mechanic.1", Array.Empty<object>())
            },
            new string[2]{
                "Um... should my nightlight be on?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Mechanic.2", Array.Empty<object>())
            },
            new string[2]{
                "Well, I like " + givenNames[2] + ", but I, ah... I have my eyes on someone else.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Mechanic.3", givenNames[2])
            },
            new string[2]{
                "Maybe I should've waterproofed my gadgets... They're starting to corrode.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Mechanic.4", Array.Empty<object>())
            },

			//商人
			new string[2]{
                "Each night seems only more foreboding than the last. I feel unthinkable terrors are watching your every move.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Merchant.1", Array.Empty<object>())
            },
            new string[2]{
                "Are you daft?! Turn off those lamps!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Merchant.2", Array.Empty<object>())
            },
            new string[2]{
                "If this acid rain keeps up, there'll be a shortage of Dirt Blocks soon enough!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Merchant.3", Array.Empty<object>())
            },
            new string[2]{
                "I happen to have several Angel Statues at the moment, a truely rare commodity. Want one?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Merchant.4", Array.Empty<object>())
            },
            new string[2]{
                "The caverns have become increasingly dark as of late, so I stocked up on some special torches if you have the funds.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Merchant.5", Array.Empty<object>())
            },

			//护士
			new string[2]{
                "Now is not the time!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Nurse", Array.Empty<object>())
            },

			//画家
			new string[2]{
                "A little sickness isn't going to stop me from doing my work as an artist!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.1", Array.Empty<object>())
            },
            new string[2]{
                "There's a surprising art to this area. A sort of horrifying, eldritch feeling. It inspires me!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.2", Array.Empty<object>())
            },
            new string[2]{
                "Think " + givenNames[7] + " would let me paint him like one of his French girls?!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.3", givenNames[7])
            },
            new string[2]{
                "I'm not exactly suited for this cold weather. Still looks pretty, though.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.4", Array.Empty<object>())
            },
            new string[2]{
                "I hate sand. It's coarse, and rough and gets in my paint.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.5", Array.Empty<object>())
            },
            new string[2]{
                "Do you think unicorn blood could be used as a good pigment or resin? No I'm not going to find out myself.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.6", Array.Empty<object>())
            },
            new string[2]{
                "I can't work in this environment. All of my paint just floats off.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.7", Array.Empty<object>())
            },
            new string[2]{
                "Painting the tortoises in a still life isn't going so well.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.8", Array.Empty<object>())
            },
            new string[2]{
                "I can't paint a still life if the fruit grows legs and walks away.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.9", Array.Empty<object>())
            },
            new string[2]{
                "On the canvas, things get heated around here all the time. Like the environment!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.10", Array.Empty<object>())
            },
            new string[2]{
                "Sorry, I'm all out of watercolors. They keep evaporating.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.11", Array.Empty<object>())
            },
            new string[2]{
                "Roses, really? That's such an overrated thing to paint.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.12", Array.Empty<object>())
            },
            new string[2]{
                "Fun fact! Sulphur was used as pigment once upon a time! Or was it Cinnabar?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.13", Array.Empty<object>())
            },
            new string[2]{
                "Easiest landscape I've ever painted in my life.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Painter.14", Array.Empty<object>())
            },

			//派对女孩
			new string[2]{
                "I have a feeling we're going to have absolutely fantastic parties with " + givenNames[2] + " around!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.PartyGirl.1", givenNames[2])
            },
            new string[2]{
                "I think my light display is turning into an accidental bug zapper. At least the monsters are enjoying it.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.PartyGirl.2", Array.Empty<object>())
            },
            new string[2]{
                "Ooh! I love parties where everyone wears a scary costume!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.PartyGirl.3", Array.Empty<object>())
            },

			//海盗
			new string[2]{
                "Aye, I've heard of a mythical creature in the oceans, singing with an alluring voice. Careful when yer fishin out there.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.1", Array.Empty<object>())
            },
            new string[2]{
                "I have to thank ye again for takin' care of that sea serpent. Or was that another one...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.2", Array.Empty<object>())
            },
            new string[2]{
                "I remember legends about that " + givenNames[10] + ". He ain't quite how the stories make him out to be though.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.3", givenNames[10])
            },
            new string[2]{
                "Twenty-nine bottles of beer on the wall...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.4", Array.Empty<object>())
            },
            new string[2]{
                "Now this is a scene that I can admire any time! I feel like something is watching me though.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.5", Array.Empty<object>())
            },
            new string[2]{
                "It ain't much of a sight, but there's still life living in these waters.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.6", Array.Empty<object>())
            },
            new string[2]{
                "Me ship might just sink from the acid alone.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Pirate.7", Array.Empty<object>())
            },

			//骷髅商人
			new string[2]{
                "What'dya buyin'?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.SkeletonMerchant", Array.Empty<object>())
            },

			//蒸汽朋克人
			new string[2]{
                "Just what is that contraption? It makes my Teleporters look like child's play!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Steampunker.1", Array.Empty<object>())
            },
            new string[2]{
                "Yep! I'm also considering being a space pirate now.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Steampunker.2", Array.Empty<object>())
            },
            new string[2]{
                "Some of my machines are starting to go haywire thanks to this Astral Infection. I probably shouldn't have built them here",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Steampunker.3", Array.Empty<object>())
            },
            new string[2]{
                "I'm sorry I really don't have any Unicorn proof tech here, you're on your own.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Steampunker.4", Array.Empty<object>())
            },

			//发型师
			new string[2]{
                "Please don't catch space lice. Or " + "Crimson" + " lice. Or just lice in general.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.1", Array.Empty<object>())
            },
            new string[2]{
                "Please don't catch space lice. Or " + "Corruption" + " lice. Or just lice in general.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.2", Array.Empty<object>())
            },
            new string[2]{
                "Sometimes I catch " + givenNames[2] + " sneaking up from behind me.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.3", givenNames[2])
            },
            new string[2]{
                givenNames[2] + " is always trying to brighten my mood... even if, deep down, I know she's sad.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.4", givenNames[2])
            },
            new string[2]{
                "They look so cute and yet, I can feel their immense power just by being near them. What are you?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.5", Array.Empty<object>())
            },
            new string[2]{
                "I hate to break it to you, but you don't have hair to cut or style, hun.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.6", Array.Empty<object>())
            },
            new string[2]{
                "Aww, they're so cute, do they have names?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Stylist.7", Array.Empty<object>())
            },

			//酒保
			new string[2]{
                "Care for a little Moonshine?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Tavernkeep.1", Array.Empty<object>())
            },
            new string[2]{
                "Sheesh, " + givenNames[2] + " is a little cruel, isn't she? I never claimed to be an expert on anything but ale!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Tavernkeep.2", givenNames[2])
            },

			//税收官
			new string[2]{
                "BAH! Doesn't seem like I'll ever be able to quarrel with the debts of the town again!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TaxCollector.1", Array.Empty<object>())
            },
            new string[2]{
                "Where and how are you getting all of this money?",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TaxCollector.2", Array.Empty<object>())
            },
            new string[2]{
                "Perhaps with all that time you've got you could check those old ruins? Certainly something of value in it for you!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TaxCollector.3", Array.Empty<object>())
            },
            new string[2]{
                "Devourer of what, you said? Devourer of Funds, if its payroll is anything to go by!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TaxCollector.4", Array.Empty<object>())
            },
            new string[2]{
                "Goodness! That cane has swagger!",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TaxCollector.5", Array.Empty<object>())
            },

			//旅商
			new string[2]{
                "Tell " + givenNames[2] + " I'll take up her offer and meet with her at the back of " + givenNames[3] + "'s house.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.TravellingMerchant", givenNames[2], givenNames[3])
            },

			//松露人
			new string[2]{
                "I don't feel very safe; I think there's pigs following me around and it frightens me.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Truffle.1", Array.Empty<object>())
            },
            new string[2]{
                "Sometimes, " + givenNames[2] + " just looks at me funny and I'm not sure how I feel about that.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Truffle.2", givenNames[2])
            },

			//巫医
			new string[2]{
                "My home here has an extensive history and a mysterious past. You'll find out quickly just how extensive it is...",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WitchDoctor.1", Array.Empty<object>())
            },
            new string[2]{
                "I have unique items if you show me that you have bested the guardian of this jungle.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WitchDoctor.2", Array.Empty<object>())
            },
            new string[2]{
                "This is as good a time as any to pick up the best ingredients for potions.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.WitchDoctor.3", Array.Empty<object>())
            },

			//法师
			new string[2]{
                "Space just got way too close for comfort.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Wizard.1", Array.Empty<object>())
            },
            new string[2]{
                "I'd let " + givenNames[7] + " coldheart MY icicle.",
                LangHelper.GetTextValue("CalamityMod.NPCs.Dialogues.Wizard.2", givenNames[7])
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