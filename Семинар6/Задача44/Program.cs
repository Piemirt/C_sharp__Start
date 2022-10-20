//Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Ф.: 0 и 1.

Console.Clear();

Console.Write("Введите количество для расчёта чисел Фибоначчи: ");
int size = int.Parse(Console.ReadLine()!);
int a = 0;
int b = 1;
double[] numbers = new double[size];
numbers[0] = a;
numbers[1] = b;
for (int i = 2; i < numbers.Length; i++)
{
    numbers[i] = numbers[i - 1] + numbers[i - 2];
}
PrintArray(numbers);

void PrintArray(double[] numbers)
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