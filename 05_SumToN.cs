using System;

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
long sum = 0;

for (int i = 1; i <= n; i++)
    sum += i;

Console.WriteLine($"Сумма: {sum}");
