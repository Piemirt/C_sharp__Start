// Задача12. Напишите программу, которая принимает на вход 2 числа и проверяет, кратно ли второе число первому? 
// Если не кратно, то вывести остаток от деления.

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine($"Число не кратно, остаток = {number1 % number2}");
}