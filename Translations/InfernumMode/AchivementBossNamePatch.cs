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
                return ModsCall.Infernum != null && ModsCall.Calamity != null && ModsCall.IsCN;
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
            if (id < NPCID.Count)
            {
                return id switch
                {
                    NPCID.Spazmatism => "双子魔眼",
                    NPCID.MoonLordCore => "月亮领主",
                    _ => NPC.GetFullnameByID(id)
                };
            }

            return NPCLoader.GetNPC(id).DisplayName.GetDefault() switch
            {
                "Guardian Commander" => "亵渎守卫",
                _ => NPCLoader.GetNPC(id).DisplayName.GetTranslation((int)GameCulture.CultureName.Chinese)
            };
        }

        private delegate string GetNPCFullNameFromIDDelegate(int id);
    }
}
