// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введены отрицательные числа, операция не выполнима!");
}
else Console.WriteLine(FunctionAkkerman(numberM, numberN));

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}