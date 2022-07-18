//  Задача 41: Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] arrayNumbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int countPositiveNumbers = 0;
for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] > 0) countPositiveNumbers ++;
}
Console.WriteLine($"Введено чисел больше 0: {countPositiveNumbers}");