// / Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные: выходные данные: 1, 7, 0, 1	
Console.Clear();
int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[] { 2, 3, 3, 1 };
int[] arr;
int num = 0;
int k = 0;
while (k < data.Length)
{
    for (int i = 0; i < info.Length; i++)
    {
        arr = new int[info[i]];
        for (int j = 0; j < arr.Length; j++)
        {
            arr[j] = data[j + k];
        }
        Console.Write($"{i + 1}) BinNum -> {String.Join("", arr)}, ");
        num = returnDecNum(arr);
        Console.WriteLine($"DecNum = {num}");
        k = k + info[i];
    }
}

int returnDecNum(int[] arr)
{
    Array.Reverse(arr);
    num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        num = num + (int)Math.Pow(2, i) * arr[i];
    }
    return num;
}
