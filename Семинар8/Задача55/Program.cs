// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Решение с Денисом Сапрыкиным: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 7);
int columns = rows;
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером: {rows} * {columns} ");
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Строки в массиве стали столбцами: ");
ChangeRowsColumns(numbers);
PrintArray(numbers);

void ChangeRowsColumns(int[,] numbers)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
        }
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