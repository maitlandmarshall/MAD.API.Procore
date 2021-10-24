using Humanizer;

namespace MAD.API.Procore.Gen
{
    public static class StringExtensions
    {
        public static string CleanForCode(this string name)
        {
            return name.Replace("/", "")
                .Replace("filters[", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Replace("\n", "")
                .Replace("\r", "")
                .Replace("!", "")
                .Replace("@", "")
                .Replace("#", "")
                .Replace("$", "")
                .Replace("%", "")
                .Replace("^", "")
                .Replace("&", "")
                .Replace("*", "")
                .Replace("[", "")
                .Replace("]", "")
                .Replace("-", "")
                .Replace(".", "")
                .Replace("+", "")
                .Replace("'", "")
                .Replace("\"", "")
                .Pascalize();
        }
    }
}
