﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

int Func(int num)
{   
    if (num > 1)
    {
        Console.Write($"{ num}, ");
        int result = num - 1;
        return Func(result);
    }
    else
    {
        Console.Write($"{num}\"");
        return 1;
    }
}

Console.WriteLine("Insert nuber");
int N = Int32.Parse(Console.ReadLine());

// int prev = Func(N);
Console.Write($"N = {N} -> \"");
int prev = Func(N);
Console.WriteLine();