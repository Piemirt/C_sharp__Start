Console.Clear();

Console.Write("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if((num < 1000) & (num > 99))
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Число не соответствует условию задачи.");
}