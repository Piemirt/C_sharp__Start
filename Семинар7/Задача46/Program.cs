// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
Console.WriteLine($"Массив размером {rows} x {columns}: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
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
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}