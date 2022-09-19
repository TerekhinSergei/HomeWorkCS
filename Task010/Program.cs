Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!) ;

number = number / 10 % 10;

Console.Write(number);
