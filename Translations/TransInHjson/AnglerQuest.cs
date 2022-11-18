using System;
using CalamityCN.Utils;
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
				chat = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.EutrophicSandfish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.EutrophicSandfish.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Serpentuna>())
			{
				chat = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Serpentuna.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Serpentuna.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<SurfClam>())
			{
				chat = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.SurfClam.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.SurfClam.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Brimlish>())
			{
				chat = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Brimlish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Brimlish.CatchLocation");
				return;
			}
			if (type == ModContent.ItemType<Slurpfish>())
			{
				chat = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Slurpfish.Chat");
				catchLocation = LangHelper.GetText("CalamityMod.NPCs.AnglerQuest.Slurpfish.CatchLocation");
			}
		}
	}
}
