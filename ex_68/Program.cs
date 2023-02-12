/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

// from Wikipedia
/* функция ack(n, m)
  если n = 0
    вернуть m + 1
  иначе, если m = 0
    вернуть ack (n - 1, 1)
  еще
    вернуть ack(n - 1, ack (n, m - 1)) */

long Ackerman(long n, long m)
{
    if (n == 0)
    {
        m = m + 1;
        return m;
    }
    else
    {
        if (m == 0)
        {
            return Ackerman(n - 1, 1);
        }
        else
        {
            return Ackerman(n - 1, Ackerman(n, m - 1));
        }
    }
}

long GetNum(string text)
{
    Console.WriteLine(text);
    long num = Int32.Parse(Console.ReadLine());
    return num;
}

long m = GetNum("Insert n argument");
long n = GetNum("Insert m argument");
Console.WriteLine();
Console.Write($"m = {m}, n = {n} - > ");
long ack = Ackerman(m, n);
Console.Write($"{ack}");
Console.WriteLine();
