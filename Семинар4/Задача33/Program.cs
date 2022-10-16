// Задача 33. Задайте массив. Задайте число. Напишите программу, ктороая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, -3] --> нет             -3; массив [6, 7, 19, 345, -3] --> да

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] numbers = new int[10];

FillArray(numbers);
// if (FindNumber(numbers, num))
//     Console.WriteLine($"Число {num} присутствует в массиве");
// else
//     Console.WriteLine($"Числа {num} нет в массиве");

CheckArray(numbers, num);

PrintArray(numbers);

void CheckArray(int[] numbers, int num)
{
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (num == numbers[i])
        {
            flag = true;
        }
    }
    if (flag == true)
        Console.WriteLine($"Число {num} находится в массиве");
    else
        Console.WriteLine($"Число {num} не находится в массиве");
}

// bool FindNumber(int[] numbers, int num)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 10);
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