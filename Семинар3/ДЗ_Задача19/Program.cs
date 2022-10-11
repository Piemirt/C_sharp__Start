//  Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  23432 -> да
//  12821 -> да

Console.Clear();

Console.Write("Введите ПЯТИзначное число: ");
int num = int.Parse(Console.ReadLine()!);
num = Math.Abs(num);
int current_num = num;
int result = 0;

if (num > 9999 && num < 100000)
{
    while (current_num > 0)
    {
        int digit = current_num % 10;
        result = result * 10 + digit;
        current_num /= 10;
        Console.WriteLine(result);
    }
    if (num == result)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ является палиндромом");
    }
}
else 
{
    Console.Write("Введено НЕ ПЯТИзначное число");
}