using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;
using CalamityMod;
using CalamityMod.Projectiles.Melee;
using CalamityMod.Projectiles.Summon;
using CalamityMod.Systems;
using CalamityMod.NPCs.TownNPCs;
using CalamityMod.CalPlayer;
using CalamityMod.Items.Weapons.Ranged;
using CalamityMod.Items.Potions;
using CalamityMod.Items.Weapons.Magic;
using CalamityMod.Cooldowns;
using CalamityMod.Projectiles.Summon.SmallAresArms;

namespace CalamityCN.Translations.Patch
{
    public class TextPatch
    {
        private static List<ILHook> ILHooksT;
        public static void Load()
        {
            ILHooksT = new List<ILHook>();
            //武器提示
            QuickTranslate(typeof(ArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(TrueArkoftheAncientsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(ArkoftheElementsParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(ArkoftheCosmosParryHoldout), "GeneralParryEffects", "Parry!", "格挡！");
            QuickTranslate(typeof(AtlasMunitionsAutocannonHeld), "AI", "OUCH! HOT!", "我焯！好烫！");
            QuickTranslate(typeof(ExoskeletonPanel), "PreDraw", "Insufficient minion slots!", "召唤栏位不足！");
            //世界加载
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Corrupting a floating island", "正在邪恶化一处空岛");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Partially flooding an overblown desert", "正在淹没部分沙漠");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Building a bigger jungle temple", "正在创建更大的丛林神庙");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Placing the Lihzahrd altar", "正在放置神庙电饭煲");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Reallocating gem deposits to match cavern depth", "正在洞穴深度生成宝石洞穴");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Uncovering the ruins of a fallen empire", "正在令失落帝国的废墟重见天日");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Polluting one of the oceans", "正在污染一个海洋");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Placing hidden shrines", "正在放置特殊神龛");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Rust and Dust", "锈蚀和灰尘");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Discovering the new Challenger Deep", "正在探索更深处的新挑战");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "Further polluting one of the oceans", "正在进一步污染海洋");
            QuickTranslate(typeof(WorldgenManagementSystem), "ModifyWorldGenTasks", "I Wanna Rock", "石头，嘿嘿嘿，我的石头");
            //对话按钮
            QuickTranslate(typeof(THIEF), "SetChatButtons", "Refund", "退款".zh());
            QuickTranslate(typeof(SEAHOE), "SetChatButtons", "Help", "帮助".zh());
            QuickTranslate(typeof(WITCH), "SetChatButtons", "Enchant", "咒术炼注".zh());
            QuickTranslate(typeof(FAP), "SetChatButtons", "Death Count", "死亡次数".zh());
            //死亡信息
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " is food for the Wyrms.", "成为了妖龙的食物。");
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", "Oxygen failed to reach ", "在");
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " from the depths of the Abyss.", "溺亡时肺里没有一丝氧气。");
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " failed the challenge at hand.", "没能逃脱命运之手的操控。");
            QuickTranslate(typeof(CalamityPlayer), "KillPlayer", " was destroyed by a mysterious force.", "被神秘的力量摧毁了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " downed too many shots.", "喝的太多了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s liver failed.", "的肝衰竭了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was charred by the brimstone inferno.", "被硫磺烈焰烧焦了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s soul was released by the lava.", "的灵魂与岩浆融为一体了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s soul was extinguished.", "的灵魂消散了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was melted by the toxic waste.", "被剧毒废物融化了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s ashes scatter in the wind.", "离解成灰。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was turned to ashes by the Profaned Goddess.", "被亵渎之神变成了灰烬。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " fell prey to their sins.", "被自己的罪孽吞噬了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s spirit was turned to ash.", "的灵魂化作了灰烬。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " became a blood geyser.", "血如泉涌。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was crushed by the pressure.", "被压力碾碎了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s lungs collapsed.", "的肺坍缩成了一团。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was consumed by the black flames.", "被漆黑的烈焰燃尽。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s flesh was melted by the plague.", "的血肉被瘟疫所融化。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " didn't vaccinate.", "已无药可医。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s infection spread too far.", "成为了星辉瘟疫的一部分。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s skin was replaced by the astral virus.", "的皮肤被星辉病毒侵蚀了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was incinerated by lunar rays.", "被月之射线焚化了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " vaporized into thin air.", "气化了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", "'s life was completely converted into mana.", "的生命完全升华为了魔力。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " succumbed to alcohol sickness.", "因酗酒痛苦死去。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " withered away.", "凋谢了。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " was summoned too soon.", "没来得及积蓄足够的力量。");
            QuickTranslate(typeof(CalamityPlayer), "PreKill", " lost too much blood.", "失血过多。");
            QuickTranslate(typeof(CalamityPlayer), "OnConsumeMana", " converted all of their life to mana.", "的生命完全升华为了魔力。");
            QuickTranslate(typeof(BloodBoiler), "Shoot", " suffered from severe anemia.", "极度贫血而死。");
            QuickTranslate(typeof(BloodBoiler), "Shoot", " was unable to obtain a blood transfusion.", "没能及时完成输血。");
            QuickTranslate(typeof(AstralInjection), "OnConsumeItem", "'s blood vessels burst from drug overdose.", "的血管由于药物过量爆裂了。");
            QuickTranslate(typeof(ThornBlossom), "Shoot", " was violently pricked by a flower.", "被花上的刺扎死了。");
            //进入世界
            QuickTranslate(typeof(CalamityPlayer), "OnEnterWorld", " [c/EE4939:Be sure to check out the Official Calamity Mod Wiki at ][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] ", " [c/EE4939:官方灾厄维基][c/3989FF:calamitymod.wiki.gg][c/EE4939:!] [c/EE4939:灾厄中文维基][c/3989FF:soammer.com][c/EE4939:!] ");
            //冷却图标
            QuickTranslate(typeof(ChaosState), "get_DisplayName", "Teleportation Cooldown", "传送冷却");
            QuickTranslate(typeof(AquaticHeartIceShield), "get_DisplayName", "Ice Shield Cooldown", "冰盾冷却");
            QuickTranslate(typeof(BloodflareFrenzy), "get_DisplayName", "Blood Frenzy Cooldown", "鲜血狂怒冷却");
            QuickTranslate(typeof(BloodflareRangedSet), "get_DisplayName", "Bloodflare Soul Cooldown", "幽火游魂冷却");
            QuickTranslate(typeof(BrimflameFrenzy), "get_DisplayName", "Brimflame Frenzy Cooldown", "硫火狂怒冷却");
            QuickTranslate(typeof(CounterScarf), "get_DisplayName", "Scarf Cooldown", "围巾冷却");
            QuickTranslate(typeof(DivineBless), "get_DisplayName", "Divine Bless Cooldown", "神圣祝福冷却");
            QuickTranslate(typeof(DivingPlatesBreaking), "get_DisplayName", "Abyssal Diving Suit Plates Durability", "深渊潜游服耐久");
            QuickTranslate(typeof(DivingPlatesBroken), "get_DisplayName", "Abyssal Diving Suit Broken Plates", "深渊潜游服外壳破损");
            QuickTranslate(typeof(CalamityMod.Cooldowns.DraconicElixir), "get_DisplayName", "Draconic Surge Cooldown", "龙魂加持冷却");
            QuickTranslate(typeof(EvasionScarf), "get_DisplayName", "Scarf Cooldown", "围巾冷却");
            QuickTranslate(typeof(FleshTotem), "get_DisplayName", "Contact Damage Halving Cooldown", "接触伤害减半冷却");
            QuickTranslate(typeof(GlobalDodge), "get_DisplayName", "Dodge Cooldown", "闪避冷却");
            QuickTranslate(typeof(GodSlayerDash), "get_DisplayName", "God Slayer Dash Cooldown", "弑神者冲刺冷却");
            QuickTranslate(typeof(InkBomb), "get_DisplayName", "Ink Bomb Cooldown", "墨水炸弹冷却");
            QuickTranslate(typeof(LionHeartShield), "get_DisplayName", "Energy Shell Cooldown", "能量庇护冷却");
            QuickTranslate(typeof(NebulousCore), "get_DisplayName", "Nebulous Core Cooldown", "星云之核冷却");
            QuickTranslate(typeof(OmegaBlue), "get_DisplayName", "Abyssal Madness Cooldown", "深渊狂乱冷却");
            QuickTranslate(typeof(OmegaBlue), "get_DisplayName", "Abyssal Madness", "深渊狂乱");
            QuickTranslate(typeof(PermafrostConcoction), "get_DisplayName", "Permafrost's Concoction Cooldown", "永冻秘药冷却");
            QuickTranslate(typeof(PlagueBlackout), "get_DisplayName", "Plague Blackout Cooldown", "瘟疫爆发冷却");
            QuickTranslate(typeof(PotionSickness), "get_DisplayName", "Healing Cooldown", "治疗冷却");
            QuickTranslate(typeof(PrismaticLaser), "get_DisplayName", "Prismatic Laser Barrage Cooldown", "光棱冷却");
            QuickTranslate(typeof(ProfanedSoulArtifact), "get_DisplayName", "Profaned Soul Artifact Burnout", "渎魂神物灼伤冷却");
            QuickTranslate(typeof(RelicOfResilience), "get_DisplayName", "Relic of Resilience Cooldown", "塑魂冷却");
            QuickTranslate(typeof(RogueBooster), "get_DisplayName", "Rogue Booster Cooldown", "瘟疫染料背包冷却");
            QuickTranslate(typeof(SandCloak), "get_DisplayName", "Sand Cloak Cooldown", "沙尘披风冷却");
            QuickTranslate(typeof(SandsmokeBomb), "get_DisplayName", "Sandsmoke Bomb Cooldown", "沙尘覆盖冷却");
            QuickTranslate(typeof(SandsmokeBomb), "get_DisplayName", "Sandsmoke Bomb Duration", "沙尘覆盖持续时间");
            QuickTranslate(typeof(SilvaRevive), "get_DisplayName", "Silva Revive Cooldown", "始源林海复活冷却");
            QuickTranslate(typeof(TarragonCloak), "get_DisplayName", "Tarragon Cloak Cooldown", "龙蒿披风冷却");
            QuickTranslate(typeof(TarragonImmunity), "get_DisplayName", "Tarragon Immunity Cooldown", "龙蒿无敌冷却");
            QuickTranslate(typeof(UniverseSplitter), "get_DisplayName", "Universe Splitter Cooldown", "渊宇天基炮冷却");
            QuickTranslate(typeof(WulfrumBastion), "get_DisplayName", "Wulfrum Bastion Cooldown", "钨钢转换冷却");
            QuickTranslate(typeof(WulfrumBastion), "get_DisplayName", "Power Armor Durability", "能量护甲耐久");
            QuickTranslate(typeof(WulfrumRoverDriveDurability), "get_DisplayName", "Protective Matrix Durability", "保护矩阵耐久");
            QuickTranslate(typeof(WulfrumRoverDriveRecharge), "get_DisplayName", "Protective Matrix Recharge", "保护矩阵充能");


            //QuickTranslate(typeof(), "", "", "");

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
            type.GetMethod(methodName, (BindingFlags)60 | BindingFlags.Instance),
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
