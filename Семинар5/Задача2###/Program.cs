// Задача 2(доп): Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. 
// Размер массива должен совпадать с квадратом количества единиц в нём.

Console.Clear();

Random random = new Random();
int countOnes = random.Next(1, 11);
Console.WriteLine("Количество единиц: " + countOnes);
int size = countOnes * countOnes;
int[] numbers = new int[size];
int randomIndex = random.Next(0, size);
for (int i = 0; i < countOnes; i++)
{
    while (numbers[randomIndex] == 1)
    {
        Console.WriteLine($"Элемент {randomIndex + 1} уже равен 1, ищем следующий");
        randomIndex = random.Next(0, size);
    }
    numbers[randomIndex] = 1;
    Console.WriteLine($"Элемент {randomIndex + 1} стал 1");
}
PrintArray(numbers);

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