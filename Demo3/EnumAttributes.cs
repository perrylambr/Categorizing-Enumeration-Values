using System;

namespace Demo3
{
    internal static partial class Enums
    {
        [AttributeUsage(AttributeTargets.Field)]
        internal class Italian : Attribute { }

        [AttributeUsage(AttributeTargets.Field)]
        internal class Mexican : Attribute { }

        [AttributeUsage(AttributeTargets.Field)]
        internal class Vegetarian : Attribute { }

        [AttributeUsage(AttributeTargets.Field)]
        internal class Supercar : Attribute { }
    }
}
