using System;

int[] numbers = { 10, 20, 30, 40, 50 };
long sum = 0;

foreach (int number in numbers)
    sum += number;

// Приведение к double предотвращает целочисленное деление с отбрасыванием дробной части.
double average = (double)sum / numbers.Length;
Console.WriteLine($"Массив: {string.Join(" ", numbers)}");
Console.WriteLine($"Среднее: {average}");
