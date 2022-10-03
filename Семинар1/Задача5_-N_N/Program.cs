Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);
for (int i = -number; i <= number; i++)
{
    Console.Write(i + $" , ");
}