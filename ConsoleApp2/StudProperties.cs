using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    class StudProperties : Student 
    {

        public static Student DateUsername;
        public static Student FirstNameUsername;
        public static Student SecondNameusername;
        public static Student MiddleNameusername;
        public static Student DeletedUsername;
        private static int year1;
        private static int month1;
        private static int day1;

        public static string GetCount(int i=0)
        {
            i++;
            return i+".";
        }
        public static string GetLevel()
        {
            int a = rnd.Next(1, 5);
            switch (a)
            {
                case 1:
                    return $"A-{rnd.Next(1, 4)}";
                case 2:
                    return $"B-{rnd.Next(1, 4)}";
                case 3:
                    return $"C-{rnd.Next(1, 4)}";
                case 4:
                    return $"D-{rnd.Next(1, 4)}";
                default:
                    return null;
            }
        }
        public static int GetDebtCount()
        {
            return rnd.Next(0, 10);
        }
        public static string GetEduForm()
        {
            int a = rnd.Next(1, 3);
            switch (a)
            {
                case 1:
                    return "Очно";
                case 2:
                    return "Дистанционно";
                default:
                    return null;
            }
        }
        public static void DeleteStudent()
        {
            Console.WriteLine("Удаление студента, выберите номер\n");
            string Count1 = Console.ReadLine();
            string TempCount = Count1 +".";
            DeletedUsername = studentlist.Find(item => item.Count == TempCount);
            bool a = studentlist.Contains(DeletedUsername);
                if (a)
                {
                    Console.Clear();
                    studentlist.RemoveAll(e => e.Count == TempCount);
                    Program.Abilities();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Студент с номером {Count1} удален");
                    Console.ResetColor();
                    Print();
                }
                else
                {
                    Console.Clear();
                    Program.Abilities();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Студент с номером {Count1} не найден");
                    Console.ResetColor();
                    Print();
                }
        }
        public static void FindDate()
        {
            Console.Write("Введите год ");
            try
            {
                int year = int.Parse(Console.ReadLine());
                year1 = year;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                FindDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                FindDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                FindDate();
            }
            Console.Write("Введите месяц ");
            try
            {
                int  month = int.Parse(Console.ReadLine());
                month1 = month;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                FindDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                FindDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                FindDate();
            }
            Console.Write("Введите день ");
            try
            {
                int day = int.Parse(Console.ReadLine());
                day1 = day;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                FindDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                FindDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                FindDate();
            }
            if (year1 < 0 | month1 > 12 | month1 < 0 | day1 > 31 | day1 < 0)
            {
                Console.Clear();
                Console.WriteLine("Введены ошибочные данные");
                FindDate();
            }
            DateTime FindYear = new DateTime(year1 , month1, day1);
            DateUsername = studentlist.Find(item => item.BirthDate == FindYear);
            bool a = studentlist.Contains(DateUsername);
            if (a)
            {
                PrintFoundName();
            }
            else
            {
                Console.WriteLine($"Студент с датой рождения {year1}.{month1}.{day1} не найден");
                Print();
            }
        }
        static void PrintFoundName()
        {
            Console.Clear();
            Program.Abilities();
            Console.WriteLine($"Студент с {year1}.{month1}.{day1} найден");
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID               Дата Рождения         Группа           Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == DateUsername)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }

        }
        public static string GetFullName()
        {
            string[] list = File.ReadAllLines("Names.txt");
            return list[rnd.Next(list.Length)];
        }
        public static string GetFirstName(int i)
        {
            string[] list = File.ReadAllLines("FirstNames.txt");
            i++;
            return list[i];
        }
        public static string GetSecondName(int i)
        {
            string[] list = File.ReadAllLines("SecondNames.txt");
            i++;
            return list[i];
        }
        public static string GetMiddleName(int i)
        {
            string[] list = File.ReadAllLines("MiddleNames.txt");
            i++;
            return list[i];
        }
        public static string /*object*/ GetID()
        {
            return "210"+$"{rnd.Next(10000,100000)}";
        }
        public static DateTime GetBirthDate()
        {
            RandomDateTime date = new RandomDateTime();
            return date.Next();
        }
        public static string GetGroup()
        {
            int a = rnd.Next(1, 4);
            switch (a)
            {
                case 1:
                    return "БИВТ-21-" + rnd.Next(1, 20);
                case 2:
                    return "БПИ-21-" + rnd.Next(1, 20);
                case 3:
                    return "БПМ-21-" + rnd.Next(1, 20);
                default:
                    return null;
            }
        }
        public static int GetAvgMark()
        {
            return rnd.Next(200, 300);
        }
        public static void Print()
        {
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void GetList(Student student, int studentCount)
        {
            studentlist.Clear();
            for (int i = 0; i < studentCount; i++)
            {
                studentlist.Add(new Student()
                {
                    Count = GetCount(i),
                    FirstName = GetFirstName(i),
                    SecondName = GetSecondName(i),
                    MiddleName = GetMiddleName(i),
                    Id = GetID(),
                    DebtCount = GetDebtCount(),
                    Level = GetLevel(),
                    EduForm =GetEduForm(),
                    BirthDate = GetBirthDate(),
                    Institite = "МИСИС",
                    Group = GetGroup(),
                    AvgMark = GetAvgMark(),
                    Course = 1,
                }) ;
            }
        }
        public static void AvgSort()
        {
            /*studentlist = studentlist;*/
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist.OrderBy(x => x.AvgMark).ToList())
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void PrintMaxMarksSearch()
        {
            var maxZ = studentlist.Max(obj => obj.AvgMark);
            Student maxPerson = studentlist.Find(e => (e.AvgMark == maxZ));
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == maxPerson)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }
        }
        public static void PrintMinMarksSearch()
        {
            var minZ = studentlist.Min(obj => obj.AvgMark);
            Student minPerson = studentlist.Find(e => (e.AvgMark == minZ));
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == minPerson)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }
        }
        public static void FindFirstName(string Firstname)
        {
            FirstNameUsername = studentlist.Find(item => item.FirstName == Firstname);
            bool a = studentlist.Contains(FirstNameUsername);
            if (a)
            {
                PrintFoundFirstName();
            }
            else
            {
                Console.WriteLine($"Студент c именем {Firstname} не найден");
                Print();
            }
        }
        static void PrintFoundFirstName()
        {
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == FirstNameUsername)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }

        }
        public static void FindSecondName(string SecondName)
        {
            SecondNameusername = studentlist.Find(item => item.SecondName == SecondName);
            bool a = studentlist.Contains(SecondNameusername);
            if (a)
            {
                PrintFoundSecondName();
            }
            else
            {
                Console.WriteLine($"Студент c фамилией {SecondName} не найден");
                Print();
            }
        }
        static void PrintFoundSecondName()
        {
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == SecondNameusername)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }

        }
        public static void FindMiddleName(string MiddleName)
        {
            MiddleNameusername = studentlist.Find(item => item.MiddleName == MiddleName);
            bool a = studentlist.Contains(MiddleNameusername);
            if (a)
            {
                PrintFoundMiddleName();
            }
            else
            {
                Console.WriteLine($"Студент c фамилией {MiddleName} не найден");
                Print();
            }
        }

        private static void PrintFoundMiddleName()
        {
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in studentlist)
            {
                if (item == MiddleNameusername)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{item}" + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.Write($"{item}" + "\n");
            }

        }
        public static void TakeAllEqAvgMark()
        {
            var query = studentlist.GroupBy(x => x.AvgMark).Where(g => g.Count() > 1).Select(y => y.First()).ToList();
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in query)
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void DeleteSameFirstName()
        {
            var items = studentlist.GroupBy(x => x.FirstName).Select(group =>group.First()).ToList();
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in items)
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void DeleteSameSecondName()
        {
            var items = studentlist.GroupBy(x => x.SecondName).Select(group => group.First()).ToList();
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in items)
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void DeleteSameMiddleName()
        {
            var items = studentlist.GroupBy(x => x.MiddleName).Select(group => group.First()).ToList();
            Console.WriteLine("№   Фамилия        Имя           Отчество         ID           Дата Рождения      Группа         Вуз   Курс Ср. балл   Форма обучения    Уровень   Кол-во долгов   ");
            foreach (var item in items)
            {
                Console.Write($"{item}" + "\n");
            }
        }
        public static void DeleteFIO()
        {
            Console.WriteLine($"Для поиска по фамилии нажите {ConsoleKey.NumPad1}\n" +
                $"Для поиска по имени нажите {ConsoleKey.NumPad2}\n" +
                $"Для поиска по отчеству нажмите {ConsoleKey.NumPad3}\n");
            StudProperties.Print();
            bool torch = true;
            while (torch)
            {
                ConsoleKey ck3 = Console.ReadKey().Key;
                switch (ck3)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        StudProperties.Print();
                        Console.Write("Введите фамилию:  ");
                        string FirstName = Console.ReadLine();
                        Console.Clear();
                        Program.Abilities();
                        StudProperties.FindFirstName(FirstName);
                        return;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        StudProperties.Print();
                        Console.Write("Введите имя:  ");
                        string SecondName = Console.ReadLine();
                        Console.Clear();
                        Program.Abilities();
                        StudProperties.FindSecondName(SecondName);
                        return;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        StudProperties.Print();
                        Console.Write("Введите отчество:  ");
                        string MiddleName = Console.ReadLine();
                        Console.Clear();
                        Program.Abilities();
                        StudProperties.FindMiddleName(MiddleName);
                        return;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Выбрана неверная кнопка");
                        Console.ResetColor();
                        DeleteFIO();
                        return;
                }
            }
        }
        public static void AddStudent
            (
            int studentCount, 
            string FirstName, 
            string SecondName, 
            string MiddleName, 
            string id,
            int DebtCount,
            string Level,
            string EduForm,
            DateTime BirtDate,
            string Institute,
            string Group,
            int AvgMark,
            int Course
            )
        {
            studentlist.Add(new Student()
            {
                Count = GetCount(studentCount-1),
                FirstName = FirstName,
                SecondName = SecondName,
                MiddleName = MiddleName,
                Id = id,
                DebtCount = DebtCount,
                Level = Level,
                EduForm = EduForm,
                BirthDate = BirtDate,
                Institite = Institute,
                Group = Group,
                AvgMark = AvgMark,
                Course = Course,
            });
        }
    }
}
