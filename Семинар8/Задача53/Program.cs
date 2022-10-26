// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.
// Решение с Денисом Сапрыкиным: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 7);
int columns = random.Next(4, 7);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером: {rows} * {columns} ");
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Первая и последняя строки в массиве поменялись местами: ");
ChangeRows(numbers);
PrintArray(numbers);

void ChangeRows(int[,] numbers)
{
    int minIndex = 0;
    int maxIndex = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (numbers[minIndex, j], numbers[maxIndex, j]) = (numbers[maxIndex,j], numbers[minIndex, j]);
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}