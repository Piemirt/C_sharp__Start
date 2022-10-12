// Напишите программу, которая принимает на вход число (N) и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int prod = 1;
Console.Write($"Произведение чисел от 1 до {n} = ");

for (int i = 1; i <= n; i++)
{
    prod *= i;
}
Console.Write(prod);