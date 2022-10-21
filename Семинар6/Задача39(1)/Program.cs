// Задача 39(1). Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. Использовать рекурсию.
// Решение с Мироном --->>>

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(RecurSum(a));

int RecurSum(int a)
{
    if (a > 1)
    {
        return a + RecurSum(a - 1);
    }
    else
    {
        return 1;
    }
}