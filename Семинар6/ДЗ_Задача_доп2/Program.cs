// Задача 2*. Написать программу, которая принимает от пользователя положительные числа и считает среднее значение этих чисел.
// Ввод чисел осуществляется до тех пор, пока пользователь не введёт "-1". Ввод чисел и расчёт должен происходить в рекурсии.
// 1    2   3   4   -1      -> 2,5
// Решение с Мироном: --->>>

Console.Clear();

double average = CalcAverageFromConsole();
Console.WriteLine(average);

double CalcAverageFromConsole(double sum = 0, int count = 0)
{
    Console.Write("Введите положительное число: ");
    double number = double.Parse(Console.ReadLine()!);

    if (number == -1)
        return sum / count;
    else
        return CalcAverageFromConsole(sum + number, count + 1);
}