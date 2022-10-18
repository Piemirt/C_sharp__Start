// Задача 37(1). Напишите метод, который объединяет два массива в один

Console.Clear();

Console.Write("Введите числа первого массива через пробел: ");
string inputOne = Console.ReadLine()!;
int[] arrayOne = StringToArray(inputOne);

Console.Write("Введите числа второго массива через пробел: ");
string inputTwo = Console.ReadLine()!;
int[] arrayTwo = StringToArray(inputTwo);

int[] arrayThree = new int[arrayOne.Length + arrayTwo.Length];
arrayThree = ConcatArray(arrayOne, arrayTwo);

Console.Write("Объединённый массив: ");
PrintArray(arrayThree);

int[] StringToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int[] ConcatArray(int[] array1, int[] array2)
{
    int[] resultArray = new int[array1.Length + array2.Length];
    int counter = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        resultArray[counter] = array1[i];
        counter++;   
    }
    for (int i = 0; i < array2.Length; i++)
    {
        resultArray[counter] = array2[i];
        counter++;   
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.Write("[ ");

    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i < length -1)
            Console.Write(", ");
    }
    Console.Write(" ]");
}


// Решение №2  --->>>
/*
Console.Clear();

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstArray, secondArray);

Console.WriteLine(String.Join(", ", newArray));

int[] ParseToArray(string str1, string str2)
{
    string str = str1 + ' ' + str2;
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}
*/