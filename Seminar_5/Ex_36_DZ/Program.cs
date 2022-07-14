//  Задача 36: Задайте одномерный массив, 
//  заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

int sumElementsInOddIndex = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,100);
    if (i %2 != 0)
    {
        sumElementsInOddIndex+=array[i];
    }
}
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}], Сумма элеметов на нечётных позициях: {sumElementsInOddIndex}");