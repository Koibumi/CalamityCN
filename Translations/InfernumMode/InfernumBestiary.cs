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
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("InfernumMode.Bestiary.BereftVassal")));
            }
            if (npc.type == ModContent.NPCType<DepthFeeder>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("InfernumMode.Bestiary.DepthFeeder")));
            }
            if (npc.type == ModContent.NPCType<Herring>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("InfernumMode.Bestiary.Herring")));
            }
            if (npc.type == ModContent.NPCType<LionfishEnemy>())
            {
                bestiaryEntry.Info.RemoveAt(bestiaryEntry.Info.Count - 1);
                bestiaryEntry.Info.Add(new FlavorTextBestiaryInfoElement(LangHelper.GetText("InfernumMode.Bestiary.LionfishEnemy")));
            }
        }
    }
}
