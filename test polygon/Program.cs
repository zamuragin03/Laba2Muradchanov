using System;

namespace test_polygon
{
    class RandomDateTime
    {
        DateTime start;
        DateTime border;
        Random gen;
        int range;

        public RandomDateTime()
        {
            start = new DateTime(2001, 1, 1);
            border = new DateTime(2003, 12, 12);
            gen = new Random();
            range = (border - start).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range));
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            RandomDateTime date = new RandomDateTime();
            Console.WriteLine(date.Next().ToShortDateString());
        }
    }
}
