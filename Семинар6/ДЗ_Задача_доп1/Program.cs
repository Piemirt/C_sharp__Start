// Задача 1*. Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную.
// 2 -> 10          11 -> 1011          16 -> 10000
// Решение с Мироном: --->>>

Console.Clear();

Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine(DecimToBin(decimalNumber));

string DecimToBin(int decNum, string binNum = "")
{
    if (decNum / 2 > 0)
    {
        binNum += (decNum % 2).ToString();
        return DecimToBin(decNum / 2, binNum);
    }
    else
    {
        binNum += decNum.ToString();
        char[] charArray = binNum.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}