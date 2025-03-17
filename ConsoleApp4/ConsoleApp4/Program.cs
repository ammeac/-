using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблицу умножения");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0,4}", result);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

