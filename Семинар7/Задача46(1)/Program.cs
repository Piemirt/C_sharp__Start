// Задача 46. Задайте трёхмерный массив размером m*n*z, заполненный случ. целыми числами (от 0 до 99). Выведите массив в консоль.
// Решение с Мироном --->>>

Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите z: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] numbers = new int[m, n, z];
FillArray(numbers);
PrintArray(numbers);


void PrintArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write($"{numbers[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                numbers[i, j, k] = random.Next(0, 100);
            }
        }
    }
}