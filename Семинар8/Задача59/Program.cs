// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший эл. массива.
// Решение с Денисом: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 8);
int columns = random.Next(4, 8);
int[,] numbers = new int[rows, columns];
Console.WriteLine($"Массив размером: {rows} * {columns} ");
FillArray(numbers);
PrintArray(numbers);

int min = numbers[0, 0];
int i_min = 0;
int j_min = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (numbers[i, j] < min)
        {
            min = numbers[i, j];
            i_min = i;
            j_min = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine($" N [{i_min + 1}, {j_min + 1}] = {min}");

int rowsResult = rows - 1;
int columnsResult = columns - 1;
int[,] result = new int[rowsResult, columnsResult];
int bias_i = 0;
int bias_j = 0;

for (int i = 0; i < rowsResult; i++)
{
    if (i == i_min) bias_i++;
    bias_j = 0;
    for (int j = 0; j < columnsResult; j++)
    {
        if (j == j_min) bias_j++;
        result[i, j] = numbers[i + bias_i, j + bias_j];
    }
}
Console.WriteLine();
PrintArray(result);
Console.WriteLine();

// Другое решение с помощью печати:

for (int i = 0; i < rows; i++)
{
    if (i != i_min)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j != j_min)
                Console.Write(numbers[i, j] + "\t");
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
            numbers[i, j] = random.Next(-100, 101);
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