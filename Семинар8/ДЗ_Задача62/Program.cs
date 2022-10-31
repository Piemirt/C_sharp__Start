// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int rows = 6;
int columns = 4;
int[,] matrix = new int[rows, columns];

int index = 0;
int currentRow = 0;
int currentColumn = 0;

int changeIndexRow = 0;
int changeIndexColumn = 1;

int steps = columns;
int turns = 0;

while (index < matrix.Length)
{
    matrix[currentRow, currentColumn] = index + 1;
    index++;
    steps--;
    if (steps == 0)
    {
        if (turns % 2 == 0)
            steps = rows - 1 - turns / 2;
        else
            steps = columns - 1 - turns / 2;
        int temp = changeIndexRow;
        changeIndexRow = changeIndexColumn;
        changeIndexColumn = -temp;
        turns++;
    }
    currentRow += changeIndexRow;
    currentColumn += changeIndexColumn;
}

PrintMatrix(matrix);

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