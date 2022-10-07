// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
Console.Clear();

Console.Write("Задайте размерность массива m x n.\nВведите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = generator.Next(0, 2); // для наличия "недробных" чисел в массиве
            if (k == 0)
                array[i, j] = Math.Round(generator.Next(-10, 10) + generator.NextDouble(), 2);
            else
                array[i, j] = generator.Next(-9, 10); 
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}

