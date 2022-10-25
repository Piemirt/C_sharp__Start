// Задача 49. Задайте двумерный массив. Найдите эл-ты, у которых оба индекса чётные, и замените эти эл-ты на их квадраты.
// Решение с Мироном: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 6);
int columns = random.Next(4, 6);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером {rows} * {columns}: ");
FillArray(numbers);
PrintArray(numbers);
ReplaceArray(numbers);
Console.WriteLine();
PrintArray(numbers);

void ReplaceArray(int[,] numbers)
{
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            numbers[i, j] = (int)Math.Pow(numbers[i, j], 2);
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

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(1, 6);
        }
    }
}