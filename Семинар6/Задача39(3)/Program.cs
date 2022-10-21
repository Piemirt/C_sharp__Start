// Задача 39(3). Напишите программу, которая будет рекурсивно выводить каждый элемент массива в консоль.
// Решение с Мироном --->>>

Console.Clear();

int size = 5;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.Write("Рекурсивный массив: ");
RecurPrintArray(numbers);

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.Write("Массив: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}

void RecurPrintArray(int[] numbers, int i = 0)
{
    int length = numbers.Length;
    if (i < length)
    {
        Console.Write(numbers[i] + " ");
        i++;
        RecurPrintArray(numbers, i);
    }
}

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        numbers[i] = random.Next(-50, 50);
    }
}