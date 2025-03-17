﻿using System;

namespace BankDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вашего вклада:");

            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев, на которые хотите сделать вклад:");

            int numberOfMonths = Convert.ToInt32(Console.ReadLine());

            decimal currentAmount = depositAmount;
            decimal interestRate = 0.07m;
            int month = 1;

            while (month <= numberOfMonths)
            {
                decimal monthlyInterest = currentAmount * interestRate;

                currentAmount = currentAmount + monthlyInterest;

                month++;
            }

            Console.WriteLine("Через " + numberOfMonths + " месяцев на вашем вкладе будет: " + currentAmount.ToString("F2") + " рублей.");
        }
    }
}


