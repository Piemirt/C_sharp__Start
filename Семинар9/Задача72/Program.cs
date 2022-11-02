// Задача 72: Задан массив, в котором хранится двоичное представление числа.Нужно вывести его десятичное представление
// {0,1,1,1,1} -> 15
// Решение с Мироном: --->>>

Console.Clear();

int[] collection = CreateArray();
FillArray(collection);
Console.WriteLine(String.Join(", ", collection));
int res = BinaryToDecimal(collection);
Console.WriteLine(res);


int[] CreateArray()
{
    int[] result = new int[new Random().Next(1, 7)];
    return result;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

int BinaryToDecimal(int[] array)
{
    int result = 0;
    int count = 0;
    for (int i = array.Length - 1; i > -1; i--)
    {
        result += array[i] * (int)Math.Pow(2, count);
        count++;
    }
    return result;
}