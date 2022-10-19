// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Ограничения:
// Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();

int size = 8;
int[] numbers = new int[size];

FillArray(numbers, 100, 1000);
PrintArray(numbers);
int count = EvenNumbers(numbers);
Console.WriteLine("Количество чётных чисел = " + count);

int EvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0)
            count++;
    }
    return count;
}

void FillArray(int[] numbers, int minValue = 10, int maxValue = 100)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
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