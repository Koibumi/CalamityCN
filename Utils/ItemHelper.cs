using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityCN.Utils
{
	internal static class ItemHelper
	{
		internal static void TranslateTooltip(Item item, List<TooltipLine> tooltips, string lineName, Action<TooltipLine> action)
		{
			ItemHelper.ApplyTooltipEdits(item, tooltips, ItemHelper.TooltipLineName(lineName), action);
		}

		internal static void ApplyTooltipEdits(Item item, List<TooltipLine> lines, Func<Item, TooltipLine, bool> predicate, Action<TooltipLine> action)
		{
			Func<TooltipLine, bool> predicate2;
			if ((predicate2 = null) == null)
			{
				predicate2 = ((TooltipLine line) => predicate(item, line));
			}
			foreach (TooltipLine line2 in lines.Where(predicate2))
			{
				if (line2 != null)
				{
					action(line2);
				}
			}
		}
		private static Func<Item, TooltipLine, bool> TooltipLineName(string name)
		{
			return (Item item, TooltipLine tooltip) => tooltip.Name == name;
		}

		internal static Color ColorSwap(Color firstColor, Color secondColor, float seconds)
		{
			float num = (float)((Math.Sin(6.28318548202515 / (double)seconds * (double)Main.GlobalTimeWrappedHourly) + 1.0) * 0.5);
			return Color.Lerp(firstColor, secondColor, num);
		}

	}
}
