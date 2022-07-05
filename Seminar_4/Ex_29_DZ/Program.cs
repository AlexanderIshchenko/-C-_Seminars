// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


// Вариат 1. Задает массив из 8 случаных чисел от 0 до 100
// int[] array = Array(8);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// 
// int[] Array(int size)
// {
//     int[] resultArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = new Random().Next(100);
//     }
//     return resultArray;
// }


// Вариант 2
// int[] array = { 1, 2, 5, 7, 19 };
// Console.Write($"[{String.Join(", ", array)}]");


// Вариант 3
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"[{String.Join(", ", array)}]");
