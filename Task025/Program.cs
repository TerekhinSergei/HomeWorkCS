// напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвращает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите натуральное число B: ");
int b = int.Parse(Console.ReadLine()!);

if (b > 0)
    Console.Write($"{a} в степени {b} = {Power(a, b)}");
else
{
    Console.Write($"{b} - НЕ натуральное число!");
}

int Power(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}