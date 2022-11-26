using System;
using System.Reflection;
using Terraria.ModLoader;

namespace CalamityCN
{
	public class DisableJIT : PreJITFilter
	{
		public override bool ShouldJIT(MemberInfo member)
		{
			return false;
		}
	}
}
