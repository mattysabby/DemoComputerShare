using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoComputerShare
{
    public static class EnumHelper<T>
    {
        public static string GetEnumDescription(string value)
        {
            Type type = typeof(T);
            var name = Enum.GetNames(type).Where(f => f.Equals(value, StringComparison.CurrentCultureIgnoreCase)).Select(d => d).FirstOrDefault();

            if (name == null)
            {
                return string.Empty;
            }
            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return customAttribute.Length > 0 ? ((DescriptionAttribute)customAttribute[0]).Description : name;
        }

        public static Y GetAttribute<Y>(Enum enumValue) where Y : Attribute
        {
            Y attribute;

            MemberInfo memberInfo = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();

            if (memberInfo != null)
            {
                attribute = (Y)memberInfo.GetCustomAttributes(typeof(Y), false).FirstOrDefault();
                return attribute;
            }
            return null;
        }
    }
}
