using System;

int[] numbers = { 1, 2, 3, 4, 5 };
for (int left = 0, right = numbers.Length - 1; left < right; left++, right--)
{
    // Меняем симметричные элементы местами, двигаясь от краёв к центру.
    (numbers[left], numbers[right]) = (numbers[right], numbers[left]);
}

Console.WriteLine($"Стало: {string.Join(" ", numbers)}");
