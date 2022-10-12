// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Console.Clear();

int[,] matrix = new int[4, 4]; // тестовый массив
//int[,] matrix = new int[11, 11]; // мой массив
PrintArray(FillArraySpiral(matrix));


int[,] FillArraySpiral(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int number = 1;
    // заполняем контур массива
    for (int j = 0; j < n; j++)
    {
        matrix[0, j] = number;
        number++;
    }
    for (int i = 1; i < m; i++) {
        matrix[i , n - 1] = number;
        number++;
    }
    for (int j = n - 2; j >= 0; j--) {
        matrix[m - 1, j] = number;
        number++;
    }
    for (int i = m - 2; i > 0; i--)
    {
        matrix[i , 0] = number;
        number++;
    }
    // используем принцип закрашивания картинки
    int k = 1; // индексы первой еще незаполненной ячейки
    int l = 1;
    while (number < m * n) // до тех пор пока не заполним весь массив размером m x n.
    {
        while (matrix[k , l+1] == 0) // Движемся вправо до уже заполненной яцейки.
        {
            matrix[k,l] = number;
            number++;
            l++;
        }
        while (matrix[k+1 ,l] == 0) // Движемся вниз до уже заполненной яцейки.
        {
            matrix[k ,l] = number;
            number++;
            k++;
        }
        while (matrix[k ,l-1] == 0) // Движемся влево до уже заполненной яцейки.
        {
            matrix[k, l] = number;
            number++;
            l--;
        }
        while (matrix[k -1, l] == 0) // Движемся вверх до уже заполненной яцейки.
        {
            matrix[k , l] = number;
            number++;
            k--;
        }
    }
    for (int i = 0; i < m + 1 / 2; i++) // проверяем чтобы в центре не осталось незаполненной ячейки
    {
        for (int j = 0; j < n + 1 / 2; j++)
        {
            if (matrix[i, j] == 0)
                matrix[i, j] = number;
        }
    }
    return matrix; 
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)  // для выравнивания
                Console.Write($" 0{matrix[i, j]}  ");
            else if (matrix[i, j] < 100)
                Console.Write($" {matrix[i, j]}  ");
            else
                Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine("");
    }
}