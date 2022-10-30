using System;

namespace CalamityCN.LangUtils
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
