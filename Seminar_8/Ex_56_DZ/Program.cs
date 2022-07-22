// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int rows = 3;
int colomns = 5;

int[,] array = GetArray(rows, colomns);

PrintArray(array);

int minSumRowElements = int.MaxValue;
int indexMinSumRowElements = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sumRowElements = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRowElements += array[i, j];
    }
    if (minSumRowElements > sumRowElements)
    {
        minSumRowElements = sumRowElements;
        indexMinSumRowElements = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: ");

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write(array[indexMinSumRowElements, i] + "\t");
}