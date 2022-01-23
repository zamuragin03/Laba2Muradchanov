using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;

namespace ConsoleApp2
{
    class Student
    {
        public static void Filer()
        {
            using StreamWriter temp = new StreamWriter("result.txt");
            foreach (var str in studentlist/*.Select(item => item.MiddleName)*/)
            {
                temp.WriteLine(str);
            }
            Console.WriteLine("Все успешно сохранено в новый файл result.txt");

        }
        public override string ToString()
        {
            return $"{Count.Shorten(20),-3} {FirstName.Shorten(20),-13} {SecondName.Shorten(20),-13} {MiddleName.Shorten(20),-13}\t {Id.ToString().Shorten(20),-13}\t {BirthDate.ToShortDateString()}\t {Group}\t {Institite}\t {Course}      {AvgMark}\t {EduForm.Shorten(20),-13}     {Level}            {DebtCount}";
        }
        public static Random rnd = new Random();
        /*public static int StudentCount = rnd.Next(20);*/
        public static string StudentCount;
        public static List<Student> studentlist = new List<Student>();
        public string Count { get; set; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string MiddleName { set; get; }
        public string Id { set; get; }
        public DateTime BirthDate { set; get; }
        public string Institite { set; get; }
        public string Group { set; get; }
        public int Course { set; get; }
        public int AvgMark { set; get; }
        public string EduForm { set; get; }
        public string Level { set; get; }
        public int DebtCount { set; get; }

    }
}
