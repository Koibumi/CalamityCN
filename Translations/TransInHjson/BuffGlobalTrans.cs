using CalamityCN.Utils;
using CalamityMod;
using CalamityMod.Buffs.StatBuffs;
using CalamityMod.Buffs.Summon;
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Translations.TransInHjson {
    public class BuffGlobalTrans : GlobalBuff {
        public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare) {
            string text = "";
            if (type == ModContent.BuffType<BossEffects>()) {
                text = LangHelper.GetTextValue(CalamityConfig.Instance.BossZen ? "CalamityMod.Buffs.BossEffects.Description.BossZen" : "CalamityMod.Buffs.BossEffects.Description", Array.Empty<object>());
            }

            if (type == ModContent.BuffType<ProfanedBabs>()) {
                text = ((tip == "The Profaned Babs will accompany you!") ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedBabs.Description", Array.Empty<object>()) : text);
            }

            if (type == ModContent.BuffType<ProfanedCrystalBuff>()) {
                Player player = Main.player[Main.myPlayer];
                if (player.Calamity().profanedCrystalBuffs) {
                    if (player.Calamity().endoCooper) {
                        tip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.1", Array.Empty<object>());
                        return;
                    }
                    if (player.Calamity().magicHat) {
                        tip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.2", Array.Empty<object>());
                        return;
                    }
                    bool offense = (Main.dayTime && !player.wet) || player.lavaWet;
                    bool enrage = player.statLife <= (int)((double)player.statLifeMax2 * 0.5);
                    tip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.3", Array.Empty<object>()) + (offense ? ((Main.dayTime ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.4", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.5", Array.Empty<object>())) + LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.6", Array.Empty<object>())) : ((player.wet ? (player.honeyWet ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.7", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.8", Array.Empty<object>())) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.9", Array.Empty<object>())) + LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.10", Array.Empty<object>()))) + (enrage ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.11", Array.Empty<object>()) : "");
                    return;
                } else {
                    if (DownedBossSystem.downedCalamitas && DownedBossSystem.downedExoMechs) {
                        tip = LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.12", Array.Empty<object>());
                        return;
                    }
                    tip = ((!DownedBossSystem.downedExoMechs) ? LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.13", Array.Empty<object>()) : LangHelper.GetTextValue("CalamityMod.Buffs.ProfanedCrystalBuff.Description.14", Array.Empty<object>()));
                    return;
                }
            }

            if (type <= 62) {
                if (type <= 26) {
                    switch (type) {
                        case 3:
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Swiftness.Description", Array.Empty<object>());
                            break;
                        case 4:
                        case 6:
                            break;
                        case 5:
                            tip = tip.Replace("Increase defense by ", LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Defense.Description", Array.Empty<object>()));
                            break;
                        case 7:
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.MagicPower.Description", Array.Empty<object>());
                            break;
                        default:
                            if (type == 16) {
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Archery.Description", Array.Empty<object>());
                                break;
                            }
                            break;
                    }
                } else if (type != 26) {
                    if (type != 39) {
                        if (type == 60) {
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Emits.Description", Array.Empty<object>());
                        }
                        if (type == 62) {
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.IceBarrier.Description", Array.Empty<object>());
                        }
                    } else {
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.CursedInferno.Description", Array.Empty<object>());
                    }
                } else {
                    text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedS.Description", Array.Empty<object>());
                }
            } else if (type <= 114) {
                switch (type) {
                    case 71:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueVenom.Description", Array.Empty<object>());
                        break;
                    case 72:
                        break;
                    case 73:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueCursedFlames.Description", Array.Empty<object>());
                        break;
                    case 74:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueFire.Description", Array.Empty<object>());
                        break;
                    case 75:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueGold.Description", Array.Empty<object>());
                        break;
                    case 76:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueIchor.Description", Array.Empty<object>());
                        break;
                    case 77:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueNanites.Description", Array.Empty<object>());
                        break;
                    case 78:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbueConfetti.Description", Array.Empty<object>());
                        break;
                    case 79:
                        text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WeaponImbuePoison.Description", Array.Empty<object>());
                        break;
                    default:
                        switch (type) {
                            case 88:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.ChaosState.Description", Array.Empty<object>());
                                break;
                            case 89:
                            case 90:
                            case 91:
                            case 92:
                            case 93:
                            case 94:
                                break;
                            case 95:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance1.Description", Array.Empty<object>());
                                break;
                            case 96:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance2.Description", Array.Empty<object>());
                                break;
                            case 97:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleEndurance3.Description", Array.Empty<object>());
                                break;
                            case 98:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight1.Description", Array.Empty<object>());
                                break;
                            case 99:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight2.Description", Array.Empty<object>());
                                break;
                            case 100:
                                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.BeetleMight3.Description", Array.Empty<object>());
                                break;
                            default:
                                if (type == 114) {
                                    text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Endurance.Description", Array.Empty<object>());
                                }
                                break;
                        }
                        break;
                }
            } else if (type <= 181) {
                if (type != 124) {
                    switch (type) {
                        case 179:
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg1.Description", Array.Empty<object>());
                            break;
                        case 180:
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg2.Description", Array.Empty<object>());
                            break;
                        case 181:
                            text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.NebulaUpDmg3.Description", Array.Empty<object>());
                            break;
                    }
                } else {
                    text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.Warmth.Description", Array.Empty<object>());
                }
            } else if (type == 192) {
                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.SugarRush.Description", Array.Empty<object>());
            } else if (type == 206) {
                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedM.Description", Array.Empty<object>());
            } else if (type == 207) {
                text = LangHelper.GetTextValue("CalamityMod.Buffs.Vanilla.WellFedL.Description", Array.Empty<object>());
            }
            if (!text.Equals("")) {
                tip = text;
            }
        }

        public override bool IsLoadingEnabled(Mod mod) {
            return ModsCall.IsCN && ModsCall.Calamity != null;
        }

    }

}
