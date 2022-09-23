Console.Write("Введите координату X для А: ");
double xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для А: ");
double ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для А: ");
double za = double.Parse(Console.ReadLine()!);

Console.Write("Введите координату X для B: ");
double xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для B: ");
double yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для B: ");
double zb = double.Parse(Console.ReadLine()!);


double lgth = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
//d = Math.Round(d, 2);
Console.Write($"длина отрезка А({xa},{ya},{za}) B({xb},{yb},{zb}) = {lgth:f2}");
