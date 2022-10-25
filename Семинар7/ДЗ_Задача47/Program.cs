// Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

Console.Clear();

int m = 5;
int n = 5;
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);


void FillArray(double[,] numbers)
{
    Random random = new Random();
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 200 - 100, 2);
        }
    }
}

void PrintArray(double[,] numbers)
{
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}