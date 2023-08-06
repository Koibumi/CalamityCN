using System;

namespace CalamityCN.Utils
{
	public class ContentTranslation
	{
		public virtual bool IsTranslationEnabled
		{
			get
			{
				return false;
			}
		}

		public virtual float Priority
		{
			get
			{
				return 1f;
			}
		}
	}
}
