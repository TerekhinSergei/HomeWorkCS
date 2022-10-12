// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 

Console.Clear();

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"минимальная сумма элементов в {GetMinSumRow(matrix)} строке");


int GetMinSumRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }        
        sumRow[i] = sum;  // сохраняем суммы строк в массив.
    }        
    int min = int.MaxValue;
    int index = -1; 
    for (int i = 0; i < sumRow.Length; i++)
    {       
        if (min > sumRow[i])
        {
            min = sumRow[i];
            index = i;            
        }        
    }
    return index + 1;   //в соотвествии с образцом строка с индексом 0 считается первой 
}

void FillArray(int[,] matrix)
{
    Random generator = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator.Next(1, 10);
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