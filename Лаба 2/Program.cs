using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Лаба_2
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
    class Student
    {
        public static string[] list = new string[100];
        public int id;
        public static Random rnd = new Random();
        public string FullName;
        public string BirthDate;
        public string Institute;
        public string group;
        public int course;
        public double Avg;

        public static string GetBirthDate()
        {
            int[] year = new int[list.Length];
            int[] month = new int[list.Length];
            int[] day = new int[list.Length];
            string[] Date = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                year[i] = Student.rnd.Next(2001, 2004);
                month[i] = Student.rnd.Next(1, 13);
                day[i] = Student.rnd.Next(1, 30);
                Date[i] = Convert.ToString(year[i]) + "." + Convert.ToString(month[i]) + "." + Convert.ToString(day[i]);
                list[i] = Convert.ToString(list[i]) +"   " + Convert.ToString(Date[i]);
            }
            return list[list.Length - 1];
        }
        public static string GetFullName()
        {
            string[] line1 = File.ReadAllLines("Names.txt");

            for (int i = 0; i < list.Length; i++)
            {
                if (line1[i] == "")
                {
                    list[i] = "Нет данных ";
                }
                else
                list[i] = line1[i];
            }
            return list[list.Length-1];
        }
        public static string GetGroup()
        {
            int[] group = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                group[i] = Student.rnd.Next(1,4);
                switch (group[i])
                {
                    case 1:
                        list[i] =list[i]+ "    БИВТ-21-" + Student.rnd.Next(1,20);
                        break;
                    case 2:
                        list[i] = list[i] + "    БПИ-" + Student.rnd.Next(1, 20);
                        break;
                    case 3:
                        list[i] = list[i] + "    БПМ-" + Student.rnd.Next(1, 20);
                        break;
                    default:
                        return null;
                }
            }
            return list[list.Length - 1];
        }
        public static string GetCourse()
        {
            int[] course = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = list[i] +"  " + Student.rnd.Next(1, 5);
            } 
            return list[list.Length - 1];

        }
        public static string GetInstitute()
        {
            int[] vuz = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                vuz[i] = Student.rnd.Next(1, 4);
                switch (vuz[i])
                {
                    case 1:
                        list[i] = list[i] + "    МГУ";
                        break;
                    case 2:
                        list[i] = list[i] + "    МФТИ";
                        break;
                    case 3:
                        list[i] = list[i] + "    МИСИС";
                        break;
                    default:
                        return null;
                }
            }
            return list[list.Length - 1];
        }
        public static void Print()
        {
            Console.WriteLine("Фамилия Имя Отчество \t\t Дата рождения\t\t Институт");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 60;
            Console.WindowWidth = 200;

            Student firstStudent = new Student();
            firstStudent.FullName = Student.GetFullName();
            firstStudent.BirthDate = Student.GetBirthDate();
            firstStudent.Institute = Student.GetInstitute();
            firstStudent.Institute = Student.GetGroup();
            firstStudent.Institute = Student.GetCourse();
            Student.Print();
            Console.ReadKey();
        }
    }
}
