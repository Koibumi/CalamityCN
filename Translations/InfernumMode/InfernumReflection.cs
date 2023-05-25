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
