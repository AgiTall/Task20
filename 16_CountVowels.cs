using System;

Console.Write("Введите строку: ");
// Null заменяем пустой строкой, а регистр нормализуем для одной проверки гласных.
string text = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
const string vowels = "аеёиоуыэюя";
int count = 0;

foreach (char character in text)
    if (vowels.Contains(character)) count++;

Console.WriteLine($"Количество гласных: {count}");
