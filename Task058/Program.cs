// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
/*Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

int[,] matrixA = new int[3 , 2] { { 7, 6 }, { 5, 4 }, { 3, 2 } }; // мой вариант матриц
int[,] matrixB = new int[2, 3] { { 2, 3, 4 }, { 5, 6, 7 } };
//int[,] matrixA = new int[2 ,2] { { 2, 4 }, { 3, 2 } };// тестовый вариант матриц
//int[,] matrixB = new int[2, 2] { { 3, 4 }, { 3, 3 } };

if (matrixA.GetLength(0) == matrixB.GetLength(1))
{
    Console.WriteLine("Матрица [А]:");
    PrintArray(matrixA);
    Console.WriteLine("Матрица [B]:");
    PrintArray(matrixB);
    Console.WriteLine("Итоговая матрица [A]*[B]:");
    PrintArray(MultiplicationMatrix(matrixA, matrixB));
}
else
    Console.WriteLine("матрицы такого размера не могут быть перемножены");


int[,] MultiplicationMatrix (int[,] matrixA, int [,]matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k]*matrixB[k, j];
                    }
                }
            }
            return resultMatrix;
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