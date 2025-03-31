using System;

namespace bulbulio;
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] io = {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.Write("{{");
            for (int i = 0; i < io.GetLength(0); i++)
            {
                Console.Write("{{");
                for (int j = 0; j < io.GetLength(1); j++)
                {
                    Console.Write(io[i, j, 0] + ", " + io[i, j, 1]);

                    if (j < io.GetLength(1) - 1)
                    {
                        Console.Write("}, {");
                    }
                }
                Console.Write("}}");
                if (i < mas.GetLength(0) - 1)
                {
                    Console.Write(", {{");
                }
            }
            Console.Write("}}");
            Console.WriteLine();
        }
    }
}

