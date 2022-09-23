Console.Clear();

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i != number)
        Console.Write(", ");
    else
        Console.WriteLine(".");
}