// Задача 48. Задайте двумерный массив размером m*n. Каждый эл. в массиве находится по формуле: Amn = m+n. Выведите массив в консоль.
// Решение с Мироном --->>>

Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);


void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = i + j;
        }
    }
}