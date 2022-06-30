//  Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number >99)
    {
        int result = number / 10 % 10;
        Console.WriteLine($"Результат - {result}");
    }
else
    {
        Console.WriteLine("Введено не трехзначное число!");
    }

// Вариант от Михаила
// string testNumber = Console.ReadLine();
// Console.WriteLine(testNumber[2]);