// Задача 39. Напишите программу, которая перевернёт одномерный массив (последний эл. будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

Console.Write("Введите элементы массива через пробел: ");
string array = Console.ReadLine()!;

int[] newArray = ParseToArray(array);
int[] newNewArray = Reverse(newArray);

Console.Write(String.Join(", ", newNewArray));

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int c = array[i];
        array[i] = array[array.Length - i -1];
        array[array.Length - i -1] = c;
    }
    return array;
}