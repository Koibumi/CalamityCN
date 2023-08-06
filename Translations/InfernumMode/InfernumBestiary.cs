using CalamityCN.Utils;
using InfernumMode.Content.BehaviorOverrides.AbyssAIs;
using InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
    public class InfernumBestiary : GlobalNPC
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCN;
        }

        public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            if (npc.type == ModContent.NPCType<BereftVassal>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("一位警惕的守护者，曾漫无目的地流浪。在得知他的国王还活着后，他似乎已重新燃起了他生存的意志。他期待着再次与你战斗。"));
            }
            if (npc.type == ModContent.NPCType<DepthFeeder>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("即使是在深渊这一极其恶劣的环境中，生态系统仍然有可能蓬勃发展。"));
            }
            if (npc.type == ModContent.NPCType<Herring>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("源于不寻常的顽强，这种生物得以在剧毒的深渊上层的洞穴中繁衍生息。但无论如何，它们仍处于食物链的底端。"));
            }
            if (npc.type == ModContent.NPCType<LionfishEnemy>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement("这些畸形的鱼在它们的自然栖息地很少被捕食，这在很大程度上归功于它们那攻守兼备的毒刺。"));
            }
        }
    }
}
