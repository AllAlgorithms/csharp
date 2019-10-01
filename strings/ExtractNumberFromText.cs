using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    public static class ExtractNumberFromText
    {
        public static string OnlyNumber(this string str)
        {
            return Regex.Replace(str, "[^0-9]", "");
        }
        public static string OnlyNumber(this string str, string ifEmpty)
        {
            var value = str.OnlyNumber();
            if (string.IsNullOrEmpty(value))
                return ifEmpty;
            else
                return value;
        }
    }
}
