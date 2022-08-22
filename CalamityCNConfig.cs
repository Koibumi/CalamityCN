using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CalamityCN
{
    [Label("汉化补丁设置")]
    public class CalamityCNConfig : ModConfig
    {
        public static CalamityCNConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded()
        {
            Instance = this;
        }

        // 繁简转换
        [ReloadRequired]
        [Header("繁简转换")]

        [Label("使用繁体显示")]
        [Tooltip("注意：仅仅是将简体字直接替换为字库中相应的繁体字，可能产生语义不通问题，仅为测试功能")]
        [DefaultValue(false)]
        public bool TSChange;
    }
}
