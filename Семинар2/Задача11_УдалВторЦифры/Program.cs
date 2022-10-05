// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int hundreds = number / 100;
int ones = number % 10;
Console.WriteLine($"{hundreds}{ones}");