using System;

class Program
{
    static void Main(string[] args)
    {

        string fullName;
        int age;
        string major;
        bool hasScholarship;
        double russianGrade;
        double mathGrade;


        Console.Write("Введите ФИО: ");
        fullName = Console.ReadLine();


        Console.Write("Введите возраст: ");
        age = int.Parse(Console.ReadLine());


        Console.Write("На кого учиться: ");
        major = Console.ReadLine();


        Console.Write("Получает стипендию (да/нет): ");
        string scholarshipInput = Console.ReadLine();
        hasScholarship = scholarshipInput.ToLower() == "да";


        Console.Write("Введите оценку по Русскому: ");
        russianGrade = double.Parse(Console.ReadLine());

        Console.Write("Введите оценку по Математике: ");
        mathGrade = double.Parse(Console.ReadLine());

        Console.WriteLine("\nИнформация о студенте:");
        Console.WriteLine($"ФИО: {fullName}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Специальность: {major}");
        Console.WriteLine($"Получает стипендию: {(hasScholarship ? "Да" : "Нет")}");
        Console.WriteLine($"Оценка по Русскому: {russianGrade}");
        Console.WriteLine($"Оценка по Математике: {mathGrade}");
    }
}