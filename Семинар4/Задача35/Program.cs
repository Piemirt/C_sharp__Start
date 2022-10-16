// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите кол-во эл-ов массива, значения которых лежат в отрезке [10, 99].

// Решение с Мироном --->>>

// Console.Clear();

// int[] numbers = new int[123];
// FillArray(numbers);
// PrintArray(numbers);
// int c = GetCount(numbers);
// Console.WriteLine($"Количество элементов от 10 до 99 равно {c} ");

// int GetCount(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] numbers)
// {
//     int count = numbers.Length;
//     Console.Write("[");
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write(numbers[i]);
//         if (i == count - 1)
//             Console.WriteLine("]");
//         else
//             Console.Write(", ");
//     }
//     Console.WriteLine();
// }

// void FillArray(int[] numbers)
// {
//     Random random = new Random();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(0, 201);
//     }
// }


// Решение с Денисом Сапрыкиным --->>>

Console.Clear();

int size = 12;
int[] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);
FindArray(numbers);

void FindArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
            count++;
    }
    Console.WriteLine($"Количество элементов от 10 до 99 равно {count} ");
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-10, 150);
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