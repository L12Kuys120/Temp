/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

using System;
using static System.Console;

int[,] array1 = new int[,] { { 2, 4 }, { 3, 2 }};
int[,] array2 = new int[,] { { 3, 4 }, { 3, 3 }};

PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
int[,] array3 = MultiMatrix(array1, array2);
PrintArray(array3);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],2} ");
        }
        WriteLine();
    }
}

int[,] MultiMatrix(int[,] arr1, int[,] arr2)
{
    int n = 2; 
    int[,] arr3 = new int[2, 2];
   
    for (int k = 0; k < n; k++)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
             
                
            }   
        }
        
    }return arr3;
}