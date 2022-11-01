// Задача 64: Задайте значение N. Напишите программу, которая выведет все нату-ые числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"                 N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
FindNumRecursion(number);

void FindNumRecursion(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        FindNumRecursion(number - 1);
    }
    else if (number == 1)
    {
        Console.Write(number);
        Console.WriteLine();
    }
    if (number <= 0)
    {
        Console.WriteLine($"Натуральных чисел от 1 до {number} нет");
    }
}