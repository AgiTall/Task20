using System;

Console.Write("Введите число: ");
long number = long.Parse(Console.ReadLine()!);
long value = Math.Abs(number);
long reversed = 0;

while (value > 0)
{
    // Сдвигаем уже собранное число влево и дописываем его последнюю цифру исходного.
    reversed = reversed * 10 + value % 10;
    value /= 10;
}

if (number < 0) reversed = -reversed;
Console.WriteLine($"Перевернутое число: {reversed}");
