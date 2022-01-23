using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class RandomDateTime 
    {
        private readonly DateTime border;
        readonly Random gen = new Random();
        private readonly int range;
        private readonly DateTime start;
        public RandomDateTime()
        {
           start = new DateTime(2001, 1, 1);
           border = new DateTime(2003, 12, 12);
           range = (border - start).Days;
        }
        public DateTime Next()
        {
            DateTime dt = start.AddDays(gen.Next(range));
            return dt;
        }
/*        public string Next2()
        {
            string dt = start.AddDays(gen.Next(range)).ToShortDateString();
            return dt;
        }*/
    }
}
