using System;

Console.Write("Введите число: ");
long number = Math.Abs(long.Parse(Console.ReadLine()!));
long sum = 0;

while (number > 0)
{
    sum += number % 10; // Остаток от деления на 10 — последняя цифра.
    number /= 10; // Удаляем обработанную цифру.
}

Console.WriteLine($"Сумма цифр: {sum}");
