// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3             78 -> 2            89126 -> 5

Console.Clear();

Console.Write("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int current = num;
int result = 0;

while (current > 0)
{
    current /= 10;
    result++;
}
Console.Write($"Количество цифр в числе {num} = {result}");