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
using CalamityMod.Items.Placeables.FurnitureWulfrum;


namespace CalamityCN.Translations
{
    public class ItemGlobalTrans : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.IsCN && ModsCall.Calamity != null;
        }

        //重命名（这个问题怎么山猪还不锈（）
        public override void SetDefaults(Item item)
        {
            if (item.type == ModContent.ItemType<WulfrumWorkbench>())
            {
                item.SetNameOverride("钨钢工作台");
            }
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

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips)
            {
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

                if (item.CountsAsClass(DamageClass.Melee))
                {
                    line.Text = line.Text.Replace("true melee damage", "真近战伤害");
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

                if (Main.zenithWorld)
                {
                    line.Text = line.Text.Replace("盗贼", "盗贱");
                }

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
                    line.Text = line.Text.Replace("Halves flight time when taking a hit", "受击时飞行时间减半");
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
                if (item.type == ItemID.IronskinPotion)
                {
                    line.Text = line.Text.Replace("Increase defense by", "防御力增加");
                }

                #endregion
            }
        }
    }
}
