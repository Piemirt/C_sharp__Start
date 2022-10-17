// Задача31. Задайте массив из 12 эл-ов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отриц. и полож. эл-ов массива.

// Решение Задача 31 с Денисом Сапрыкиным --->>>

// Console.Clear();

// int size = 12;
// int[] numbers = new int[size];

// FillArray(numbers, -9, 9);
// PrintArray(numbers);
// Console.WriteLine(GetSumPositive(numbers));
// Console.WriteLine(GetSumNegative(numbers));

// int GetSumPositive(int[] numbers)
// {
//     int sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//             sum += numbers[i];
//     }
//     return sum;
// }

// int GetSumNegative(int[] numbers)
// {
//     int sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] < 0)
//             sum += numbers[i];
//     }
//     return sum;
// }

// void FillArray(int[] numbers,
//                 int minValue = -50,
//                 int maxValue = 50)
// {
//     Random random = new Random();
//     maxValue++;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(minValue, maxValue);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     Console.WriteLine("Вывод массива: ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + "  ");
//     }
//     Console.WriteLine();
// }

// Решение Задача 31 с Мироном --->>>

Console.Clear();

Console.Write("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

Console.Write($"Сумма положительных элементов = {PositiveSum(array)}");
Console.WriteLine();
Console.Write($"Сумма отрицательных элементов = {NegativeSum(array)}");

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int PositiveSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += array[i];
    }
    return count;
}

int NegativeSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count += array[i];
    }
    return count;
}