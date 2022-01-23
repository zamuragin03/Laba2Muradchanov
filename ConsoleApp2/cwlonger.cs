using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class StringHelper
    {
        public static string Shorten(this string str, int value)
        {
            return
                value > 3 && str.Length > value ? str.Substring(0, value - 3) + " " : str;
        }
    }
}
