// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/////////////////
Console.Clear();

Console.Write("Введите элементы (вещественные числа) массива через пробел: ");
string strArray = Console.ReadLine()!;
double[] Array = ParseToArray(strArray);

double max = FindMaxElement(Array);
double min = FindMinElement(Array);

Console.WriteLine(String.Join("  ", Array));
Console.WriteLine($"разница между max({max}) и min({min}) = {max - min:f2}");


double[] ParseToArray(string str)
{
    string[] stringArr = str.Split(" ");
    double[] result = new double[stringArr.Length];

    for (int i = 0; i < stringArr.Length; i++)
    {
        result[i] = double.Parse(stringArr[i]);
    }
    return result;
}

double FindMinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double FindMaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}
