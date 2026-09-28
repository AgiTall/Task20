using System;

Console.Write("Введите число: ");
long number = long.Parse(Console.ReadLine()!);
long value = Math.Abs(number);
// У нуля одна цифра; цикл ниже для него не выполнится.
int count = value == 0 ? 1 : 0;

while (value > 0)
{
    count++;
    value /= 10; // Отбрасываем последнюю цифру при целочисленном делении.
}

Console.WriteLine($"Количество цифр: {count}");
