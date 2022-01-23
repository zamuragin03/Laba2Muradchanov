using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class AddStudent:Student
    {
        public static int Count1 { get; set; }
        public static string FullName1 { set; get; }
        public static string FirstName1 { set; get; }
        public static string SecondName1 { set; get; }
        public static string MiddleName1 { set; get; }
        public static int Id1 { set; get; }
        public static DateTime BirthDate1 { set; get; }
        public static string Institite1 { set; get; }
        public static string Group1 { set; get; }
        public static int Course1 { set; get; }
        public static int AvgMark1 { set; get; }
        public static string EduForm1 { set; get; }
        public static string Level1 { set; get; }
        public static int DebtCount1 { set; get; }
        static int AddCount()
        {
            Console.Write("Введите номер ");
            try
            {
                Count1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                AddCount();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
            }
            return Count1;
        }
        static string AddFirstName()
        {
            Console.Write("Введите фамилию ");
            string FirstName = Console.ReadLine();
            return FirstName;
        }
        static string AddSecondName()
        {
            Console.Write("Введите Имя ");
            string SecondName = Console.ReadLine();
            return SecondName;
        }
        static string AddMiddleName()
        {
            Console.Write("Введите Отчество ");
            string MiddleName = Console.ReadLine();
            return MiddleName;
        }
        static string AddID()
        {
            Console.Write("Введите Id ");
            try
            {
                Id1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException )
            {
                Console.WriteLine("Введен неверный формат");
                AddID();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
            }
            return Id1.ToString();
        }
        public static int Year()
        {
            Console.Write("Введите год ");
            try
            {
               int year1 = int.Parse(Console.ReadLine());
                return year1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                AddBirthDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                AddBirthDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                AddBirthDate();
            }
            return 0;
        }
        public static int Month()
        {
            Console.Write("Введите месяц ");
            try
            {
                int month1 = int.Parse(Console.ReadLine());
                if (month1 > 13 || month1 < 0)
                {
                    Console.WriteLine("В календаре всего 12 месяцев");
                    Month();
                }
                return month1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                AddBirthDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                AddBirthDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                AddBirthDate();
            }
            return 0;
        }
        public static int Day()
        {
            Console.Write("Введите день ");
            try
            {
                int day1 = int.Parse(Console.ReadLine());
                if (day1 > 31 | day1 < 0)
                {
                    Console.WriteLine("В календаре всего 30 дней");
                    Day();
                } 
                return day1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен неверный формат");
                AddBirthDate();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
                AddBirthDate();
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
                AddBirthDate();
            }
            return 0;
        }
        static DateTime AddBirthDate()
        {
            Console.Write("Введите дату рождения \n");
            DateTime BirthDate1 = new DateTime(Year(), Month(), Day());
/*            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex);
                AddBirthDate();
            }*/
            return BirthDate1;
        }
        static string AddGroup()
        {
            Console.Write("Введите группу ");
            string Group1 = Console.ReadLine();
            return Group1;
        }
        static string AddInstitute()
        {
            Console.Write("Введите институт ");
            string Institite1 = Console.ReadLine();
            return Institite1;
        }
        static int AddCourse()
        {
            Console.Write("Введите курс ");
            try
            {
                Course1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException )
            {
                Console.WriteLine("Введен неверный формат");
                AddCourse();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
            }
            return Course1;
        }
        static int AddAvgMark()
        {
            Console.Write("Введите средний балл ");
            try
            {
                AvgMark1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                AddAvgMark();
            }
            return AvgMark1;
        }
        static string AddEduForm()
        {
            Console.Write("Введите форму обучения ");
            string EduForm1 = Console.ReadLine();
            return EduForm1;
        }
        static int AddDebtCount()
        {
            Console.Write("Введите количество долгов ");
            try
            {
                DebtCount1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException )
            {
                Console.WriteLine("Введен неверный формат");
                AddDebtCount();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            catch (OverflowException)
            {
                Console.WriteLine("введено слишком большое число");
            }
            return DebtCount1;
        }
        static string AddLevel()
        {
            Console.Write("Введите уровень ");
            string Level1 = Console.ReadLine();
            return Level1;
        }
        public static void AddStudent1()
        {
            StudProperties.AddStudent(AddCount(), AddFirstName(), AddSecondName(), AddMiddleName(), AddID(), AddDebtCount(), AddLevel(), AddEduForm(), AddBirthDate(), AddInstitute(), AddGroup(), AddAvgMark(), AddCourse());
        }
    }
}
