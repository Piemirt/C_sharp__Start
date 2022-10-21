// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int size = 10;
int[] numbers = new int[size];
int[] other = new int[size];
FillArray(numbers);
for (int i = 0; i < size; i++)
{
    other[i] = numbers[i];
}
Console.WriteLine("Вывод изначального массива: ");
PrintArray(numbers);
Console.WriteLine("Вывод скопированного массива: ");
PrintArray(other);

void FillArray(int[] numbers)
{
    Random random = new Random();
    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        numbers[i] = random.Next(0, 15);
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