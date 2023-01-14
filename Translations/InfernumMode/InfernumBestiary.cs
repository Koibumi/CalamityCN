using CalamityCN.Utils;
using InfernumMode.Content.BehaviorOverrides.BossAIs.GreatSandShark;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
    public class Bestiary : GlobalNPC
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
        }
    }
}
