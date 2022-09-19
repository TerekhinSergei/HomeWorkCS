Console.Clear();

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);

if ((number == 6) || (number == 7))
    Console.WriteLine("Да, это выходной день");
else if ((number < 1) || (number > 7))
    Console.WriteLine("в неделе 7 дней - введите цифру от 1 до 7");
else
    Console.WriteLine("нет, это рабочий день");