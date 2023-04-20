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
        [Header("繁简转换")]//需要改
        [Label("将大部分简体转化为繁体（仅包含灾厄本体）")]
        [Tooltip("注意：仅将简体字直接替换为字库中相应的繁体字（为测试功能，已停止维护）\n警告：不支持Mac系统，启用会报错！")]
        [DefaultValue(0)]
        public Systems.zhCNLang Lang;

        [ReloadRequired]
        [Header("炼狱模式部分配置")]
        [Label("标题字体转换")]
        [Tooltip("启用后炼狱模式下BOSS介绍标题字体将使用中文格式\n注意：需要重启游戏！需要启用下方特殊部分才有效！")]
        [DefaultValue(false)]
        public bool InfernumCNFont;

		[ReloadRequired]
        [Label("特殊部分汉化")]
        [Tooltip("默认启用，除非炼狱更新或其他情况不适配了尝试关闭")]
        [DefaultValue(true)]
        public bool InfernumCN;
    }
}
