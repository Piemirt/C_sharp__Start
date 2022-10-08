// Два числа. Является ли первое число квадратом второго?

Console.Clear();

Console.Write("Введите первое число: ");
string inputA = Console.ReadLine()!;
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine()!;
int numberB = int.Parse(inputB);

if(numberA == numberB * numberB)
{
    Console.WriteLine("Первое число явлется квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ явлется квадратом второго");
}