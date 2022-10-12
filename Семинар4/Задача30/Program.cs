// Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Console.Clear();

//Random random = new Random();
//int size = random.Next(4, 10);
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
Console.WriteLine(size);

// Заполнение массива с клавиатуры:
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Введите {i + 1}-й элемент массива: ");
//     numbers[i] = int.Parse(Console.ReadLine()!);
// }

FillArray(numbers);
// for (int i = 0; i < size; i++)
// {
//     numbers[i] = random.Next(0, 2);
// }

PrintArray(numbers);
// for (int i = 0; i < size; i++)
// {
//     Console.Write(numbers[i] + "  ");
// }
// Console.WriteLine();


void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
    }
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "  ");
    }
    Console.WriteLine();
}