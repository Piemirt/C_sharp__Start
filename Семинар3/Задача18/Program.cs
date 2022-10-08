// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine()!);

if (a == 1)
{
    Console.WriteLine("В первой четверти: x(0, +&); y(0, +&)");
}
else if (a == 2)
{
    Console.WriteLine("Во второй четверти: x(-&, 0); y(0, +&)");
}
else if (a == 3)
{
    Console.WriteLine("В третьей четверти: x(-&, 0); y(-&, 0)");
}
else if (a == 4)
{
    Console.WriteLine("В четвёртой четверти: x(0, +&); y(-&, 0)");
}
else
{
    Console.WriteLine("Таких четвертей нет =)");
}