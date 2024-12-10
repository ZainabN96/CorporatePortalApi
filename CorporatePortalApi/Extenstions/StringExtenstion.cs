using System.Runtime.CompilerServices;

namespace CorporatePortalApi.Extenstions
{
    public static class StringExtenstion
    {
        public static bool IsEmpty(this string s)
        {
            return string.IsNullOrEmpty(s.Trim());
        }
    }
}
