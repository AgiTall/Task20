using System;

Console.Write("Количество студентов: ");
int count = int.Parse(Console.ReadLine()!);
if (count <= 0)
{
    Console.WriteLine("Количество студентов должно быть положительным.");
    return;
}

string[] names = new string[count];
double[] grades = new double[count];
double sum = 0;

for (int i = 0; i < count; i++)
{
    Console.Write($"Имя студента {i + 1}: ");
    names[i] = Console.ReadLine() ?? string.Empty;
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = double.Parse(Console.ReadLine()!);
    sum += grades[i];
}

double average = sum / count;
// Храним индекс, чтобы затем вывести и имя, и оценку одного студента.
int bestIndex = 0;
int aboveAverage = 0;
for (int i = 1; i < count; i++)
    if (grades[i] > grades[bestIndex]) bestIndex = i;
for (int i = 0; i < count; i++)
    if (grades[i] > average) aboveAverage++;

Console.WriteLine($"\nСредняя оценка: {average:F1}");
Console.WriteLine($"Лучший студент: {names[bestIndex]} — {grades[bestIndex]}");
Console.WriteLine($"Выше среднего: {aboveAverage}");
