using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace CalamityCN.Mods.InfernumMode
{
	public class InfernumReflection : ILoadable
	{
		public bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.Calamity != null && ModsCall.Infernum != null && ModsCall.IsCN;
		}

		public void Load(Mod mod)
		{
			CalamityCN.Instance.BossIntroScreensFont = ModContent.Request<DynamicSpriteFont>("CalamityCN/Fonts/BossIntroScreensFont", (ReLogic.Content.AssetRequestMode)1).Value;
			On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float += new On_ChatManager.hook_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float(this.DrawColorCodedStringWithShadowHook);
		}

		public void Unload()
		{
			On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= new On_ChatManager.hook_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float(this.DrawColorCodedStringWithShadowHook);
		}
		private Vector2 DrawColorCodedStringWithShadowHook(On_ChatManager.orig_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, float spread)
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
									text2 = "湮灭敌对NPC";
								}
							}
							else
							{
								text2 = "加速时间至傍晚";
							}
						}
						else
						{
							text2 = "加速时间至正午";
						}
					}
					else
					{
						text2 = "加速时间至早晨";
					}
				}
				else
				{
					text2 = "切换反物理飞行";
				}
			}
			else
			{
				text2 = "切换无敌控制";
			}
			text = text2;
			return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
		}
	}
}
