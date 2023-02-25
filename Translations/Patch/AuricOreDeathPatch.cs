using MonoMod.Cil;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using CalamityMod.CalPlayer;
using Terraria.ModLoader;
using CalamityMod.Tiles.Ores;
using CalamityMod.Tiles.Abyss.AbyssAmbient;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using CalamityMod.Buffs.DamageOverTime;
using Terraria.DataStructures;
using Terraria.Audio;

namespace CalamityCN.Translations.Patch
{
    public class AuricOreDeathPatch
    {
        private static Hook temp_AuricOreDeath;

        public static void Load()
        {
            MethodBase auric = typeof(CalamityPlayer).GetMethod("HandleTileEffects", BindingFlags.NonPublic | BindingFlags.Instance);
            temp_AuricOreDeath = new Hook(auric, HandleTileEffects);
            if (temp_AuricOreDeath is not null)
                temp_AuricOreDeath.Apply();

        }
        public static void Unload()
        {

            if (temp_AuricOreDeath is not null)
            {
                temp_AuricOreDeath.Dispose();
                temp_AuricOreDeath = null;
            }
        }

        private delegate void HandleTileEffects_tr(CalamityPlayer calPlayer);
        private static void HandleTileEffects(HandleTileEffects_tr orig, CalamityPlayer calPlayer)
        {
            Player player = calPlayer.Player;
            int num = ModContent.TileType<AstralOre>();
            int num2 = ModContent.TileType<AuricOre>();
            int num3 = ModContent.TileType<ScoriaOre>();
            int num4 = ModContent.TileType<AbyssKelp>();
            int num5 = 300;
            float num6 = player.noKnockback ? 20f : 40f;
            foreach (Point point in Collision.GetEntityEdgeTiles(player, true, true, true, true))
            {
                Tile tile = Main.tile[point];
                if (tile.HasTile && tile.HasUnactuatedTile)
                {
                    if (tile.TileType == num4)
                    {
                        if (player.velocity.Length() == 0f)
                        {
                            break;
                        }
                        Dust dust = Main.dust[Dust.NewDust(player.Center, 16, 16, DustID.Firefly, 0.23255825f, 10f, 0, new Color(117, 55, 15), 1.5116279f)];
                        dust.noGravity = true;
                        dust.noLight = true;
                        dust.fadeIn = 2.5813954f;
                    }
                    if (tile.TileType == num)
                    {
                        player.AddBuff(ModContent.BuffType<AstralInfectionDebuff>(), 2, true, false);
                    }
                    if (tile.TileType == num3 && !player.fireWalk)
                    {
                        player.AddBuff(67, 2, true, false);
                    }
                    else if (tile.TileType == num2 && !calPlayer.auricSet)
                    {
                        player.RemoveAllGrapplingHooks();
                        AuricOre.Animate = true;
                        Vector2 vector = Vector2.Normalize(player.Center - Terraria.Utils.ToWorldCoordinates(point, 8f, 8f));
                        player.velocity += vector * num6;
                        player.Hurt(PlayerDeathReason.ByCustomReason(player.name + "不配。"), num5, 0, false, false, false, -1);
                        player.AddBuff(144, 300, true, false);
                        SoundStyle soundStyle = new SoundStyle("CalamityMod/Sounds/Custom/ExoMechs/TeslaShoot1", 0);
                        SoundEngine.PlaySound(in soundStyle, default(Vector2?));
                    }
                }
            }
        }

    }
}