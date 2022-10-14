// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Рекурсивно
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое натуральное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе натуральное число n: ");
int n = int.Parse(Console.ReadLine()!);

if ((n < 1) || (m < 1))
    Console.Write($"числа должны быть больше 0");
else if (m > n)   // если пользователь ввел первое число больше второго
{
    int temp = m;
    m = n;
    n = temp;
    PrintSumNumber(m, n);
}
else
    PrintSumNumber(m, n);


void PrintSumNumber(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов: {sum}");
        return;
    }
    sum += m;
    m++;
    PrintSumNumber(m, n, sum);
}
