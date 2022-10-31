// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.
// Решение с Мироном: --->>>

Console.Clear();

int rows = 5;
int columns = 5;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 0, 9);
PrintMatrix(matrix);
Console.WriteLine("Первая строка матрицы поменялась с последней строкой: ");
ChangeMatrixRows(matrix);
PrintMatrix(matrix);


void ChangeMatrixRows(int[,] matrix)
{
    int minIndex = 0;
    int maxIndex = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (matrix[minIndex, j], matrix[maxIndex, j]) = (matrix[maxIndex, j], matrix[minIndex, j]);
    }
}

void FillMatrix(int[,] matrix, int minValue = 0, int maxValue = 0)
{
    maxValue++;
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