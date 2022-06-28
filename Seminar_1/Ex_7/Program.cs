// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 100 && N <= 999)
{
    int LastNumber = N % 10;
    Console.WriteLine("Последняя цифра: " + LastNumber);
}
else
{
   Console.WriteLine("Введено не трехзначное число!"); 
}