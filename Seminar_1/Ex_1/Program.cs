Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int SquareNumber = numberB * numberB;
if (SquareNumber == numberA)
{
    Console.WriteLine("Да");
    }
else
{
  Console.WriteLine("Нет"); 
}
