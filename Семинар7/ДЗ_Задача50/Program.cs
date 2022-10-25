// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] numbers = new int[6, 6];
FillArray(numbers);
PrintArray(numbers);

Console.Write("Введите индекс строки: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int column = int.Parse(Console.ReadLine()!);
if (IndexCheck(numbers, row, column))
    Console.WriteLine($"Значение запрошенного элемента: {numbers[row, column]}");
else
    Console.WriteLine("Элемента с заданными индексами нет в данном массиве");

bool IndexCheck(int[,] numbers, int row, int column)
{
    if (row < numbers.GetLength(0) &&
        column < numbers.GetLength(1) &&
        row >= 0 &&
        column >= 0)
    {
        return true;
    }
    else
        return false;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}