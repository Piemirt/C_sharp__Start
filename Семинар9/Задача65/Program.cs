// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натур-ые числа в промежутке от M до N. Рекурсивно.
// Решение с Денисом: --->>>

Console.Clear();

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine()!);
FindNumRecursion(number, numberM);

void FindNumRecursion(int number, int counter = 0)
{
    Console.WriteLine(counter);
    counter++;
    if (counter > number)
        return;
    FindNumRecursion(number, counter);
}