using System;

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 0)
{
    Console.WriteLine("Факториал отрицательного числа не определен.");
    return;
}

// Начинаем с 1, потому что это нейтральный элемент умножения (и 0! = 1).
long result = 1;
for (int i = 2; i <= n; i++)
    result *= i;

Console.WriteLine($"Факториал: {result}");
