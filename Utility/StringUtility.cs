using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShopBridgeAPI.Utility
{
    public static class StringUtility
    {
        // IsAlphaNumberic validates a alphanumeric string.
        public static bool IsAlphaNumberic(string data)
        {
            Regex rAlphaNum = new Regex("^[a-zA-Z0-9]*$");
            return rAlphaNum.IsMatch(data);
        }

        // IsAlphaNumbericWithSpaceSpecialChar validates a alphanumeric string with space and special characters.
        public static bool IsAlphaNumbericWithSpaceSpecialChar(string data)
        {
            Regex rAlphabet = new Regex(@"^[a-zA-Z0-9\s,-]*$");
            return rAlphabet.IsMatch(data);
        }
    }
}