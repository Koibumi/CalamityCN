using CalamityCN.Utils;
using CalamityMod.Systems;
using System;
using Microsoft.Xna.Framework;
using On.Terraria.UI.Chat;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using InfernumModeMusic.Projectiles;

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
			//InfernumModeMusic
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
				text2 = "Maw of the Corruption - 世界吞噬怪";
			}
			else if (text == "Intellect of the Crimson - The Brain of Cthulhu")
			{
				text2 = "Intellect of the Crimson - 克苏鲁之脑";
			}
			else if (text == "Royal Retaliation - The Queen Bee")
			{
				text2 = "Royal Retaliation - 蜂王";
			}
			else if (text == "Warden of the Damned - Skeletron")
			{
				text2 = "Warden of the Damned - 骷髅王";
			}
			else if (text == "One's Ending, Another's Beginning - Wall of Flesh")
			{
				text2 = "One's Ending, Another's Beginning - 血肉墙";
			}
			else if (text == "Crowned before One's End - Queen Slime")
			{
				text2 = "Crowned before One's End - 史莱姆皇后";
			}
			else if (text == "Inferior Fabrications - The Mechanical Trio")
			{
				text2 = "劣等造物 - 机械三王";
			}
			else if (text == "Floral Animosity - Plantera")
			{
				text2 = "Floral Animosity - 世纪之花";
			}
			else if (text == "Razorblade Typhoon - Duke Fishron")
			{
				text2 = "利刃台风 - 猪龙鱼公爵";
			}
			else if (text == "Shining Kaleidoscope - The Empress of Light")
			{
				text2 = "Shining Kaleidoscope - 光之女皇";
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
			else if (text == "Inferior Fabrications (Exo Remix) - The Exo Mechs")
			{
				text2 = "Inferior Fabrications (Exo Remix) - 星流巨械";
			}
			else if (text == "Catastrophic Fabrications - The Exo Mechs")
			{
				text2 = "铸灾神械 - 星流巨械";
			}
			else if (text == "Their Fabricator - Draedon")
			{
				text2 = "它们的造物主 - 嘉登";
			}
			else if (text == "Storm Before Dawn - Infernum")
			{
				text2 = "黎明前的风暴 - 炼狱";
			}

			
			/*
			else if (text == "")
			{
				text2 = "";
			}
			*/
			text = text2;
			return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
		}

	}
}
