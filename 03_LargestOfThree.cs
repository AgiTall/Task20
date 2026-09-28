using System;

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine()!);

int largest = first;
if (second > largest) largest = second;
if (third > largest) largest = third;
Console.WriteLine($"\nСамое большое число: {largest}");
