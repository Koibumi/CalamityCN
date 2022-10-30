using System;
using CalamityCN.LangUtils;
using CalamityMod.Items.Fishing.BrimstoneCragCatches;
using CalamityMod.Items.Fishing.SunkenSeaCatches;
using Terraria.ModLoader;

namespace CalamityCN.Translations.TransInHjson
{
	public class AnglerQuest : GlobalItem
	{
		public override bool IsLoadingEnabled(Mod mod)
		{
			return ModsCall.IsCN && ModsCall.Calamity != null;
		}

		public override void AnglerChat(int type, ref string chat, ref string catchLocation)
		{
			if (type == ModContent.ItemType<EutrophicSandfish>())
			{
				chat = LangHelper.GetText("CalamityMod.AnglerQuest.EutrophicSandfish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.EutrophicSandfish.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Serpentuna>())
			{
				chat = LangHelper.GetText("CalamityMod.AnglerQuest.Serpentuna.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Serpentuna.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<SurfClam>())
			{
				chat = LangHelper.GetText("CalamityMod.AnglerQuest.SurfClam.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.SurfClam.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Brimlish>())
			{
				chat = LangHelper.GetText("CalamityMod.AnglerQuest.Brimlish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Brimlish.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Slurpfish>())
			{
				chat = LangHelper.GetText("CalamityMod.AnglerQuest.Slurpfish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.AnglerQuest.Slurpfish.CatchLocation");
			}
		}
	}
}
