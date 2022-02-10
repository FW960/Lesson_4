using System;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы узнать сумму всех чисел, введите их через пробел: ");

            string NumbersInStringWithSpace = Console.ReadLine();

            int sum = ConvertingStringToIntWithPlusesInsteadOfSpaces(NumbersInStringWithSpace);

            Console.WriteLine($"Сумма всех чисел равна: {sum}");

        }
        static int ConvertingStringToIntWithPlusesInsteadOfSpaces(string b)
        {
            int f = 0;
            int h = 0;
            string z = "";
            for (int i = 0; i <= b.Length; i++)
            {
                if (i == b.Length)
                {
                    h = Convert.ToInt32(z);
                    f = h + f;
                    break;
                }

                if (b[i] == ' ')
                {
                    h = Convert.ToInt32(z);
                    f = h + f;
                    z = "";
                    continue;
                }
                z = ($"{z + b[i]}");

            }
            return f;

        }



    }
}
