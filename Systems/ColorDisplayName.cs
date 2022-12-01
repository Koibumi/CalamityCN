using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoMod.RuntimeDetour.HookGen;
using ReLogic.Content;
using System;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace CalamityCN.Systems
{
	public class ColorDisplayName : ModSystem
	{
		private static Type _uiModItemType;
		private static MethodInfo _drawMethod;

		private static RenderTarget2D _renderTarget;

		public override void Load()
		{
			if (Main.dedServ)
			{
				return;
			}

			Main.QueueMainThreadAction(() =>
			{
				string text = Mod.DisplayName + " v" + Mod.Version;
				var size = ChatManager.GetStringSize(FontAssets.MouseText.Value, text, Vector2.One).ToPoint();

				_renderTarget = new RenderTarget2D(Main.graphics.GraphicsDevice, size.X, size.Y);

				Main.spriteBatch.Begin();
				Main.graphics.GraphicsDevice.SetRenderTarget(_renderTarget);
				Main.graphics.GraphicsDevice.Clear(Color.Transparent);

				ChatManager.DrawColorCodedString(Main.spriteBatch, FontAssets.MouseText.Value, text, Vector2.Zero,
					Color.White, 0f, Vector2.Zero, Vector2.One);

				Main.spriteBatch.End();
				Main.graphics.GraphicsDevice.SetRenderTarget(null);
			});

			_uiModItemType = typeof(Main).Assembly.GetTypes().First(t => t.Name == "UIModItem");
			_drawMethod = _uiModItemType.GetMethod("Draw", BindingFlags.Instance | BindingFlags.Public);

			if (_drawMethod is not null)
			{
				HookEndpointManager.Add(_drawMethod, DrawHook);
			}
		}

		public override void Unload()
		{
			if (Main.dedServ)
			{
				return;
			}
			if (_drawMethod is not null)
			{
				HookEndpointManager.Remove(_drawMethod, DrawHook);
			}
			if (_renderTarget is not null)
			{
				_renderTarget = null;
			}
		}

		public delegate void DrawDelegate(object uiModItem, SpriteBatch sb);

		private void DrawHook(DrawDelegate orig, object uiModItem, SpriteBatch sb)
		{
			orig.Invoke(uiModItem, sb);

			if (_renderTarget is null)
			{
				return;
			}
			if (_uiModItemType.GetField("_modName", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(uiModItem) is not UIText modName)
			{
				throw new Exception("出现错误嘞");
			}
			if (!modName.Text.Contains(Mod.DisplayName))
			{
				return;
			}
			// 材质目录在这里
			var texture = ModContent.Request<Texture2D>("CalamityCN/Assets/Textures/Shader/Golden");
			var shader = ModContent.Request<Effect>("CalamityCN/Assets/Effects/Golden", AssetRequestMode.ImmediateLoad).Value;

			shader.Parameters["uTime"].SetValue(Main.GlobalTimeWrappedHourly * 0.25f);
			Main.instance.GraphicsDevice.Textures[1] = texture.Value;

			var position = modName.GetDimensions().Position() - new Vector2(0f, 2f);


			sb.End();
			sb.Begin(SpriteSortMode.Immediate, sb.GraphicsDevice.BlendState, sb.GraphicsDevice.SamplerStates[0],
				sb.GraphicsDevice.DepthStencilState, sb.GraphicsDevice.RasterizerState, shader, Main.UIScaleMatrix);
			sb.Draw(_renderTarget, position, Color.White);
			// 一般的绘制字符串方法
			// ChatManager.DrawColorCodedString(sb, FontAssets.MouseText.Value, modName.Text, position, Color.White, 0f, Vector2.Zero, Vector2.One);
			sb.End();
			sb.Begin(SpriteSortMode.Deferred, sb.GraphicsDevice.BlendState, sb.GraphicsDevice.SamplerStates[0],
				sb.GraphicsDevice.DepthStencilState, sb.GraphicsDevice.RasterizerState, null, Main.UIScaleMatrix);
		}
	}
}
