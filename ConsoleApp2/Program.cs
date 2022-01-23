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
    static class Program
    {
        public static List<Student> studentlist = new List<Student>();
        public static void Abilities()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                            $"\t{ConsoleKey.S}\t\t Для нахождения студента по дате рождения  \n" +
                            $"\t{ConsoleKey.NumPad0}\t\t Для вывода минимального балла\n" +
                            $"\t{ConsoleKey.NumPad2}\t\t Для сортировки по среднему баллу   \n" +
                            $"\t{ConsoleKey.NumPad3}\t\t Для вывода максимального балла \n" +
                            $"\t{ConsoleKey.NumPad4}\t\t Для поиска по по ФИО  \n" +
                            $"\t{ConsoleKey.NumPad5}\t\t Для вывода списка  \n" +
                            $"\t{ConsoleKey.NumPad7}\t\t Для удаления одинаковых фамилий \n" +
                            $"\t{ConsoleKey.NumPad8}\t\t Для удаления одинаковых имен \n" +
                            $"\t{ConsoleKey.NumPad9}\t\t Для удаления одинаковых отчеств \n" +
                            $"\t{ConsoleKey.Delete}\t\t Для удаления студента по номеру \n" +
                            $"\t{ConsoleKey.Enter}\t\t Для того чтобы вывести больше/меньше студентов \n" +
                            $"\t{ConsoleKey.Add}\t\t Для добавления студента \n" +
                            $"\t{ConsoleKey.Tab}\t\t Для сохранения текущего списка в файл \n\n" +
                            $"\t{ConsoleKey.Escape}\t\t Для выхода"
                            );
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Меню
        /// </summary>
        static void Menu()
        {
            bool torch = true;
            Student student = new StudProperties();

            while (torch)
            {
                Console.WriteLine("Лабораторная работа #2 'База данных' \n");
                Console.WriteLine("Введите количество студентов");
                Student.StudentCount = Console.ReadLine();
                bool res = int.TryParse(Student.StudentCount, out int Count);
                string[] liststud = File.ReadAllLines("SecondNames.txt");
                if (Count > liststud.Length)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Столько студентов нет в базе данных:(");
                    Console.ResetColor();
                    Menu();
                }
                if (res & Count>0)
                {
                    Console.Clear();
                    Abilities();
                    StudProperties.GetList(student, Count);
                    while (true)
                    {
                        ConsoleKey ck2 = Console.ReadKey().Key;
                        switch (ck2)
                        {
                            case ConsoleKey.S:
                                Console.Clear();
                                StudProperties.Print();
                                StudProperties.FindDate();
                                break;
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Abilities();
                                StudProperties.AvgSort();
                                break;
                            case ConsoleKey.Delete:
                                Console.Clear();
                                StudProperties.Print();
                                StudProperties.DeleteStudent();
                                break;
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Abilities();
                                StudProperties.PrintMaxMarksSearch();
                                break;
                            case ConsoleKey.Escape:
                                Environment.Exit(777);
                                break;
                            case ConsoleKey.Enter:
                                Console.Clear();
                                Menu();
                                break;
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                Abilities();
                                StudProperties.Print();
                                break;
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                StudProperties.DeleteFIO();
                                break;
                            case ConsoleKey.Add:
                                Console.Clear();
                                StudProperties.Print();
                                AddStudent.AddStudent1();
                                break;
                            case ConsoleKey.NumPad0:
                                Console.Clear();
                                Abilities();
                                StudProperties.PrintMinMarksSearch();
                                break;
                            case ConsoleKey.Tab:
                                Console.Clear();
                                Student.Filer();
                                Abilities();
                                break;
                            case ConsoleKey.NumPad7:
                                Console.Clear();
                                Abilities();
                                StudProperties.DeleteSameFirstName();
                                break;
                            case ConsoleKey.NumPad8:
                                Console.Clear();
                                Abilities();
                                StudProperties.DeleteSameSecondName();
                                break;
                            case ConsoleKey.NumPad9:
                                Console.Clear();
                                Abilities();
                                StudProperties.DeleteSameMiddleName();
                                break;
                            case ConsoleKey.NumPad6:
                                Console.Clear();
                                Abilities();
                                StudProperties.TakeAllEqAvgMark();
                                break;
                            default:
                                Console.Clear();
                                Abilities();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Нажата неверная кнопка");
                                Console.ResetColor();
                                StudProperties.Print();
                                break;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введено не число");
                    Console.ResetColor();
                    Menu();
                    StudProperties.Print();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(180, 50);
            Menu();
        }
    }
}
