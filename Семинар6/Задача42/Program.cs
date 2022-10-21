// Задача 42. Напишите программу, ктороая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101             3 -> 11             2 -> 10

// Решение через строку: --->>>
/*
Console.Clear();

int n = InputMessage("Введите число: ");
string result = "";

while (n > 0)
{
    result = n % 2 + result;
    n /= 2;
}
Console.WriteLine(result);

int InputMessage(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
*/
// Решение через конвертацию с учётом системы счисления: --->>>

Console.Clear();

int n = InputMessage("Введите число: ");
string result = Convert.ToString(n, 2);

Console.WriteLine(result);

int InputMessage(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}