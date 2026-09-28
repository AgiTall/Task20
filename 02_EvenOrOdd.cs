using System;

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// Оператор % возвращает остаток; нулевой остаток означает, что число делится на 2.
Console.WriteLine(number % 2 == 0 ? "Число четное" : "Число нечетное");
