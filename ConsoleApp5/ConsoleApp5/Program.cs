using System;

namespace ot0to10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение двух чисел от 0 до 10.");
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
                {
                    int result = number1 * number2;
                    Console.WriteLine("Результат: " + result);
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введенные числа недопустимы.");
                }
            }
        }
    }
}

