// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Решение с Денисом Сапрыкиным: --->>>

Console.Clear();

int rows = 5;
int columns = rows;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 0, 9);
PrintMatrix(matrix);
Console.WriteLine("Строки стали столбцами и наоборот: ");
ChangeRowsColumns(matrix);
PrintMatrix(matrix);

void ChangeRowsColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            (matrix[i,j], matrix[j,i]) = (matrix[j,i], matrix[i,j]);
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