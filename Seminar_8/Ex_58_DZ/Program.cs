// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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
int colomns = 4;

int[,] arrayOne = GetArray(rows, colomns);
int[,] arrayTwo = GetArray(rows, colomns);

PrintArray(arrayOne);
Console.WriteLine();
PrintArray(arrayTwo);

int[,] arrayMultiplication = new int [rows,colomns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        arrayMultiplication[i,j] = arrayOne[i,j]*arrayTwo[i,j];
    }
}

Console.WriteLine("Результат: ");
PrintArray(arrayMultiplication);