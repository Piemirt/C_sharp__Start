// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = -9

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
    Console.WriteLine("min = " + num2);
}
else
{
    Console.WriteLine("max = " + num2);
    Console.WriteLine("min = " + num1);
}