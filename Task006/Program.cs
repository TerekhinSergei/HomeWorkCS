Console.Clear();

Console.WriteLine("введите число: ");
string a = Console.ReadLine()!;
int number = int.Parse(a);

int result = number % 2;

if (result == 0 )
{ 
Console.WriteLine("ДА - число четное");    
}
else
{
Console.WriteLine("НЕТ - число нечетное");
}