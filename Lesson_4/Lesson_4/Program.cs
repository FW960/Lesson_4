using System;

namespace Lesson_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задайте количество пользователей: ");
            int a = Convert.ToInt32(Console.ReadLine().ToString());
            string [] allPersons = new string[a];
            for (int i = 0; i < allPersons.Length; i++)
            {
                Console.WriteLine("Введите имя пользователя: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию пользователя: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите отчество пользователя ");
                string patronymic = Console.ReadLine();

                string FullName = GetFullName(firstName, lastName, patronymic);

                allPersons[i] = FullName;

                Console.WriteLine($"Пользователь сохраненом под №{i+1}:{allPersons[i]}");

            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {

            string fullName = ($"{lastName} {firstName} {patronymic}");
            return (fullName);
        }


    }
}
