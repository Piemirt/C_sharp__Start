// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x = ");
int ax = int.Parse(Console.ReadLine());
Console.Write("y = ");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
int bx = int.Parse(Console.ReadLine());
Console.Write("y = ");
int by = int.Parse(Console.ReadLine());

int p = bx - ax;
int q = by - ay;

double length = Math.Sqrt(p * p + q * q);
length = Math.Round(length, 2);
Console.WriteLine($"Расстояние между точками = {length}");