// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвращает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Введите число: ");
int number = (int)Math.Abs(int.Parse(Console.ReadLine()!)); // так как нам нужны только цифры берем модуль веденного числа
Console.WriteLine($"сумма цифр в введенном числе = {NumSumma(number)}");

int NumSumma(int number)
{
    string num = number.ToString();
    int res = 0;
    for (int i = 0; i < num.Length; i++)
    {
        res = res + number % 10;
        number = number / 10;        
    }
    return res;
}


