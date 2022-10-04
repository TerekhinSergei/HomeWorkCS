// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Прямые заданны уравнениями: y = k1 * x + b1 \n" + 
                  "                         и: y = k2 * x + b2");
Console.Write("Введите через пробел k1 и b1: ");
string input = Console.ReadLine()!;
(double, double) result = ParseString (input);
double k1 = result.Item1;
double b1 = result.Item2;

Console.Write("Введите через пробел k2 и b2: ");
input = Console.ReadLine()!;
result = ParseString (input);
double k2 = result.Item1;
double b2 = result.Item2;
double x = 0, y = 0;

if ((k1 == k2) && (b1 == b2)) 
    Console.WriteLine($"Прямые совпадают.");
else if (k1 == k2)
    Console.WriteLine($"Прямые у = {k1} * x + {b1}\n" +
                      $"     и y = {k2} * x + {b2}\n" +
                      "не пересекаются!");
else if (b1 == b2)
    Console.WriteLine($"Прямые у = {k1} * x + {b1}\n" +
                      $"     и y = {k2} * x + {b2}\n" +
                      $"координаты пересечения (0; {b1})");
else
{
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые у = {k1} * x + {b1}\n" +
                      $"     и y = {k2} * x + {b2}\n" +
                      $"координаты пересечения ({x:f2}; {y:f2})");
}

(double, double) ParseString (string str)
{
    string[] stringArr = str.Split(" ");
    double k = double.Parse(stringArr[0]);
    double b = double.Parse(stringArr[1]);
    return (k, b);
}