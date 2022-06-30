// Ctrl + / - быстрое комментирование

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число - {number}"); // интерполяция
int digitOne = number / 10; // 56 -> 5. 56/10 = 5
int digitTwo = number % 10; // 56 -> 6

Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int max = Math.Max(digitOne, digitTwo); // Max(1_значениеб 2_значение)
int min = Math.Min(digitOne, digitTwo); // Min(1_значениеб 2_значение)

Console.WriteLine($"Самое большое число - это {max}");
Console.WriteLine($"Самое маленькое число - это {min}");