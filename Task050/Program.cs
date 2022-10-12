// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4      ввод 1 , 7 -> такого числа в массиве нет

Console.Clear();
int[,] array = new int[4, 6];
FillArray(array);
PrintArray(array);

Console.Write("Введите индекс элемента двухмерного массива через запятую (i,j) : ");
(int, int) result = ParseString(Console.ReadLine()!);
int i = result.Item1;
int j = result.Item2;


if (i < array.GetLength(0) && j < array.GetLength(1) &&  i >= 0 && j >= 0) 
    Console.WriteLine($"Элемент с индексом {i},{j} = {array[i, j]}");
else
    Console.WriteLine("В массиве нет такого элемента!");

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(-9, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0) // для красоты представления массива
                Console.Write($"{array[i, j]}  ");
            else
                Console.Write($" {array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}

(int, int) ParseString(string str)
{
    string[] stringArr = str.Split(",");
    int a = int.Parse(stringArr[0]);
    int b = int.Parse(stringArr[1]);
    return (a, b);
}