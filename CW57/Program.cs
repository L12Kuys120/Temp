// *Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза

// 1 встречается 1 раз

// 2 встречается 1 раз

// 8 встречается 1 раз

// 9 встречается 3 раза

// 1, 2, 3,4, 6, 1, 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза*\

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
            result[i, j] = new Random().Next(0, 10);
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


int[] CreateArray(int[,] array2)
{
    int[] array1 = new int[array2.GetLength(0)* array2.GetLength(1)];
    int k = 0;
    
    for (int i = 0; i < array2.GetLength(0); i++)
    { 

        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array1[k] = array2[i,j]; 
            k++;
        }        
    
    }
    return array1;
}

int[] array1 = CreateArray(array);
MetodBubleSort(array1);
Count(array1);

int[] MetodBubleSort(int[] array1)
{
for (int i = 0; i < array1.Length; i++)
            {
                

                for (int j = 0; j < array1.Length - 1 - i; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                       int temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }                   
                }            
            }
            return array1;
        }


void Count(int[] array1)
{
    int count = 1;
    int current = array1[0];
    for(int i = 1; i < array1.Length; i++){
        if (current == array1[i])
        count ++;
        else
        {

            WriteLine($"{current} Встречается {count} раз! ");
            current = array1[i];
            count = 1;
        }
    }

}   

Console.WriteLine();

//------------------------------------------------------------------------------------
//Решение препода

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

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

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
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

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count}");
}



// int[] CountELements(int[,] table, int[] MinMax)
// {
//     int num = MinMax[1] + 1 - MinMax[0];
//     int[] countArray = new int[num];
//     int t = 0;
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             t = table[i, j] - MinMax[0];
//             countArray[t] += 1;
//         }
//     }
//     return countArray;
// }