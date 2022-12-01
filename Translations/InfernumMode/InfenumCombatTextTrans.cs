using CalamityCN.Utils;
using Terraria;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfenumCombatTextTrans
	{
		public static uint ComputeStringHash(string s)
        {
			uint num = 1;
			if (s != null)
            {
				num = 2166136261U;
				for (int i = 0; i < s.Length; i++)
                {
					num = ((uint)s[i] ^ num) * 16777619U;
                }
            }
			return num;
        }
		internal static void LoadTranslation()
		{
			for (int index = 0; index < 100; index++)
			{
				if (Main.combatText[index].active)
				{
					CombatText combatText = Main.combatText[index];
					string origin = Main.combatText[index].text;
					string text;
					uint num = ComputeStringHash(origin);
					if (num <= 2004682116U)
					{
						if (num <= 804483337U)
						{
							if (num <= 499214376U)
							{
								if (num <= 227737799U)
								{
									if (num <= 113125783U)
									{
										if (num <= 38081143U)
										{
											if (num != 1192334U)
											{
												if (num != 38081143U)
												{
													goto IL_1CA0;
												}
												if (!(origin == "Many layered platforms can help greatly to avoid the exploding Cursed Flames!"))
												{
													goto IL_1CA0;
												}
												text = LangHelper.GetText("InfernumMode.CombatTexts.14");
											}
											else
											{
												if (!(origin == "Be sure to remember if any sharkrons or tooth balls appear, so that their remains don't surprise you later!"))
												{
													goto IL_1CA0;
												}
												text = LangHelper.GetText("InfernumMode.CombatTexts.101");
											}
										}
										else if (num != 80951842U)
										{
											if (num != 113125783U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Keep your feet working! This gelatinous queen will stop at nothing to crush her foes!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.52");
										}
										else
										{
											if (!(origin == "So many skulls, but it appears they aren't focused directly at you! Try going inbetween!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.123");
										}
									}
									else if (num <= 151365498U)
									{
										if (num != 127796875U)
										{
											if (num != 151365498U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Home stretch! Do the same as you did before!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.56");
										}
										else
										{
											if (!(origin == "Polterghast's spirits have been released! But they don't seem very happy with us..."))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.98");
										}
									}
									else if (num != 188025546U)
									{
										if (num != 227737799U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Best to keep close during these Exo Overload attacks, otherwise you may have trouble keeping up with the spin!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.117");
									}
									else
									{
										if (!(origin == "Try and move as precisely as possible here; you don't want to waste arena space!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.54");
									}
								}
								else if (num <= 377837453U)
								{
									if (num <= 310291947U)
									{
										if (num != 234251981U)
										{
											if (num != 310291947U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Oof, that mustve Stung..."))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.31");
										}
										else
										{
											if (!(origin == "You better have dessert for me after this..."))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.7");
										}
									}
									else if (num != 361292375U)
									{
										if (num != 377837453U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Destroy those builder drones before the whole jungle goes kablooey!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.62");
									}
									else
									{
										if (!(origin == "Oh man, theres so many lasers! Slow and precise movements seem like your best bet here..."))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.109");
									}
								}
								else if (num <= 408287461U)
								{
									if (num != 393351119U)
									{
										if (num != 408287461U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "A dash and a hook can greatly help with reacting to the Eaters bursts of speed!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.15");
									}
									else
									{
										if (!(origin == "Watch for the gaps in the icicles around Cryogen, they're a great indicator of where a safe spot is!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.47");
									}
								}
								else if (num != 472331902U)
								{
									if (num != 499214376U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Better stay near the edges of the arena during those carpet bomb flames, That should keep them out of the way!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.110");
								}
								else
								{
									if (!(origin == "Those large red lightning pillars can be negated by flying below them!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.85");
								}
							}
							else if (num <= 594202444U)
							{
								if (num <= 539277367U)
								{
									if (num <= 523119728U)
									{
										if (num != 512318792U)
										{
											if (num != 523119728U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Those blue tesla mines are going to explode into gas; take cover!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.40");
										}
										else
										{
											if (!(origin == "Stay somewhat close, otherwise you may be caught off guard!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.60");
										}
									}
									else if (num != 532660594U)
									{
										if (num != 539277367U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Dont let all the projectiles intimidate you, be very cautious with your movement!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.39");
									}
									else
									{
										if (!(origin == "AND IF I SHOULD DIE BEFORE YOU CONTINUEE, YOU SHALL HAV-... Wait, you died? Come on, I was on a roll here!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.114");
									}
								}
								else if (num <= 540327797U)
								{
									if (num != 539373450U)
									{
										if (num != 540327797U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Squib emoji"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.79");
									}
									else
									{
										if (!(origin == "The Brain is going to try to decieve you with various mind games, keep your eyes on the real one!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.18");
									}
								}
								else if (num != 577263927U)
								{
									if (num != 594202444U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Going in a tight circular pattern helps with the attacker guardian's spears!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.82");
								}
								else
								{
									if (!(origin == "The Moon Lord seems angry! Try to dodge the side projectiles, and don't touch that black hole!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.77");
								}
							}
							else if (num <= 722296927U)
							{
								if (num <= 658693862U)
								{
									if (num != 636570394U)
									{
										if (num != 658693862U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "A dashing accessory would be reeaaally helpful here..."))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.105");
									}
									else
									{
										if (!(origin == "This is the time you would want to learn the opponents moves, use their tells to get the upper hand!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.23");
									}
								}
								else if (num != 718896877U)
								{
									if (num != 722296927U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "The fight against the Dragonfolly is very chaotic and fast paced. Good mobility and reaction time help a lot!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.84");
								}
								else
								{
									if (!(origin == "Deerclops' are Myopic, so they will force you to stay close, dont let them corner you!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.32");
								}
							}
							else if (num <= 780033873U)
							{
								if (num != 769678801U)
								{
									if (num != 780033873U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Short hops may help better than trying to fly away from all the crystal shrapnel!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.53");
								}
								else
								{
									if (!(origin == "Plantera isn't keeping anything back, watch out!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.68");
								}
							}
							else if (num != 781102651U)
							{
								if (num != 804483337U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "The Weaver has shed its exterior. It will now move far faster!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.90");
							}
							else
							{
								if (!(origin == "The Scourge will stop at nothing to snack on you! Stay on the move!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.51");
							}
						}
						else if (num <= 1476028669U)
						{
							if (num <= 1125932602U)
							{
								if (num <= 1024949842U)
								{
									if (num <= 919572897U)
									{
										if (num != 905606832U)
										{
											if (num != 919572897U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Pay attention to where you move. Try to stay in one spot so that those bombs aren't all over the arena!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.86");
										}
										else
										{
											if (!(origin == "Most of the Void's attacks require fast maneuvering to evade. Be sure to pay attention to any projectiles on-screen!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.95");
										}
									}
									else if (num != 948217555U)
									{
										if (num != 1024949842U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Do you want my Witch's hat? Matching her atire could be fun..."))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.127");
									}
									else
									{
										if (!(origin == "Better choose well!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.116");
									}
								}
								else if (num <= 1091789739U)
								{
									if (num != 1062610440U)
									{
										if (num != 1091789739U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Those eyeballs perform attacks that require a lot of weaving! Make sure to not panic when they happen!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.78");
									}
									else
									{
										if (!(origin == "The Weaver seems to be creating a bunch of clouds above you! Try to weave through the resulting bolts as they fall!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.92");
									}
								}
								else if (num != 1092166232U)
								{
									if (num != 1125932602U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Even when all hell breaks loose, stay focused on your dodging!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.126");
								}
								else
								{
									if (!(origin == "Ares' has one hell of a supercomputer, those arms are super predictive! Maybe you can use that to your advantage?"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.118");
								}
							}
							else if (num <= 1323379165U)
							{
								if (num <= 1243838464U)
								{
									if (num != 1201214479U)
									{
										if (num != 1243838464U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "That serpent is really fast! Good mobility will be important to defeat it!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.67");
									}
									else
									{
										if (!(origin == "Deer god..."))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.34");
									}
								}
								else if (num != 1271335048U)
								{
									if (num != 1323379165U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "A dashing accessory would be reeaaaally helpful here..."))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.106");
								}
								else
								{
									if (!(origin == "The beam predicts your position, try baiting it into shooting away from you!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.49");
								}
							}
							else if (num <= 1360799992U)
							{
								if (num != 1330264761U)
								{
									if (num != 1360799992U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Watch out, that last twin is gonna hit you with everything it's got! Don't let up!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.41");
								}
								else
								{
									if (!(origin == "This speed is crazy! Make sure you know when it starts; you might get jumpscared!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.111");
								}
							}
							else if (num != 1428666239U)
							{
								if (num != 1476028669U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Try your best to weave through the razorblades and brace youself!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.73");
							}
							else
							{
								if (!(origin == "Try to learn King Slime's jump pattern! It could help you plan your next move better."))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.1");
							}
						}
						else if (num <= 1764677452U)
						{
							if (num <= 1642214125U)
							{
								if (num <= 1497618692U)
								{
									if (num != 1492665238U)
									{
										if (num != 1497618692U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Stay near the center of your arena if you can. Those thorns are really good at cornering you!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.48");
									}
									else
									{
										if (!(origin == "Movement speed is gonna matter a lot against that fish!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.102");
									}
								}
								else if (num != 1566208834U)
								{
									if (num != 1642214125U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Don't worry about hooking to the walls or anything like that. Providence provides you with unlimited flight time!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.89");
								}
								else
								{
									if (!(origin == "Don't panic when Skeletron does his barrages of hand fireballs! Just jump and stay calm!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.36");
								}
							}
							else if (num <= 1749689980U)
							{
								if (num != 1678923931U)
								{
									if (num != 1749689980U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "The Exo-Twins are magnificently in-sync, try finding a rythem to outsmart them!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.119");
								}
								else
								{
									if (!(origin == "Try not to move too much at the start of the battle. Finding a good spot and staying near it helps a lot!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.94");
								}
							}
							else if (num != 1759250026U)
							{
								if (num != 1764677452U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "This is the Void's last stand! Try not to get sucked in, and weave through the energy bolts!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.93");
							}
							else
							{
								if (!(origin == "There isnt Mushroom for the three of us, and I can tell who won the roullete."))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.13");
							}
						}
						else if (num <= 1840059357U)
						{
							if (num <= 1815454155U)
							{
								if (num != 1780814809U)
								{
									if (num != 1815454155U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Don't fret, face fear in the eyes and dash directly into Thanatos' face-plates!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.120");
								}
								else
								{
									if (!(origin == "Being able to face it head on with a ram sounds like a good idea, don't you think?"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.107");
								}
							}
							else if (num != 1834937684U)
							{
								if (num != 1840059357U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Investing in a hook or high mobility could prove great to dodge the Eye of Cthulhu's Charges!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.9");
							}
							else
							{
								if (!(origin == "Watch out, he might try to trick you at the end!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.96");
							}
						}
						else if (num <= 1957583182U)
						{
							if (num != 1894625697U)
							{
								if (num != 1957583182U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "If you can't handle dodging at high speeds, try baiting it into circling you!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.50");
							}
							else
							{
								if (!(origin == "Dont feel overwhelmed by all the projectiles, keep your cool during this flaming match!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.125");
							}
						}
						else if (num != 1960144321U)
						{
							if (num != 1989680423U)
							{
								if (num != 2004682116U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "I guess it eats more than just worlds."))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.16");
							}
							else
							{
								if (!(origin == "The meteors all split in the same way; use this to your advantage!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.58");
							}
						}
						else
						{
							if (!(origin == "Those bombs will explode into kunai that fly towards you. Be careful!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.97");
						}
					}
					else if (num <= 3133823908U)
					{
						if (num <= 2552107572U)
						{
							if (num <= 2288585637U)
							{
								if (num <= 2140053102U)
								{
									if (num <= 2068036710U)
									{
										if (num != 2011672741U)
										{
											if (num != 2068036710U)
											{
												goto IL_1CA0;
											}
											if (!(origin == "Keep track of where the long charge stops! You might get swept up by a tidal wave!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.72");
										}
										else
										{
											if (!(origin == "Don't move around too quickly! Small but quick horizontal movements are important for evading those crystals!"))
											{
												goto IL_1CA0;
											}
											text = LangHelper.GetText("InfernumMode.CombatTexts.87");
										}
									}
									else if (num != 2085660633U)
									{
										if (num != 2140053102U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "That thing seems to have shed its outer shell. Brace yourself, it's going to be a lot faster now!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.64");
									}
									else
									{
										if (!(origin == "I would make a snarky comment right now, but I probably should Mind my own business..."))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.27");
									}
								}
								else if (num <= 2202717505U)
								{
									if (num != 2171992537U)
									{
										if (num != 2202717505U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Try to not move too far away when the Weaver spins in place, so you can see the bolts before they accelerate too much!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.91");
									}
									else
									{
										if (!(origin == "If one of the Polterghast's legs turn red, quickly back away; it's going to swipe at you and release accelerating projectiles!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.100");
									}
								}
								else if (num != 2207170501U)
								{
									if (num != 2288585637U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "The ninja shoots more shurikens the farther you are, so don't go too far!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.0");
								}
								else
								{
									if (!(origin == "Crabulon will only launch spores every 3rd jump, better keep count!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.11");
								}
							}
							else if (num <= 2471077927U)
							{
								if (num <= 2378552975U)
								{
									if (num != 2330102409U)
									{
										if (num != 2378552975U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Yharon's burning some serious energy now! Stay focused!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.113");
									}
									else
									{
										if (!(origin == "Having trouble dodging during the spin? Three can play at that game, Spin!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.42");
									}
								}
								else if (num != 2415679194U)
								{
									if (num != 2471077927U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Pay attention to where you move. You don't want Providence to fire her lasers when near a wall!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.88");
								}
								else
								{
									if (!(origin == "It seems like she's going to give it all she has! Brace yourself!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.55");
								}
							}
							else if (num <= 2533386021U)
							{
								if (num != 2491270642U)
								{
									if (num != 2533386021U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Calamitas' is laying exploding brimstone magic with every charge, try to direct them away from a safe location!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.124");
								}
								else
								{
									if (!(origin == "Eye can't believe you died to that."))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.10");
								}
							}
							else if (num != 2538139252U)
							{
								if (num != 2552107572U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Home stretch! try focusing on yourself more than the boss!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.59");
							}
							else
							{
								if (!(origin == "Don't forget about that rubble! It will rain down from above!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.65");
							}
						}
						else if (num <= 2974622869U)
						{
							if (num <= 2746664723U)
							{
								if (num <= 2565914917U)
								{
									if (num != 2563223442U)
									{
										if (num != 2565914917U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "If a certain starting combo isnt working too well, maybe experiment with another one?"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.115");
									}
									else
									{
										if (!(origin == "Those drones are building a jail around you, destroying one will give you an opening!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.61");
									}
								}
								else if (num != 2740178606U)
								{
									if (num != 2746664723U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Seems like they are combining efforts, beware!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.122");
								}
								else
								{
									if (!(origin == "Getting rid of those extra hornets should be your top priority!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.29");
								}
							}
							else if (num <= 2894787964U)
							{
								if (num != 2810029304U)
								{
									if (num != 2894787964U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Try to keep a counter in the last phase. The Old Duke will teleport, charge seven times, and then repeat."))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.103");
								}
								else
								{
									if (!(origin == "I loath sand, its grainy and itchy and sticks to every part of my feet."))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.6");
								}
							}
							else if (num != 2914346585U)
							{
								if (num != 2974622869U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "The Deerclops will follow a set pattern, learn it to gain the upper hand!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.33");
							}
							else
							{
								if (!(origin == "Lightning is going to aim ahead of you! Try to bait it!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.74");
							}
						}
						else if (num <= 3053428252U)
						{
							if (num <= 3011215640U)
							{
								if (num != 2989176132U)
								{
									if (num != 3011215640U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Perhaps a long platform or two could help avoid some of the attacks?"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.19");
								}
								else
								{
									if (!(origin == "The Brain of Cthulhu uses a lot of prediction and deception in its attacks, so play extra smart!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.17");
								}
							}
							else if (num != 3044878930U)
							{
								if (num != 3053428252U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Don't feel intimidated, face fear in the eyes and dash directly into the Devourer's maw!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.108");
							}
							else
							{
								if (!(origin == "Stay away from those energy fields! Being too close to them will hurt you!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.81");
							}
						}
						else if (num <= 3063171529U)
						{
							if (num != 3057515533U)
							{
								if (num != 3063171529U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Those Honey Shots sure are bouncy, don't move too fast else they will splatter everywhere!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.28");
							}
							else
							{
								if (!(origin == "Prepare for it's final stand! Watch for red laser telegraphs and prepare to dash to safety!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.45");
							}
						}
						else if (num != 3084403564U)
						{
							if (num != 3133823908U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "The Hive Mind begins its next attack early if you attack it; wait until it's on cooldown before you shoot!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.25");
						}
						else
						{
							if (!(origin == "Quite a sticky situation you had to deal with..."))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.3");
						}
					}
					else if (num <= 3804465192U)
					{
						if (num <= 3578788770U)
						{
							if (num <= 3315356716U)
							{
								if (num <= 3241947331U)
								{
									if (num != 3194031378U)
									{
										if (num != 3241947331U)
										{
											goto IL_1CA0;
										}
										if (!(origin == "Are you really sure you don't want to use a dash for that fish?"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.104");
									}
									else
									{
										if (!(origin == "Move as little as possible while it's above you. That should calm down its spastic jittering!"))
										{
											goto IL_1CA0;
										}
										text = LangHelper.GetText("InfernumMode.CombatTexts.46");
									}
								}
								else if (num != 3278041695U)
								{
									if (num != 3315356716U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Static bolts seem to be flying towards you! Be wary of them, and don't get trapped by the lightning telegraphs!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.83");
								}
								else
								{
									if (!(origin == "The more you hurt it, the more probes it will spawn. Don't bite off more than you can chew!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.44");
								}
							}
							else if (num <= 3359204056U)
							{
								if (num != 3323550256U)
								{
									if (num != 3359204056U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "It seems as if it is manipulating telelocational magic, your Rod of Discord is of no use here!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.128");
								}
								else
								{
									if (!(origin == "That didn't work, but dont worry! Hive got a plan!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.26");
								}
							}
							else if (num != 3550252460U)
							{
								if (num != 3578788770U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "The Scourge usually roars when it's about to whip up a sandstorm, get to high grounds!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.4");
							}
							else
							{
								if (!(origin == "You're gonna have a bad time..."))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.70");
							}
						}
						else if (num <= 3645430594U)
						{
							if (num <= 3616040137U)
							{
								if (num != 3600999015U)
								{
									if (num != 3616040137U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Golem's eye color will change depending on it's attack. Keep your own eyes peeled!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.71");
								}
								else
								{
									if (!(origin == "Watch out for those teeth bombs! The teeth spew away from the bomb's landing, try staying close!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.8");
								}
							}
							else if (num != 3642696937U)
							{
								if (num != 3645430594U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "It's still going?!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.21");
							}
							else
							{
								if (!(origin == "Brace yourself! A barrage of slow bolts are going to be released!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.80");
							}
						}
						else if (num <= 3739140494U)
						{
							if (num != 3658948662U)
							{
								if (num != 3739140494U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "A dash of sorts helps a lot with the spinning ring attack, since it lets you quickly reach the opening!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.99");
							}
							else
							{
								if (!(origin == "Contrary to what you may think, running into the shadowflame walls will not work, take it slow!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.35");
							}
						}
						else if (num != 3748308231U)
						{
							if (num != 3804465192U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "Try to push his Rain Charge away by running towards the Hive Mind, this can help keep your arena clean!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.24");
						}
						else
						{
							if (!(origin == "Those meteorites fall ahead of you. Try baiting them for a little more breathing room!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.129");
						}
					}
					else if (num <= 3981008898U)
					{
						if (num <= 3858014629U)
						{
							if (num <= 3827530788U)
							{
								if (num != 3825034933U)
								{
									if (num != 3827530788U)
									{
										goto IL_1CA0;
									}
									if (!(origin == "Don't panic while trying to evade the bolts!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.66");
								}
								else
								{
									if (!(origin == "I can't Bee-lieve that, totally uncalled for!"))
									{
										goto IL_1CA0;
									}
									text = LangHelper.GetText("InfernumMode.CombatTexts.30");
								}
							}
							else if (num != 3853881130U)
							{
								if (num != 3858014629U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Try to get between those lines, before the ice barrages explode!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.75");
							}
							else
							{
								if (!(origin == "Oh my, so many lasers... better keep on the move!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.121");
							}
						}
						else if (num <= 3935776334U)
						{
							if (num != 3887883986U)
							{
								if (num != 3935776334U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "The Hive spews out a ton of lingering ichor, so space management is key!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.20");
							}
							else
							{
								if (!(origin == "You can weave through the clefs if you manipulate her movement well!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.57");
							}
						}
						else if (num != 3956624609U)
						{
							if (num != 3981008898U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "Don't let the flashbang faze you! Keep your eyes peeled for where the embers are!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.112");
						}
						else
						{
							if (!(origin == "Try focusing on those Crab Shrooms. They'll overwhelm you if you leave them alone!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.12");
						}
					}
					else if (num <= 4068307557U)
					{
						if (num <= 4019700548U)
						{
							if (num != 3986743527U)
							{
								if (num != 4019700548U)
								{
									goto IL_1CA0;
								}
								if (!(origin == "Geeettttttt DUNKED ON!!!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.35");
							}
							else
							{
								if (!(origin == "Be sure to run the opposite direction!"))
								{
									goto IL_1CA0;
								}
								text = LangHelper.GetText("InfernumMode.CombatTexts.43");
							}
						}
						else if (num != 4059823598U)
						{
							if (num != 4068307557U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "That guy was quite a lunatic, You might want extra mobility!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.76");
						}
						else
						{
							if (!(origin == "They dont seem very intelligent, maybe you could trick them to jump higher if you do aswell?"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.38");
						}
					}
					else if (num <= 4145226738U)
					{
						if (num != 4092173843U)
						{
							if (num != 4145226738U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "Some of Ravager's attacks reward you for staying close. Try not to run away!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.63");
						}
						else
						{
							if (!(origin == "Manage those clouds carefully. You'll need to weave through them to find the gap in her tentacles!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.69");
						}
					}
					else if (num != 4167621833U)
					{
						if (num != 4204657679U)
						{
							if (num != 4218444779U)
							{
								goto IL_1CA0;
							}
							if (!(origin == "Staying calm and still will help dodge the slow projectiles!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.22");
						}
						else
						{
							if (!(origin == "A Hook may prove useful to quickly get out of the Scourge's mandibles!"))
							{
								goto IL_1CA0;
							}
							text = LangHelper.GetText("InfernumMode.CombatTexts.5");
						}
					}
					else
					{
						if (!(origin == "With a jump that high, I wonder if you could duck beneath him?"))
						{
							goto IL_1CA0;
						}
						text = LangHelper.GetText("InfernumMode.CombatTexts.2");
					}
				/*
				if (Main.combatText[i].text == "")
				{
					Main.combatText[i].text = LangHelper.GetText("InfernumMode.CombatTexts.");
				}
				*/
				IL_1CAD:
					combatText.text = text;
					goto IL_1CB4;
				IL_1CA0:
					text = Main.combatText[index].text;
					goto IL_1CAD;
				}
			IL_1CB4:;
			}
		}
	}
}
