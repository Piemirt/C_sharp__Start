// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// Ограничения:
// Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();

int size = 8;
double[] numbers = new double[size];

FillArrayDouble(numbers);
PrintArrayDouble(numbers);
double max = FindMax(numbers);
double min = FindMin(numbers);
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) = {Math.Round(max - min, 2)}");

double FindMax(double[] numbers)
{
    int length = numbers.Length;
    double max = double.MinValue;
    for (int i = 0; i < length; i++)
    {
        if (max < numbers[i])
            max = numbers[i];
    }
    return max;
}

double FindMin(double[] numbers)
{
    int length = numbers.Length;
    double min = double.MaxValue;
    for (int i = 0; i < length; i++)
    {
        if (min > numbers[i])
            min = numbers[i];
    }
    return min;
}

void FillArrayDouble(double[] numbers)
{
    int length = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        double value = random.NextDouble() * 30 -20;
        numbers[i] = Math.Round(value, 2);
    }
}

void PrintArrayDouble(double[] numbers)
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