// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию эл-ты каждой строки двумерного массива.

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 6);
int columns = random.Next(4, 6); ;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
Console.WriteLine("Строки отсортированы по убыванию: ");
SortRows(matrix);
PrintMatrix(matrix);

void SortRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int edge = columns - j - 1;
            for (int k = 0; k < edge; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                }

            }
        }
    }
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