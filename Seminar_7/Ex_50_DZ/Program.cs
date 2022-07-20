// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int rows = 3;
int colomns = 4;

int[,] matrix = new int[rows, colomns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Введите индекс массива через запятую: ");
int[] inputIndexElement = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
String result = "Элемент массива отсутствует";
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (inputIndexElement[0] == i && inputIndexElement[1] == j)
        {
            result = $"Число в массиве с индексом {i},{j}: " + matrix[i, j];
        }
    }
}
Console.WriteLine(result);