//  Задача 38: Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и 
//  минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[4];

double maxElement = 0;
double minElement = 100;
double subtractionMaxMinElement = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble()*100;
    if (array[i] > maxElement) maxElement = array[i];
    if (array[i] < minElement) minElement = array[i];
}
subtractionMaxMinElement = maxElement - minElement;
Console.WriteLine($"Исходный массив: [{String.Join("; ", array)}], разницу между максимальным и минимальным элементами массива: {subtractionMaxMinElement}");