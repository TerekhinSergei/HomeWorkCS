Console.Clear();

Console.Write("введите первое число: ");
string input1 = Console.ReadLine()!;
int number1 = int.Parse(input1);
Console.Write("введите второе число: ");
string input2 = Console.ReadLine()!;
int number2 = int.Parse(input2);

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}
else
{
    Console.WriteLine("Введенные числа равны");
}