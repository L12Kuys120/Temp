﻿/*Задача 53:**Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

8 4 2 4

5 9 2 3

1 4 7 2*/

using System;
using static System.Console;
Clear();
Write("Введите колличество строк ");
int m = int.Parse(ReadLine());
Write("Введите колличество столбцов ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n);
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 100);
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
            Write($"{inArray[i,j],5} ");
        }
        WriteLine();
    }
}

PrintArray(array);

int[,] FindingNumber(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(1); i++)
    { 
        int b = array2[0,i];
        array2[0,i] = array2[array2.GetLength(0)-1,i];
        array2[array2.GetLength(0)-1,i] = b;          
    }
    return array2;
}
Console.WriteLine();
PrintArray(FindingNumber(array));

//------------------------------------------------------------------------------------
//Решение препода
using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);
WriteLine();
Write("Введите строку 1: ");
int a1 = int.Parse(ReadLine());
Write("Введите строку 2: ");
int b1 = int.Parse(ReadLine());
ChangeRows(array, a1, b1);
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
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void ChangeRows(int[,] inArray, int a, int b)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[a - 1, i];
        inArray[a - 1, i] = inArray[b - 1, i];
        inArray[b - 1, i] = k;
    }
}