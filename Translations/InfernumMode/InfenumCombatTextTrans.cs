using CalamityCN.Utils;
using Terraria;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfenumCombatTextTrans
	{
		internal static void LoadTranslation()
		{
			for (int index = 0; index < 100; index++)
			{
				if (Main.combatText[index].active)
				{
					if (Main.combatText[index].text.Equals("Gate not set!"))
					{
						Main.combatText[index].text = "没有设置魔法门！";
					}
					if (Main.combatText[index].text.Equals("Infernum must be enabled to enter the Colosseum!"))
					{
						Main.combatText[index].text = "必须启用炼狱模式才能进入失落竞技场！";
					}
					/*
					if (Main.combatText[index].text.Equals("Many layered platforms can help greatly to avoid the exploding Cursed Flames!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.14");
					}
					if (Main.combatText[index].text.Equals("Be sure to remember if any sharkrons or tooth balls appear, so that their remains don't surprise you later!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.101");
					}
					if (Main.combatText[index].text.Equals("Keep your feet working! This gelatinous queen will stop at nothing to crush her foes!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.52");
					}
					if (Main.combatText[index].text.Equals("So many skulls, but it appears they aren't focused directly at you! Try going inbetween!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.123");
					}
					if (Main.combatText[index].text.Equals("Home stretch! Do the same as you did before!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.56");
					}
					if (Main.combatText[index].text.Equals("Polterghast's spirits have been released! But they don't seem very happy with us..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.98");
					}
					if (Main.combatText[index].text.Equals("Best to keep close during these Exo Overload attacks, otherwise you may have trouble keeping up with the spin!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.117");
					}
					if (Main.combatText[index].text.Equals("Try and move as precisely as possible here; you don't want to waste arena space!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.54");
					}
					if (Main.combatText[index].text.Equals("Oof, that mustve Stung..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.31");
					}
					if (Main.combatText[index].text.Equals("You better have dessert for me after this..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.7");
					}
					if (Main.combatText[index].text.Equals("Destroy those builder drones before the whole jungle goes kablooey!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.62");
					}
					if (Main.combatText[index].text.Equals("Oh man, theres so many lasers! Slow and precise movements seem like your best bet here..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.109");
					}
					if (Main.combatText[index].text.Equals("A dash and a hook can greatly help with reacting to the Eaters bursts of speed!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.15");
					}
					if (Main.combatText[index].text.Equals("Watch for the gaps in the icicles around Cryogen, they're a great indicator of where a safe spot is!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.47");
					}
					if (Main.combatText[index].text.Equals("Better stay near the edges of the arena during those carpet bomb flames, That should keep them out of the way!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.110");
					}
					if (Main.combatText[index].text.Equals("Those large red lightning pillars can be negated by flying below them!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.85");
					}
					if (Main.combatText[index].text.Equals("Those blue tesla mines are going to explode into gas; take cover!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.40");
					}
					if (Main.combatText[index].text.Equals("Stay somewhat close, otherwise you may be caught off guard!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.60");
					}
					if (Main.combatText[index].text.Equals("Dont let all the projectiles intimidate you, be very cautious with your movement!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.39");
					}
					if (Main.combatText[index].text.Equals("AND IF I SHOULD DIE BEFORE YOU CONTINUEE, YOU SHALL HAV-... Wait, you died? Come on, I was on a roll here!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.114");
					}
					if (Main.combatText[index].text.Equals("Squib emoji"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.79");
					}
					if (Main.combatText[index].text.Equals("The Brain is going to try to decieve you with various mind games, keep your eyes on the real one!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.18");
					}
					if (Main.combatText[index].text.Equals("Going in a tight circular pattern helps with the attacker guardian's spears!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.82");
					}
					if (Main.combatText[index].text.Equals("The Moon Lord seems angry! Try to dodge the side projectiles, and don't touch that black hole!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.77");
					}
					if (Main.combatText[index].text.Equals("A dashing accessory would be reeaaally helpful here..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.105");
					}
					if (Main.combatText[index].text.Equals("This is the time you would want to learn the opponents moves, use their tells to get the upper hand!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.23");
					}
					if (Main.combatText[index].text.Equals("The fight against the Dragonfolly is very chaotic and fast paced. Good mobility and reaction time help a lot!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.84");
					}
					if (Main.combatText[index].text.Equals("Deerclops' are Myopic, so they will force you to stay close, dont let them corner you!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.32");
					}
					if (Main.combatText[index].text.Equals("Short hops may help better than trying to fly away from all the crystal shrapnel!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.53");
					}
					if (Main.combatText[index].text.Equals("Plantera isn't keeping anything back, watch out!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.68");
					}
					if (Main.combatText[index].text.Equals("The Weaver has shed its exterior. It will now move far faster!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.90");
					}
					if (Main.combatText[index].text.Equals("The Scourge will stop at nothing to snack on you! Stay on the move!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.51");
					}
					if (Main.combatText[index].text.Equals("Pay attention to where you move. Try to stay in one spot so that those bombs aren't all over the arena!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.86");
					}
					if (Main.combatText[index].text.Equals("Most of the Void's attacks require fast maneuvering to evade. Be sure to pay attention to any projectiles on-screen!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.95");
					}
					if (Main.combatText[index].text.Equals("Do you want my Witch's hat? Matching her atire could be fun..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.127");
					}
					if (Main.combatText[index].text.Equals("Better choose well!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.116");
					}
					if (Main.combatText[index].text.Equals("Those eyeballs perform attacks that require a lot of weaving! Make sure to not panic when they happen!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.78");
					}
					if (Main.combatText[index].text.Equals("The Weaver seems to be creating a bunch of clouds above you! Try to weave through the resulting bolts as they fall!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.92");
					}
					if (Main.combatText[index].text.Equals("Even when all hell breaks loose, stay focused on your dodging!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.126");
					}
					if (Main.combatText[index].text.Equals("Ares' has one hell of a supercomputer, those arms are super predictive! Maybe you can use that to your advantage?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.118");
					}
					if (Main.combatText[index].text.Equals("That serpent is really fast! Good mobility will be important to defeat it!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.67");
					}
					if (Main.combatText[index].text.Equals("Deer god..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.34");
					}
					if (Main.combatText[index].text.Equals("A dashing accessory would be reeaaaally helpful here..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.106");
					}
					if (Main.combatText[index].text.Equals("The beam predicts your position, try baiting it into shooting away from you!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.49");
					}
					if (Main.combatText[index].text.Equals("Watch out, that last twin is gonna hit you with everything it's got! Don't let up!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.41");
					}
					if (Main.combatText[index].text.Equals("This speed is crazy! Make sure you know when it starts; you might get jumpscared!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.111");
					}
					if (Main.combatText[index].text.Equals("Try your best to weave through the razorblades and brace youself!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.73");
					}
					if (Main.combatText[index].text.Equals("Try to learn King Slime's jump pattern! It could help you plan your next move better."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.1");
					}
					if (Main.combatText[index].text.Equals("Stay near the center of your arena if you can. Those thorns are really good at cornering you!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.48");
					}
					if (Main.combatText[index].text.Equals("Movement speed is gonna matter a lot against that fish!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.102");
					}
					if (Main.combatText[index].text.Equals("Don't worry about hooking to the walls or anything like that. Providence provides you with unlimited flight time!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.89");
					}
					if (Main.combatText[index].text.Equals("Don't panic when Skeletron does his barrages of hand fireballs! Just jump and stay calm!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.36");
					}
					if (Main.combatText[index].text.Equals("The Exo-Twins are magnificently in-sync, try finding a rythem to outsmart them!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.119");
					}
					if (Main.combatText[index].text.Equals("Try not to move too much at the start of the battle. Finding a good spot and staying near it helps a lot!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.94");
					}
					if (Main.combatText[index].text.Equals("This is the Void's last stand! Try not to get sucked in, and weave through the energy bolts!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.93");
					}
					if (Main.combatText[index].text.Equals("There isnt Mushroom for the three of us, and I can tell who won the roullete."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.13");
					}
					if (Main.combatText[index].text.Equals("Don't fret, face fear in the eyes and dash directly into Thanatos' face-plates!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.120");
					}
					if (Main.combatText[index].text.Equals("Being able to face it head on with a ram sounds like a good idea, don't you think?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.107");
					}
					if (Main.combatText[index].text.Equals("Investing in a hook or high mobility could prove great to dodge the Eye of Cthulhu's Charges!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.9");
					}
					if (Main.combatText[index].text.Equals("Watch out, he might try to trick you at the end!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.96");
					}
					if (Main.combatText[index].text.Equals("If you can't handle dodging at high speeds, try baiting it into circling you!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.50");
					}
					if (Main.combatText[index].text.Equals("Dont feel overwhelmed by all the projectiles, keep your cool during this flaming match!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.125");
					}
					if (Main.combatText[index].text.Equals("I guess it eats more than just worlds."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.16");
					}
					if (Main.combatText[index].text.Equals("The meteors all split in the same way; use this to your advantage!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.58");
					}
					if (Main.combatText[index].text.Equals("Those bombs will explode into kunai that fly towards you. Be careful!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.97");
					}
					if (Main.combatText[index].text.Equals("Keep track of where the long charge stops! You might get swept up by a tidal wave!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.72");
					}
					if (Main.combatText[index].text.Equals("Don't move around too quickly! Small but quick horizontal movements are important for evading those crystals!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.87");
					}
					if (Main.combatText[index].text.Equals("That thing seems to have shed its outer shell. Brace yourself, it's going to be a lot faster now!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.64");
					}
					if (Main.combatText[index].text.Equals("I would make a snarky comment right now, but I probably should Mind my own business..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.27");
					}
					if (Main.combatText[index].text.Equals("Try to not move too far away when the Weaver spins in place, so you can see the bolts before they accelerate too much!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.91");
					}
					if (Main.combatText[index].text.Equals("If one of the Polterghast's legs turn red, quickly back away; it's going to swipe at you and release accelerating projectiles!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.100");
					}
					if (Main.combatText[index].text.Equals("The ninja shoots more shurikens the farther you are, so don't go too far!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.0");
					}
					if (Main.combatText[index].text.Equals("Crabulon will only launch spores every 3rd jump, better keep count!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.11");
					}
					if (Main.combatText[index].text.Equals("Yharon's burning some serious energy now! Stay focused!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.113");
					}
					if (Main.combatText[index].text.Equals("Having trouble dodging during the spin? Three can play at that game, Spin!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.42");
					}
					if (Main.combatText[index].text.Equals("Pay attention to where you move. You don't want Providence to fire her lasers when near a wall!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.88");
					}
					if (Main.combatText[index].text.Equals("It seems like she's going to give it all she has! Brace yourself!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.55");
					}
					if (Main.combatText[index].text.Equals("Calamitas' is laying exploding brimstone magic with every charge, try to direct them away from a safe location!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.124");
					}
					if (Main.combatText[index].text.Equals("Eye can't believe you died to that."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.10");
					}
					if (Main.combatText[index].text.Equals("Home stretch! try focusing on yourself more than the boss!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.59");
					}
					if (Main.combatText[index].text.Equals("Don't forget about that rubble! It will rain down from above!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.65");
					}
					if (Main.combatText[index].text.Equals("If a certain starting combo isnt working too well, maybe experiment with another one?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.115");
					}
					if (Main.combatText[index].text.Equals("Those drones are building a jail around you, destroying one will give you an opening!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.61");
					}
					if (Main.combatText[index].text.Equals("Seems like they are combining efforts, beware!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.122");
					}
					if (Main.combatText[index].text.Equals("Getting rid of those extra hornets should be your top priority!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.29");
					}
					if (Main.combatText[index].text.Equals("Try to keep a counter in the last phase. The Old Duke will teleport, charge seven times, and then repeat."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.103");
					}
					if (Main.combatText[index].text.Equals("I loath sand, its grainy and itchy and sticks to every part of my feet."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.6");
					}
					if (Main.combatText[index].text.Equals("The Deerclops will follow a set pattern, learn it to gain the upper hand!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.33");
					}
					if (Main.combatText[index].text.Equals("Lightning is going to aim ahead of you! Try to bait it!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.74");
					}
					if (Main.combatText[index].text.Equals("Perhaps a long platform or two could help avoid some of the attacks?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.19");
					}
					if (Main.combatText[index].text.Equals("The Brain of Cthulhu uses a lot of prediction and deception in its attacks, so play extra smart!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.17");
					}
					if (Main.combatText[index].text.Equals("Don't feel intimidated, face fear in the eyes and dash directly into the Devourer's maw!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.108");
					}
					if (Main.combatText[index].text.Equals("Stay away from those energy fields! Being too close to them will hurt you!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.81");
					}
					if (Main.combatText[index].text.Equals("Those Honey Shots sure are bouncy, don't move too fast else they will splatter everywhere!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.28");
					}
					if (Main.combatText[index].text.Equals("Prepare for it's final stand! Watch for red laser telegraphs and prepare to dash to safety!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.45");
					}
					if (Main.combatText[index].text.Equals("The Hive Mind begins its next attack early if you attack it; wait until it's on cooldown before you shoot!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.25");
					}
					if (Main.combatText[index].text.Equals("Quite a sticky situation you had to deal with..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.3");
					}
					if (Main.combatText[index].text.Equals("Are you really sure you don't want to use a dash for that fish?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.104");
					}
					if (Main.combatText[index].text.Equals("Move as little as possible while it's above you. That should calm down its spastic jittering!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.46");
					}
					if (Main.combatText[index].text.Equals("Static bolts seem to be flying towards you! Be wary of them, and don't get trapped by the lightning telegraphs!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.83");
					}
					if (Main.combatText[index].text.Equals("The more you hurt it, the more probes it will spawn. Don't bite off more than you can chew!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.44");
					}
					if (Main.combatText[index].text.Equals("It seems as if it is manipulating telelocational magic, your Rod of Discord is of no use here!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.128");
					}
					if (Main.combatText[index].text.Equals("That didn't work, but dont worry! Hive got a plan!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.26");
					}
					if (Main.combatText[index].text.Equals("The Scourge usually roars when it's about to whip up a sandstorm, get to high grounds!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.4");
					}
					if (Main.combatText[index].text.Equals("You're gonna have a bad time..."))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.70");
					}
					if (Main.combatText[index].text.Equals("Golem's eye color will change depending on it's attack. Keep your own eyes peeled!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.71");
					}
					if (Main.combatText[index].text.Equals("Watch out for those teeth bombs! The teeth spew away from the bomb's landing, try staying close!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.8");
					}
					if (Main.combatText[index].text.Equals("It's still going?!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.21");
					}
					if (Main.combatText[index].text.Equals("Brace yourself! A barrage of slow bolts are going to be released!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.80");
					}
					if (Main.combatText[index].text.Equals("A dash of sorts helps a lot with the spinning ring attack, since it lets you quickly reach the opening!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.99");
					}
					if (Main.combatText[index].text.Equals("Contrary to what you may think, running into the shadowflame walls will not work, take it slow!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.35");
					}
					if (Main.combatText[index].text.Equals("Try to push his Rain Charge away by running towards the Hive Mind, this can help keep your arena clean!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.24");
					}
					if (Main.combatText[index].text.Equals("Those meteorites fall ahead of you. Try baiting them for a little more breathing room!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.129");
					}
					if (Main.combatText[index].text.Equals("Don't panic while trying to evade the bolts!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.66");
					}
					if (Main.combatText[index].text.Equals("I can't Bee-lieve that, totally uncalled for!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.30");
					}
					if (Main.combatText[index].text.Equals("Try to get between those lines, before the ice barrages explode!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.75");
					}
					if (Main.combatText[index].text.Equals("Oh my, so many lasers... better keep on the move!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.121");
					}
					if (Main.combatText[index].text.Equals("The Hive spews out a ton of lingering ichor, so space management is key!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.20");
					}
					if (Main.combatText[index].text.Equals("You can weave through the clefs if you manipulate her movement well!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.57");
					}
					if (Main.combatText[index].text.Equals("Don't let the flashbang faze you! Keep your eyes peeled for where the embers are!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.112");
					}
					if (Main.combatText[index].text.Equals("Try focusing on those Crab Shrooms. They'll overwhelm you if you leave them alone!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.12");
					}
					if (Main.combatText[index].text.Equals("Geeettttttt DUNKED ON!!!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.35");
					}
					if (Main.combatText[index].text.Equals("Be sure to run the opposite direction!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.43");
					}
					if (Main.combatText[index].text.Equals("That guy was quite a lunatic, You might want extra mobility!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.76");
					}
					if (Main.combatText[index].text.Equals("They dont seem very intelligent, maybe you could trick them to jump higher if you do aswell?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.38");
					}
					if (Main.combatText[index].text.Equals("Some of Ravager's attacks reward you for staying close. Try not to run away!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.63");
					}
					if (Main.combatText[index].text.Equals("Manage those clouds carefully. You'll need to weave through them to find the gap in her tentacles!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.69");
					}
					if (Main.combatText[index].text.Equals("Staying calm and still will help dodge the slow projectiles!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.22");
					}
					if (Main.combatText[index].text.Equals("A Hook may prove useful to quickly get out of the Scourge's mandibles!"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.5");
					}
					if (Main.combatText[index].text.Equals("With a jump that high, I wonder if you could duck beneath him?"))
					{
						Main.combatText[index].text = LangHelper.GetText("InfernumMode.CombatTexts.2");
					}
					*/
				}
			}
		}
	}
}
