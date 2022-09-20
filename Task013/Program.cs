Console.Clear();

Console.Write("Введите число: ");
int number = (int)Math.Abs(int.Parse(Console.ReadLine()!)); // Берем модуль введеного числа, для упрощения решения 

if (number < 100)
    Console.WriteLine("У числа нет третьей цифры");
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.Write($"третья цифра введенного числа -> {number % 10}");
}