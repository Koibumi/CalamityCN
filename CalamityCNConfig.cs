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

        [ReloadRequired]
        [Header("繁简转换")]
        [Label("使用繁体显示")]
        [Tooltip("注意：仅将简体字直接替换为字库中相应的繁体字（为测试功能，已停止维护）\n警告：不支持Mac系统，启用会报错！")]
        [DefaultValue(false)]
        public bool TSChange;

        [ReloadRequired]
        [Header("炼狱模式部分配置")]
        [Label("字体转换")]
        [Tooltip("启用后炼狱模式下BOSS介绍标题字体将使用中文格式（部分翻译未完成）\n注意：需要重启游戏，强制重载可能有Bug！")]
        [DefaultValue(false)]
        public bool InfernumCNFont;

        [Label("汉化开关")]
        [Tooltip("默认启用，除非炼狱更新又不适配了应急关闭")]
        [DefaultValue(true)]
        public bool InfernumCN;
    }
}
