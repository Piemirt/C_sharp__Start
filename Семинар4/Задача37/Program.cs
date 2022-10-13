// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний эл-т, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
// [1 2 3 4 5] --> 5 8 3                [6 7 3 6] --> 36 21

Console.Clear();

int[] array = new int[10];
int[] array2 = new int[5];

FillArray(array);
PrintArray(array);
Product(array, array2);
PrintArray(array2);

void Product(int[] arr, int[] arr2)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arr2[i] = arr[i] * arr[arr.Length - 1 - i];
    }
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