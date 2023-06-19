/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;
using static System.Console;
int[,] array = GetArray(4, 4, 0, 45);
//GetArray(array);
PrintArray(array);
int[] res = SumRows(array);
WriteLine();
PrintArray2(res);
MinRow(res);


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

void PrintArray2(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        
            Write($"{inArray[i],3} ");
           
    }  WriteLine();
}

int[] SumRows(int[,] inArray)

{
    int a = inArray.GetLength(0);
    int b = inArray.GetLength(1);
    int[] sum = new int[a];
    int max = sum[0];
   
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++) sum[i] += inArray[i, j];        
    } 
    return sum;
}

void MinRow(int[] inArray)
{ 
    int minRow = 0;
    int min = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i] < min) 
        {
            min = inArray[i];
            minRow = i;
        }        
    }
    WriteLine($"Строка с мин. суммой  { minRow + 1}");
}   WriteLine();