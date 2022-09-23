Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string num = number.ToString();
if (num.Length != 5)
    Console.WriteLine($"{num} не является пятизначным числом");
else
{
    int n = number;
    int revers = 0;

    while (n > 0)
    {
        revers = revers * 10 + n % 10;
        n = n / 10;
    }

    if (revers == number)
        Console.Write($"Да, {number} - палиндром");
    else
        Console.Write($"Нет, {number} - не является палиндромом");
}