// Задача16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1)
    Console.WriteLine("Является квадратом");
else
    Console.WriteLine("НЕ является квадратом");