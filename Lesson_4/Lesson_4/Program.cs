using System;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий номер месяца без пробелов: ");
            string numOfSeason = Console.ReadLine();

            switch (numOfSeason)
            {
                case "12":
                case "1":
                case "2":
                    Console.WriteLine($"Сейчас {Seasons.Зима}");
                    break;
                case "3":
                case "4":
                case "5":
                    Console.WriteLine($"Сейчас {Seasons.Весна}");
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine($"Сейчас {Seasons.Лето}");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine($"Сейчас {Seasons.Осень}");
                    break;
                default:
                    Console.WriteLine(
                    @"Введите корректный номер месяца. 
                    Нажмите пробел, чтобы продолжить");

                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                    break;
            }
        }

        enum Seasons
        {
            Зима = 0,
            Весна = 1,
            Лето = 2,
            Осень = 3,

        }
    }
}
