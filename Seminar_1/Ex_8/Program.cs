//  Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int EvenNumber = 2;

while (EvenNumber <= N)
{
    Console.WriteLine(EvenNumber);
    EvenNumber += 2;
}