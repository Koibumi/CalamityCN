namespace CalamityCN
{
    internal static class CalamityCNUtils
    {
        public static string tc(this string strSimple)
        {
            string strTraditional = Microsoft.VisualBasic.Strings.StrConv(strSimple, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 1033);
            return strTraditional;
        }
        public static string zh(this string strSimple)
        {
            if (CalamityCNConfig.Instance.TSChange)
                return strSimple.tc();
            return strSimple;
        }
    }
}
