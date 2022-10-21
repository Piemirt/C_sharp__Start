// Задача 44(1). Напишите программу, которая принимает на вход 2 числа (кол-во строк и  столбцов), создаёт матрицу данного размера,
// заполняет нулями и единицами в случайном порядке и выводит в консоль.
// Решение с Мироном --->>>

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int coloumns = int.Parse(Console.ReadLine()!);
int[,] table = CreateArray(rows, coloumns);
FillArray(table);
PrintArray(table);

int[,] CreateArray(int rows, int coloumns)
{
    int[,] table = new int[rows, coloumns];
    return table;
}

void FillArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 2);
        }
    }
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($" | {table[i,j]} | ");
        }
        Console.WriteLine();
    }
}