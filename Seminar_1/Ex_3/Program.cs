Console.WriteLine("Введите номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber == 1)
{Console.WriteLine("Понедельник");}
if (DayNumber == 2)
{Console.WriteLine("Вторник");}
if (DayNumber == 3)
{Console.WriteLine("Среда");}
if (DayNumber == 4)
{Console.WriteLine("Четверг");}
if (DayNumber == 5)
{Console.WriteLine("Пятница");}
if (DayNumber == 6)
{Console.WriteLine("Суббота");}
if (DayNumber == 7)
{Console.WriteLine("Воскресенье");}
if (DayNumber > 7)
{Console.WriteLine("В неделе всего СЕМЬ дней!");}