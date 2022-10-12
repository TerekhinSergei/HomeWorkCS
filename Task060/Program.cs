// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

//int[,,] array3D = new int[2, 2, 2]; // тестовый массив
int[,,] array3D = new int[3, 3, 3]; // мой массив
if (array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2) > 90)
{
    Console.WriteLine("Размер массива больше, чем количество двухзначных чисел!");
}
else
{
    int[] array = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    FillUnique3DArray(GetUniqueRandomArr(array), array3D);
    Console.WriteLine("трехмерный массив из неповторяющихся двузначных чисел (с индексами)");
    PrintArrayWithIndex(array3D);
}

int[] GetUniqueRandomArr(int[] array) // формирование массива из неповторящихся двузначных чисел
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        var num = random.Next(10, 100);
        if (array.Contains(num))
            i--;
        else
            array[i] = num;
    }
    return array;
}

void FillUnique3DArray(int[] array, int[,,] array3D) //превращения массива в трехмерный массив
{
    int m = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array[m];
                m++;
            }
        }
    }
}

void PrintArrayWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}