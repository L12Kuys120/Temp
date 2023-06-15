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
/*Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());*/

int[,] array = GetArray(4, 5, 0, 45);
//GetArray(array);
PrintArray(array);
ChangeRows(array);
WriteLine();
PrintArray(array);


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

int[,] ChangeRows(int[,] inArray)

{
    int a = inArray.GetLength(0);
    int b = inArray.GetLength(1);

    for (int i = 0; i < a; i++)
    {
        for (int j = 1; j < b; j++)
        {
            if (inArray[i, j - 1] < inArray[i, j])
            {
                int k = inArray[i, j - 1];
                inArray[i, j - 1] = inArray[i, j];
                inArray[i, j] = k;
            }
        }   
         
    }  return inArray;
}  




/*void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }            
    }
}
*/