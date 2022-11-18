using System;
using System.Reflection;

namespace CalamityCN.Utils
{
    public abstract class OnPatcher
    {
        public virtual bool AutoLoad
        {
            get
            {
                return false;
            }
        }

        public abstract MethodInfo ModifiedMethod { get; }

        public abstract Delegate Delegate { get; }
    }
}
