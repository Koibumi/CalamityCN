using CalamityCN;
using CalamityCN.Utils;
using InfernumMode.Content.Projectiles.Pets;
using System;
using System.Reflection;
using Terraria;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod
{
	public class HatGirlPatch : OnPatcher
	{
		public override bool AutoLoad
		{
			get
			{
				return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN;
			}
		}

		public override MethodInfo ModifiedMethod
		{
			get
			{
				return typeof(HatGirl).GetCachedMethod("SayThingWhileOwnerIsAlive");
			}
		}

		public override Delegate Delegate
		{
			get
			{
				return new Action<HatGirlPatch.SayThingWhileOwnerIsAliveDelegate, Player, string>(this.Translation);
			}
		}

		private void Translation(HatGirlPatch.SayThingWhileOwnerIsAliveDelegate orig, Player owner, string text)
		{
			//测试,没有GetTips部分
			string text2;
			if (text == "The ninja shoots more shurikens the farther you are, so don't go too far!")
			{
				text2 = "你离忍者越远，他就会扔更多飞镖，所以不要离太远！";
				goto IL_99A;
			}
			else if (text == "Those crystals are equally spaced... seems like you can dodge them the same way consistently!")
            {
				text2 = "这些水晶间隔相等……似乎你可以一直用同样的方法躲避它们！";
					goto IL_99A;
			}
			else if (text == "Those fireballs seem to only explode if they hit lava, you should probably bait them away!")
			{
				text2 = "那些火球似乎只有在碰到熔岩时才会爆炸，你应该把它们引开!";
					goto IL_99A;
			}
			else if (text == "It looks like Providence is preparing something!")
			{
				text2 = "看来亵渎天神，普罗维登斯在准备什么了!";
				goto IL_99A;
			}
			else if (text == "Who opened the faucets again?!")
			{
				text2 = "谁又把水龙头打开了?";
				goto IL_99A;
			}
			else if (text == "The lava is rising, get to higher ground!")
			{
				text2 = "岩浆正在上升，到高处去!";
				goto IL_99A;
			}
			else if (text == "So many skulls, but it appears they aren't focused directly at you! Try going inbetween!")
			{
				text2 = "好多头骨！但它们似乎并没有直接瞄准你，试着从空隙中穿过去！";
				goto IL_99A;
			}
			else if (text == "Home stretch! Do the same as you did before!")
			{
				text2 = "冲刺阶段！和之前一样躲！";
				goto IL_99A;
			}
			else if (text == "Polterghast's spirits have been released! But they don't seem very happy with us...")
			{
				text2 = "噬魂幽花体内的灵魂被释放了！但它们看起来并不快乐……";
				goto IL_99A;
			}
			else if (text == "Oh man, theres so many lasers! Slow and precise movements seem like your best bet here...")
			{
				text2 = "哦，天呐，好多激光！精准的慢动作似乎是你最好的选择……";
				goto IL_99A;
			}
			else if (text == "Bonk!")
			{
				text2 = "猛击！";
				goto IL_99A;
			}
			else if (text == "The profaned magic seems to be blocking your Rod of Discord!")
			{
				text2 = "亵渎魔法似乎禁止了你的混沌传送杖！";
				goto IL_99A;
			}
			else if (text == "It seems as if it is manipulating telelocational magic, your Rod of Discord is of no use here!")
			{
				text2 = "这似乎是影响传送定位的魔法，你的混沌传送杖在这里失效了！";
				goto IL_99A;
			}
			else if (text == "Better choose well!")
			{
				text2 = "做好选择！";
				goto IL_99A;
			}
			else if (text == "Stay calm and circle! Don't lose focus!")
			{
				text2 = "保持冷静的绕圈！不要失去注意力！";
				goto IL_99A;
			}

			/* 翻译后移出注释
			else if (text == "Destroy those builder drones before the whole jungle goes kablooey!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those blue tesla mines are going to explode into gas; take cover!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Better stay near the edges of the arena during those carpet bomb flames, That should keep them out of the way!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "The Moon Lord seems angry! Try to dodge the side projectiles, and don't touch that black hole!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "Plantera isn't keeping anything back, watch out!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "They've holed themselves up on the right, but if you get there you can probably breach their defenses!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "The Weaver seems to be creating a bunch of clouds above you! Try to weave through the resulting bolts as they fall!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "The beam predicts your position, try baiting it into shooting away from you!")
			{
				text2 = "!";
				goto IL_99A;
			}
			else if (text == "Even when all hell breaks loose, stay focused on your dodging!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "This speed is crazy! Make sure you know when it starts; you might get jumpscared!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those portals are preparing something! Get near the void, quickly!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Try your best to weave through the razorblades and brace youself!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Watch out, that last twin is gonna hit you with everything it's got! Don't let up!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "That thing is releasing so much energy! Try to get to the edge and move up and down to weave through it!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Stay near the center of your arena if you can. Those thorns are really good at cornering you!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Watch out, he might try to trick you at the end!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't fret, face fear in the eyes and dash directly into Thanatos' face-plates!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those bombs will explode into kunai that fly towards you. Be careful!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Dont feel overwhelmed by all the projectiles, keep your cool during this flaming match!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Keep track of where the long charge stops! You might get swept up by a tidal wave!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't move around too quickly! Small but quick horizontal movements are important for evading those crystals!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "The ninja shoots more shurikens the farther you are, so don't go too far!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "That thing seems to have shed its outer shell. Brace yourself, it's going to be a lot faster now!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Yharon's burning some serious energy now! Stay focused!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "The water is almost boiling, I'd surface unless you want to become fried human!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "Try ramming into the defender!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Calamitas' is laying exploding brimstone magic with every charge, try to direct them away from a safe location!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those chains wont seem to hold it much longer, brace yourself!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Home stretch! try focusing on yourself more than the boss!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't forget about that rubble! It will rain down from above!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "If a certain starting combo isnt working too well, maybe experiment with another one?")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those drones are building a jail around you, destroying one will give you an opening!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Seems like they are combining efforts, beware!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Looks like that's not all this serpent could do, we gotta skeddadle!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Ohhh, he's really mad now! Stay on your toes!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Lightning is going to aim ahead of you! Try to bait it!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Prepare for it's final stand! Watch for red laser telegraphs and prepare to dash to safety!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't feel intimidated, face fear in the eyes and dash directly into the Devourer's maw!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Static bolts seem to be flying towards you! Be wary of them, and don't get trapped by the lightning telegraphs!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "It's getting physical now! Don't let one distract you from the other!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "They're a really good team! You'll want to manage everything at once, taking it slow is your best shot!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "Brace yourself! A barrage of slow bolts are going to be released!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "You're gonna have a bad time...")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Those blobs seem to spin in a spiral! Spin with them!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "It's still going?!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "That bleach bubble looks like a good place to recover from the acidic water!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't panic while trying to evade the bolts!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Don't let the flashbang faze you! Keep your eyes peeled for where the embers are!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Try to get between those lines, before the ice barrages explode!")
			{
				text2 = "";
				goto IL_99A;
			}
			else if (text == "Staying calm and still will help dodge the slow projectiles!")
			{
				text2 = "";
				goto IL_99A;
			}
			
			else if (text == "Manage those clouds carefully. You'll need to weave through them to find the gap in her tentacles!")
			{
				text2 = "";
				goto IL_99A;
			}
			*/
			text2 = text;
			IL_99A:
			text = text2;
			orig(owner, text);
		}

		private delegate void SayThingWhileOwnerIsAliveDelegate(Player owner, string text);
	}
}
