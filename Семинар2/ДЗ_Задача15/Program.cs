// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);
string[] week = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};

if (a > 0 && a < 8)
{   Console.WriteLine(week[a-1]);
    if (a == 6 || a == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это будний день");
    }
}
else
{
    Console.WriteLine("А это точно день недели?");
}
