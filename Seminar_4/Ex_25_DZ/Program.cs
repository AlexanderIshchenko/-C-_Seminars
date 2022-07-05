// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Число А в степени В: " + Math.Pow(A, B));

// Нужно написать цикл. Пропустил этот момент в варианте выше.
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    result*=A;
}
Console.Write("Число А в степени В: " + result);