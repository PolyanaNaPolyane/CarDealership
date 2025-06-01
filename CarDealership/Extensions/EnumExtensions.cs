using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            var displayAttr = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
            return displayAttr?.Name ?? enumValue.ToString();
        }
    }
}
