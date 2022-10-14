// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите целое число больше 1: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 1) 
    Console.Write($"{n} меньше 1");
else
    PrintNumber(n);

void PrintNumber(int n)
{       
    if (n == 1) 
    {
        Console.Write($"{n}.");
        return;
    }
    else
    {
        Console.Write($"{n}, ");
        PrintNumber(n - 1);
    }
}
