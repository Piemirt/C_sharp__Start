Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
for (int i = number * (-1); i <= number; i++)
{
    Console.Write(i + $" , ");
}