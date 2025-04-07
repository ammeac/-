using System;

namespace zadaniya
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1
            static int Sum(List<int> num)
            {
                int sum = 0;
                foreach (int number in num)
                {
                    sum += number;
                }
                return sum;
            }

            // 2
            static bool palidram(string str)
            {
                str = str.ToLower();
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            // 3

            static long factolial(int n)
            {
                long result = 1;
                if (n == 0)
                {
                    return 1;
                }
                if (n < 0)
                {
                    Console.WriteLine("Неверно.");
                }
                int i = 1;
                while (i <= n)
                {
                    result = result * i;
                    i = i + 1;
                }
                return result;
            }




            // 4
            static int Max(List<int> numbers)
            {
                if (numbers == null || numbers.Count == 0)
                {
                    Console.WriteLine("Списку нельзя быть пустым.");
                    return 0;
                }
                int max = numbers[0];

                int i = 1;

                while (i < numbers.Count)
                {

                    if (numbers[i] > max)
                    {

                        max = numbers[i];
                    }
                    i = i + 1;
                }
                return max;
            }



            // 5
            static List<int> deletedubl(List<int> numbers)
            {
                List<int> result = new List<int>();

                foreach (int number in numbers)
                {
                    bool found = false;
                    int i = 0;
                    while (i < result.Count)
                    {
                        if (result[i] == number)
                        {

                            found = true;
                            break;
                        }
                        i = i + 1;
                    }

                    if (!found)
                    {
                        result.Add(number);
                    }
                }
                return result;
            }
        }
    }
}

