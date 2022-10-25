// Задача 51. Задайте двумерный массив. Найдите сумму эл-ов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)
// Решение с Мироном: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(5, 6);
int columns = random.Next(5, 6);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером {rows} * {columns}: ");
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов главной диагонали = {SumOfMainDiag(numbers)}");

int SumOfMainDiag(int[,] numbers)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
                sum = sum + numbers[i, j];
        }
    }
    return sum;
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