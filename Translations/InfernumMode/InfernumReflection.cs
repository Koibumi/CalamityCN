using CalamityCN.Utils;
using CalamityMod.Systems;
using System;
using Microsoft.Xna.Framework;
using On.Terraria.UI.Chat;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;

namespace CalamityCN.Mods.InfernumMode
{
	public class InfernumReflection : ContentTranslation, ILoadableContent
	{
		public override bool IsTranslationEnabled
		{
			get
			{
				return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN;
			}
		}

		public override float Priority
		{
			get
			{
				return 1f;
			}
		}

		public void LoadContent()
		{
			DifficultyModeSystem.Difficulties[4].Name = "炼狱";
			DifficultyModeSystem.Difficulties[4].ShortDescription = "[c/B32E81:对于追求比死亡模式更高难度人来说，这是一个独特的挑战。]\n[c/B32E81:此模式不适用于大师模式或For The Worth种子]";
			CalamityCN.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityCN/Fonts/BossIntroScreensFont", (ReLogic.Content.AssetRequestMode)1).Value;

			ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float += new ChatManager.hook_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float(this.DrawColorCodedStringWithShadowHook);
		}

		public void UnloadContent()
		{
			ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= new ChatManager.hook_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float(this.DrawColorCodedStringWithShadowHook);
		}

		private Vector2 DrawColorCodedStringWithShadowHook(ChatManager.orig_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, float spread)
		{
			string text2;
			if (!(text == "Toggle cybernetic immortality"))
			{
				if (!(text == "Toggle physics defiance flying"))
				{
					if (!(text == "Accelerate time until sunrise"))
					{
						if (!(text == "Accelerate time until noon"))
						{
							if (!(text == "Accelerate time until sunset"))
							{
								if (!(text == "Atomize every single hostile NPC"))
								{
									text2 = text;
								}
								else
								{
									text2 = "湮灭每个敌对NPC";
								}
							}
							else
							{
								text2 = "时间加速至日落";
							}
						}
						else
						{
							text2 = "时间加速至中午";
						}
					}
					else
					{
						text2 = "时间加速至日出";
					}
				}
				else
				{
					text2 = "开关反物理飞行";
				}
			}
			else
			{
				text2 = "开关控制不死";
			}
			//InfernumModeMusic ? 重加载才生效
			if (text == "Sky After Rain - Infernum")
			{
				text2 = "雨后的天空 - 炼狱";
			}
			else if (text == "Gelatinous Dynasty - King Slime")
			{
				text2 = "凝元王朝 - 史莱姆王";
			}
			else if (text == "Seer of the Night - The Eye of Cthulhu")
			{
				text2 = "夜幕凝视 - 克苏鲁之眼";
			}
			else if (text == "Maw of the Corruption - The Eater of Worlds")
			{
				text2 = "腐化胃咽 - 世界吞噬怪";
			}
			else if (text == "Intellect of the Crimson - The Brain of Cthulhu")
			{
				text2 = "猩红遗智 - 克苏鲁之脑";
			}
			else if (text == "Royal Retaliation - The Queen Bee")
			{
				text2 = "皇后的复仇 - 蜂王";
			}
			else if (text == "Warden of the Damned - Skeletron")
			{
				text2 = "诅咒守门人 - 骷髅王";
			}
			else if (text == "One's Ending, Another's Beginning - Wall of Flesh")
			{
				text2 = "终亦是始 - 血肉墙";
			}
			else if (text == "Misanthropic Encounters - Minibosses")
			{
				text2 = "Misanthropic Encounters - 小Boss";
			}
			else if (text == "Crowned before One's End - Queen Slime")
			{
				text2 = "神赐末王 - 史莱姆皇后";
			}
			else if (text == "Inferior Fabrications - The Mechanical Trio")
			{
				text2 = "劣等造物 - 机械三王";
			}
			else if (text == "Floral Animosity - Plantera")
			{
				text2 = "花卉暴憎 - 世纪之花";
			}
			else if (text == "Icon of the Sun - Golem")
			{
				text2 = "Icon of the Sun - 石巨人";
			}
			else if (text == "Razorblade Typhoon - Duke Fishron")
			{
				text2 = "利刃台风 - 猪龙鱼公爵";
			}
			else if (text == "Shining Kaleidoscope - The Empress of Light")
			{
				text2 = "曜天万華鏡 - 光之女皇";
			}
			else if (text == "Eidolic Ancestry - The Lunatic Cultist")
			{
				text2 = "幻海血脉 - 拜月教邪教徒";
			}
			else if (text == "Duel for a Lost Kingdom - The Bereft Vassal")
			{
				text2 = "为失落王国而决斗 - 无邦封臣";
			}
			else if (text == "The End of an Olden Era - The Moon Lord")
			{
				text2 = "旧世之终 - 月亮领主";
			}
			else if (text == "TVocitus Terminus - The Eidolon Wyrm")
			{
				text2 = "Vocitus Terminus - 幻海妖龙";
			}
			else if (text == "Inferior Fabrications (Exo Remix) - The Exo Mechs")
			{
				text2 = "劣等造物（星流混音） - 星流巨械";
			}
			else if (text == "Catastrophic Fabrications - The Exo Mechs")
			{
				text2 = "铸灾神械 - 星流巨械";
			}
			else if (text == "Their Fabricator - Draedon")
			{
				text2 = "它们的造物主 - 嘉登";
			}
			else if (text == "Scars of Calamity - Calamitas")
			{
				text2 = "Scars of Calamity - 灾厄";
			}
			else if (text == "Storm Before Dawn - Infernum")
			{
				text2 = "黎明前的风暴 - 炼狱";
			}

			text = text2;
			
			return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
		}

	}
}
