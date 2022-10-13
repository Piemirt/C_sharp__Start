// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите кол-во эл-ов массива, значения которых лежат в отрезке [10, 99].

Console.Clear();

int[] array = new int[123];
FillArray(array);
PrintArray(array);
int c = GetCount(array);
Console.WriteLine($"Количество элементов от 10 до 99 равно {c} ");

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 201);
    }
}