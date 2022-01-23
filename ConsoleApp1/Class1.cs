using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class MyExtensions
    {
        public static void Print(this DateTime date)
        {
            Console.WriteLine(date);
        }
    }
}
