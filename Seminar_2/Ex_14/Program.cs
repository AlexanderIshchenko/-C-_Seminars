// 14. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("Число кратно одновременно 7 и 23");
}
else
{
    Console.Write("Число некратно одновременно 7 и 23");
}

// Вариант от Михаила:

// bool IsMultiplicity(int number)
// {
//     return(num % 7 == 0 && num % 23 == 0);
// }
// Console.WriteLine(IsMultiplicity(161));