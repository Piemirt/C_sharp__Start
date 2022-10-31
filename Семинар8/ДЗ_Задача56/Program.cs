// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой эл-ов.

Console.Clear();

int rows = 4;
int columns = 5;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 0, 20);
PrintMatrix(matrix);

int minSum = SumInRow(matrix, 0);
Console.WriteLine($"Сумма элементов 1 строки = {minSum}");
int minIndex = 0;

for (int i = 1; i < rows; i++)
{
    int sum = SumInRow(matrix, i);
    if (sum < minSum)
    {
        minSum = sum;
        minIndex = i;
    }
    Console.WriteLine($"Сумма элементов {i + 1} строки = {sum}");
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1}. Сумма элементов в ней = {minSum}");


int SumInRow(int[,] matrix, int i)
{
    int columns = matrix.GetLength(1);
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}

void FillMatrix(int[,] matrix, int minValue = 0, int maxValue = 0)
{
    Random random = new Random();
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}