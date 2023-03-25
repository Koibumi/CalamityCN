using CalamityCN;
using CalamityMod;
using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.DraedonMisc;
using CalamityMod.Items.Mounts;
using CalamityMod.Items.Placeables.FurnitureAbyss;
using CalamityMod.Items.Placeables.FurnitureAcidwood;
using CalamityMod.Items.Placeables.FurnitureAncient;
using CalamityMod.Items.Placeables.FurnitureAshen;
using CalamityMod.Items.Placeables.FurnitureCosmilite;
using CalamityMod.Items.Placeables.FurnitureExo;
using CalamityMod.Items.Placeables.FurnitureMonolith;
using CalamityMod.Items.Placeables.FurnitureOtherworldly;
using CalamityMod.Items.Placeables.FurnitureProfaned;
using CalamityMod.Items.Placeables.FurnitureStatigel;
using CalamityMod.Items.Placeables.FurnitureStratus;
using CalamityMod.Items.Placeables.FurnitureVoid;
using CalamityMod.Items.Potions;
using CalamityMod.Items.SummonItems;
using CalamityMod.Items.Weapons.DraedonsArsenal;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Items.Weapons.Melee;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod.Items.Placeables.Furniture.CraftingStations;
using CalamityMod.Items.Placeables.Walls;
using CalamityCN.Utils;
using System;

public class ItemGlobalTrans : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.IsCN && ModsCall.Calamity != null;
    }
    //重命名
    public override void SetDefaults(Item item)
    {
        //星流家具
        if (item.type == ModContent.ItemType<ExoChair>())
        {
            item.SetNameOverride("星流椅");
        }
        if (item.type == ModContent.ItemType<ExoBathtub>())
        {
            item.SetNameOverride("星流浴缸");
        }
        if (item.type == ModContent.ItemType<ExoBed>())
        {
            item.SetNameOverride("星流床");
        }
        if (item.type == ModContent.ItemType<ExoBookcase>())
        {
            item.SetNameOverride("星流书架");
        }
        if (item.type == ModContent.ItemType<ExoCandelabra>())
        {
            item.SetNameOverride("星流烛台");
        }
        if (item.type == ModContent.ItemType<ExoCandle>())
        {
            item.SetNameOverride("星流蜡烛");
        }
        if (item.type == ModContent.ItemType<ExoChandelier>())
        {
            item.SetNameOverride("星流吊灯");
        }
        if (item.type == ModContent.ItemType<ExoChest>())
        {
            item.SetNameOverride("星流箱");
        }
        if (item.type == ModContent.ItemType<ExoClock>())
        {
            item.SetNameOverride("星流钟");
        }
        if (item.type == ModContent.ItemType<ExoDoor>())
        {
            item.SetNameOverride("星流门");
        }
        if (item.type == ModContent.ItemType<ExoDresser>())
        {
            item.SetNameOverride("星流梳妆台");
        }
        if (item.type == ModContent.ItemType<ExoKeyboard>())
        {
            item.SetNameOverride("星流键盘");
        }
        if (item.type == ModContent.ItemType<ExoLamp>())
        {
            item.SetNameOverride("星流灯");
        }
        if (item.type == ModContent.ItemType<ExoLantern>())
        {
            item.SetNameOverride("星流灯笼");
        }
        if (item.type == ModContent.ItemType<ExoPlatform>())
        {
            item.SetNameOverride("星流平台");
        }
        if (item.type == ModContent.ItemType<ExoPrismPlatform>())
        {
            item.SetNameOverride("星流棱晶平台");
        }
        if (item.type == ModContent.ItemType<ExoSink>())
        {
            item.SetNameOverride("星流水槽");
        }
        if (item.type == ModContent.ItemType<ExoSofa>())
        {
            item.SetNameOverride("星流沙发");
        }
        if (item.type == ModContent.ItemType<ExoTable>())
        {
            item.SetNameOverride("星流桌");
        }
        if (item.type == ModContent.ItemType<ExoToilet>())
        {
            item.SetNameOverride("星流马桶");
        }
        if (item.type == ModContent.ItemType<ExoWorkbench>())
        {
            item.SetNameOverride("星流工作台");
        }
        //酸腐木家具
        if (item.type == ModContent.ItemType<AcidwoodBathtub>())
        {
            item.SetNameOverride("酸腐木浴缸");
        }
        if (item.type == ModContent.ItemType<AcidwoodBed>())
        {
            item.SetNameOverride("酸腐木床");
        }
        if (item.type == ModContent.ItemType<AcidwoodBench>())
        {
            item.SetNameOverride("酸腐木长凳");
        }
        if (item.type == ModContent.ItemType<AcidwoodBookcase>())
        {
            item.SetNameOverride("酸腐木书架");
        }
        if (item.type == ModContent.ItemType<AcidwoodCandelabra>())
        {
            item.SetNameOverride("酸腐木烛台");
        }
        if (item.type == ModContent.ItemType<AcidwoodCandle>())
        {
            item.SetNameOverride("酸腐木蜡烛");
        }
        if (item.type == ModContent.ItemType<AcidwoodChair>())
        {
            item.SetNameOverride("酸腐木椅子");
        }
        if (item.type == ModContent.ItemType<AcidwoodChandelier>())
        {
            item.SetNameOverride("酸腐木吊灯");
        }
        if (item.type == ModContent.ItemType<AcidwoodChest>())
        {
            item.SetNameOverride("酸腐木箱");
        }
        if (item.type == ModContent.ItemType<AcidwoodClock>())
        {
            item.SetNameOverride("酸腐木钟");
        }
        if (item.type == ModContent.ItemType<AcidwoodDoor>())
        {
            item.SetNameOverride("酸腐木门");
        }
        if (item.type == ModContent.ItemType<AcidwoodDresser>())
        {
            item.SetNameOverride("酸腐木梳妆台");
        }
        if (item.type == ModContent.ItemType<AcidwoodLamp>())
        {
            item.SetNameOverride("酸腐木灯");
        }
        if (item.type == ModContent.ItemType<AcidwoodLantern>())
        {
            item.SetNameOverride("酸腐木灯笼");
        }
        if (item.type == ModContent.ItemType<AcidwoodPiano>())
        {
            item.SetNameOverride("酸腐木钢琴");
        }
        if (item.type == ModContent.ItemType<AcidwoodPlatform>())
        {
            item.SetNameOverride("酸腐木平台");
        }
        if (item.type == ModContent.ItemType<AcidwoodSink>())
        {
            item.SetNameOverride("酸腐木水槽");
        }
        if (item.type == ModContent.ItemType<AcidwoodTable>())
        {
            item.SetNameOverride("酸腐木桌子");
        }
        if (item.type == ModContent.ItemType<AcidwoodWorkBench>())
        {
            item.SetNameOverride("酸腐木工作台");
        }
        //星石家具
        if (item.type == ModContent.ItemType<MonolithBathtub>())
        {
            item.SetNameOverride("星石浴缸");
        }
        if (item.type == ModContent.ItemType<MonolithBed>())
        {
            item.SetNameOverride("星石床");
        }
        if (item.type == ModContent.ItemType<MonolithBench>())
        {
            item.SetNameOverride("星石长凳");
        }
        if (item.type == ModContent.ItemType<MonolithBookcase>())
        {
            item.SetNameOverride("星石书架");
        }
        if (item.type == ModContent.ItemType<MonolithCandelabra>())
        {
            item.SetNameOverride("星石烛台");
        }
        if (item.type == ModContent.ItemType<MonolithCandle>())
        {
            item.SetNameOverride("星石蜡烛");
        }
        if (item.type == ModContent.ItemType<MonolithChair>())
        {
            item.SetNameOverride("星石椅");
        }
        if (item.type == ModContent.ItemType<MonolithChandelier>())
        {
            item.SetNameOverride("星石吊灯");
        }
        if (item.type == ModContent.ItemType<MonolithChest>())
        {
            item.SetNameOverride("星石箱");
        }
        if (item.type == ModContent.ItemType<MonolithClock>())
        {
            item.SetNameOverride("星石钟");
        }
        if (item.type == ModContent.ItemType<MonolithDoor>())
        {
            item.SetNameOverride("星石门");
        }
        if (item.type == ModContent.ItemType<MonolithDresser>())
        {
            item.SetNameOverride("星石梳妆台");
        }
        if (item.type == ModContent.ItemType<MonolithLamp>())
        {
            item.SetNameOverride("星石灯");
        }
        if (item.type == ModContent.ItemType<MonolithLantern>())
        {
            item.SetNameOverride("星石灯笼");
        }
        if (item.type == ModContent.ItemType<MonolithPiano>())
        {
            item.SetNameOverride("星石钢琴");
        }
        if (item.type == ModContent.ItemType<MonolithPlatform>())
        {
            item.SetNameOverride("星石平台");
        }
        if (item.type == ModContent.ItemType<MonolithSink>())
        {
            item.SetNameOverride("星石水槽");
        }
        if (item.type == ModContent.ItemType<MonolithTable>())
        {
            item.SetNameOverride("星石桌");
        }
        if (item.type == ModContent.ItemType<MonolithWorkBench>())
        {
            item.SetNameOverride("星石工作台");
        }
        //异域家具
        if (item.type == ModContent.ItemType<OtherworldlyBathtub>())
        {
            item.SetNameOverride("异域浴缸");
        }
        if (item.type == ModContent.ItemType<OtherworldlyBed>())
        {
            item.SetNameOverride("异域床");
        }
        if (item.type == ModContent.ItemType<OtherworldlyBookcase>())
        {
            item.SetNameOverride("异域书架");
        }
        if (item.type == ModContent.ItemType<OtherworldlyCandelabra>())
        {
            item.SetNameOverride("异域烛台");
        }
        if (item.type == ModContent.ItemType<OtherworldlyCandle>())
        {
            item.SetNameOverride("异域蜡烛");
        }
        if (item.type == ModContent.ItemType<OtherworldlyChair>())
        {
            item.SetNameOverride("异域椅");
        }
        if (item.type == ModContent.ItemType<OtherworldlyChandelier>())
        {
            item.SetNameOverride("异域吊灯");
        }
        if (item.type == ModContent.ItemType<OtherworldlyChest>())
        {
            item.SetNameOverride("异域箱");
        }
        if (item.type == ModContent.ItemType<OtherworldlyClock>())
        {
            item.SetNameOverride("异域钟");
        }
        if (item.type == ModContent.ItemType<OtherworldlyDoor>())
        {
            item.SetNameOverride("异域门");
        }
        if (item.type == ModContent.ItemType<OtherworldlyDresser>())
        {
            item.SetNameOverride("异域梳妆台");
        }
        if (item.type == ModContent.ItemType<OtherworldlyLamp>())
        {
            item.SetNameOverride("异域灯");
        }
        if (item.type == ModContent.ItemType<OtherworldlyLantern>())
        {
            item.SetNameOverride("异域灯笼");
        }
        if (item.type == ModContent.ItemType<OtherworldlyPiano>())
        {
            item.SetNameOverride("异域钢琴");
        }
        if (item.type == ModContent.ItemType<OtherworldlyPlatform>())
        {
            item.SetNameOverride("异域平台");
        }
        if (item.type == ModContent.ItemType<OtherworldlySink>())
        {
            item.SetNameOverride("异域水槽");
        }
        if (item.type == ModContent.ItemType<OtherworldlySofa>())
        {
            item.SetNameOverride("异域沙发");
        }
        if (item.type == ModContent.ItemType<OtherworldlyStone>())
        {
            item.SetNameOverride("异域石");
        }
        if (item.type == ModContent.ItemType<OtherworldlyTable>())
        {
            item.SetNameOverride("异域桌");
        }
        if (item.type == ModContent.ItemType<OtherworldlyWorkBench>())
        {
            item.SetNameOverride("异域工作台");
        }
        //其他家具
        if (item.type == ModContent.ItemType<VoidBathtub>())
        {
            item.SetNameOverride("虚空浴缸");
        }
        if (item.type == ModContent.ItemType<VoidObelisk>())
        {
            item.SetNameOverride("虚空钟");
        }
        if (item.type == ModContent.ItemType<VoidWorkbench>())
        {
            item.SetNameOverride("虚空工作台");
        }
        if (item.type == ModContent.ItemType<AshenBathtub>())
        {
            item.SetNameOverride("灰烬浴缸");
        }
        if (item.type == ModContent.ItemType<AshenPipeOrgan>())
        {
            item.SetNameOverride("灰烬钢琴");
        }
        if (item.type == ModContent.ItemType<AshenWorkBench>())
        {
            item.SetNameOverride("灰烬工作台");
        }
        if (item.type == ModContent.ItemType<AncientBathtub>())
        {
            item.SetNameOverride("远古浴缸");
        }
        if (item.type == ModContent.ItemType<AncientPipeOrgan>())
        {
            item.SetNameOverride("远古钢琴");
        }
        if (item.type == ModContent.ItemType<AncientWorkBench>())
        {
            item.SetNameOverride("远古工作台");
        }
        if (item.type == ModContent.ItemType<AbyssBathtub>())
        {
            item.SetNameOverride("深渊浴缸");
        }
        if (item.type == ModContent.ItemType<AbyssSynth>())
        {
            item.SetNameOverride("深渊钢琴");
        }
        if (item.type == ModContent.ItemType<AbyssWorkBench>())
        {
            item.SetNameOverride("深渊工作台");
        }
        if (item.type == ModContent.ItemType<StatigelBathtub>())
        {
            item.SetNameOverride("斯塔提斯浴缸");
        }
        if (item.type == ModContent.ItemType<StatigelWorkbench>())
        {
            item.SetNameOverride("斯塔提斯工作台");
        }
        if (item.type == ModContent.ItemType<ProfanedBathtub>())
        {
            item.SetNameOverride("渎神浴缸");
        }
        if (item.type == ModContent.ItemType<ProfanedWorkbench>())
        {
            item.SetNameOverride("渎神工作台");
        }
        if (item.type == ModContent.ItemType<CosmiliteBathtub>())
        {
            item.SetNameOverride("宇宙浴缸");
        }
        if (item.type == ModContent.ItemType<CosmiliteWorkBench>())
        {
            item.SetNameOverride("宇宙工作台");
        }
        if (item.type == ModContent.ItemType<StratusWorkbench>())
        {
            item.SetNameOverride("幻云工作台");
        }
        if (item.type == ModContent.ItemType<OtherworldlyStoneWall>())
        {
            item.SetNameOverride("异域石墙");
        }
        if (item.type == ModContent.ItemType<EutrophicShelf>())
        {
            item.SetNameOverride("富养制造架");
        }
        if (item.type == ModContent.ItemType<MonolithAmalgam>())
        {
            item.SetNameOverride("星幻柱综合体");
        }
        if (item.type == ModContent.ItemType<ProfanedCrucible>())
        {
            item.SetNameOverride("亵渎坩埚");
        }
        if (item.type == ModContent.ItemType<SilvaBasin>())
        {
            item.SetNameOverride("闪耀操纵机");
        }
    }
    //修改描述	
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
            foreach (TooltipLine line in tooltips)
            {
            //图鉴掉落提示
            ItemHelper.TranslateTooltip(item, tooltips, "BestiaryNotes", delegate (TooltipLine tooltip)
            {
                line.Text = line.Text.Replace("This is a Revengeance Mode drop rate", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.1", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops only on the first kill", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.2", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops on the first kill of the final Mechanical Boss", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.3", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops once you have defeated both Draedon and Calamitas", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.4", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops if Providence was summoned in the Hallow", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.5", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops if Providence was summoned in the Underworld", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.6", Array.Empty<object>()));
                line.Text = line.Text.Replace("or if Providence is only attacked during nighttime", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.7", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops if Providence is only attacked during nighttime", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.8", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops in Hardmode", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.9", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the first tier of Acid Rain", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.10", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the second tier of Acid Rain", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.11", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops if Providence was defeated only with the [i:", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.12", Array.Empty<object>()));
                line.Text = line.Text.Replace("] Profaned Soul Artifact", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.13", Array.Empty<object>()));
                line.Text = line.Text.Replace("This is an Expert Mode drop rate", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.14", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops if fed to a Trasher", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Other.15", Array.Empty<object>()));
                
                line.Text = line.Text.Replace("Drops after defeating King Slime", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.1", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Desert Scourge", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.2", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Eye of Cthulhu", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.3", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Crabulon", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.4", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Brain of Cthulhu", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.5", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Eater of Worlds", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.6", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Hive Mind", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.7", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Perforators", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.8", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Queen Bee", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.9", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Deerclops", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.10", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Skeletron", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.11", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Slime God", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.12", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Queen Slime", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.13", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Cryogen", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.14", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Aquatic Scourge", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.15", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Brimstone Elemental", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.16", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Destroyer", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.17", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Twins", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.18", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Skeletron Prime", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.19", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating a Mechanical Boss", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.20", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating all three Mechanical Bosses", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.21", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Calamitas Clone", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.22", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Plantera", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.23", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Calamitas or Plantera", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.24", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Leviathan and Anahita", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.25", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Astrum Aureus", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.26", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Golem", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.27", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Plaguebringer Goliath", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.28", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Empress of Light", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.29", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Duke Fishron", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.30", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Ravager", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.31", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Lunatic Cultist", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.32", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Astrum Deus", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.33", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Moon Lord", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.34", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Profaned Guardian", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.35", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Dragonfolly", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.36", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Providence", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.37", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Signus", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.38", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Storm Weaver", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.39", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Ceaseless Void", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.40", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Polterghast", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.41", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Old Duke", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.42", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Devourer of Gods", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.43", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Yharon", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.44", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Exo Mechs", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.45", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Calamitas", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.46", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Adult Eidolon Wyrm", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.47", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Giant Clam", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.48", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Giant Clam in Hardmode", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.49", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating the Great Sand Shark", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.50", Array.Empty<object>()));
                line.Text = line.Text.Replace("Drops after defeating Betsy", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.Boss.51", Array.Empty<object>()));

                //line.Text = line.Text.Replace("", LangHelper.GetTextValue("CalamityMod.BestiaryNotes.", Array.Empty<object>()));
            });

                if (item.type == ModContent.ItemType<Eternity>())
                {
                    line.Text = line.Text.Replace("There's pictures of ponies in the book", "书内有张小马图片");
                }

                if (item.type == ModContent.ItemType<CosmicWorm>())
                {
                    line.Text = line.Text.Replace("WARNING! Some sentinels have not been truly defeated yet and will spawn at full power during this fight!", "警告！某些神之仆从并没有被真正的打败，在这场战斗中他们会全力以赴！");
                    line.Text = line.Text.Replace("Not consumable", "不消耗");
                }

                if (item.type == ModContent.ItemType<HadalStew>())
                {
                    line.Text = line.Text.Replace("Only gives 37 seconds of Potion Sickness", "只造成37秒的药水疾病减益");
                }

                if (item.type == ModContent.ItemType<SpectralVeil>())
                {
                    string hotkeySpecVeil = CalamityKeybinds.SpectralVeilHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeySpecVeil + " to consume 25% of your maximum stealth to perform a mid-range teleport and render you momentarily invulnerable", "按下 " + hotkeySpecVeil + " 消耗25%最大潜行值，向鼠标方向进行中距离传送");
                }

                if (item.type == ModContent.ItemType<SandCloak>())
                {
                    string hotkeySand = CalamityKeybinds.SandCloakHotkey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeySand + " to consume 10% of your maximum stealth to create a protective dust veil which provides +6 defense and +2 life regen", "按下 " + hotkeySand + " 消耗10%最大潜行值，召唤一个围绕你的破坏性沙漠龙卷持续15秒，并提供6点防御和+2生命恢复");
                }

                if (item.type == ModContent.ItemType<TheCommunity>())
                {
                    line.Text = line.Text.Replace("Max health increased by", "最大生命增加");
                    line.Text = line.Text.Replace("Melee speed increased by", "近战攻速增加");
                    line.Text = line.Text.Replace("Life regeneration increased by", "生命再生速度增加");
                    line.Text = line.Text.Replace("Critical strike chance increased by", "暴击率增加");
                    line.Text = line.Text.Replace("Damage increased by", "伤害增加");
                    line.Text = line.Text.Replace("Damage reduction increased by", "伤害减免增加");
                    line.Text = line.Text.Replace("Defense increased by", "防御增加");
                    line.Text = line.Text.Replace("Minion knockback increased by", "召唤物击退增加");
                    line.Text = line.Text.Replace("Movement speed increased by", "移速增加");
                    line.Text = line.Text.Replace("Flight time increased by", "飞行时间增加");
                }

                if (item.type == ModContent.ItemType<ProfanedSoulCrystal>())
                {
                    line.Text = line.Text.Replace("Requires 10 minion slots to use in order to grant the following effects", "需要10个召唤栏以启用以下所有效果：");
                    line.Text = line.Text.Replace("All non-summon weapons are converted into powerful summon variations", "所有非召唤攻击都被转换为强力的召唤变种");
                    line.Text = line.Text.Replace("Falling below 50% life will empower these attacks", "掉到50%血量以下会强化这些攻击");
                    line.Text = line.Text.Replace("Transforms Melee attacks into a barrage of spears", "将近战攻击转换为一波投矛");
                    line.Text = line.Text.Replace("Transforms Magic attacks into a powerful splitting fireball for", "将魔法攻击转换为强力分裂火球，每次消耗");
                    line.Text = line.Text.Replace("mana per cast", "点魔力值");
                    line.Text = line.Text.Replace("Transforms Ranged attacks into a flurry of fireballs and meteors", "将远程攻击转换为一阵火球与陨石");
                    line.Text = line.Text.Replace("Transforms Rogue attacks into a deadly crystalline spiral", "将盗贼攻击转换为死亡水晶螺旋");
                    line.Text = line.Text.Replace("Summons and empowers the profaned babs to fight alongside you", "召唤并强化三个亵渎守卫为你而战");
                    line.Text = line.Text.Replace("You are no longer affected by burn out when hit", "受伤时不再受到灼伤减益");
                    line.Text = line.Text.Replace("Provides buffs depending on the time of day", "基于所处的时间给予增益");
                    line.Text = line.Text.Replace("Thinking back, it was a boring life", "我的人生平淡无奇，索然无味");
                    line.Text = line.Text.Replace("And so we burn it all in the name of purity", "现在我们以纯化之名将其燃烧殆尽");
                    line.Text = line.Text.Replace("The soul within this crystal has been defiled by the powerful magic of a supreme witch", "这块水晶中的魂魄被至尊女巫的强大魔力污染了");
                    line.Text = line.Text.Replace("The soul within this crystal has been defiled by overwhelming energy waves from dangerous mechanations", "这块水晶中的魂魄被危险的机械造物发出的能量波干扰了");
                    line.Text = line.Text.Replace("Merchants will reject a defiled soul such as this.", "商人会拒绝收购这样一个被玷污的魂魄");

                }

                if (item.type == ModContent.ItemType<PlaguedFuelPack>())
                {
                    string plagueHotkey = CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + plagueHotkey + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of plagued clouds", "按下 " + plagueHotkey + " 键消耗25%最大潜行值并快速斜向上喷射\n并在沿途留下大量瘟疫毒云");
                }

                if (item.type == ModContent.ItemType<CelestialJewel>())
                {
                    string hotkeyCelestial = CalamityKeybinds.AstralTeleportHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyCelestial + " to teleport to a random location while no bosses are alive", "没有Boss存活时按下 " + hotkeyCelestial + " 键进行随机传送");
                }

                if (item.type == ModContent.ItemType<BlunderBooster>())
                {
                    string hotkeyBlunder = CalamityKeybinds.PlaguePackHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyBlunder + " to consume 25% of your maximum stealth to perform a swift upwards/diagonal dash which leaves a trail of lightning bolts", "按下 " + hotkeyBlunder + " 键消耗你盗贼潜行值的25%来向左上/右上方冲刺并留下追踪闪电");
                }

                if (item.type == ModContent.ItemType<AstralArcanum>())
                {
                    string hotkeyArcanum = CalamityKeybinds.AstralArcanumUIHotkey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyArcanum + " to toggle teleportation UI while no bosses are alive", "没有Boss存活时按下 " + hotkeyArcanum + " 键可以打开传送UI");
                }

                if (item.type == ModContent.ItemType<AsgardianAegis>())
                {
                    string hotkeyAsgard = CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyAsgard + " to activate buffs to all damage, crit chance, and defense", "按下 " + hotkeyAsgard + " 键获得增加伤害、暴击率和防御的增益");
                }

                if (item.type == ModContent.ItemType<ElysianAegis>())
                {
                    string hotkeyElysian = CalamityKeybinds.AegisHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyElysian + " to activate buffs to all damage, crit chance and defense", "按下 " + hotkeyElysian + " 键获得增加伤害、暴击率和防御的增益");
                }

                if (item.type == ModContent.ItemType<NormalityRelocator>())
                {
                    string hotkeyReloc = CalamityKeybinds.NormalityRelocatorHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyReloc + " to teleport to the position of the mouse", "按下 " + hotkeyReloc + " 传送至鼠标位置");
                }

                if (item.type == ModContent.ItemType<AngelicAlliance>())
                {
                    string hotkeyAngelic = CalamityKeybinds.AngelicAllianceHotKey.TooltipHotkeyString();
                    line.Text = line.Text.Replace("Press " + hotkeyAngelic + " to grace yourself in divinity for 15 seconds", "按下 " + hotkeyAngelic + " 键获得15秒神之祝福");
                }
                if (item.type == ModContent.ItemType<StatMeter>())
                {
                    line.Text = line.Text.Replace("Displays almost all player stats", "显示你绝大部分属性的具体数据");
                    line.Text = line.Text.Replace("Offensive stats displayed vary with held item", "攻击数据可能会随着手持的物品而变化");
                    line.Text = line.Text.Replace("Adrenaline Damage Boost:", "肾上腺素伤害加成：");
                    line.Text = line.Text.Replace("Adrenaline DR Boost:", "肾上腺素伤害减免加成：");
                    line.Text = line.Text.Replace("Rage Damage Boost:", "愤怒模式伤害加成：");
                    line.Text = line.Text.Replace("True Melee ", "真近战");
                    line.Text = line.Text.Replace("True Danos por ataque físico:", "真实伤害:");
                    line.Text = line.Text.Replace("Ammo Consumption Chance:", "弹药消耗率：");
                    line.Text = line.Text.Replace("Mana Usage:", "魔力值消耗：");
                    line.Text = line.Text.Replace("Mana Regen:", "魔力值恢复速度：");
                    line.Text = line.Text.Replace("Minion Slots:", "召唤栏位数量：");
                    line.Text = line.Text.Replace("Rogue Velocity Boost:", "盗贼弹幕飞行速度提升：");
                    line.Text = line.Text.Replace("Rogue Weapon Consumption Chance:", "盗贼消耗性武器消耗率：");
                    line.Text = line.Text.Replace("Melee ", "近战");
                    line.Text = line.Text.Replace("Magic ", "魔法");
                    line.Text = line.Text.Replace("Ranged ", "远程");
                    line.Text = line.Text.Replace("Minion ", "召唤");
                    line.Text = line.Text.Replace("Rogue ", "盗贼");
                    line.Text = line.Text.Replace("Averaged ", "无职业");
                    line.Text = line.Text.Replace("Unsupported ", "未支持职业");
                    line.Text = line.Text.Replace("Averaged ", "无职业");
                    line.Text = line.Text.Replace("Whip ", "鞭子");
                    line.Text = line.Text.Replace("Damage", "伤害加成");
                    line.Text = line.Text.Replace("Crit Chance", "暴击率");
                    line.Text = line.Text.Replace("Attack Speed", "攻速");
                    line.Text = line.Text.Replace("Max Stealth:", "最大潜行值：");
                    line.Text = line.Text.Replace("Standing Regen:", "站定恢复速度：");
                    line.Text = line.Text.Replace("Moving Regen:", "移动时恢复速度：");
                    line.Text = line.Text.Replace("Defense:", "防御力：");
                    line.Text = line.Text.Replace("DR:", "伤害减免：");
                    line.Text = line.Text.Replace("Life Regen:", "生命再生速度：");
                    line.Text = line.Text.Replace("Armor Penetration:", "护甲穿透：");
                    line.Text = line.Text.Replace("Wing Flight Time:", "飞行时间：");
                    line.Text = line.Text.Replace("seconds", "秒");
                    line.Text = line.Text.Replace("sec", "秒");
                    line.Text = line.Text.Replace("from melee", "来自近战");
                    line.Text = line.Text.Replace("Jump Boost:", "跳跃提升：");
                    line.Text = line.Text.Replace("Move Speed:", "移速：");
                    line.Text = line.Text.Replace("Luck:", "幸运值：");
                    line.Text = line.Text.Replace("Abyss/Cave Light Strength:", "深渊/洞穴光照强度：");
                    line.Text = line.Text.Replace("Abyss Light Strength:", "深渊光照强度：");
                    line.Text = line.Text.Replace("Other Abyss stats are only displayed while in the Abyss", "其他深渊状态数据只有身处深渊才会显示");
                    line.Text = line.Text.Replace("Other Abyss Stats:", "其他深渊属性：");
                    line.Text = line.Text.Replace("Breath Lost Per Tick:", "呼吸条消耗速率：");
                    line.Text = line.Text.Replace("Breath Loss Rate:", "呼吸困难程度：");
                    line.Text = line.Text.Replace("Life Lost Per Tick at Zero Breath:", "呼吸条耗尽后生命流失速度：");
                    line.Text = line.Text.Replace("Defense Lost From Pressure:", "防御削减：");
                }
                if (item.type == ModContent.ItemType<ExoThrone>())
                {
                    line.Text = line.Text.Replace("Hold ", "坐在飞椅上时按住 ");
                    line.Text = line.Text.Replace("while sitting in the throne to move slower for more precision", "键将会精确减速");
                }
                if (item.type == ModContent.ItemType<ShatteredCommunity>())
                {
                    line.Text = line.Text.Replace("Current level:", "当前等级：");
                    line.Text = line.Text.Replace("Rage Mode damage", "暴怒模式伤害");
                    line.Text = line.Text.Replace("Progress to next level:", "距离下一等级：");
                    line.Text = line.Text.Replace("Total ", "总");
                }
                if (item.type == ModContent.ItemType<BrokenBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：");
                    line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：");
                    line.Text = line.Text.Replace("Pure Clarity", "澄澈之纯净");
                    line.Text = line.Text.Replace("Biting Embrace", "拥怀之凛冽");
                    line.Text = line.Text.Replace("Arid Grandeur", "伟岸之枯涸");
                    line.Text = line.Text.Replace("Decay's Retort", "反抗之衰朽");
                    line.Text = line.Text.Replace("Grovetender's Touch", "林妖之轻抚");
                    line.Text = line.Text.Replace("None", "无调谐");
                    line.Text = line.Text.Replace("Does nothing..yet", "似乎没什么用");
                    line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出薄弱的弹幕，它将击碎敌怪的防御");
                    line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "以冰川凝结为剑身，施行三连剑技，其最终一剑将冻结敌怪");
                    line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "于面前召唤多把炙热的剑刃，且击中敌怪次数越多，它们将愈加庞大而锋利。你在半空时，剑刃也能用于在物块之间弹跳");
                    line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "依靠幽魅的剑影向前冲锋，汲取击中敌怪的生命，并从其身上弹开");
                    line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "将剑刃绑在藤蔓一端，挥舞藤鞭。刃尖击中敌怪必定暴击，而击中物块时将把你拉去");
                }
                if (item.type == ModContent.ItemType<TrueBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Main Attunement :", "主环境调谐：");
                    line.Text = line.Text.Replace("Secondary Attunement :", "副环境调谐：");
                    line.Text = line.Text.Replace("Pure Clarity", "澄澈之纯净");
                    line.Text = line.Text.Replace("Biting Embrace", "拥怀之凛冽");
                    line.Text = line.Text.Replace("Arid Grandeur", "伟岸之枯涸");
                    line.Text = line.Text.Replace("Decay's Retort", "反抗之衰朽");
                    line.Text = line.Text.Replace("Grovetender's Touch", "林妖之轻抚");
                    line.Text = line.Text.Replace("Heaven's Might", "天国之神威");
                    line.Text = line.Text.Replace("Extant Abhorrence", "嫌恶之永存");
                    line.Text = line.Text.Replace("Gesture for the Drowned", "溺死之亡姿");
                    line.Text = line.Text.Replace("None", "无调谐");
                    line.Text = line.Text.Replace("Does nothing..yet", "暂无所长，静待调谐。");
                    line.Text = line.Text.Replace("Repairing the blade seems to have improved its attuning capacities", "似乎你对它的修复增强了它的调谐能力");
                    line.Text = line.Text.Replace("Fires a weak projectile that crushes enemy defenses", "射出薄弱的弹幕，它将击碎敌怪的防御");
                    line.Text = line.Text.Replace("Landing true melee hits places a sigil of purity over the enemy. Your projectiles home onto the marked foes", "剑刃本身将以纯净之符标记命中的敌怪，被标记者会被剑气追踪");
                    line.Text = line.Text.Replace("Perform a 3 strike combo with a glacial blade. The final strike freezes foes for a split second", "以冰川凝结为剑身，施行三连剑技，其最终一剑将冻结敌怪");
                    line.Text = line.Text.Replace("Lingering glacial mist is released on each swing, dealing damage to enemies wandering into it", "挥舞时，极寒之雾将从剑身涌出，在空中弥漫，并挫伤其中的生灵");
                    line.Text = line.Text.Replace("Conjures searing blades in front of you that get larger and stronger the more you hit enemies. The blades can also be used to bounce off tiles when in the air", "于面前召唤多把炙热的剑刃，且击中敌怪次数越多，它们将愈加庞大而锋利。你在半空时，剑刃也能用于在物块之间弹跳");
                    line.Text = line.Text.Replace("Releasing the attack button after the blades are fully charged sends them hurtling forwards to shred your foes", "剑刃蓄力达到巅峰时，停止攻击，它们将向前飞驰，撕碎敌怪");
                    line.Text = line.Text.Replace("Lunge forward using a ghostly rapier projection that leeches life off any struck foes. You also get bounced away from hit targets", "依靠幽魅的剑影向前冲锋，汲取击中敌怪的生命，并从其身上弹开");
                    line.Text = line.Text.Replace("Landing three strikes without touching the ground changes your next attack into an empowered dash thrust", "命中三次攻击而不落地，下一剑将变为强化的突刺冲锋");
                    line.Text = line.Text.Replace("Throw out the blade using a vine whip. Striking enemies with the tip of the whip as it cracks guarantees a critical hit. The whip will also propel you towards struck tiles", "将剑刃绑在藤蔓一端，挥舞藤鞭。刃尖击中敌怪必定暴击，而击中物块时将把你拉去");
                    line.Text = line.Text.Replace("Spreading vines sprout from critical strikes. These vines can hit up to three targets", "暴击使藤蔓蔓延，它最多可以击中三个目标");
                    line.Text = line.Text.Replace("Hold the attack button to charge a star-piercing lunge, release to unleash the devastating blow", "按住攻击，为贯穿星辰的冲锋蓄力，松开以释放这一毁灭性打击");
                    line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive impact which raises otherworldly monoliths", "撞击地面将引起地动山摇，异界巨石破土而出");
                    line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time", "使用回旋斩，随按住时间增加旋转速度");
                    line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. The sword then quickly returns to your hand", "使用回旋斩时松开攻击将剑掷出，它会在这之后快速回到你手中");
                    line.Text = line.Text.Replace("Shoot out two water balls at your sides. On ground contact the water balls will turn into small waves that ride along the ground", "向两侧投放水球，它们落地后会激发小型海浪沿地面滑行");
                    line.Text = line.Text.Replace("Waves fired while underwater or that touch water will become much larger and faster", "若水球接触到水，它激起的浪花将变得巨大且飞快");
                }
                if (item.type == ModContent.ItemType<OmegaBiomeBlade>())
                {
                    line.Text = line.Text.Replace("Active Attunement :", "核心调谐：");
                    line.Text = line.Text.Replace("Passive Attunement :", "辅助调谐：");
                    line.Text = line.Text.Replace("Swordsmith's Pride", "兵匠之傲");
                    line.Text = line.Text.Replace("Sanguine Fury", "血腾之愤");
                    line.Text = line.Text.Replace("Lamentations of the Chained", "缚囚之悼");
                    line.Text = line.Text.Replace("Mercurial Tides", "变幻之潮");
                    line.Text = line.Text.Replace("None", "无调谐");
                    line.Text = line.Text.Replace("Does nothing..yet", "暂无所长，静待调谐。");
                    line.Text = line.Text.Replace("It seems that upgrading the blade expanded the scope of the previous attunements", "你对它的强化将它的调谐能力发挥到了极致");
                    line.Text = line.Text.Replace("Your secondary attunement can now provide passive bonuses", "存有的第二个环境调谐现在可以提供辅助增益");
                    line.Text = line.Text.Replace("Hold the attack button to swing the sword around you, accelerating over time. Sword beams are fired wildly while swinging", "按住攻击舞动剑刃，使用大回旋斩，同时剑气将狂野四散");
                    line.Text = line.Text.Replace("Releasing the attack button hurls the sword towards your cursor. Sword beams home onto enemies struck by the thrown sword", "中途停止攻击将剑朝鼠标猛然掷出，以纯净之符标记击中的敌怪。剑气将追踪被标记的敌怪");
                    line.Text = line.Text.Replace("All attacks have a chance to fire sword beams", "所有攻击有几率射出剑气");
                    line.Text = line.Text.Replace("Conjures molten blades in front of you that get larger and stronger the more you hit enemies.", "于面前召唤熔岩剑刃，击中敌怪次数越多，它们将愈加庞大而锋利");
                    line.Text = line.Text.Replace(" The blades can also be used to bounce off tiles when in the air", "你在半空时，剑刃也能用于在物块之间弹跳");
                    line.Text = line.Text.Replace("Releasing the attack button sends the charged blades hurtling forwards like a wheel.", "在剑刃达到巅峰时停止攻击，它们将如扇叶一般旋转飞出");
                    line.Text = line.Text.Replace(" Attacking again immediately thereafter dashes to the wheel, shredding anything in the way", "此时立即进行下一次攻击，你将冲向剑刃，并撕裂途径的一切");
                    line.Text = line.Text.Replace("Striking enemies rarely steals a small amount of life", "击中敌人偶尔会为你回复生命");
                    line.Text = line.Text.Replace("Hold the attack button to charge a heaven-shattering lunge, release to unleash the devastating blow.", "按住攻击，为碎裂天界的冲锋蓄力，松开以释放这一毁灭性打击");
                    line.Text = line.Text.Replace(" Shock waves are emitted as the sword charges up", "蓄力时，不断产生冲击波");
                    line.Text = line.Text.Replace("Striking the earth with the lunge will cause a massive shock wave on impact which raises a flood of monoliths", "撞击地面将引发山崩地裂，天地轰鸣，刹那间，一排异界巨石破土而出");
                    line.Text = line.Text.Replace("Periodically emit shock waves while attacking", "攻击时，周期性在身边释放冲击波");
                    line.Text = line.Text.Replace("Lash out with a flurry of chained blades. Striking enemies with the tip of the blades guarantees a critical hit", "快速挥舞大量链刃，以刃尖攻击时必定暴击");
                    line.Text = line.Text.Replace("Critical strikes send out extra phantom chains which latch onto multiple targets", "暴击将生成锁缚多个目标的幻影锁链");
                    line.Text = line.Text.Replace("An enchanted chain hook floats near you. Striking enemies makes the hook whirl around you, freezing enemies", "附魔链钩在你身旁漂浮。攻击敌人会触发钩子回旋，冻结近身的敌怪");
                }
                if (item.type == ModContent.ItemType<FourSeasonsGalaxia>())
                {
                    line.Text = line.Text.Replace("Active Attunement :", "星系调谐：");
                    line.Text = line.Text.Replace("Passive Blessing :", "星系馈赠：");
                    line.Text = line.Text.Replace("Phoenix's Pride", "凤凰之耀");
                    line.Text = line.Text.Replace("Aries' Wrath", "白羊之怒");
                    line.Text = line.Text.Replace("Polaris' Gaze", "北斗之眸");
                    line.Text = line.Text.Replace("Andromeda's Stride", "仙女之跃");
                    line.Text = line.Text.Replace("Capricorn's Blessing", "摩羯之祈");
                    line.Text = line.Text.Replace("Cancer's Blessing", "巨蟹之礼");
                    line.Text = line.Text.Replace("Hold left click to swing Galaxia around you, accelerating over time", "回旋挥舞银河，随时间加速");
                    line.Text = line.Text.Replace("The swirling nebula constantly emits homing cosmic bolts", "旋转的星云将持续释放银河之雷");
                    line.Text = line.Text.Replace("Release left click to hurl Galaxia toward the cursor alongside 6 gigantic cosmic bolts", "释放回旋斩时停止攻击，把剑伴随六个巨型银河之雷向前掷出");
                    line.Text = line.Text.Replace("Throw Galaxia to your cursor, holding it in place with constellations", "将银河掷向鼠标，以群星将其拉住");
                    line.Text = line.Text.Replace("Galaxia follows your cursor, rapidly spinning to shred enemies", "银河将跟随鼠标移动，快速旋转，粉碎敌怪");
                    line.Text = line.Text.Replace("Striking enemies causes nebulous explosions which spawn homing cosmic bolts", "击中敌人引发星云爆破，释放银河之雷");
                    line.Text = line.Text.Replace("Hold left click to channel Galaxia's power into a tight vortex of galactic energies", "引导北极星之力，化为星环簇拥的星系能量漩涡");
                    line.Text = line.Text.Replace("The vortex powers up over time and when hitting enemies", "随着时间流逝或击中敌怪，漩涡将逐渐成长");
                    line.Text = line.Text.Replace("Release left click to fire off the charged star in straight line", "停止攻击将释放北极星向前飞跃");
                    line.Text = line.Text.Replace(" Press left click again immediately to dash towards the star and release cosmic bolts", "此时立即再次攻击，你将追随北极星的步伐高速冲刺，并化身超新星爆发，四散银河之雷");
                    line.Text = line.Text.Replace("Hold left click to charge a god-erasing lunge, release to unleash the devastating blow", "按住攻击，为抹杀神明的冲锋蓄力，松开以释放这一毁灭性打击");
                    line.Text = line.Text.Replace("Galaxia emits cosmic bolts while charging", "银河在蓄力时会释放银河之雷");
                    line.Text = line.Text.Replace("Lunging into the ground will cause a shockwave which summons a storm of cosmic energies", "撞击地面使得寰宇崩塌，时空撕裂，末世风暴般的宇宙能量轰鸣而至");
                    line.Text = line.Text.Replace("Periodically releases a ring of weakening stars around your cursor when attacking", "攻击时，在光标处召唤能削弱敌怪的星环");
                    line.Text = line.Text.Replace("The ring is repelled away from you at first, before slowing down over time", "星环会离你而去，逐渐变慢");
                    line.Text = line.Text.Replace("Periodically releases a ring of lifestealing stars around yourself when attacking", "攻击时，在身旁召唤吸取敌怪生命的星环");
                    line.Text = line.Text.Replace("The ring is attracted towards you at first, before slowing down over time", "星环会朝你飞去，逐渐变慢");
                }
                if (item.type == ModContent.ItemType<FracturedArk>())
                {
                    line.Text = line.Text.Replace("Using RMB will extend the Ark out in front of you", "右键向前延展方舟");
                    line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you a small window of invulnerability", "剑刃击中敌人时会进行招架，并使你短暂无敌");
                    line.Text = line.Text.Replace("You can also parry projectiles and temporarily make them deal 100 less damage", "你也可以用剑刃格挡弹幕，并短暂使其伤害造成的伤害减少100点");
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, boosting their damage and letting them throw projectiles out", "格挡后会获得10层充能，充能会强化普通攻击和伤害，并让剑刃能够发射弹幕");
                }
                if (item.type == ModContent.ItemType<TrueArkoftheAncients>())
                {
                    line.Text = line.Text.Replace("Using right click will extend the Ark out in front of you.Hitting an enemy with it will parry them, granting you brief invulnerability", "右键向前延展方舟。剑刃击中敌人时会进行招架，并使你短暂无敌");
                    line.Text = line.Text.Replace("You can also parry projectiles to make them deal 160 less damage for a short period", "你也可以用剑刃格挡弹幕，并短暂使其伤害造成的伤害减少160点");
                    line.Text = line.Text.Replace("Parrying empowers the next 10 swings of the sword, letting them throw stronger projectiles", "格挡后会获得10层充能，充能会强化普通攻击，并且剑刃会发射更加强大的弹幕");
                    line.Text = line.Text.Replace("Using right click and pressing UP will release all empowered charges in a powerful burst of energy", "按住上并点击右键会释放储存的所有充能并产生强大的能量爆发");
                }
                if (item.type == ModContent.ItemType<ArkoftheElements>())
                {
                    line.Text = line.Text.Replace("Using left click performs a 5-swing combo that ends by throwing the blade", "左键进行一次五连斩，斩击以掷出剑刃结束");
                    line.Text = line.Text.Replace("Releasing left click while the blade is out will deal extra damage and give 2 charges", "在剑刃掷出时松开左键会造成额外伤害并获得2层充能");
                    line.Text = line.Text.Replace("Using right click will snip out the scissor blades in front of you", "右键用剑刃向前方剪出");
                    line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you brief invulnerability", "剑刃击中敌人时会进行招架，并使你短暂无敌");
                    line.Text = line.Text.Replace("You can also parry projectiles to make them deal 200 less damage for a short period", "你也可以用剑刃格挡弹幕，并短暂使其伤害造成的伤害减少200点");
                    line.Text = line.Text.Replace("Parrying will empower the next 10 swings of the sword, letting you use both blades at once", "格挡后会获得10层充能，充能会强化普通攻击，让你可以同时使用两把剑刃");
                    line.Text = line.Text.Replace("Using right click while pressing UP with empowered charges will provoke a Big Rip in spacetime and use all charges", "当处于强化状态时，按住上并点击右键会引起时空之中的大撕裂，并一次性释放所有充能");
                    line.Text = line.Text.Replace("If more than 5 charges were used, you can dash across the rip by holding UP", "若释放的充能超过5层，保持按住上键将允许你冲过撕裂");
            }
                if (item.type == ModContent.ItemType<ArkoftheCosmos>())
                {
                    line.Text = line.Text.Replace("Using left click performs a 5-swing combo that ends by throwing the blade", "左键进行一次五连斩，斩击以掷出剑刃结束");
                    line.Text = line.Text.Replace("The thrown blade will follow your cursor", "掷出的剑刃会跟随你的光标");
                    line.Text = line.Text.Replace("Releasing left click while the blade is out will cause an exploding snap", "在剑刃掷出时松开左键会释放爆炸剪击");
                    line.Text = line.Text.Replace("Using right click will snip out the scissor blades in front of you", "右键用剑刃向前方剪出");
                    line.Text = line.Text.Replace("Hitting an enemy with it will parry them, granting you brief invulnerability", "剑刃击中敌人时会进行招架，并使你短暂无敌");
                    line.Text = line.Text.Replace("You can parry projectiles to make them deal 200 less damage for a short period", "你也可以用剑刃格挡弹幕，并短暂使其伤害造成的伤害减少200点");
                    line.Text = line.Text.Replace("Parrying anything will empower the next 10 swings of the sword", "格挡后会获得10层充能，充能会强化普通攻击");
                    line.Text = line.Text.Replace("Using right click while pressing UP with empowered charges will provoke a Big Rip in spacetime and use all charges", "当处于强化状态时，按住上并点击右键会引起时空之中的大撕裂，并一次性释放所有充能");
                    line.Text = line.Text.Replace("If more than 5 charges were used, you can dash across the rip by holding UP", "若释放的充能超过5层，保持按住上键将允许你冲过撕裂");
                }

                if (item.CountsAsClass(DamageClass.Melee))
                {
                    line.Text = line.Text.Replace("true melee damage", "真近战伤害");
                }

                if (item.DamageType.Name == "RogueDamageClass")
                {
                    line.Text = line.Text.Replace("rogue damage", "盗贼伤害");
                    line.Text = line.Text.Replace("stealth strike damage", "潜伏攻击伤害");
                }

                if (item.DamageType.Name == "AverageDamageClass")
                {
                    line.Text = line.Text.Replace("average damage", "无职业伤害");
                }

                if (item.type >= ItemID.Celeb2 && (item.Calamity()?.UsesCharge ?? false))
                {
                    line.Text = line.Text.Replace("Current Charge:", "当前充能：");

                }

                if ((item.Calamity()?.UsesCharge ?? false) || item.type == ModContent.ItemType<AuricQuantumCoolingCell>() || item.type == ModContent.ItemType<PlasmaGrenade>() || item.type == ModContent.ItemType<VoltageRegulationSystem>() || item.type == ModContent.ItemType<AdvancedDisplay>() || item.type == ModContent.ItemType<LongRangedSensorArray>() || item.type == ModContent.ItemType<DecryptionComputer>())
                {
                    line.Text = line.Text.Replace("You don't have sufficient knowledge to create this yet", "你没有足够的知识去制作这个");
                    line.Text = line.Text.Replace("The Sunken Sea schematic must be deciphered first", "需要先获取沉沦之海原型图");
                    line.Text = line.Text.Replace("The Planetoid schematic must be deciphered first", "需要先破译小行星原型图");
                    line.Text = line.Text.Replace("The Jungle schematic must be deciphered first", "需要先破译丛林原型图");
                    line.Text = line.Text.Replace("The Underworld schematic must be deciphered first", "需要先破译地狱原型图");
                    line.Text = line.Text.Replace("The Ice biome schematic must be deciphered first", "需要先破译雪原原型图");

                }

                if (item.Calamity().canFirePointBlankShots)
                {
                    line.Text = line.Text.Replace("Does extra damage to enemies shot at point-blank range", "对近距离敌怪射击时造成额外伤害");
                }

                if (item.Calamity().devItem)
                {
                    line.Text = line.Text.Replace("Developer Item", "开发者物品");
                }

                if (item.Calamity().donorItem)
                {
                    line.Text = line.Text.Replace("Donor Item", "捐赠者物品");
                }

                if (item.accessory && !item.social && item.prefix > 0)
                {
                    line.Text = line.Text.Replace("damage reduction", "伤害减免");
                    line.Text = line.Text.Replace("stealth generation", "潜行值恢复速度");

                }

                if (item.type == ModContent.ItemType<RuneofKos>())
                {
                    line.Text = line.Text.Replace("Summons the Storm Weaver", "召唤风暴编织者");
                    line.Text = line.Text.Replace("Summons Signus, Envoy of the Devourer", "召唤神之使徒西格纳斯");
                    line.Text = line.Text.Replace("Summons the Ceaseless Void", "召唤无尽虚空");
                    line.Text = line.Text.Replace("Enrages on the surface", "在地表上狂暴");
                }

                if (item.type == ModContent.ItemType<CalamityMod.Items.Accessories.Wings.HadarianWings>())
                {
                    line.Text = line.Text.Replace("Hold ", "按住");
                    line.Text = line.Text.Replace(" and ", "和");
                    line.Text = line.Text.Replace(" to hover", "可以悬浮");
                    line.Text = line.Text.Replace("Press ", "按下");
                    line.Text = line.Text.Replace(" to toggle hover\nPress ", "可切换悬停\n按下");
                    line.Text = line.Text.Replace(" to deactivate hover", "可停用悬停");
                }

                if (item.type == ModContent.ItemType<EncryptedSchematicSunkenSea>() || item.type == ModContent.ItemType<EncryptedSchematicPlanetoid>() || item.type == ModContent.ItemType<EncryptedSchematicJungle>() || item.type == ModContent.ItemType<EncryptedSchematicIce>() || item.type == ModContent.ItemType<EncryptedSchematicHell>())
                {
                    line.Text = line.Text.Replace("Has already been decrypted.", "已经破解该原型图");
                    line.Text = line.Text.Replace("Click to view its contents.", "点击查看内容");
                    line.Text = line.Text.Replace("Unlocked recipes:", "解锁配方：");
                    line.Text = line.Text.Replace("Gauss Dagger", "高斯短匕");
                    line.Text = line.Text.Replace("Taser", "泰瑟枪");
                    line.Text = line.Text.Replace("Pulse Pistol", "脉冲手枪");
                    line.Text = line.Text.Replace("Star Swallower Containment Unit", "噬星者控制元件");
                    line.Text = line.Text.Replace("Tracking Disk", "逐影飞盘");
                    line.Text = line.Text.Replace("Decryption Computer", "解密计算机");
                    line.Text = line.Text.Replace("Hydraulic Volt Crasher", "液压伏冲器");
                    line.Text = line.Text.Replace("Matter Modulator", "物质调谐器");
                    line.Text = line.Text.Replace("Gauss Pistol", "高斯手枪");
                    line.Text = line.Text.Replace("Mounted Scanner", "架式扫射机");
                    line.Text = line.Text.Replace("Frequency Manipulator", "变频器");
                    line.Text = line.Text.Replace("Long Ranged Sensor Array", "远程传感器阵列");
                    line.Text = line.Text.Replace("Galvanizing Glaive", "磁能分割刀");
                    line.Text = line.Text.Replace("Gauss Rifle", "高斯来复枪");
                    line.Text = line.Text.Replace("Gatling Laser", "激光加特林");
                    line.Text = line.Text.Replace("Pulse Turret Remote", "脉冲炮塔遥控装置");
                    line.Text = line.Text.Replace("System Bane", "神经系统紊乱装置");
                    line.Text = line.Text.Replace("Advanced Display", "高级显示屏");
                    line.Text = line.Text.Replace("Phaseslayer", "相位剑");
                    line.Text = line.Text.Replace("Pulse Rifle", "脉冲步枪");
                    line.Text = line.Text.Replace("The Anomaly's Nanogun", "异象纳米枪");
                    line.Text = line.Text.Replace("Tesla Cannon", "特斯拉巨炮");
                    line.Text = line.Text.Replace("Pole Warper", "电极解离机");
                    line.Text = line.Text.Replace("Plasma Grenade", "等离子手雷");
                    line.Text = line.Text.Replace("Auric Quantum Cooling Cell", "金源量子冷却电池");
                    line.Text = line.Text.Replace("Pulse Dragon", "脉冲龙链枷");
                    line.Text = line.Text.Replace("Heavy Laser Rifle", "重型激光步枪");
                    line.Text = line.Text.Replace("Plasma Caster", "等离子液铸器");
                    line.Text = line.Text.Replace("Snake Eyes", "蛇眼");
                    line.Text = line.Text.Replace("Wave Pounder", "震波炸弹");
                    line.Text = line.Text.Replace("Voltage Regulation System", "电压校准系统");

                }
                
                if (item.type == ModContent.ItemType<Terminus>())
                {
                    line.Text = line.Text.Replace("Terminus", "终末石");
                }
                 if (item.type == ModContent.ItemType<CryoKey>())
                {
                    line.Text = line.Text.Replace("Cryo Key", "极寒之匙");
                    line.Text = line.Text.Replace("Summons Cryogen when used in the tundra", "在雪原使用，召唤极地冰灵");
                }

                /*		
                            if (item.type == ModContent.ItemType<>())
                            {
                                line.Text = line.Text.Replace("", "");
                            }	
                */
                //-原版物品-
                #region 武器
                if (item.type == ItemID.DeathSickle)
                {
                    line.Text = line.Text.Replace("Inflicts Whispering Death on hit", "命中造成死亡低语减益");
                }

                if (item.type == ItemID.Excalibur || item.type == ItemID.TrueExcalibur || item.type == ItemID.Gungnir)
                {
                    line.Text = line.Text.Replace("Inflicts Holy Flames", "命中造成神圣之火减益");
                    line.Text = line.Text.Replace("Deals double damage to enemies above 75% life", "对75%生命值以上的敌怪造成双倍伤害");
                }

                if (item.type == 46 || item.type == 273 || item.type == 675 || item.type == 162 || item.type == 3279)
                {
                    line.Text = line.Text.Replace("Inflicts Shadowflame on hit", "命中造成暗影焰减益");
                }

                if (item.type == 2608)
                {
                    line.Text = line.Text.Replace("Holding this item grants +20% increased movement speed", "手持此物品时会获得20%移动速度加成");
                }

                if (item.type == 426 || item.type == 1166 || item.type == 3772)
                {
                    line.Text = line.Text.Replace("Ignores 50% of enemy defense", "无视敌怪50%的防御力");
                }

                if (item.type == 795 || item.type == 801 || item.type == 802 || item.type == 3280)
                {
                    line.Text = line.Text.Replace("Inflicts Burning Blood on hit", "命中造成沸腾之血减益");
                }

                if (item.type == 483 || item.type == 537)
                {
                    line.Text = line.Text.Replace("Decreases enemy defense by 25% on hit", "命中时减少敌人25%防御");
                }

                if (item.type == 1185 || item.type == 1186)
                {
                    line.Text = line.Text.Replace("Increases life regen on hit", "命中时增加生命恢复速度");
                }

                if (item.type == 484 || item.type == 390)
                {
                    line.Text = line.Text.Replace("Decreases enemy contact damage by 10% on hit", "命中时减少敌人10%接触伤害");
                }

                if (item.type == 1192 || item.type == 1193)
                {
                    line.Text = line.Text.Replace("Increases how frequently the Orichalcum set bonus triggers on hit", "命中时增加山铜套触发效果");
                }

                if (item.type == 406 || item.type == 482)
                {
                    line.Text = line.Text.Replace("Slows enemies on hit", "命中时减速敌人");
                }

                if (item.type == 3065 || item.type == 1947 || item.type == 3106)
                {
                    line.Text = line.Text.Replace("Receives 33% benefit from melee speed bonuses", "只能享受33%近战攻速加成效果");
                }

                if (item.type == 3859)
                {
                    line.Text = line.Text.Replace("Shoots splitting arrows", "射出分裂的箭");
                }

                if (item.type == 1199 || item.type == 1200)
                {
                    line.Text = line.Text.Replace("Deals increased damage to enemies with high knockback resistance", "对高击退抗性的敌人造成更多伤害");
                }

                List<int> i100ed = new List<int>() { 3352, 198, 199, 200, 201, 202, 203, 3764, 3765, 3766, 3767, 3768, 3769, 4258, 4259 };
                if (i100ed.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Ignores 100% of enemy defense", "无视敌怪100%的防御力");
                }
                #endregion

                #region 工具
                if (item.type == ItemID.Pwnhammer || item.type == ItemID.Hammush)
                {
                    line.Text = line.Text.Replace("Demon Altars now drop Souls of Night instead of generating ores when destroyed", "摧毁恶魔祭坛获得暗影之魂，而不是新三矿");
                    line.Text = line.Text.Replace("Hardmode ores now generate after defeating Mechanical Bosses for the first time", "新三矿仅在击败每个机械Boss后生成");
                }

                if (item.type == ItemID.GoldPickaxe || item.type == ItemID.PlatinumPickaxe)
                {
                    line.Text = line.Text.Replace("Can mine Demonite, Crimtane, Meteorite, Sea Prisms and Sea Prism Crystals", "可开采魔矿、猩红矿、陨石、海棱晶和海棱晶碎晶");
                }

                if (item.type == ItemID.Picksaw)
                {
                    line.Text = line.Text.Replace("Can mine Scoria Ore located in the Abyss", "可开采深渊中的熔渣矿");
                }

                if (item.type == ItemID.VortexPickaxe || item.type == ItemID.NebulaPickaxe || item.type == ItemID.SolarFlarePickaxe || item.type == ItemID.StardustPickaxe)
                {
                    line.Text = line.Text.Replace("Can mine Uelibloom Ore", "可开采龙蒿矿");
                }

                if (item.type == ItemID.GoldenFishingRod)
                {
                    line.Text = line.Text.Replace("Its fishing line will never break", "鱼线永远不会断裂");
                }
                #endregion

                #region 饰品
                if (item.type == 4986)
                {
                    line.Text = line.Text.Replace("Throws a mixture of slime and sparkling crystals\nSlimed enemies take more damage from fire-based debuffs", "投掷粘液和闪亮晶体的混合物\n史莱姆类敌人会受到更多来自火系减益的伤害");
                }
                if (item.type == ItemID.TerrasparkBoots)
                {
                    line.Text = line.Text.Replace("Immunity to the On Fire! debuff", "免疫着火了减益");
                }
                if (item.type == ItemID.Magiluminescence)
                {
                    line.Text = line.Text.Replace("Increases movement acceleration and deceleration by 1.25x", "移动加速度和减速度增加1.25倍");
                    line.Text = line.Text.Replace("Increases movement speed by 1.05x. This bonus applies to running boot accessories", "移动速度增加1.05倍。该效果适用于移动饰品");
                }

                if (item.type == ItemID.YoYoGlove || item.type == ItemID.YoyoBag)
                {
                    line.Text = line.Text.Replace("Secondary yoyos will do 50% less damage", "第二个悠悠球伤害减少50%");
                }

                if (item.type == ItemID.ArmorPolish || item.type == ItemID.ArmorBracing)
                {
                    line.Text = line.Text.Replace("and Armor Crunch", "免疫碎甲减益");
                }

                if (item.type == ItemID.AnkhShield)
                {
                    line.Text = line.Text.Replace("including Mighty Wind", "包括强风");
                }

                if (item.type == ItemID.BlackBelt || item.type == ItemID.MasterNinjaGear || item.type == ItemID.BrainOfConfusion)
                {
                    line.Text = line.Text.Replace("Grants the ability to dodge attacks", "获得闪避能力");
                    line.Text = line.Text.Replace("The dodge has a 90 second cooldown which is shared with all other dodges and reflects", "闪避有90秒冷却，且与其他闪避和反弹效果共享冷却");
                }

                if (item.type == ItemID.FleshKnuckles || item.type == ItemID.BerserkerGlove || item.type == ItemID.HeroShield)
                {
                    line.Text = line.Text.Replace("Max life increased by 45", "最大生命增加45");
                }

                if (item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.BerserkerGlove)
                {
                    line.Text = line.Text.Replace("10% increased true melee damage", "真近战伤害增加10%");
                }

                if (item.type == ItemID.FireGauntlet)
                {
                    line.Text = line.Text.Replace("14% increased melee damage and speed", "近战伤害和攻速增加14%");
                    line.Text = line.Text.Replace("10% increased true melee damage", "真近战伤害增加10%");
                }

                if (item.type == ItemID.SunStone)
                {
                    line.Text = line.Text.Replace("Grants immunity to Holy Flames", "免疫神圣之火减益");
                }

                if (item.type == ItemID.MoonStone)
                {
                    line.Text = line.Text.Replace("Grants immunity to Nightwither", "免疫夜魇减益");
                }

                if (item.type == ItemID.CelestialStone || item.type == ItemID.CelestialShell)
                {
                    line.Text = line.Text.Replace("Grants immunity to Nightwither and Holy Flames", "免疫夜魇和神圣之火减益");
                }

                if (item.type == ItemID.DivingHelmet || item.type == ItemID.ArcticDivingGear || item.type == ItemID.CelestialShell)
                {
                    line.Text = line.Text.Replace("Moderately reduces breath loss in the abyss", "适当缓解深渊造成的呼吸困难");
                }

                if (item.type == ItemID.JellyfishNecklace || item.type == ItemID.JellyfishDivingGear || item.type == ItemID.ArcticDivingGear || item.type == ItemID.ShadowOrb || item.type == ItemID.CrimsonHeart || item.type == ItemID.MagicLantern || item.type == ItemID.Magiluminescence || item.type == ItemID.MiningHelmet)
                {
                    line.Text = line.Text.Replace("Provides a small amount of light in the abyss", "在深渊中提供少量光照");
                }

                if (item.type == ItemID.FairyBell || item.type == ItemID.DD2PetGhost || item.type == ItemID.ShinePotion)
                {
                    line.Text = line.Text.Replace("Provides a moderate amount of light in the abyss", "在深渊中提供适量光照");
                }

                if (item.type == ItemID.WispinaBottle || item.type == ItemID.SuspiciousLookingTentacle || item.type == ItemID.GolemPetItem || item.type == ItemID.FairyQueenPetItem || item.type == ItemID.PumpkingPetItem)
                {
                    line.Text = line.Text.Replace("Provides a large amount of light in the abyss", "在深渊中提供大量光照");
                }

                if (item.type == ItemID.EmpressFlightBooster)
                {
                    line.Text = line.Text.Replace("Increases wing flight time by 25%", "翅膀飞行时间增加25%");
                    line.Text = line.Text.Replace("Increases movement and jump speed by 10% and acceleration by 1.1x", "移动和跳跃速度提高10%，加速度提高1.1倍");
                }

                if (item.type == ItemID.ArcaneFlower || item.type == ItemID.MagnetFlower)
                {
                    line.Text = line.Text.Replace("12% reduced mana usage", "减少12%魔力消耗");
                }

                if (item.type == ItemID.MagicQuiver)
                {
                    line.Text = line.Text.Replace("Increases arrow damage by 5% and greatly increases arrow speed", "增加5%的箭矢伤害，并大幅提高箭矢速度");
                }

                if (item.type == ItemID.MoltenQuiver)
                {
                    line.Text = line.Text.Replace("Increases arrow damage by 7% and greatly increases arrow speed", "增加7%的箭矢伤害，并大幅提高箭矢速度");
                    line.Text = line.Text.Replace("and all arrows inflict Hellfire", "所有箭矢造成狱火减益");
                }

                if (item.type == ItemID.SniperScope)
                {
                    line.Text = line.Text.Replace("7% increased ranged damage and critical strike chance", "提高7%远程伤害和暴击率");
                }

                if (item.type == ItemID.HandWarmer)
                {
                    line.Text = line.Text.Replace("Provides a regeneration boost while wearing the Snow armor", "穿着全套的防雪盔甲时额外提升2点生命再生速度");
                }

                if (item.type == ItemID.HellfireTreads)
                {
                    line.Text = line.Text.Replace("Multiplies all fire-based debuff damage by 1.5", "所有火焰类减益伤害乘于1.5");
                    line.Text = line.Text.Replace("All attacks inflict Hellfire", "所有攻击造成狱火减益");
                }

                if (item.type == ItemID.FairyBoots)
                {
                    line.Text = line.Text.Replace("Fairies can spawn at any time on the surface and spawn far more frequently", "大幅度提升仙灵的生成概率，在白天地表也能自然生成");
                    line.Text = line.Text.Replace("Nearby fairies grant increased life regen, defense and movement speed", "靠近仙灵获得生命恢复，防御与移动速度");
                    line.Text = line.Text.Replace("Fairies are immune to damage and will no longer flee", "仙灵免疫敌怪的伤害并能跟随你");
                }

                if (item.type == ItemID.DemonWings)
                {
                    line.Text = line.Text.Replace("5% increased damage and critical strike chance", "提高5%伤害和暴击率");
                }

                if (item.type == ItemID.AngelWings)
                {
                    line.Text = line.Text.Replace("+20 max life, +10 defense and +2 life regen", "+20最大生命值，+10防御力和2点生命恢复");
                }

                if (item.type == ItemID.LeafWings)
                {
                    line.Text = line.Text.Replace("+5 defense, 5% increased damage reduction,", "穿着提基盔甲提高5防御力和5%减伤");
                    line.Text = line.Text.Replace("and permanent Dryad's Blessing while wearing the Tiki Armor", "并永久获得树妖祝福");
                }

                if (item.type == ItemID.FinWings)
                {
                    line.Text = line.Text.Replace("Gills effect and you can move freely through liquids", "具有鱼鳃效果且允许在液体中快速移动");
                    line.Text = line.Text.Replace("You fall faster while submerged in liquid", "液体中下落速度加快");
                }

                if (item.type == ItemID.BeeWings)
                {
                    line.Text = line.Text.Replace("Permanently gives the Honey buff", "任何时候都会给予蜂蜜buff");
                }

                if (item.type == ItemID.ButterflyWings)
                {
                    line.Text = line.Text.Replace("+20 max mana, 5% decreased mana usage,", "+20最大魔力值，减少5%魔力消耗");
                    line.Text = line.Text.Replace("5% increased magic damage and magic critical strike chance", "提高5%魔法伤害和魔法暴击率");
                }

                if (item.type == ItemID.FairyWings)
                {
                    line.Text = line.Text.Replace("+60 max life", "+60最大生命值");
                }

                if (item.type == ItemID.BatWings)
                {
                    line.Text = line.Text.Replace("At night or during an eclipse, you will gain the following boosts:", "在夜晚或日食期间，你将获得以下加成：");
                    line.Text = line.Text.Replace("7% increased damage and 3% increased critical strike chance", "增加7%伤害和3%暴击率");
                }

                if (item.type == ItemID.HarpyWings)
                {
                    line.Text = line.Text.Replace("20% increased movement speed", "提高20%移动速度");
                    line.Text = line.Text.Replace("With Harpy Ring or Angel Treads equipped, most attacks sometimes launch feathers", "在装备女妖指环或天使之靴时大多数攻击会释放羽毛");
                }

                if (item.type == ItemID.BoneWings)
                {
                    line.Text = line.Text.Replace("10% increased movement speed, ranged damage and critical strike chance", "穿着死灵盔甲时提高10%移动速度，提高10%远程伤害和远程暴击率");
                    line.Text = line.Text.Replace("and +30 defense while wearing the Necro Armor", "提高30点防御力");
                }

                if (item.type == ItemID.MothronWings)
                {
                    line.Text = line.Text.Replace("+5 defense and 5% increased damage", "增加5防御力，提高5%伤害");
                }

                if (item.type == ItemID.FrozenWings)
                {
                    line.Text = line.Text.Replace("2% increased melee and ranged damage", "穿着寒霜盔甲时");
                    line.Text = line.Text.Replace("and 1% increased melee and ranged critical strike chance", "提高2%近战和远程伤害");
                    line.Text = line.Text.Replace("while wearing the Frost Armor", "提高1%近战和远程暴击率");
                }

                if (item.type == ItemID.FlameWings)
                {
                    line.Text = line.Text.Replace("5% increased melee damage and critical strike chance", "提高5%近战伤害和近战暴击率");
                }

                if (item.type == ItemID.GhostWings)
                {
                    line.Text = line.Text.Replace("+10 defense and 5% increased damage reduction while wearing the Spectre Hood set", "穿着幽灵盔甲配幽灵兜帽时提高10防御力和5%减伤");
                    line.Text = line.Text.Replace("5% increased magic damage and critical strike chance while wearing the Spectre Mask set", "穿着幽灵盔甲配幽灵面具时提高5%魔法伤害和魔法暴击率");
                }

                if (item.type == ItemID.BeetleWings)
                {
                    line.Text = line.Text.Replace("+10 defense and 5% increased damage reduction while wearing the Beetle Shell set", "穿着甲虫盔甲配甲虫壳时增加10防御力和5%减伤");
                    line.Text = line.Text.Replace("5% increased melee damage and critical strike chance while wearing the Beetle Scale Mail set", "穿着甲虫盔甲配甲虫铠甲时提高5%近战伤害和近战暴击率");
                }

                if (item.type == ItemID.Hoverboard)
                {
                    line.Text = line.Text.Replace("10% increased weapon-type damage while wearing the Shroomite Armor", "穿着蘑菇矿盔甲时提高10%武器类型伤害");
                    line.Text = line.Text.Replace("The weapon type boosted matches which Shroomite helmet is worn", "加成武器类型取决于戴的蘑菇矿头盔的类型");
                }

                if (item.type == ItemID.FestiveWings)
                {
                    line.Text = line.Text.Replace("+40 max life", "+40最大生命值");
                    line.Text = line.Text.Replace("Ornaments rain down as you fly", "飞行时掉落装饰品");
                }

                if (item.type == ItemID.SpookyWings)
                {
                    line.Text = line.Text.Replace("Increased minion knockback and 5% increased minion damage while wearing the Spooky Armor", "穿着阴森盔甲时提高召唤物击退和5%召唤伤害");
                }

                if (item.type == ItemID.TatteredFairyWings)
                {
                    line.Text = line.Text.Replace("5% increased damage and critical strike chance", "提高5%伤害和暴击率");
                }

                if (item.type == ItemID.SteampunkWings)
                {
                    line.Text = line.Text.Replace("+8 defense, 10% increased movement speed,", "+8防御力和10%移速");
                    line.Text = line.Text.Replace("4% increased damage, and 2% increased critical strike chance", "并提高4%伤害和2%暴击率");
                }

                if (item.type == ItemID.WingsNebula)
                {
                    line.Text = line.Text.Replace("+20 max mana, 5% increased magic damage and critical strike chance,", "穿着星云盔甲时+20最大魔力值");
                    line.Text = line.Text.Replace("and 5% decreased mana usage while wearing the Nebula Armor", "提高5%魔法伤害和魔法暴击率减少5%魔力消耗");
                }

                if (item.type == ItemID.WingsVortex)
                {
                    line.Text = line.Text.Replace("3% increased ranged damage and 7% increased ranged critical strike chance", "穿着星旋盔甲时");
                    line.Text = line.Text.Replace("while wearing the Vortex Armor", "提高3%远程伤害和7%远程暴击率");
                }

                if (item.type == ItemID.WingsStardust)
                {
                    line.Text = line.Text.Replace("10% increased minion damage while wearing the Stardust Armor", "穿着星尘盔甲时增加10%召唤伤害");
                }

                if (item.type == ItemID.WingsSolar)
                {
                    line.Text = line.Text.Replace("7% increased melee damage and 3% increased melee critical strike chance", "穿着耀斑盔甲时");
                    line.Text = line.Text.Replace("while wearing the Solar Flare Armor", "提高7%近战伤害和3%近战暴击率");
                }

                List<int> wings = new List<int>() { 4978, 492, 493, 1162, 761, 2494, 822, 785, 748, 665, 1583, 1584, 1585, 1586, 3228, 3580, 3582, 3588, 3592, 3924, 3928, 4730, 4746, 4750, 4754, 1165, 1515, 749, 821, 823, 1866, 786, 2770, 823, 2280, 1871, 1830, 1797, 948, 3883, 4823, 2609, 3470, 3469, 3468, 3471, 4954 };
                if (wings.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Horizontal speed", "水平飞行速度");
                    line.Text = line.Text.Replace("Acceleration multiplier", "加速倍率");
                    line.Text = line.Text.Replace("Bad vertical speed", "糟糕的垂直飞行速度");
                    line.Text = line.Text.Replace("Average vertical speed", "普通的垂直飞行速度");
                    line.Text = line.Text.Replace("Good vertical speed", "不错的垂直飞行速度");
                    line.Text = line.Text.Replace("Great vertical speed", "较强的垂直飞行速度");
                    line.Text = line.Text.Replace("Excellent vertical speed", "优异的垂直飞行速度");
                    line.Text = line.Text.Replace("Flight time", "飞行时间");
                }

                List<int> grappins = new List<int>() { 84, 1236, 1237, 1238, 1239, 1240, 1241, 939, 1273, 2585, 2360, 185, 1800, 1915, 437, 3021, 3023, 3020, 3022, 2800, 1829, 1916, 3572, 3623, 4257, 4759, 4980 };
                if (grappins.Contains(item.type))
                {
                    line.Text = line.Text.Replace("Reach", "长度");
                    line.Text = line.Text.Replace("tiles", "图格");
                    line.Text = line.Text.Replace("Launch Velocity", "发射速度");
                    line.Text = line.Text.Replace("Reelback Velocity", "回收速度");
                    line.Text = line.Text.Replace("Pull Velocity", "牵引速度");
                }
                #endregion

                #region 盔甲
                if (item.type == 89 || item.type == 80 || item.type == 76)
                {
                    line.Text = line.Text.Replace("5% increased damage", "伤害增加5%");
                    line.Text = line.Text.Replace("3% increased critical strike chance", "暴击率增加3%");
                    line.Text = line.Text.Replace("5% increased movement speed", "移速增加5%");
                }
                if (item.type == 91 || item.type == 82 || item.type == 78)
                {
                    line.Text = line.Text.Replace("5% increased critical strike chance", "暴击率增加5%");
                    line.Text = line.Text.Replace("+2 life regen", "生命再生增加2点");
                    line.Text = line.Text.Replace("8% increased movement speed", "移动速度增加8%");
                }
                if (item.type == 954 || item.type == 90 || item.type == 81 || item.type == 77)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by 3%", "所受伤害减少3%");
                }
                if (item.type == 955 || item.type == 92 || item.type == 83 || item.type == 79)
                {
                    line.Text = line.Text.Replace("6% increased damage", "伤害增加6%");
                    line.Text = line.Text.Replace("Reduces damage taken by 5%", "所受伤害减少5%");
                    line.Text = line.Text.Replace("10% increased movement speed", "移速增加10%");
                }
                if (item.type == 687 || item.type == 688 || item.type == 689)
                {
                    line.Text = line.Text.Replace("3% increased critical strike chance", "暴击率增加3%");
                    line.Text = line.Text.Replace("+1 life regen", "生命再生增加1点");
                    line.Text = line.Text.Replace("5% increased movement speed", "移速增加5%");
                }
                if (item.type == 690 || item.type == 691 || item.type == 692)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by 3%", "所受伤害减少3%");
                }
                if (item.type == 693 || item.type == 694 || item.type == 695)
                {
                    line.Text = line.Text.Replace("7% increased damage", "伤害增加7%");
                    line.Text = line.Text.Replace("+1 life regen", "生命再生增加1点");
                    line.Text = line.Text.Replace("8% increased movement speed", "移速增加8%");
                }
                if (item.type == 696 || item.type == 697 || item.type == 698)
                {
                    line.Text = line.Text.Replace("6% increased damage", "伤害增加6%");
                    line.Text = line.Text.Replace("5% increased critical strike chance", "暴击率增加5%");
                    line.Text = line.Text.Replace("10% increased movement speed", "移速增加10%");
                }
                if (item.type == 956 || item.type == 957 || item.type == 958 || item.type == 102 || item.type == 101 || item.type == 100)
                {
                    line.Text = line.Text.Replace("5% increased damage and 7% increased jump speed", "增加5%伤害和7%跳跃速度");
                }
                if (item.type == 792 || item.type == 793 || item.type == 794)
                {
                    line.Text = line.Text.Replace("life regen", "生命再生");
                }
                if (item.type == 3187 || item.type == 3188 || item.type == 3189)
                {
                    line.Text = line.Text.Replace("3% increased rogue damage", "增加3%盗贼伤害");
                    line.Text = line.Text.Replace("3% increased rogue critical strike chance", "增加3%盗贼暴击率");
                    line.Text = line.Text.Replace("3% increased rogue velocity", "增加3%盗贼弹幕速度");
                }
                if (item.type == 371 || item.type == 372 || item.type == 373 || item.type == 374 || item.type == 375)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 60", "增加60最大魔力值");
                }
                if (item.type == 376 || item.type == 377 || item.type == 378 || item.type == 379 || item.type == 380)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 80", "增加80最大魔力值");
                    line.Text = line.Text.Replace("12% increased damage", "伤害增加12%");
                    line.Text = line.Text.Replace("14% increased critical strike chance", "暴击率增加14%");
                }
                if (item.type == 400 || item.type == 401 || item.type == 402 || item.type == 403 || item.type == 404)
                {
                    line.Text = line.Text.Replace("Increases maximum mana by 100", "增加100最大魔力值");
                }
                if (item.type == 1208 || item.type == 1209)
                {
                    line.Text = line.Text.Replace("5% increased damage", "伤害增加5%");
                }
                if (item.type == 1213)
                {
                    line.Text = line.Text.Replace("10% increased critical strike chance", "暴击率增加10%");
                }
                if (item.type == 3800 || item.type == 3801 || item.type == 3802)
                {
                    line.Text = line.Text.Replace("10% increased minion and melee damage", "增加10%召唤和近战伤害");
                    line.Text = line.Text.Replace("5% increased minion damage and melee critical strike chance", "增加5%召唤伤害和近战暴击率");
                    line.Text = line.Text.Replace("15% increased movement speed", "移速增加15%");
                }
                if (item.type == 3803 || item.type == 3804 || item.type == 3805)
                {
                    line.Text = line.Text.Replace("10% increased minion and ranged damage", "增加10%召唤和远程伤害");
                    line.Text = line.Text.Replace("10% chance to not consume ammo", "10%几率不消耗弹药");
                }
                if (item.type == 3806 || item.type == 3807 || item.type == 3808)
                {
                    line.Text = line.Text.Replace("Increases your max number of sentries by 1 and increases melee attack speed by 10%", "增加1最大哨兵栏，增加10%近战攻速");
                    line.Text = line.Text.Replace("10% increased minion and melee damage", "增加10%召唤和近战伤害");
                    line.Text = line.Text.Replace("5% increased minion damage and melee critical strike chance", "增加5%召唤伤害和近战暴击率");
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%");
                }
                if (item.type == 3797 || item.type == 3798 || item.type == 3799)
                {
                    line.Text = line.Text.Replace("5% increased minion damage and magic critical strike chance", "增加5%召唤伤害和魔法暴击率");
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%");
                }
                if (item.type == 3871 || item.type == 3872 || item.type == 3873)
                {
                    line.Text = line.Text.Replace("30% increased minion damage and increased life regeneration", "增加30%召唤伤害，提高生命再生速度");
                    line.Text = line.Text.Replace("10% increased minion damage and melee critical strike chance", "增加10%召唤伤害和近战暴击率");
                    line.Text = line.Text.Replace("20% increased movement speed", "移速增加20%");
                }
                if (item.type == 3880 || item.type == 3881 || item.type == 3882)
                {
                    line.Text = line.Text.Replace("Increases your max number of sentries by 2", "增加2最大哨兵栏");
                    line.Text = line.Text.Replace("10% increased melee and minion damage", "增加10%召唤和近战伤害");
                    line.Text = line.Text.Replace("10% increased minion damage and melee speed", "增加10%召唤伤害和近战攻速");
                    line.Text = line.Text.Replace("10% increased minion damage and melee critical strike chance", "增加10%召唤伤害和近战暴击率");
                }
                if (item.type == 3877 || item.type == 3878 || item.type == 3879)
                {
                    line.Text = line.Text.Replace("15% increased minion and ranged damage and 20% chance to not consume ammo", "增加15%召唤和远程伤害,20%几率不消耗弹药");
                }
                if (item.type == 3874 || item.type == 3875 || item.type == 3876)
                {
                    line.Text = line.Text.Replace("10% increased minion damage and magic critical strike chance", "增加5%召唤伤害和魔法暴击率");
                }
                #endregion

                #region 物品
                if (item.type == ItemID.DeerThing || item.type == ItemID.QueenSlimeCrystal || item.type == ItemID.TruffleWorm || item.type == ItemID.MechanicalEye || item.type == ItemID.MechanicalWorm || item.type == ItemID.MechanicalSkull || item.type == ItemID.LihzahrdPowerCell || item.type == ItemID.WormFood || item.type == ItemID.BloodySpine || item.type == ItemID.Abeemination || item.type == ItemID.SlimeCrown || item.type == ItemID.GoblinBattleStandard || item.type == ItemID.SnowGlobe || item.type == ItemID.PumpkinMoonMedallion || item.type == ItemID.NaughtyPresent || item.type == ItemID.SolarTablet || item.type == ItemID.PirateMap || item.type == ItemID.BloodMoonStarter || item.type == ItemID.CelestialSigil || item.type == ItemID.SuspiciousLookingEye)
                {
                    line.Text = line.Text.Replace("Not consumable", "不消耗");

                    line.Text = line.Text.Replace("when used during nighttime", "在夜晚使用");
                    line.Text = line.Text.Replace("when used in the Jungle", "在丛林使用");
                    line.Text = line.Text.Replace("when used in the Hallow", "在神圣之地使用");
                    line.Text = line.Text.Replace("when used in the Snow or Ice biome", "在雪原群系使用");
                    line.Text = line.Text.Replace("when used in the Crimson", "在血腥之地使用");
                    line.Text = line.Text.Replace("when used in the Corruption", "在腐化之地使用");

                    line.Text = line.Text.Replace("Enrages during the day", "白天会狂暴");
                    line.Text = line.Text.Replace("Enrages outside the Underground Jungle", "在地下丛林外会狂暴");
                    line.Text = line.Text.Replace("Enrages outside the Underground Crimson", "在地下血腥外会狂暴");
                    line.Text = line.Text.Replace("Enrages outside the Underground Corruption", "在地下腐化外会狂暴");
                    line.Text = line.Text.Replace("Enrages outside the Jungle Temple", "在丛林神庙外会狂暴");
                    line.Text = line.Text.Replace("Enrages outside the Ocean", "海洋群系外会狂暴");
                    
                    line.Text = line.Text.Replace("to summon the Golem", "召唤石巨人");
                    line.Text = line.Text.Replace("Summons Duke Fishron if used as bait in the Ocean", "在海洋钓一条猪鲨");
                }
                if (item.type == ItemID.GuideVoodooDoll)
                {
                    line.Text = line.Text.Replace("Summons the Wall of Flesh if thrown into lava in the underworld while the Guide is alive", "向导存活时将娃娃扔进地狱的岩浆中召唤肉山");
                }
                if (item.type == ItemID.ClothierVoodooDoll)
                {
                    line.Text = line.Text.Replace("While equipped, summons Skeletron when the Clothier is killed during nighttime", "装备后在夜晚杀死服饰商召唤骷髅王");
                    line.Text = line.Text.Replace("Enrages during the day", "白天会狂暴");
                }
                if (item.type == ItemID.Ale || item.type == ItemID.Sake)
                {
                    line.Text = line.Text.Replace("Increases melee damage and speed by 10% and reduces defense by 10%", "增加10%近战伤害和攻速，减少10%防御");
                }
                if (item.type == ItemID.GillsPotion)
                {
                    line.Text = line.Text.Replace("Greatly reduces breath loss in the abyss", "大大缓解深渊造成的呼吸困难");
                }
                if (item.type == ItemID.BottledHoney)
                {
                    line.Text = line.Text.Replace("Grants the Honey buff for 2 minutes", "给予2分钟蜂蜜增益");
                }
                if (item.type == ItemID.ArcheryPotion)
                {
                    line.Text = line.Text.Replace("20% increased arrow speed and 5% increased arrow damage", "增加20%箭矢速度和5%箭矢伤害");
                }
                if (item.type == ItemID.EndurancePotion)
                {
                    line.Text = line.Text.Replace("Reduces damage taken by 5%", "减少5%受到的伤害");
                }
                if (item.type == ItemID.MagicPowerPotion)
                {
                    line.Text = line.Text.Replace("10% increased magic damage", "增加10%魔法伤害");
                }
                if (item.type == ItemID.SwiftnessPotion)
                {
                    line.Text = line.Text.Replace("15% increased movement speed", "增加15%移速");
                }
                if (item.type == ItemID.WarmthPotion)
                {
                    line.Text = line.Text.Replace("Grants immunity to Chilled, Frozen and Glacial State", "免疫冷冻、冰冻和冰河时代减益");
                }
                if (item.type == ItemID.RodofDiscord)
                {
                    line.Text = line.Text.Replace("Teleportation is disabled while Chaos State is active", "混乱状态下禁用传送");
                }
                if (item.type == ItemID.EmptyBucket)
                {
                    line.Text = line.Text.Replace("Cannot be used in the Abyss", "无法在深渊使用");
                }
                if (item.type == ItemID.DD2ElderCrystal)
                {
                    line.Text = line.Text.Replace("Once placed you can right click the crystal to skip waves or increase the spawn rate of the invaders", "放置后你可以通过右键水晶跳过波数等待或加快刷怪速度");
                }
                if (item.type == ModContent.ItemType<Lacerator>())
                {
                    line.Text = line.Text.Replace("Someone thought this was a viable weapon against DoG at one point lol", "竟然有人觉得用这东西可以在某一时间与神明吞噬者战斗，可笑");
                }
                if (item.type == ModContent.ItemType<CryoKey>())
                {
                    line.Text = line.Text.Replace("Summons Cryogen when used in the tundra", "在雪原使用，召唤极地冰灵");
                }
                if (item.type == ModContent.ItemType<ProfanedShard>())
                {
                    line.Text = line.Text.Replace("Summons the Profaned Guardians when used in the Hallow or Underworld during daytime", "白天在地狱或神圣之地使用，召唤亵渎守卫");
                }
                if (item.type == ModContent.ItemType<SandstormsCore>())
                {
                    line.Text = line.Text.Replace("Summons the Great Sand Shark when used in the desert", "在沙漠使用，召唤旱海狂鲨");
                }
                #endregion

                //偷懒                
                line.Text = line.Text.Replace("You have already consumed this item", "你已经使用过这个");
                line.Text = line.Text.Replace("Restores", "恢复");
                line.Text = line.Text.Replace("life", "生命");
                line.Text = line.Text.Replace(" or Revengeance", "或者复仇");
        }
    }
}
