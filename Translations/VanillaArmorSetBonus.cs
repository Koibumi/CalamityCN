using CalamityMod;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityCN.Utils;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace CalamityCN.Translations.TransInHjson
{
    public class VanillaArmorSetBonus : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.Calamity != null && ModsCall.IsCN;
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            ItemHelper.TranslateTooltip(item, tooltips, "SetBonus", delegate (TooltipLine tooltip)
            {
                Player player = Main.player[Main.myPlayer];
                if (player.armor[0].type == 401 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.AdamantiteMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 400 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.AdamantiteCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 402 && player.armor[1].type == 403 && player.armor[2].type == 404)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.AdamantiteRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 372 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.CobaltMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 371 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.CobaltCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 373 && player.armor[1].type == 374 && player.armor[2].type == 375)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.CobaltRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 377 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.MythrilMelee", Array.Empty<object>());
                }
                if (player.armor[0].type == 376 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.MythrilCaster", Array.Empty<object>());
                }
                if (player.armor[0].type == 378 && player.armor[1].type == 379 && player.armor[2].type == 380)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.MythrilRanged", Array.Empty<object>());
                }
                if (player.armor[0].type == 102 || (player.armor[0].type == 956 && player.armor[1].type == 101) || (player.armor[1].type == 957 && player.armor[2].type == 100) || player.armor[2].type == 958)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Shadow", Array.Empty<object>());
                }
                if (player.armor[0].type == 803 || (player.armor[0].type == 978 && player.armor[1].type == 804) || (player.armor[1].type == 979 && player.armor[2].type == 805) || player.armor[2].type == 980)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Eskimo", Array.Empty<object>());
                }
                if (player.armor[0].type == 1003 || player.armor[0].type == 1001 || (player.armor[0].type == 1002 && player.armor[1].type == 1004 && player.armor[2].type == 1005))
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Chlorophyte", Array.Empty<object>());
                }
                if (player.armor[0].type == 1503 && player.armor[1].type == 1504 && player.armor[2].type == 1505)
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SpectreHealing", Array.Empty<object>());
                }
                if (player.armor[0].type == 88 || (player.armor[0].type == 4008 && player.armor[1].type == 410 && player.armor[2].type == 411))
                {
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Mining", Array.Empty<object>());
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
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Copper", Array.Empty<object>());
                                return;
                            case 77:
                            case 81:
                            case 90:
                                break;
                            case 78:
                            case 82:
                            case 91:
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Silver", Array.Empty<object>());
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
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Meteor", Array.Empty<object>());
							} 
								return;
                        }
                    }
                    else
                    {
                        switch (type)
                        {
                            case >= 231 and <= 233:
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Molten", Array.Empty<object>());
                                return;
                            case 687:
                            case 688:
                            case 689:
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Tin", Array.Empty<object>());
                                return;
                            case 690:
                            case 691:
                            case 692:
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Lead", Array.Empty<object>());
                                return;
                            case 693:
                            case 694:
                            case 695:
                                {
                                    Player localPlayer = Main.LocalPlayer;
                                    float kb = localPlayer.GetWeaponKnockback(CalamityUtils.ActiveItem(localPlayer));
                                    float bonus = MathHelper.Clamp(kb, 0f, 10f);
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Tungsten", new object[]
                                    {
                                       bonus,
                                       kb
                                    });
                                    return;
                                }
                            case 696:
                            case 697:
                            case 698:
                                tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Platinum", Array.Empty<object>());
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
                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Iron", Array.Empty<object>());
                    return;
                IL_790:
                    tooltip.Text = tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Gold", Array.Empty<object>());
                    return;
                }
                else if (type <= 3268)
                {
                    if (type >= 3187)
                    {
                        if (type - 3187 <= 2)
                        {
                            tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Gladiator", Array.Empty<object>());
                            return;
                        }
                        if (type - 3266 > 2)
                        {
                            return;
                        }
                        tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.Obsidian", Array.Empty<object>());
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
                            tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.ApprenticeTier2", Array.Empty<object>());
                            return;
                        case 3800:
                        case 3801:
                        case 3802:
                            tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SquireTier2", Array.Empty<object>());
                            return;
                        case 3803:
                        case 3804:
                        case 3805:
                            tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.HuntressTier2", Array.Empty<object>());
                            return;
                        case 3806:
                        case 3807:
                        case 3808:
                            tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.MonkTier2", Array.Empty<object>());
                            return;
                        default:
                            switch (type)
                            {
                                case 3871:
                                case 3872:
                                case 3873:
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.SquireTier3", Array.Empty<object>());
                                    return;
                                case 3874:
                                case 3875:
                                case 3876:
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.ApprenticeTier3", Array.Empty<object>());
                                    return;
                                case 3877:
                                case 3878:
                                case 3879:
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.HuntressTier3", Array.Empty<object>());
                                    return;
                                case 3880:
                                case 3881:
                                case 3882:
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.MonkTier3", Array.Empty<object>());
                                    return;
                                default:
								if (type > 4981 )
								{
                                    if (type - 4982 > 2)
                                    {
                                        return;
                                    }
                                    tooltip.Text = Language.GetTextValue("Mods.CalamityMod.Vanilla.Armor.CrystalNinja", Array.Empty<object>());
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
