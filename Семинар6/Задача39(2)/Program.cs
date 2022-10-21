// Задача 39(2). Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе. Использовать рекурсию.
// Решение с Мироном --->>>

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} количество цифр = {CountDigits(num)}");

//Вариант со счётчиком: --->>>
/*
int CountDigits(int num, int counter = 0)
{
    if (num / 10 == 0)
        return counter + 1;
    else
        return counter + CountDigits(num / 10) + 1;
}
*/

//Вариант без счётчика: --->>>

int CountDigits(int num)
{
    if (num / 10 < 1)
        return 1;
    else
        return 1 + CountDigits(num / 10);
}