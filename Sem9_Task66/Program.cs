// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
void PrintNumber(int M, int N)
{
    if (M > N) 
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + M;
    PrintNumber(M + 1, N);
}

PrintNumber(4, 8);