using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2003, 11, 08);
            
            Console.WriteLine(dt.ToShortDateString());
        }
    }
}
