using System;

string[] choices = { "камень", "ножницы", "бумага" };
Random random = new();

Console.Write("Ваш выбор (камень, ножницы или бумага): ");
string userChoice = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
if (Array.IndexOf(choices, userChoice) < 0)
{
    Console.WriteLine("Некорректный выбор.");
    return;
}

// Next(длина) возвращает случайный индекс от 0 до длины массива, не включая её.
string computerChoice = choices[random.Next(choices.Length)];
Console.WriteLine($"Компьютер: {computerChoice}");

if (userChoice == computerChoice)
    Console.WriteLine("Ничья!");
// Здесь перечислены все три комбинации, в которых побеждает игрок.
else if ((userChoice == "камень" && computerChoice == "ножницы") ||
         (userChoice == "ножницы" && computerChoice == "бумага") ||
         (userChoice == "бумага" && computerChoice == "камень"))
    Console.WriteLine("Вы победили!");
else
    Console.WriteLine("Победил компьютер!");
