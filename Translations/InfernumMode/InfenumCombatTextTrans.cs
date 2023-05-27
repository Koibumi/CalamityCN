using CalamityCN.Utils;
using Terraria;

namespace CalamityCN.Translations.InfernumMode
{
	public class InfenumCombatTextTrans
	{
		internal static void LoadTranslation()
		{
			for (int index = 0; index < Main.maxCombatText; index++)
			{
				if (Main.combatText[index].active)
				{
					if (Main.combatText[index].text.Equals("Gate not set!"))
					{
						Main.combatText[index].text = "没有设置魔法门！";
					}
                    else if (Main.combatText[index].text.Equals("Infernum must be enabled to enter the Colosseum!"))
					{
						Main.combatText[index].text = "必须启用炼狱模式才能进入失落竞技场！";
					}
					else if (Main.combatText[index].text.Equals("Infinite flight granted!"))
                    {
                        Main.combatText[index].text = "准许无限飞行！";
                    }
					else if (Main.combatText[index].text.Equals("Peck!"))
					{
						Main.combatText[index].text = "菜！";
					}
					else if (Main.combatText[index].text.Equals("The pressure is too strong to escape!"))
					{
						Main.combatText[index].text = "压力太大了，无法逃脱!";
					}
					//Pet-RisingWarriorsSoulstone
					else if (Main.combatText[index].text.Equals("Thought you could keep me away? Think again!"))
					{
						Main.combatText[index].text = "你想远离我？ 再考虑下！";
					}
					else if (Main.combatText[index].text.Equals("Huzzah! I return."))
					{
						Main.combatText[index].text = "芜湖!我回来了。";
					}
					else if (Main.combatText[index].text.Equals("WOW it smells dusty inside that tablet..."))
					{
						Main.combatText[index].text = "WOW it smells dusty inside that tablet...";
					}
					else if (Main.combatText[index].text.Equals("Be careful with me, I'm a special little guy."))
					{
						Main.combatText[index].text = "小心点我，我是个特殊的小家伙。";
					}
					else if (Main.combatText[index].text.Equals("Back at last! Time to wreak havoc once more!"))
					{
						Main.combatText[index].text = "终于回来了!是时候再一次肆虐了!";
					}
					else if (Main.combatText[index].text.Equals("Gamers don't die, they respawn."))
					{
						Main.combatText[index].text = "玩家不会死亡，他们会复活。";
					}
					else if (Main.combatText[index].text.Equals("Weh!"))
					{
						Main.combatText[index].text = "疼!";
					}
					else if (Main.combatText[index].text.Equals("It's a beautiful day outside. Birds are singing, flowers are blooming..."))
					{
						Main.combatText[index].text = "外面是多美好的一天，鸟语花香……";
					}
					else if (Main.combatText[index].text.Equals("Wanna come pick flowers with me?"))
					{
						Main.combatText[index].text = "想和我一起去摘花吗?";
					}
					else if (Main.combatText[index].text.Equals("Hey, where do you keep your explosives?"))
					{
						Main.combatText[index].text = "嘿，你把炸药放哪了?";
					}
					else if (Main.combatText[index].text.Equals("What a boring day."))
					{
						Main.combatText[index].text = "多么无聊的一天。";
					}
					else if (Main.combatText[index].text.Equals("Come on! Let's do something FUN!"))
					{
						Main.combatText[index].text = "来吧!让我们做些有趣的事情吧!";
					}
					else if (Main.combatText[index].text.Equals("What's next on the agenda, compadre?"))
					{
						Main.combatText[index].text = "接下来干什么，伙计?";
					}
					else if (Main.combatText[index].text.Equals("Sparkle sparkle!"))
					{
						Main.combatText[index].text = "闪耀光芒!";
					}
					else if (Main.combatText[index].text.Equals("Heh, this'll be over quick."))
					{
						Main.combatText[index].text = "嘿，这很快就会结束。";
					}
					else if (Main.combatText[index].text.Equals("Don't die this time, alright?"))
					{
						Main.combatText[index].text = "这次别死，好吗?";
					}
					else if (Main.combatText[index].text.Equals("Back so soon?"))
					{
						Main.combatText[index].text = "这么快就回来了?";
					}
					else if (Main.combatText[index].text.Equals("If you lose this time, I'll eat all your furniture. That's a threat."))
					{
						Main.combatText[index].text = "如果这次你输了，我就吃光你的家具。这就是威胁。";
					}
					else if (Main.combatText[index].text.Equals("Don't forget potions!"))
					{
						Main.combatText[index].text = "别忘了药水！";
					}
					else if (Main.combatText[index].text.Equals("If you die on purpose, I'll give you a twenty."))
					{
						Main.combatText[index].text = "如果你是故意死的，我给你打二十分。";
					}
					else if (Main.combatText[index].text.Equals("Keh, this'll be a breeze!"))
					{
						Main.combatText[index].text = "咳，这将易如反掌!";
					}
					else if (Main.combatText[index].text.Equals("Go forth. Make me proud."))
					{
						Main.combatText[index].text = "勇往直前，我的骄傲。";
					}
					else if (Main.combatText[index].text.Equals("Show us how it's done, big shot."))
					{
						Main.combatText[index].text = "给我展示一手，大佬。";
					}
					else if (Main.combatText[index].text.Equals("Remember, fallgodding is ALWAYS an option!"))
					{
						Main.combatText[index].text = "Remember, fallgodding is ALWAYS an option!";
					}
					else if (Main.combatText[index].text.Equals("Hey now..."))
					{
						Main.combatText[index].text = "嘿,现在……";
					}
					else if (Main.combatText[index].text.Equals("WEH?"))
					{
						Main.combatText[index].text = "嗯？";
					}
					else if (Main.combatText[index].text.Equals("Affections!"))
					{
						Main.combatText[index].text = "爱情!";
					}
					else if (Main.combatText[index].text.Equals("Wait, don't stop..."))
					{
						Main.combatText[index].text = "等等，别停下来……";
					}

					/*
					 * LangHelper.GetText("InfernumMode.CombatTexts.New")
					 * 
					else if (Main.combatText[index].text.Equals(""))
					{
						Main.combatText[index].text = "";
					}
					*/
				}
			}
		}
	}
}
