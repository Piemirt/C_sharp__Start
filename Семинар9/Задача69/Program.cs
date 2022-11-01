// Задача 69. Напишите программу, которая принимает на вход два числа (A и B) и возводит число А в целую степень В с помощью рекурсии..
// Решение с Денисом: --->>>

Console.Clear();

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine()!);
// int result = 1;
// for (int i = 0; i < b; i++)
// {
//     result *= a;
// }
// Console.Write($" {a}^{b} = {result}");

Pow(a,b);

void Pow(int a, int b, int i = 0, int result = 1)
{
    if (i >= b)
    {
        Console.Write($" {a}^{b} = {result}");
        return;
    }
    result *= a;
    i++;
    Pow(a, b, i, result);
}