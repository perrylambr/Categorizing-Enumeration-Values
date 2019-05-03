using System;
using System.Collections.Generic;
using System.Reflection;

namespace Demo3
{
    internal static class Utils
    {
        internal static List<TEnum> GetEnumValues<TEnum, TAttrib>()
            where TEnum : struct, IComparable, IFormattable, IConvertible
            where TAttrib : Attribute
        {
            Type enumType = typeof(TEnum);
            Type attribType = typeof(TAttrib);

            List<TEnum> enumValues = new List<TEnum>();
            foreach (TEnum enumValue in Enum.GetValues(enumType))
            {
                MemberInfo enumValueMemberInfo = enumType.GetMember(enumValue.ToString())[0];
                if (Attribute.IsDefined(enumValueMemberInfo, attribType))
                    enumValues.Add(enumValue);
            }

            return enumValues;
        }
    }
}
