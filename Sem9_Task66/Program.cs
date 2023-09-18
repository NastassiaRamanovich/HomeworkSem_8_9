// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
void SumNumber(int M, int N)
{
    if (M > N) 
    {
        Console.WriteLine("Сумма натуральных элементов от M до N равна " + sum);
        return;
    }
    sum = sum + M;
    SumNumber(M + 1, N);
}

SumNumber(4, 8);