using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using CalamityMod.Systems;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.CalPlayer;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Potions;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Cooldowns;
using CalamityMod.Projectiles.Summon.SmallAresArms;
using CalamityMod.NPCs.CalClone;
using CalamityMod.NPCs.Ravager;
using CalamityMod.NPCs.Bumblebirb;
using CalamityMod.NPCs.ProfanedGuardians;
using CalamityCN.Utils;
using CalamityMod.Items.LoreItems;
using CalamityMod.NPCs.Providence;

namespace CalamityCN.Translations.Patch {
    public class TextPatch {
        private static List<ILHook> ILHooksT;
        public static void Load() {
            ILHooksT = new List<ILHook>();
            //武器提示
            QuickTranslate(typeof(ExoskeletonPanel), "PreDraw", "Insufficient minion slots!", "召唤栏位不足！".zh());
            //世界加载
            string[][] WMS = new string[][] {
                new string[2]{"Corrupting a floating island", "正在邪恶化一处空岛".zh()},
                new string[2]{"Partially flooding an overblown desert", "正在淹没部分沙漠".zh()},
                new string[2]{"Building a bigger jungle temple", "正在创建更大的丛林神庙".zh()},
                new string[2]{"Placing the Lihzahrd altar", "正在放置神庙电饭煲".zh()},
                new string[2]{"Reallocating gem deposits to match cavern depth", "正在洞穴深度生成宝石洞穴".zh()},
                new string[2]{"Uncovering the ruins of a fallen empire", "正在令失落帝国的废墟重见天日".zh()},
                new string[2]{"Polluting one of the oceans", "正在污染一个海洋".zh()},
                new string[2]{"Placing hidden shrines", "正在放置特殊神龛".zh()},
                new string[2]{"Rust and Dust", "锈蚀和灰尘".zh()},
                new string[2]{"Discovering the new Challenger Deep", "正在探索更深处的新挑战".zh()},
                new string[2]{"Further polluting one of the oceans", "正在进一步污染海洋".zh()},
                new string[2]{"I Wanna Rock", "石头，嘿嘿嘿，我的石头".zh()}

            };
            foreach (string[] il in WMS) {
                if (!il[1].Equals("".zh()))
                {
                    QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", il[0], il[1]);
                }
            }
            //对话按钮
            QuickTranslate(typeof(THIEF), "SetChatButtons", "Refund", "退款".zh());
            QuickTranslate(typeof(SEAHOE), "SetChatButtons", "Help", "帮助".zh());
            QuickTranslate(typeof(WITCH), "SetChatButtons", "Enchant", "咒术炼注".zh());
            QuickTranslate(typeof(FAP), "SetChatButtons", "Death Count", "死亡次数".zh());
            //死亡信息
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " is food for the Wyrms.", "成为了妖龙的食物。".zh());
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", "Oxygen failed to reach ", "在".zh());
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " from the depths of the Abyss.", "溺亡时肺里没有一丝氧气。".zh());
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " failed the challenge at hand.", "没能逃脱命运之手的操控。".zh());
            QuickTranslate(typeof(CalamityPlayer), "UpdateBadLifeRegen", "'s flesh was dissolved by sulphuric water.", "的血肉被硫磺海水溶解了。".zh());

            string[][] CPPK = new string[][] {
            new string[2]{" downed too many shots.", "喝的太多了。".zh()},
            new string[2]{"'s liver failed.", "的肝衰竭了。".zh()},
            new string[2]{" was charred by the brimstone inferno.", "被硫磺烈焰烧焦了。".zh()},
            new string[2]{"'s soul was released by the lava.", "的灵魂与岩浆融为一体了。".zh()},
            new string[2]{"'s soul was extinguished.", "的灵魂消散了。".zh()},
            new string[2]{" was melted by the toxic waste.", "被剧毒废物融化了。".zh()},
            new string[2]{"'s ashes scatter in the wind.", "离解成灰。".zh()},
            new string[2]{" was turned to ashes by the Profaned Goddess.", "被亵渎之神变成了灰烬。".zh()},
            new string[2]{" fell prey to their sins.", "被自己的罪孽吞噬了。".zh()},
            new string[2]{"'s spirit was turned to ash.", "的灵魂化作了灰烬。".zh()},
            new string[2]{" became a blood geyser.", "血如泉涌。".zh()},
            new string[2]{" was crushed by the pressure.", "被压力碾碎了。".zh()},
            new string[2]{"'s lungs collapsed.", "的肺坍缩成了一团。".zh()},
            new string[2]{" was consumed by the black flames.", "被漆黑的烈焰燃尽。".zh()},
            new string[2]{"'s flesh was melted by the plague.", "的血肉被瘟疫所融化。".zh()},
            new string[2]{" didn't vaccinate.", "已无药可医。".zh()},
            new string[2]{"'s infection spread too far.", "成为了星辉瘟疫的一部分。".zh()},
            new string[2]{"'s skin was replaced by the astral virus.", "的皮肤被星辉病毒侵蚀了。".zh()},
            new string[2]{" was incinerated by lunar rays.", "被月之射线焚化了。".zh()},
            new string[2]{" vaporized into thin air.", "气化了。".zh()},
            new string[2]{"'s life was completely converted into mana.", "的生命完全升华为了魔力。".zh()},
            new string[2]{" succumbed to alcohol sickness.", "因酗酒痛苦死去。".zh()},
            new string[2]{" withered away.", "凋谢了。".zh()},
            new string[2]{" was summoned too soon.", "没来得及积蓄足够的力量。".zh()},
            new string[2]{" lost too much blood.", "失血过多。".zh()},
            new string[2]{" was blown away by miraculous technological advancements.", "被奇迹般的科技进步扫进了历史的垃圾堆。".zh()},
            new string[2]{" disintegrated from the overpowering exotic resonance.", "与星流能量共振而塌缩了。".zh()}
            };
            foreach (string[] il in CPPK) {
                if (!il[1].Equals(""))
                {
                    QuickTranslate(typeof(CalamityPlayer), "PreKill", il[0], il[1]);
                }
            }
            QuickTranslate(typeof(CalamityPlayer), "OnConsumeMana", " converted all of their life to mana.", "的生命完全升华为了魔力。".zh());
            QuickTranslate(typeof(BloodBoiler), "Shoot", " suffered from severe anemia.", "极度贫血而死。".zh());
            QuickTranslate(typeof(BloodBoiler), "Shoot", " was unable to obtain a blood transfusion.", "没能及时完成输血。".zh());
            QuickTranslate(typeof(AstralInjection), "OnConsumeItem", "'s blood vessels burst from drug overdose.", "的血管由于药物过量爆裂了。".zh());
            QuickTranslate(typeof(ThornBlossom), "Shoot", " was violently pricked by a flower.", "被花上的刺扎死了。".zh());
            QuickTranslate(typeof(ProvUtils), "ApplyHitEffects", " burst into sinless ash.", "化为无罪的灰烬。".zh());

            //进入世界
            QuickTranslate(typeof(CalamityPlayer), "OnEnterWorld", " [c/EE4939:Note: The Fandom wiki is no longer supported by Calamity.] ", " [c/EE4939:备注：灾厄已不再支持Fandom Wiki。] ".zh());
            QuickTranslate(typeof(CalamityPlayer), "OnEnterWorld", " [c/EE4939:Check out the Official Calamity Mod Wiki at ][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] ", " [c/EE4939:官方灾厄维基][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] [c/EE4939:灾厄中文维基][c/3989FF:soammer.com][c/EE4939:!] ".zh());
            //冷却图标
            QuickTranslate(typeof(ChaosState), "get_DisplayName", "Teleportation Cooldown", "传送冷却".zh());
            QuickTranslate(typeof(AquaticHeartIceShield), "get_DisplayName", "Ice Shield Cooldown", "冰盾冷却".zh());
            QuickTranslate(typeof(BloodflareFrenzy), "get_DisplayName", "Blood Frenzy Cooldown", "鲜血狂怒冷却".zh());
            QuickTranslate(typeof(BloodflareRangedSet), "get_DisplayName", "Bloodflare Soul Cooldown", "幽火游魂冷却".zh());
            QuickTranslate(typeof(BrimflameFrenzy), "get_DisplayName", "Brimflame Frenzy Cooldown", "硫火狂怒冷却".zh());
            QuickTranslate(typeof(CounterScarf), "get_DisplayName", "Scarf Cooldown", "围巾冷却".zh());
            QuickTranslate(typeof(DivineBless), "get_DisplayName", "Divine Bless Cooldown", "神圣祝福冷却".zh());
            QuickTranslate(typeof(DivingPlatesBreaking), "get_DisplayName", "Abyssal Diving Suit Plates Durability", "深渊潜游服耐久".zh());
            QuickTranslate(typeof(DivingPlatesBroken), "get_DisplayName", "Abyssal Diving Suit Broken Plates", "深渊潜游服外壳破损".zh());
            QuickTranslate(typeof(EvasionScarf), "get_DisplayName", "Scarf Cooldown", "围巾冷却".zh());
            QuickTranslate(typeof(FleshTotem), "get_DisplayName", "Contact Damage Halving Cooldown", "接触伤害减半冷却".zh());
            QuickTranslate(typeof(GlobalDodge), "get_DisplayName", "Dodge Cooldown", "闪避冷却".zh());
            QuickTranslate(typeof(GodSlayerDash), "get_DisplayName", "God Slayer Dash Cooldown", "弑神者冲刺冷却".zh());
            QuickTranslate(typeof(InkBomb), "get_DisplayName", "Ink Bomb Cooldown", "墨水炸弹冷却".zh());
            QuickTranslate(typeof(LionHeartShield), "get_DisplayName", "Energy Shell Cooldown", "能量庇护冷却".zh());
            QuickTranslate(typeof(NebulousCore), "get_DisplayName", "Nebulous Core Cooldown", "星云之核冷却".zh());
            QuickTranslate(typeof(OmegaBlue), "get_DisplayName", "Abyssal Madness Cooldown", "深渊狂乱冷却".zh());
            QuickTranslate(typeof(OmegaBlue), "get_DisplayName", "Abyssal Madness", "深渊狂乱".zh());
            QuickTranslate(typeof(PermafrostConcoction), "get_DisplayName", "Permafrost's Concoction Cooldown", "永冻秘药冷却".zh());
            QuickTranslate(typeof(PlagueBlackout), "get_DisplayName", "Plague Blackout Cooldown", "瘟疫爆发冷却".zh());
            QuickTranslate(typeof(PotionSickness), "get_DisplayName", "Healing Cooldown", "治疗冷却".zh());
            QuickTranslate(typeof(PrismaticLaser), "get_DisplayName", "Prismatic Laser Barrage Cooldown", "光棱冷却".zh());
            QuickTranslate(typeof(ProfanedSoulArtifact), "get_DisplayName", "Profaned Soul Artifact Burnout", "渎魂神物灼伤冷却".zh());
            QuickTranslate(typeof(RelicOfResilience), "get_DisplayName", "Relic of Resilience Cooldown", "塑魂冷却".zh());
            QuickTranslate(typeof(RogueBooster), "get_DisplayName", "Rogue Booster Cooldown", "瘟疫染料背包冷却".zh());
            QuickTranslate(typeof(SandCloak), "get_DisplayName", "Sand Cloak Cooldown", "沙尘披风冷却".zh());
            QuickTranslate(typeof(SandsmokeBomb), "get_DisplayName", "Sandsmoke Bomb Cooldown", "沙尘覆盖冷却".zh());
            QuickTranslate(typeof(SandsmokeBomb), "get_DisplayName", "Sandsmoke Bomb Duration", "沙尘覆盖持续时间".zh());
            QuickTranslate(typeof(SilvaRevive), "get_DisplayName", "Silva Revive Cooldown", "始源林海复活冷却".zh());
            QuickTranslate(typeof(TarragonCloak), "get_DisplayName", "Tarragon Cloak Cooldown", "龙蒿披风冷却".zh());
            QuickTranslate(typeof(TarragonImmunity), "get_DisplayName", "Tarragon Immunity Cooldown", "龙蒿无敌冷却".zh());
            QuickTranslate(typeof(UniverseSplitter), "get_DisplayName", "Universe Splitter Cooldown", "渊宇天基炮冷却".zh());
            QuickTranslate(typeof(WulfrumBastion), "get_DisplayName", "Wulfrum Bastion Cooldown", "钨钢转换冷却".zh());
            QuickTranslate(typeof(WulfrumBastion), "get_DisplayName", "Power Armor Durability", "能量护甲耐久".zh());
            QuickTranslate(typeof(WulfrumRoverDriveDurability), "get_DisplayName", "Protective Matrix Durability", "保护矩阵耐久".zh());
            QuickTranslate(typeof(WulfrumRoverDriveRecharge), "get_DisplayName", "Protective Matrix Recharge", "保护矩阵充能".zh());
            //死亡名称
            QuickTranslate(typeof(CalamitasClone), "BossLoot", "The Calamitas Clone", "灾厄之影".zh());
            QuickTranslate(typeof(RavagerBody), "BossLoot", "Ravager", "毁灭魔像".zh());
            QuickTranslate(typeof(Bumblefuck), "BossLoot", "A Dragonfolly", "痴愚金龙".zh());
            QuickTranslate(typeof(ProfanedGuardianCommander), "BossLoot", "A Profaned Guardian", "亵渎守卫".zh());
            QuickTranslate(typeof(ProfanedGuardianDefender), "BossLoot", "A Profaned Guardian", "亵渎守卫".zh());
            QuickTranslate(typeof(ProfanedGuardianHealer), "BossLoot", "A Profaned Guardian", "亵渎守卫".zh());

            //QuickTranslate(typeof(), "", "", "".zh());

            foreach (ILHook hook in ILHooksT)
            {
                if (hook is not null)
                    hook.Apply();
            }
        }
            public static void Unload()
            {
                foreach (ILHook hook in ILHooksT)
                {
                    if (hook is not null)
                        hook.Dispose();
                }
                ILHooksT = null;
            }
        private static void QuickTranslate(Type type, string methodName, string origin, string trans)
        {
            ILHooksT.Add(new ILHook(
            type.GetCachedMethod(methodName),
            new ILContext.Manipulator(il =>
            {
                var cursor = new ILCursor(il);
                if (!cursor.TryGotoNext(i => i.MatchLdstr(origin)))
                    return;
                cursor.Index++;
                cursor.EmitDelegate<Func<string, string>>((eng) => trans);
            })));
        }
    }
}
