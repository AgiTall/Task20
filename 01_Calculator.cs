using System;

Console.Write("Введите первое число: ");
double first = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double second = double.Parse(Console.ReadLine()!);

Console.WriteLine($"\nСумма: {first + second}");
Console.WriteLine($"Разность: {first - second}");
Console.WriteLine($"Умножение: {first * second}");
// Проверяем делитель заранее: деление на ноль в математике не определено.
if (second == 0)
    Console.WriteLine("Деление: на ноль делить нельзя");
else
    Console.WriteLine($"Деление: {first / second}");
