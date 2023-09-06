﻿// Задача 68: 
// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"введиме число n-> ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"введиме число m-> ");
int mum = int.Parse(Console.ReadLine()!);
int result = AkkermanFunction(num, mum);
Console.WriteLine(result);

int AkkermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return AkkermanFunction(n - 1, 1);
    else
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}
