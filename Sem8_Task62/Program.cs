// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите число строк матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

int[,] FillArray(int[,] array)
{
    int k = 1; 
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    for (int j = n-1; j < array.GetLength(1); j++)
    {
        for (int i = 1; i < array.GetLength(0); i++)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    for (int i = m-1; i < array.GetLength(0); i++)
    {
        for (int j = m-2; j >= 0; j--)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    for (int i = m-2; i > 0; i--)
    {
        for (int j = 0; j < 1; j++)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    for (int i = 1; i < array.GetLength(0)-2; i++)
    {
        for (int j = 1; j < array.GetLength(1)-1; j++)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    for (int i = 2; i < array.GetLength(0)-1; i++)
    {
        for (int j = 2; j > 0; j--)
        {
            array[i, j] = k;
            k += 1;
        }
    }
    return array;
}

int[,] PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + "\t");
            }
            else
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

FillArray(array);
PrintArray(array);
