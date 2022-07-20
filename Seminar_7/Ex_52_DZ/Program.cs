// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 4];
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

double[] arrayColomnsAverageValue = new double[matrix.GetLength(1)];

double sumOfColomnsElements = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sumOfColomnsElements += matrix[j, i];
    }
    arrayColomnsAverageValue[i] = Math.Round(sumOfColomnsElements / matrix.GetLength(0),1,MidpointRounding.AwayFromZero);
    sumOfColomnsElements = 0;
}
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", arrayColomnsAverageValue)}");