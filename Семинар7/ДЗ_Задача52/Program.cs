//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] numbers = new int[6, 6];
FillArray(numbers);
PrintArray2x(numbers);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по каждому столбцу: ");
Console.WriteLine();
PrintArray(AverageAriphmetic(numbers));


double[] AverageAriphmetic(int[,] numbers)
{
    double sum;
    double[] result = new double[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            sum = sum + numbers[j, i];
        }
        result[i] = Math.Round(sum / numbers.GetLength(0), 2);
    }
    return result;
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "\t");
    }
    Console.WriteLine();
}

void PrintArray2x(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}