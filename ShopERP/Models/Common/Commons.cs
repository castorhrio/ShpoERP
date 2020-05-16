namespace ShopERP.Models.Common
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="Commons" />.
    /// </summary>
    public class Commons
    {
        /// <summary>
        /// The GetDescription.
        /// </summary>
        /// <param name="en">The en<see cref="Enum"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetDescription(Enum en)
        {
            //获取类型  
            Type type = en.GetType();
            MemberInfo[] memberInfos = type.GetMember(en.ToString());   //获取成员  
            if (memberInfos != null && memberInfos.Length > 0)
            {
                //获取描述特性  
                DescriptionAttribute[] attrs = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description;
                }
            }
            return en.ToString();
        }
    }
}
