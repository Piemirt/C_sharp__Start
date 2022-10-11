// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int sum = 0;
Console.WriteLine($"Сумма чисел от 1 до {a}: ");

for (int i = 1; i <= a; i++)
{
    Console.Write($"{i} + ");
    sum += i;
}
Console.WriteLine();
Console.WriteLine($"= {sum}");