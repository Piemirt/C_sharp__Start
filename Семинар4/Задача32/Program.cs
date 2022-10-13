// Задача 32. Напишите программу "замена элементов массива": положительные эл-ты замените на соответствующие отрицательные, и наоборот.

Console.Clear();

int[] numbers = CreateArray();
PrintArray(numbers);

CreateArray();
RevertArray(numbers);
PrintArray(numbers);

int[] CreateArray()
{
    int[] numbers = { 1, 3, -7, 5, -4 };
    return numbers;
}

void RevertArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
}
}

void PrintArray(int[] numbers)
{
    int count = numbers.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(numbers[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}