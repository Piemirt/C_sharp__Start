// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Ограничения:
// Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();

int size = 6;
int[] numbers = new int[size];

FillArray(numbers, -10, 10);
PrintArray(numbers);
int sum = GetSum(numbers);
Console.WriteLine("Сумма элементов на нечётных позициях = " + sum);

int GetSum(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += numbers[i];
    }
    return sum;
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 1000)
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