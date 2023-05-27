using System;
using System.Reflection;
using CalamityCN.Utils;
using InfernumMode;
using ReLogic.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityCN.Translations.InfernumMode
{
    public class AchivementBossNamePatch : OnPatcher
    {
        public override bool AutoLoad
        {
            get
            {
                return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN && CalamityCNConfig.Instance.InfernumCN;
            }
        }

        public override MethodInfo ModifiedMethod
        {
            get
            {
                return typeof(Utilities).GetCachedMethod("GetNPCFullNameFromID");
            }
        }

        public override Delegate Delegate
        {
            get
            {
                return new Func<GetNPCFullNameFromIDDelegate, int, string>(this.GetNPCFullNameFromID);
            }
        }

        private string GetNPCFullNameFromID(GetNPCFullNameFromIDDelegate orig, int id)
        {
            if (id >= NPCID.Count)
            {
                return NPCLoader.GetNPC(id).DisplayName.GetTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese));
            }
            return NPC.GetFullnameByID(id);
        }

        private delegate string GetNPCFullNameFromIDDelegate(int id);
    }
}
