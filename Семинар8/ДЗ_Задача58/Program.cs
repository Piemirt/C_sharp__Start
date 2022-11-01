// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillMatrix(matrix);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix);


FillMatrix(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);


if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
    }
}

Console.WriteLine("Результат произведения двух матриц: ");
PrintMatrix(resultMatrix);


int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}