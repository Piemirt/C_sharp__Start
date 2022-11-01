// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натур-ых эл-ов в промежутке от M до N. Рекурсивно
// M = 1; N = 15 -> 120                        M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} = {NaturalSumRecursion(numberM, numberN)}");

int NaturalSumRecursion(int firstNumber, int secondNumber, int result = 0)
{
    if (firstNumber < secondNumber)
    {
        result = firstNumber + NaturalSumRecursion(firstNumber + 1, secondNumber);
    }
    else if (firstNumber == secondNumber)
    {
        result = result + secondNumber;
    }
    return result;
}