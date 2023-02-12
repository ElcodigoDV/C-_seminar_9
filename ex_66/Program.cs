/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов
в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


// 8 7 6 5 4


// n + (n - 1) + (n + (n - 1)-1)...
// 8 + (8-1) 
//         7 + (7-1)
//                 6 + (6-1)
/* 
n + (n - 1)
        n + (n-1)
                n + (n + 1) */
void SumRecurs(int lowNum, int upNum, int sum)
{
    if (lowNum > upNum)
    {
        Console.WriteLine($" -> {sum}");
    }
    else
    {
        sum = sum + (lowNum++);
        SumRecurs (lowNum, upNum, sum);    
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

int M = GetNum("Insert START number");
int N = GetNum("Insert END number");
int sum = 0;
Console.Write($"M = {M}; N = {N} ");
SumRecurs (M, N, sum);