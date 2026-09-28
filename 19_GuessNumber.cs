using System;

Random random = new();
// Верхняя граница исключается, поэтому передаём 101, чтобы получить диапазон 1–100.
int secret = random.Next(1, 101);
bool guessed = false;

for (int attempt = 1; attempt <= 7; attempt++)
{
    Console.Write($"Попытка {attempt}/7: ");
    int guess = int.Parse(Console.ReadLine()!);

    if (guess == secret)
    {
        Console.WriteLine($"Вы угадали за {attempt} попыток!");
        guessed = true;
        break;
    }

    Console.WriteLine(guess < secret ? "Загаданное число больше." : "Загаданное число меньше.");
}

if (!guessed)
    Console.WriteLine($"Попытки закончились. Было загадано число {secret}.");
