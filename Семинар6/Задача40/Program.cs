// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: Каждая сторона треугольника меньше суммы двух других его сторон.

Console.Clear();

int a = InputMessage("Введите первое число: ");
int b = InputMessage("Введите второе число: ");
int c = InputMessage("Введите третье число: ");

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник со сторонами такой длины СУЩЕСТВУЕТ");
}
else
{
    Console.WriteLine("Треугольник со сторонами такой длины НЕ СУЩЕСТВУЕТ");
}

int InputMessage(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}