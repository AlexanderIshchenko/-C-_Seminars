// Задача 62: Заполните спирально массив 4 на 4.

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

int rows = 4;
int colomns = 4;

int[,] array = new int[rows, colomns];
int fillArrayNumber = 1;
for (int i = 0; i < array.GetLength(0) / 2; i++)
{
    for (int j = i; j < array.GetLength(1) - i; j++)
    {
        array[i, j] = fillArrayNumber;
        fillArrayNumber++;
    }
    for (int j = i + 1; j < array.GetLength(0) - i; j++)
    {
        array[j, array.GetLength(1) - 1 - i] = fillArrayNumber;
        fillArrayNumber++;
    }
    for (int j = array.GetLength(1) - 2 - i; j > i - 1; j--)
    {
        array[array.GetLength(0) - 1 - i, j] = fillArrayNumber;
        fillArrayNumber++;
    }
    for (int j = array.GetLength(0) - 2 - i; j > i; j--)
    {
        array[j, i] = fillArrayNumber;
        fillArrayNumber++;
    }
}

PrintArray(array);