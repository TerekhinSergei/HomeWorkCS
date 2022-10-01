// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//////////
Console.Clear();

Console.Write("Введите элементы массива через пробел: ");
string strArray = Console.ReadLine()!;
int[] Array = ParseToArray(strArray);

Console.WriteLine(String.Join(", ", Array));
Console.WriteLine($"сумма нечетных элементов = {SummOddElements(Array)}");

int[] ParseToArray(string str)
{
    string[] stringArr = str.Split(" ");
    int[] result = new int[stringArr.Length];

    for (int i = 0; i < stringArr.Length; i++)
    {
        result[i] = int.Parse(stringArr[i]);
    }
    return result;
}

int SummOddElements(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}