/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using System;
using static System.Console;
Clear();

int[,] array = GetArray(4, 5, 0, 45);

PrintArray(array);
WriteLine();
ChangeRows(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}

void ChangeRows(int[,] inArray)

{
    int a = inArray.GetLength(0);
    int b = inArray.GetLength(1);

    for (int i = 0; i < a; i++)
    {   
        for (int j = 0; j < b; j++)      
            for (int k = 0; k < b; k++)
            {
                if (inArray[i, j] >= inArray[i, k]) 
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }        
    }
   for (int i = 0; i < a; i++, Console.WriteLine()) 
        for (int j = 0; j < b; j++) 
        {             
            Console.Write("{0,4}", inArray[i, j]);
        }
}
