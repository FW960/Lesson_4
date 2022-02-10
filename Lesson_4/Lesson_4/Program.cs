using System;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] maxValue = new long[93];

            int fibNum1 = 0;

            int fibNum2 = 1;

            maxValue[0] = fibNum1;

            maxValue[1] = fibNum2;

            for (int i = 1; i < maxValue.Length - 1; i++)
            {

                maxValue[i + 1] = maxValue[i - 1] + maxValue[i];

                if (i == maxValue.Length)
                {
                    break;
                }

            }
            Console.WriteLine("Введите число, чтобы преобразовать его в число Фибоначчи от 0 до 92: ");

            int fibNum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(maxValue[fibNum3]);

        }
    }
}
