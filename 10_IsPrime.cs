using System;

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
bool isPrime = number > 1;

// Достаточно проверять делители до корня: у составного числа второй множитель будет не меньше корня.
for (int divisor = 2; divisor * divisor <= number && isPrime; divisor++)
    if (number % divisor == 0) isPrime = false;

Console.WriteLine(isPrime ? "Число простое" : "Число не простое");
