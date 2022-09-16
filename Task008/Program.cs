Console.Clear();

Console.WriteLine("введите положительное число больше 1: ");
string a = Console.ReadLine()!;
int number = int.Parse(a);
if (number <= 1)
{
    Console.WriteLine("введите положительное число больше 1 !");
}
// первый вариант решения (закомментирован)
/*int count = 2;
while (count <= number)
{
    Console.Write($"{count}, ");
    count += 2;
}
*/
// второй вариант решения
int count = 1;
while (count <= number)
{
    int result = count % 2;
    if (result == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}
