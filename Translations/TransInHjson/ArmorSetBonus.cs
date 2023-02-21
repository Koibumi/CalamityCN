using CalamityMod;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod.Items.Armor;
using CalamityMod.Items.Armor.Aerospec;
using CalamityMod.Items.Armor.Astral;
using CalamityMod.Items.Armor.Auric;
using CalamityMod.Items.Armor.Bloodflare;
using CalamityMod.Items.Armor.Brimflame;
using CalamityMod.Items.Armor.Daedalus;
using CalamityMod.Items.Armor.Demonshade;
using CalamityMod.Items.Armor.DesertProwler;
using CalamityMod.Items.Armor.Empyrean;
using CalamityMod.Items.Armor.FathomSwarmer;
using CalamityMod.Items.Armor.Fearmonger;
using CalamityMod.Items.Armor.GemTech;
using CalamityMod.Items.Armor.GodSlayer;
using CalamityMod.Items.Armor.Hydrothermic;
using CalamityMod.Items.Armor.Mollusk;
using CalamityMod.Items.Armor.OmegaBlue;
using CalamityMod.Items.Armor.Plaguebringer;
using CalamityMod.Items.Armor.PlagueReaper;
using CalamityMod.Items.Armor.Prismatic;
using CalamityMod.Items.Armor.Reaver;
using CalamityMod.Items.Armor.Silva;
using CalamityMod.Items.Armor.SnowRuffian;
using CalamityMod.Items.Armor.Statigel;
using CalamityMod.Items.Armor.Sulphurous;
using CalamityMod.Items.Armor.Tarragon;
using CalamityMod.Items.Armor.TitanHeart;
using CalamityMod.Items.Armor.Umbraphile;
using CalamityMod.Items.Armor.Victide;
using CalamityMod.Items.Armor.Wulfrum;
using CalamityMod.Items.Armor.MarniteArchitect;
using CalamityCN.Utils;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace CalamityCN.Translations.TransInHjson
{
    public class ArmorSetBonus : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.Calamity != null && ModsCall.IsCN;
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            string hotkey = CalamityMod.CalamityKeybinds.SetBonusHotKey.TooltipHotkeyString();
            string hotkeyGods = CalamityKeybinds.GodSlayerDashHotKey.TooltipHotkeyString();
            #region 灾厄套装
            if (set == "AerospecMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AerospecMagic", Array.Empty<object>());
            }
            else if (set == "AerospecRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AerospecRogue", Array.Empty<object>());
            }
            else if (set == "AerospecMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AerospecMelee", Array.Empty<object>());
            }
            else if (set == "AerospecSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AerospecSummon", Array.Empty<object>());
            }
            else if (set == "AerospecRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AerospecRanged", Array.Empty<object>());
            }
            else if (set == "AncientForbiddenCirclet")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AncientForbiddenCirclet", new object[]
                        {
                                hotkey,
                                (int)(60f * Main.player[Main.myPlayer].manaCost)
                        });
            }
            else if (set == "Astral")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Astral", Array.Empty<object>());
            }
            else if (set == "HydrothermicRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.HydrothermicRanged", Array.Empty<object>());
            }
            else if (set == "HydrothermicMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.HydrothermicMelee", Array.Empty<object>());
            }
            else if (set == "HydrothermicSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.HydrothermicSummon", Array.Empty<object>());
            }
            else if (set == "HydrothermicRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.HydrothermicRogue", Array.Empty<object>());
            }
            else if (set == "HydrothermicMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.HydrothermicMagic", Array.Empty<object>());
            }
            else if (set == "AuricMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AuricMelee", Array.Empty<object>());
            }
            else if (set == "AuricRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AuricRanged", Array.Empty<object>());
            }
            else if (set == "AuricRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AuricRogue", Array.Empty<object>());
            }
            else if (set == "AuricSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AuricSummon", Array.Empty<object>());
            }
            else if (set == "AuricMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.AuricMagic", Array.Empty<object>());
            }
            else if (set == "BloodflareRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.BloodflareRogue", Array.Empty<object>());
            }
            else if (set == "BloodflareSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.BloodflareSummon", Array.Empty<object>());
            }
            else if (set == "BloodflareRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.BloodflareRanged", hotkey);
            }
            else if (set == "BloodflareMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.BloodflareMagic", Array.Empty<object>());
            }
            else if (set == "BloodflareMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.BloodflareMelee", Array.Empty<object>());
            }
            else if (set == "Brimflame")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Brimflame", hotkey);
            }
            else if (set == "DaedalusMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DaedalusMagic", Array.Empty<object>());
            }
            else if (set == "DaedalusSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DaedalusSummon", Array.Empty<object>());
            }
            else if (set == "DaedalusMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DaedalusMelee", Array.Empty<object>());
            }
            else if (set == "DaedalusRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DaedalusRanged", Array.Empty<object>());
            }
            else if (set == "DaedalusRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DaedalusRogue", Array.Empty<object>());
            }
            else if (set == "Demonshade")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Demonshade", hotkey);
            }
            else if (set == "DesertProwler")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DesertProwler", Array.Empty<object>());
            }
            else if (set == "FathomSwarmer")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.FathomSwarmer", Array.Empty<object>());
            }
            else if (set == "Fearmonger")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Fearmonger", Array.Empty<object>());
            }
            else if (set == "GodSlayerMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GodSlayerMelee", hotkeyGods);
            }
            else if (set == "GodSlayerRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GodSlayerRanged", hotkeyGods);
            }
            else if (set == "GodSlayerRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GodSlayerRogue", hotkeyGods);
            }
            else if (set == "Mollusk")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Mollusk", Array.Empty<object>());
            }
            else if (set == "OmegaBlue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.OmegaBlue", hotkey);
            }
            else if (set == "Plaguebringer")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Plaguebringer", Array.Empty<object>());
            }
            else if (set == "PlagueReaper")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.PlagueReaper", hotkey);
            }
            else if (set == "Prismatic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Prismatic", hotkey);
            }
            else if (set == "ReaverExp")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.ReaverExp", Array.Empty<object>());
            }
            else if (set == "ReaverTan")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.ReaverTan", Array.Empty<object>());
            }
            else if (set == "ReaverMob")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.ReaverMob", Array.Empty<object>());
            }
            /*else if (set == "ShroomiteVisage")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.ShroomiteVisage", Array.Empty<object>());
            }*/
            else if (set == "SilvaSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.SilvaSummon", Array.Empty<object>());
            }
            else if (set == "SilvaMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.SilvaMagic", Array.Empty<object>());
            }
            else if (set == "SnowRuffian")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.SnowRuffian", Array.Empty<object>());
            }
            else if (set == "StatigelMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.StatigelMagic", Array.Empty<object>());
            }
            else if (set == "StatigelRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.StatigelRanged", Array.Empty<object>());
            }
            else if (set == "StatigelMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.StatigelMelee", Array.Empty<object>());
            }
            else if (set == "StatigelSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.StatigelSummon", Array.Empty<object>());
            }
            else if (set == "StatigelRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.StatigelRogue", Array.Empty<object>());
            }
            else if (set == "Sulphurous")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Sulphurous", Array.Empty<object>());
            }
            else if (set == "TarragonMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TarragonMelee", hotkey);
            }
            else if (set == "TarragonRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TarragonRogue", Array.Empty<object>());
            }
            else if (set == "TarragonSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TarragonSummon", Array.Empty<object>());
            }
            else if (set == "TarragonMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TarragonMagic", Array.Empty<object>());
            }
            else if (set == "TarragonRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TarragonRanged", Array.Empty<object>());
            }
            else if (set == "TitanHeart")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.TitanHeart", Array.Empty<object>());
            }
            else if (set == "Umbraphile")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Umbraphile", Array.Empty<object>());
            }
            else if (set == "VictideRogue")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.VictideRogue", Array.Empty<object>());
            }
            else if (set == "VictideMelee")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.VictideMelee", Array.Empty<object>());
            }
            else if (set == "VictideSummon")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.VictideSummon", Array.Empty<object>());
            }
            else if (set == "VictideMagic")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.VictideMagic", Array.Empty<object>());
            }
            else if (set == "VictideRanged")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.VictideRanged", Array.Empty<object>());
            }

            else if (set == "Empyrean")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Empyrean", Array.Empty<object>());
            }

            else if (set == "Wulfrum")
            {
                player.setBonus = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Wulfrum", Array.Empty<object>());
            }

            #endregion

            
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            #region 灾厄套装
            if (head.type == ModContent.ItemType<AerospecHat>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
            {
                return "AerospecMagic";
            }
            if (head.type == ModContent.ItemType<AerospecHeadgear>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
            {
                return "AerospecRogue";
            }
            if (head.type == ModContent.ItemType<AerospecHelm>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
            {
                return "AerospecMelee";
            }
            if (head.type == ModContent.ItemType<AerospecHelmet>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
            {
                return "AerospecSummon";
            }
            if (head.type == ModContent.ItemType<AerospecHood>() && body.type == ModContent.ItemType<AerospecBreastplate>() && legs.type == ModContent.ItemType<AerospecLeggings>())
            {
                return "AerospecRanged";
            }
            if (head.type == ModContent.ItemType<AstralHelm>() && body.type == ModContent.ItemType<AstralBreastplate>() && legs.type == ModContent.ItemType<AstralLeggings>())
            {
                return "Astral";
            }
            if (head.type == ModContent.ItemType<HydrothermicHeadRanged>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
            {
                return "HydrothermicRanged";
            }
            if (head.type == ModContent.ItemType<HydrothermicHeadMelee>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
            {
                return "HydrothermicMelee";
            }
            if (head.type == ModContent.ItemType<HydrothermicHeadSummon>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
            {
                return "HydrothermicSummon";
            }
            if (head.type == ModContent.ItemType<HydrothermicHeadRogue>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
            {
                return "HydrothermicRogue";
            }
            if (head.type == ModContent.ItemType<HydrothermicHeadMagic>() && body.type == ModContent.ItemType<HydrothermicArmor>() && legs.type == ModContent.ItemType<HydrothermicSubligar>())
            {
                return "HydrothermicMagic";
            }
            if (head.type == ModContent.ItemType<AuricTeslaRoyalHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
            {
                return "AuricMelee";
            }
            if (head.type == ModContent.ItemType<AuricTeslaHoodedFacemask>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
            {
                return "AuricRanged";
            }
            if (head.type == ModContent.ItemType<AuricTeslaPlumedHelm>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
            {
                return "AuricRogue";
            }
            if (head.type == ModContent.ItemType<AuricTeslaSpaceHelmet>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
            {
                return "AuricSummon";
            }
            if (head.type == ModContent.ItemType<AuricTeslaWireHemmedVisage>() && body.type == ModContent.ItemType<AuricTeslaBodyArmor>() && legs.type == ModContent.ItemType<AuricTeslaCuisses>())
            {
                return "AuricMagic";
            }
            if (head.type == ModContent.ItemType<BloodflareHeadRogue>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
            {
                return "BloodflareRogue";
            }
            if (head.type == ModContent.ItemType<BloodflareHeadSummon>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
            {
                return "BloodflareSummon";
            }
            if (head.type == ModContent.ItemType<BloodflareHeadRanged>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
            {
                return "BloodflareRanged";
            }
            if (head.type == ModContent.ItemType<BloodflareHeadMagic>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
            {
                return "BloodflareMagic";
            }
            if (head.type == ModContent.ItemType<BloodflareHeadMelee>() && body.type == ModContent.ItemType<BloodflareBodyArmor>() && legs.type == ModContent.ItemType<BloodflareCuisses>())
            {
                return "BloodflareMelee";
            }
            if (head.type == ModContent.ItemType<BrimflameScowl>() && body.type == ModContent.ItemType<BrimflameRobes>() && legs.type == ModContent.ItemType<BrimflameBoots>())
            {
                return "Brimflame";
            }
            if (head.type == ModContent.ItemType<DaedalusHeadMagic>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
            {
                return "DaedalusMagic";
            }
            if (head.type == ModContent.ItemType<DaedalusHeadSummon>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
            {
                return "DaedalusSummon";
            }
            if (head.type == ModContent.ItemType<DaedalusHeadMelee>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
            {
                return "DaedalusMelee";
            }
            if (head.type == ModContent.ItemType<DaedalusHeadRanged>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
            {
                return "DaedalusRanged";
            }
            if (head.type == ModContent.ItemType<DaedalusHeadRogue>() && body.type == ModContent.ItemType<DaedalusBreastplate>() && legs.type == ModContent.ItemType<DaedalusLeggings>())
            {
                return "DaedalusRogue";
            }
            if (head.type == ModContent.ItemType<DemonshadeHelm>() && body.type == ModContent.ItemType<DemonshadeBreastplate>() && legs.type == ModContent.ItemType<DemonshadeGreaves>())
            {
                return "Demonshade";
            }
            if (head.type == ModContent.ItemType<DesertProwlerHat>() && body.type == ModContent.ItemType<DesertProwlerShirt>() && legs.type == ModContent.ItemType<DesertProwlerPants>())
            {
                return "DesertProwler";
            }
            if (head.type == ModContent.ItemType<FathomSwarmerVisage>() && body.type == ModContent.ItemType<FathomSwarmerBreastplate>() && legs.type == ModContent.ItemType<FathomSwarmerBoots>())
            {
                return "FathomSwarmer";
            }
            if (head.type == ModContent.ItemType<FearmongerGreathelm>() && body.type == ModContent.ItemType<FearmongerPlateMail>() && legs.type == ModContent.ItemType<FearmongerGreaves>())
            {
                return "Fearmonger";
            }
            if (head.type == ModContent.ItemType<ForbiddenCirclet>() && body.type == ItemID.AncientBattleArmorShirt && legs.type == ItemID.AncientBattleArmorPants)
            {
                return "AncientForbiddenCirclet";
            }
            if (head.type == ModContent.ItemType<GodSlayerHeadMelee>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
            {
                return "GodSlayerMelee";
            }
            if (head.type == ModContent.ItemType<GodSlayerHeadRanged>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
            {
                return "GodSlayerRanged";
            }
            if (head.type == ModContent.ItemType<GodSlayerHeadRogue>() && body.type == ModContent.ItemType<GodSlayerChestplate>() && legs.type == ModContent.ItemType<GodSlayerLeggings>())
            {
                return "GodSlayerRogue";
            }
            if (head.type == ModContent.ItemType<MolluskShellmet>() && body.type == ModContent.ItemType<MolluskShellplate>() && legs.type == ModContent.ItemType<MolluskShelleggings>())
            {
                return "Mollusk";
            }
            if (head.type == ModContent.ItemType<OmegaBlueHelmet>() && body.type == ModContent.ItemType<OmegaBlueChestplate>() && legs.type == ModContent.ItemType<OmegaBlueTentacles>())
            {
                return "OmegaBlue";
            }
            if (head.type == ModContent.ItemType<PlaguebringerVisor>() && body.type == ModContent.ItemType<PlaguebringerCarapace>() && legs.type == ModContent.ItemType<PlaguebringerPistons>())
            {
                return "Plaguebringer";
            }
            if (head.type == ModContent.ItemType<PlagueReaperMask>() && body.type == ModContent.ItemType<PlagueReaperVest>() && legs.type == ModContent.ItemType<PlagueReaperStriders>())
            {
                return "PlagueReaper";
            }
            if (head.type == ModContent.ItemType<PrismaticHelmet>() && body.type == ModContent.ItemType<PrismaticRegalia>() && legs.type == ModContent.ItemType<PrismaticGreaves>())
            {
                return "Prismatic";
            }
            if (head.type == ModContent.ItemType<ReaverHeadTank>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
            {
                return "ReaverTan";
            }
            if (head.type == ModContent.ItemType<ReaverHeadMobility>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
            {
                return "ReaverMob";
            }
            if (head.type == ModContent.ItemType<ReaverHeadExplore>() && body.type == ModContent.ItemType<ReaverScaleMail>() && legs.type == ModContent.ItemType<ReaverCuisses>())
            {
                return "ReaverExp";
            }
            /*if (head.type == ModContent.ItemType<ShroomiteVisage>() && body.type == ItemID.ShroomiteBreastplate && legs.type == ItemID.ShroomiteLeggings)
            {
                return "ShroomiteVisage";
            }*/
            if (head.type == ModContent.ItemType<SilvaHeadSummon>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
            {
                return "SilvaSummon";
            }
            if (head.type == ModContent.ItemType<SilvaHeadMagic>() && body.type == ModContent.ItemType<SilvaArmor>() && legs.type == ModContent.ItemType<SilvaLeggings>())
            {
                return "SilvaMagic";
            }
            if (head.type == ModContent.ItemType<SnowRuffianMask>() && body.type == ModContent.ItemType<SnowRuffianChestplate>() && legs.type == ModContent.ItemType<SnowRuffianGreaves>())
            {
                return "SnowRuffian";
            }
            if (head.type == ModContent.ItemType<StatigelHeadMagic>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
            {
                return "StatigelMagic";
            }
            if (head.type == ModContent.ItemType<StatigelHeadRanged>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
            {
                return "StatigelRanged";
            }
            if (head.type == ModContent.ItemType<StatigelHeadMelee>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
            {
                return "StatigelMelee";
            }
            if (head.type == ModContent.ItemType<StatigelHeadSummon>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
            {
                return "StatigelSummon";
            }
            if (head.type == ModContent.ItemType<StatigelHeadRogue>() && body.type == ModContent.ItemType<StatigelArmor>() && legs.type == ModContent.ItemType<StatigelGreaves>())
            {
                return "StatigelRogue";
            }
            if (head.type == ModContent.ItemType<SulphurousHelmet>() && body.type == ModContent.ItemType<SulphurousBreastplate>() && legs.type == ModContent.ItemType<SulphurousLeggings>())
            {
                return "Sulphurous";
            }
            if (head.type == ModContent.ItemType<TarragonHeadMelee>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
            {
                return "TarragonMelee";
            }
            if (head.type == ModContent.ItemType<TarragonHeadRogue>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
            {
                return "TarragonRogue";
            }
            if (head.type == ModContent.ItemType<TarragonHeadSummon>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
            {
                return "TarragonSummon";
            }
            if (head.type == ModContent.ItemType<TarragonHeadMagic>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
            {
                return "TarragonMagic";
            }
            if (head.type == ModContent.ItemType<TarragonHeadRanged>() && body.type == ModContent.ItemType<TarragonBreastplate>() && legs.type == ModContent.ItemType<TarragonLeggings>())
            {
                return "TarragonRanged";
            }
            if (head.type == ModContent.ItemType<TitanHeartMask>() && body.type == ModContent.ItemType<TitanHeartMantle>() && legs.type == ModContent.ItemType<TitanHeartBoots>())
            {
                return "TitanHeart";
            }
            if (head.type == ModContent.ItemType<UmbraphileHood>() && body.type == ModContent.ItemType<UmbraphileRegalia>() && legs.type == ModContent.ItemType<UmbraphileBoots>())
            {
                return "Umbraphile";
            }
            if (head.type == ModContent.ItemType<VictideHeadRogue>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
            {
                return "VictideRogue";
            }
            if (head.type == ModContent.ItemType<VictideHeadMelee>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
            {
                return "VictideMelee";
            }
            if (head.type == ModContent.ItemType<VictideHeadSummon>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
            {
                return "VictideSummon";
            }
            if (head.type == ModContent.ItemType<VictideHeadMagic>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
            {
                return "VictideMagic";
            }
            if (head.type == ModContent.ItemType<VictideHeadRanged>() && body.type == ModContent.ItemType<VictideBreastplate>() && legs.type == ModContent.ItemType<VictideGreaves>())
            {
                return "VictideRanged";
            }

            if (head.type == ModContent.ItemType<EmpyreanMask>() && body.type == ModContent.ItemType<EmpyreanCloak>() && legs.type == ModContent.ItemType<EmpyreanCuisses>())
            {
                return "Empyrean";
            }

            if (head.type == ModContent.ItemType<WulfrumHat>() && body.type == ModContent.ItemType<WulfrumJacket>() && legs.type == ModContent.ItemType<WulfrumOveralls>())
            {
                return "Wulfrum";
            }

            #endregion

            
            return "";
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips)
            {
                if (item.type == 3776 || item.type == 3777 || (item.type == 3778 && !CalamityUtils.Calamity(Main.player[Main.myPlayer]).forbiddenCirclet))
                {
                    line.Text = line.Text.Replace("The minion damage nerf is reduced while wielding magic weapons", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Forbidden", Array.Empty<object>()));
                }

                if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<DesertProwlerHat>() && Main.LocalPlayer.armor[1].type == ModContent.ItemType<DesertProwlerShirt>() && Main.LocalPlayer.armor[2].type == ModContent.ItemType<DesertProwlerPants>())
                {
                    line.Text = line.Text.Replace("Sandsmoke Bomb - Double tap DOWN to shroud yourself in a small cloud of sand", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.1", Array.Empty<object>()));
                    line.Text = line.Text.Replace("While the sand cloud is active, gain increased mobility but heavily reduced defense", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.2", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Using a ranged weapon instantly dispels the sand cloak, but guarantees a supercrit for 200% damage\nThe super crit applies only as long as the resulting hit wouldn't exceed 100 damage\nLanding the killing blow on an enemy with this shot shortens the ability's cooldown to 1.5 seconds", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.DesertProwlerEquipped.Tooltip.3", Array.Empty<object>()));
                }
                if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<MarniteArchitectHeadgear>() && Main.LocalPlayer.armor[1].type == ModContent.ItemType<MarniteArchitectToga>())
                {

                    line.Text = line.Text.Replace("Marnite Lift - You can summon a lift under your feet to reach higher up", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.1", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The lift gets summoned when the mount hotkey gets pressed [c/D4C870:without any mounts equipped]", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.2", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Using the Up and Down keys can change the lift's height", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.MarniteArchitectEquipped.Tooltip.3", Array.Empty<object>()));
                }
                if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<WulfrumHat>() && Main.LocalPlayer.armor[1].type == ModContent.ItemType<WulfrumJacket>() && Main.LocalPlayer.armor[2].type == ModContent.ItemType<WulfrumOveralls>())
                {
                    line.Text = line.Text.Replace("Wulfrum Bastion - Double tap DOWN while dismounted to equip wulfrum power armor", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.1", Array.Empty<object>()));
                    line.Text = line.Text.Replace("While the armor is active, you can only use the integrated fusion cannon, but your defensive stats are increased", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.2", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Calling down the armor consumes one piece of wulfrum metal scrap, and the armor will lose durability faster when hit", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.3", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Hold SHIFT to see the stats of the fusion cannon", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.WulfrumEquipped.Tooltip.ArmorItemDisplay", Array.Empty<object>()));
                }
                if (Main.LocalPlayer.armor[0].type == ModContent.ItemType<GemTechHeadgear>() && Main.LocalPlayer.armor[1].type == ModContent.ItemType<GemTechBodyArmor>() && Main.LocalPlayer.armor[2].type == ModContent.ItemType<GemTechSchynbaulds>())
                {

                    line.Text = line.Text.Replace("Power Gems - Six gem fragments idly orbit you; one for each class, and a base gem", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Each active gem provides a bonus for its respective class, while the defensive gem grants defensive boosts\nPowerful enemy hits will dislodge gems, launching them into the nearest enemy for huge damage\nLost gems regenerate after a while\nThe lost gem is the same class as the weapon you are using, so better prepare for some weapon switching action!", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.1", Array.Empty<object>()));
                    line.Text = line.Text.Replace("A gem is lost when you take more than 100 damage in a single hit. The type of gem lost is the same as the class of the previous when you used\nIf said gem has already been lost, the base gem is lost instead\nWhen a gem is lost, it breaks off and homes towards the nearest enemy or boss, if one is present, dealing a base of 40000 damage\nGems have a 30 second delay before they appear again", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.1.IsKeyDown", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The red gem grants 130 maximum stealth, increased rogue stats, and makes stealth only consumable by rogue weapons", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.2", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The yellow gem provides increased melee stats and makes melee attacks release shards on hit with a cooldown. This cooldown is shorter for true melee attacks", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.3", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The green gem provides increased ranged stats and causes flechettes to fly swiftly towards targets when they are damaged by a ranged projectile", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.4", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The blue gem grants 4 extra maximum minions, increased minion damage, and reduces the penalty for summoner items while holding a non-summoner weapon", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.5", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The violet gem grants 100 extra maximum mana, increased magic stats, and makes mana rapidly regenerate when holding a non-magic weapon", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.6", Array.Empty<object>()));
                    line.Text = line.Text.Replace("The pink base gem grants 75 extra defense, extra damage reduction, increased movement speed, jump speed, and +2 life regen", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.7", Array.Empty<object>()));
                    line.Text = line.Text.Replace("When all gems exist simultaneously, hitting a target with any weapon grants you +2 life regen for 8 seconds\nThis is increased to +3 life regen if a weapon of another class is used during that 8 second period for 2.5 seconds", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.8", Array.Empty<object>()));
                    line.Text = line.Text.Replace("Hold SHIFT to see an expanded description", LangHelper.GetTextValue("CalamityMod.Items.SetBonus.GemTechEquipped.Tooltip.ExpandedDisplay", Array.Empty<object>()));
                }
            }
            ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", delegate (TooltipLine tooltip)
            {
                Player player = Main.player[Main.myPlayer];
                if (player.armor[0].type == 401 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 400 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 402 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.AdamantiteRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 372 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 371 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 373 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CobaltRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 377 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 376 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 378 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MythrilRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 102 || (player.armor[0].type == 956 && player.armor[1].type == 101) || (player.armor[1].type == 957 && player.armor[2].type == 100) || player.armor[2].type == 958)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Shadow", Array.Empty<object>());
                }
                if (player.armor[0].type == 803 || (player.armor[0].type == 978 && player.armor[1].type == 804) || (player.armor[1].type == 979 && player.armor[2].type == 805) || player.armor[2].type == 980)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Eskimo", Array.Empty<object>());
                }
                if (player.armor[0].type == 1003 || player.armor[0].type == 1001 || (player.armor[0].type == 1002 && player.armor[1].type == 1004 && player.armor[2].type == 1005))
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Chlorophyte", Array.Empty<object>());
                }
                if (player.armor[0].type == 1503 && player.armor[1].type == 1504 && player.armor[2].type == 1505)
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.SpectreHealing", Array.Empty<object>());
                }
                if (player.armor[0].type == 88 || (player.armor[0].type == 4008 && player.armor[1].type == 410 && player.armor[2].type == 411))
                {
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Mining", Array.Empty<object>());
                }
                int type = item.type;
                if (type <= 955)
                {
                    if (type <= 125)
                    {
                        switch (type)
                        {
                            case 76:
                            case 80:
                            case 89:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Copper", Array.Empty<object>());
                                return;
                            case 77:
                            case 81:
                            case 90:
                                break;
                            case 78:
                            case 82:
                            case 91:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Silver", Array.Empty<object>());
                                return;
                            case 79:
                            case 83:
                            case 92:
                                goto IL_790;
                            case 84:
                            case 85:
                            case 86:
                            case 87:
                            case 88:
                                return;
                            default:
							if (type > 122)
							{
                                if (type - 123 > 2)
                                {
                                    return;
                                }
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Meteor", Array.Empty<object>());
							} 
								return;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case >=231 and <= 233:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Molten", Array.Empty<object>());
                                return;
                            case 687:
                            case 688:
                            case 689:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Tin", Array.Empty<object>());
                                return;
                            case 690:
                            case 691:
                            case 692:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Lead", Array.Empty<object>());
                                return;
                            case 693:
                            case 694:
                            case 695:
                                {
                                    Player localPlayer = Main.LocalPlayer;
                                    float kb = localPlayer.GetWeaponKnockback(CalamityUtils.ActiveItem(localPlayer));
                                    float bonus = MathHelper.Clamp(kb, 0f, 10f);
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Tungsten", new object[]
                                    {
                                       bonus,
                                       kb
                                    });
                                    return;
                                }
                            case 696:
                            case 697:
                            case 698:
                                tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Platinum", Array.Empty<object>());
                                return;
                            default:
                                if (type != 954)
                                {
                                    if (type != 955)
                                    {
                                        return;
                                    }
                                    goto IL_790;
                                }
                                break;
                        }
                    }
                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Iron", Array.Empty<object>());
                    return;
                IL_790:
                    tooltip.Text = tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Gold", Array.Empty<object>());
                    return;
                }
                else if (type <= 3268)
                {
                    if (type >= 3187)
                    {
                        if (type - 3187 <= 2)
                        {
                            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Gladiator", Array.Empty<object>());
                            return;
                        }
                        if (type - 3266 > 2)
                        {
                            return;
                        }
                        tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.Obsidian", Array.Empty<object>());
                        return;
                    }
                }
                else
                {
                    switch (type)
                    {
                        case 3797:
                        case 3798:
                        case 3799:
                            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.ApprenticeTier2", Array.Empty<object>());
                            return;
                        case 3800:
                        case 3801:
                        case 3802:
                            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.SquireTier2", Array.Empty<object>());
                            return;
                        case 3803:
                        case 3804:
                        case 3805:
                            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.HuntressTier2", Array.Empty<object>());
                            return;
                        case 3806:
                        case 3807:
                        case 3808:
                            tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MonkTier2", Array.Empty<object>());
                            return;
                        default:
                            switch (type)
                            {
                                case 3871:
                                case 3872:
                                case 3873:
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.SquireTier3", Array.Empty<object>());
                                    return;
                                case 3874:
                                case 3875:
                                case 3876:
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.ApprenticeTier3", Array.Empty<object>());
                                    return;
                                case 3877:
                                case 3878:
                                case 3879:
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.HuntressTier3", Array.Empty<object>());
                                    return;
                                case 3880:
                                case 3881:
                                case 3882:
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.MonkTier3", Array.Empty<object>());
                                    return;
                                default:
								if (type > 4981 )
								{
                                    if (type - 4982 > 2)
                                    {
                                        return;
                                    }
                                    tooltip.Text = LangHelper.GetTextValue("CalamityMod.Items.SetBonus.Vanilla.CrystalNinja", Array.Empty<object>());
								}  
									break;
                            }
                            break;
                    }
                }
            });
        }
    }
}
