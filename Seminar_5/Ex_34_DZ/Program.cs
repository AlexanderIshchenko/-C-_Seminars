//  Задача 34: Задайте массив заполненный случайными 
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество 
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

int countEvenNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99,1000);
    if (array[i] %2 == 0)
    {
        countEvenNumbers++;
    }
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}], количество чётных чисел: {countEvenNumbers}");