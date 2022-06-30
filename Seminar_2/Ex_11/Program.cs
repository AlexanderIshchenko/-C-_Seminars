// 11. Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число - {number}"); // интерполяция
int digitOne = number / 100; // 567 -> 5. 567/100 = 5
int digitTwo = number % 10; // 56 -> 6

Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int result = digitOne * 10 + digitTwo;
Console.WriteLine("Результат: " + result);

// Console.WriteLine("Результат: " + digitOne + digitTwo);

// Вариант от Михаила

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int SearchResult(int number)
// {
//     int first = number / 100;
//     int third = number % 10;
//     return first*10+third;
// }

// Console.WriteLine(SearchResult(number));