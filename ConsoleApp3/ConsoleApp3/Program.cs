using System;

namespace Bank2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вашего вклада:");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Введите количество месяцев, на которые хотите сделать вклад:");

            int Months = Convert.ToInt32(Console.ReadLine());

            decimal current = deposit;
            decimal interestRate = 0.07m;
            int month = 1;

            while (month <= Months)
            {
                decimal monthlyInterest = current * interestRate;
                current = current + monthlyInterest;
                month++;
            }

            Console.WriteLine("Через " + Months + " месяцев на вкладе будет: " + current.ToString("F2") + " рублей.");
        }
    }
}


