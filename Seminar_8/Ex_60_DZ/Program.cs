// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int height = 3;
int length = 3;
int depth = 3;

int[,,] array = GetArray(height, length, depth);

PrintArray(array);

Console.WriteLine("Результат: ");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ({i},{j},{k})"+"\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}