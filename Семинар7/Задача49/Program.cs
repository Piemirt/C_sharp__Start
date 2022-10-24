// Задача 49. Задайте двумерный массив. Найдите эл-ты, у которых оба индекса чётные, и замените эти эл-ты на их квадраты.

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
Console.WriteLine($"Массив размером {rows} * {columns}: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < rows; i += 2)
{
    for (int j = 0; j < columns; j += 2)
    {
        numbers[i, j] = numbers[i, j] * numbers[i, j];
    }
}
Console.WriteLine();
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