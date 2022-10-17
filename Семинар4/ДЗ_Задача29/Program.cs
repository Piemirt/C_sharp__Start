// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//                      Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();

int size = 8;
int[] numbers = CreateArray();

FillArray(numbers);
PrintArray(numbers);

int[] CreateArray()
{
    int[] numbers = new int[size];
    return numbers;
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next();
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
            Console.Write("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}