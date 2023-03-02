using System.Text.RegularExpressions;

namespace RailLTD
{
    public class InputUtil
    {
        public static bool MatchInt(string text)
        {
            Regex regex = new Regex("^[0-9]*$");
            return regex.IsMatch(text);
        }

        public static bool MatchRGBInt(string text)
        {
            Regex regex = new Regex("^([01]?[0-9]?[0-9]|2[0-4][0-9]|25[0-5])$");
            return regex.IsMatch(text);
        }
    }
}