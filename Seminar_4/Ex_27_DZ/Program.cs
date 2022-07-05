// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Подскажите почему такой код не работает? Не смог разобраться.
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < number.Length; i++)
// {
//     sum = sum + Convert.ToInt32(number[i]);
// }
// Console.WriteLine("Сумма цифр в числе: " + sum);

// Рабочий код
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number != 0)
{
    sum = sum + number % 10;
    number /= 10;
}
Console.WriteLine("Сумма цифр в числе: " + sum);