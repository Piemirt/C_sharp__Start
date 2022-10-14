// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний эл-т, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
// [1 2 3 4 5] --> 5 8 3                [6 7 3 6] --> 36 21

Console.Clear();

int[] array = new int[11];

FillArray(array);
PrintArray(array);
int[] array2 = Product(array);
PrintArray(array2);

int[] Product(int[] arr)
{
    int[] arr2;
    if (arr.Length % 2 == 0)
    {
        arr2 = new int[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            arr2[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    else
    {
        arr2 = new int[arr.Length / 2 + 1];
        for (int i = 0; i < arr.Length / 2 + 1; i++)
        {
            if (i == arr.Length / 2)
                arr2[i] = arr[i];
            else
                arr2[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    return arr2;
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 20);
    }
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