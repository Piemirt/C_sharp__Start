//  Задача17. Напишите программу, которая принимает на вход координаты 
//  точки (X и Y), причём X != 0 и Y != 0, и выдаёт номер четверти плоскости, в которой находится эта точка.

void Task17()
{
    Console.Clear();

    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");
    CoordCheck(x,y);
}

void CoordCheck(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в 1 четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находится во 2 четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 4 четверти");
    }
    else
    {
        Console.WriteLine("Точка находится на одной из осей");
    }
}
Task17();