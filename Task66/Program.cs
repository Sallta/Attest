// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число 1:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число 2:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от M до N = {SumNumbers(M, N)}");

static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}
