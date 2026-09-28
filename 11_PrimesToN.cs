using System;

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

for (int number = 2; number <= n; number++)
{
    bool isPrime = true;
    for (int divisor = 2; divisor * divisor <= number; divisor++)
    {
        if (number % divisor == 0)
        {
            isPrime = false;
            break; // Один найденный делитель уже доказывает, что число составное.
        }
    }

    if (isPrime) Console.Write($"{number} ");
}
Console.WriteLine();
