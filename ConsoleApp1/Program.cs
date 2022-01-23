using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class RandomDateTime
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
        static List<Student> studentlist = new List<Student>();
        static int groupyear = 20;
        public static Random rnd = new Random();
        static public void Main(string[] args)
        {

            Console.WindowHeight = 50;
            Console.WindowHeight = 60;
            Console.WindowWidth = 200;
            for (int i = 0; i < rnd.Next(30, 50); i++)
            {
                studentlist.Add(new Student()
                {
                    FullName = Student.GetFullname(),
                    BirthDate = Student.GetDate(),
                    Group = Student.GetGroup(groupyear),
                    Course = 1,
                    Avg = Student.GetAvg(),
                });
            }
            foreach (var item in studentlist)
            {
                Console.WriteLine($"{item,3} \n");
            }
            Console.ReadKey();
        }
    }
    public class Student
    {

        public static string GetFullname()
        {
            string[] line = File.ReadAllLines("Names.txt");
            return line[rnd.Next(line.Length)];
        }
        public static RandomDateTime GetDate()
        {
            RandomDateTime BirthDate = new RandomDateTime();
            RandomDateTime Birth = BirthDate.Next();
            return BirthDate;
        }
        public static string GetGroup(int Year)
        {
            int i = rnd.Next(1, 4);

            switch (i)
            {
                case 2:
                    return "БИСТ-" + Convert.ToString(Year);
                case 1:
                    return "БИВТ-" + Convert.ToString(Year);
                case 3:
                    return "БПИ-" + Convert.ToString(Year);
                default:
                    return null;
            };
        }
        public static int GetAvg()
        {
            return rnd.Next(200, 300);
        }
        public static Random rnd = new Random();
        public string FullName { set; get; }
        public int id { set; get; }
        public RandomDateTime BirthDate { set; get; }
        public string Institute { set; get; }
        public string Group { set; get; }
        public int Course{ set; get; }
        public double Avg { set; get; }
        public override string ToString()

        {
            return FullName + "\t" + id + "\t" + BirthDate + "\t" + Course  + "\tГруппа: "
                + Group + "\t Курс" + Course + "|\t| Средний балл: " + Avg;
        }

    }
}
