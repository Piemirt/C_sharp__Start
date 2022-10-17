// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//              Ограничения:
// - НЕЛЬЗЯ использовать класс Math
// - Должна быть отдельная функция Power, которая возвращает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число (число должно быть натуральным): ");
int b = int.Parse(Console.ReadLine()!);
int result = Power();

if (b < 0)
    Console.WriteLine("Число должно быть натуральным!");
else
    Console.WriteLine($"Число {a} в степени {b} равно {result}");

int Power()
{
    int pow = 1;
    for (int i = 1; i <= b; i++)
    {
        pow *= a;
    }
    return pow;
}