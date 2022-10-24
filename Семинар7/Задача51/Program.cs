// Задача 51. Задайте двумерный массив. Найдите сумму эл-ов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 8);
int columns = rows;
int[,] numbers = new int[rows, columns];
int sum = 0;
Console.WriteLine($"Массив размером {rows} * {columns}: ");
FillArray(numbers);
PrintArray(numbers);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i == j)
            sum = sum + numbers[i, j];
    }
}
Console.WriteLine($"Сумма элементов по главной диагонали = {sum}");

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 11);
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