// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты точки A в трёхмерном пространстве: ");
Console.Write("x = ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B в трёхмерном пространстве: ");
Console.Write("x = ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("y = ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("z = ");
int bz = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");