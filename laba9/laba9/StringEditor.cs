using System.Text.RegularExpressions;

namespace laba9
{
    static class StringEditor
    {
        public static string DeleteSpaces(string str)
        {
            return str.Replace(" ", "");
        }
        public static string DeleteSigns(string str)
        {
            return Regex.Replace(str, "[,!?]", "");
        }
        public static string FirstLetterToUpper(string str)
        {
            return str.Substring(0,1).ToUpper()+ str.Substring(1).ToLower();
        }
        public static string AddExclamation(string str)
                {
            return str + '!';
                }
        public static string AddSubstring(string str)
            {
            return "I like " + str;
            }
}
}
