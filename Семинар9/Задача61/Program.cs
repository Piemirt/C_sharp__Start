// Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Решение с Денисом: --->>>

Console.Clear();

Random random = new Random();
int rows = random.Next(4, 7);
int columns = random.Next(4, 7);
int rowsSecond = columns;
int columnsSecond = random.Next(4, 7);
int[,] matrix = new int[rows, columns];
int[,] secondMatrix = new int[rowsSecond, columnsSecond];

FillMatrix(matrix, 0, 5);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix);


FillMatrix(secondMatrix, 0, 5);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);

int[,] resultMatrix = new int[rows, columnsSecond];

// Строка первой матрицы умножается на столбец второй матрицы и всё суммируется. Получается первый элемент результирующей матрицы.
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columnsSecond; j++)
    {
        for (int k = 0; k < rowsSecond; k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
    }
}

Console.WriteLine("Результат произведения двух матриц: ");
PrintMatrix(resultMatrix);


void FillMatrix(int[,] matrix, int minValue, int maxValue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
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