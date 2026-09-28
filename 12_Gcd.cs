using System;

Console.Write("Первое число: ");
long a = Math.Abs(long.Parse(Console.ReadLine()!));
Console.Write("Второе число: ");
long b = Math.Abs(long.Parse(Console.ReadLine()!));

while (b != 0)
{
    // Алгоритм Евклида: НОД(a, b) равен НОД(b, остаток от a / b).
    long remainder = a % b;
    a = b;
    b = remainder;
}

Console.WriteLine($"НОД: {a}");
