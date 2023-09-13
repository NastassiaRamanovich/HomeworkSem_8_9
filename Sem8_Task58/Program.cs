// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите число строк первой матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m, n];

int[,] FillArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 5);
            Console.Write(array1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array1;
}

Console.Write("Введите число строк второй матрицы:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы:");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array2 = new int[x, y];

int[,] FillArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 5);
            Console.Write(array2[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array2;
}

int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

int[,] MultArray(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
        {
            Console.Write("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }
    else
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] +=  array1[i, k] * array2[k, j];
            }
            Console.Write(array3[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array3;
}

FillArray1(array1);
Console.WriteLine("-----------------------");
FillArray2(array2);
Console.WriteLine("-----------------------");
MultArray(array1, array2);

// using System;

// // класс с методами расширения
// static class MatrixExt
// {
//     // метод расширения для получения количества строк матрицы
//     public static int RowsCount(this int[,] matrix)
//     {
//         return matrix.GetUpperBound(0) + 1;
//     }

//     // метод расширения для получения количества столбцов матрицы
//     public static int ColumnsCount(this int[,] matrix)
//     {
//         return matrix.GetUpperBound(1) + 1;
//     }   
// }

// class Program
// {
//     // метод для получения матрицы из консоли
//     static int[,] GetMatrixFromConsole(string name)
//     {
//         Console.Write("Количество строк матрицы {0}:    ", name);
//         var n = int.Parse(Console.ReadLine());
//         Console.Write("Количество столбцов матрицы {0}: ", name);
//         var m = int.Parse(Console.ReadLine());

//         var matrix = new int[n, m];
//         for (var i = 0; i < n; i++)
//         {
//             for (var j = 0; j < m; j++)
//             {
//                 Console.Write("{0}[{1},{2}] = ", name, i, j);
//                 matrix[i, j] = int.Parse(Console.ReadLine());
//             }
//         }

//         return matrix;
//     }

//     // метод для печати матрицы в консоль
//     static void PrintMatrix(int[,] matrix)
//     {
//         for (var i = 0; i < matrix.RowsCount(); i++)
//         {
//             for (var j = 0; j < matrix.ColumnsCount(); j++)
//             {
//                 Console.Write(matrix[i, j].ToString().PadLeft(4));
//             }

//             Console.WriteLine();
//         }
//     }

//     // метод для умножения матриц
//     static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {       
//         if (matrixA.ColumnsCount() != matrixB.RowsCount())
//         {
//             throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//         }

//         var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

//         for (var i = 0; i < matrixA.RowsCount(); i++)
//         {
//             for (var j = 0; j < matrixB.ColumnsCount(); j++)
//             {
//                 matrixC[i, j] = 0;

//                 for (var k = 0; k < matrixA.ColumnsCount(); k++)
//                 {
//                     matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
//                 }
//             }
//         }

//         return matrixC;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Программа для умножения матриц");

//         var a = GetMatrixFromConsole("A");
//         var b = GetMatrixFromConsole("B");

//         Console.WriteLine("Матрица A:");
//         PrintMatrix(a);

//         Console.WriteLine("Матрица B:");
//         PrintMatrix(b);

//         var result = MatrixMultiplication(a, b);
//         Console.WriteLine("Произведение матриц:");
//         PrintMatrix(result);

//         Console.ReadLine();
//     }
// }