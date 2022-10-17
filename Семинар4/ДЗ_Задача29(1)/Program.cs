// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

Console.Clear();

int size = 10;
int[] numbers = new int[size];

FillArray(numbers);
Console.WriteLine("Вывод первоначального массива: ");
PrintArray(numbers);

for (int i = 1; i < size; i++)
{
    for (int j = 0; j < size - i; j++)
    {
        if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}
Console.WriteLine("Вывод отсортированного по модулю массива: ");
PrintArray(numbers);

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(-30, 30);
    }
}

void PrintArray( int[] numbers)
{
    int count = numbers.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write(numbers[i]);
        if (i == count -1)
            Console.Write(" ] ");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}