// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29   для m > 0, n > 0 -> A(m,n) = A(n - 1, A(n, m - 1));

Console.Write("Введите через запятую неотрицательнве числа m , n: ");
(int, int) result = ParseString(Console.ReadLine()!);
int m = result.Item1;
int n = result.Item2;

Console.WriteLine($"функция Аккермана A({m},{n}) = {Akkerman(m, n)}");


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

(int, int) ParseString(string str)
{
    string[] stringArr = str.Split(",");
    int a = int.Parse(stringArr[0]);
    int b = int.Parse(stringArr[1]);
    return (a, b);
}