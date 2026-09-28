using System;

Console.Write("Введите слово: ");
string text = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
bool isPalindrome = true;

for (int i = 0; i < text.Length / 2; i++)
{
    // Сравниваем пары символов с противоположных концов строки.
    if (text[i] != text[text.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}

Console.WriteLine(isPalindrome ? "Палиндром" : "Не палиндром");
