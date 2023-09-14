// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Write("Введите число строк матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] FindMin(int[,] array)
{
    int min = array[0, 0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                imin = i;
                jmin = j;
            }
        }
    }
    Console.WriteLine("Минимальное значение в матрице:" + min);
    Console.WriteLine("Позиция: [" + imin + ", " + jmin + "]");

    int[,] newarray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for (int i = 0; i < imin; i++)
    {
        for (int j = 0; j < jmin; j++)
        {
            newarray[i, j] = array[i, j];
            Console.Write(newarray[i, j] + "\t");
        }
        for (int j = jmin + 1; j < array.GetLength(1); j++)
        {
            newarray[i, j - 1] = array[i, j];
            Console.Write(newarray[i, j-1] + "\t");
        }
        Console.WriteLine();
    }
    for (int i = imin + 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < jmin; j++)
        {
            newarray[i-1, j] = array[i, j];
            Console.Write(newarray[i-1, j] + "\t");
        }
        for (int j = jmin + 1; j < array.GetLength(1); j++)
        {
            newarray[i-1, j-1] = array[i, j];
            Console.Write(newarray[i-1, j-1] + "\t");
        }
        Console.WriteLine();
    }
    array = newarray;
    return newarray;
}

FillArray(array);
FindMin(array);
