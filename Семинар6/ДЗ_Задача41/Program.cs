// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.WriteLine("Сколько чисел требуется ввести?");
int countOfNumbers = int.Parse(Console.ReadLine()!);
int count = 0;
for (int i = 1; i <= countOfNumbers; i++)
{
    Console.WriteLine($"Введите {i}-ое число: ");
    int inputNumber = int.Parse(Console.ReadLine()!);
    if (inputNumber > 0)
        count++;
}
Console.WriteLine($"Введено {count} чисел больше нуля.");