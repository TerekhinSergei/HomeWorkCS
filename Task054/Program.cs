// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.

Console.Clear();

int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("");
SortArray(matrix);
PrintArray(matrix);


void SortArray(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, i] < matrix[k, j])
                {
                    int temp = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = temp;
                }
            }
        }
    }
}

void FillArray(int[,] matrix)
{
    Random generator = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine("");
    }
}
