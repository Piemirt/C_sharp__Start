// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. С помощью рекурсии.
// Решение с Денисом: --->>>

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Сумма цифр в заданном числе = {GetSumNumbersRecursion(number)}");

int GetSumNumbersRecursion(int number, int sum = 0)
{
    if (number == 0)
        return sum;
    sum = sum + number % 10;
    number = number / 10;
    return GetSumNumbersRecursion(number, sum);
}