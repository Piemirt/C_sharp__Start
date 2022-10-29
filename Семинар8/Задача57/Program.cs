// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Решение с Денисом: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером: {rows} * {columns} ");
FillArray(numbers, 0, 9);
PrintArray(numbers);
int[] counts = new int[10];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        counts[numbers[i, j]]++;
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Количество {i} в массиве: {counts[i]}");
}

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 0)
{
    maxValue++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minValue, maxValue);
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