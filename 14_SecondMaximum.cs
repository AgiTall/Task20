using System;

int[] numbers = { 15, 8, 27, 10, 21 };
int max = int.MinValue;
int secondMax = int.MinValue;

foreach (int number in numbers)
{
    if (number > max)
    {
        // Старый максимум становится кандидатом на второе место.
        secondMax = max;
        max = number;
    }
    // Исключаем повтор максимума: требуется второе различное по значению число.
    else if (number > secondMax && number != max)
    {
        secondMax = number;
    }
}

Console.WriteLine($"Массив: {string.Join(" ", numbers)}");
Console.WriteLine(secondMax == int.MinValue
    ? "В массиве нет второго различного числа."
    : $"Второе максимальное: {secondMax}");
