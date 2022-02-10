using System;

namespace Lesson_4
{
    internal class Program
    {
        static void Main()
        {
            (string, string, string) WholeNameFirst = GetFullName();
            Console.WriteLine($"Пользователь 1 сохранен: {WholeNameFirst.Item2} {WholeNameFirst.Item1} {WholeNameFirst.Item3}");
            (string, string, string) WholeNameSecond = GetFullName();
            Console.WriteLine($"Пользователь 2 сохранен: {WholeNameSecond.Item2} {WholeNameSecond.Item1} {WholeNameSecond.Item3}");
            (string, string, string) WholeNameThird = GetFullName();
            Console.WriteLine($"Пользователь 3 сохранен: {WholeNameThird.Item2} {WholeNameThird.Item1} {WholeNameThird.Item3}");
            (string, string, string) WholeNameFourth = GetFullName();
            Console.WriteLine($"Пользователь 4 сохранен: {WholeNameFourth.Item2} {WholeNameFourth.Item1} {WholeNameFourth.Item3}");
        }
        static (string, string, string) GetFullName()
        {
            Console.WriteLine("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию пользователя: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество пользователя ");
            string patronymic = Console.ReadLine();
            return (name, lastName, patronymic);
        }


    }
}
