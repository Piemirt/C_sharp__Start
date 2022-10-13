// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите кол-во эл-ов массива, значения которых лежат в отрезке [10, 99].

Console.Clear();

int[] array = new int[123];



Console.WriteLine($"Количество элементов от 10 до 99 равно {c} ");

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 201);
    }
}