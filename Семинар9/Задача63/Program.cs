// Задача 63. Задайте значене N. Напишите программу, кторая через рекурсию выведет все натуральные числа от 1 до N.
// Решение с Денисом: --->>>

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
FindNumRecursion(number);

void FindNumRecursion(int number, int counter = 0)
{
    counter++;
    Console.WriteLine(counter);
    if (counter >= number)
        return;
    FindNumRecursion(number, counter);
}