// Задача 39. Напишите программу, которая перевернёт одномерный массив (последний эл. будет на первом месте, а первый - на последнем и т.д.)
// Решение с Денисом Сапрыкиным --->>>

Console.Clear();

int size = 10;
int[] numbers = new int[size];

FillArray(numbers, -10, 10);
PrintArray(numbers);
ReverseArray(numbers);
PrintArray(numbers);

void ReverseArray(int[] numbers)
{
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        // Решение с применением КОРТЕЖЕЙ! --->>>
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}

void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 9)
{
    maxValue++;
    int length = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(numbers[i]);
        if (i < length - 1)
            Console.Write(", ");
    }
    Console.WriteLine(" ]");
}