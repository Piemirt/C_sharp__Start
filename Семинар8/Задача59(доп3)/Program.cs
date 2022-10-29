// Задача доп3. Двумерный массив размером 5*5 заполнен случайными нулями и единицами. Игорк может ходить только по полям, заполненным единицами.
// Проверьте, существует ли путь из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).
// Решение с Денисом: --->>>

Console.Clear();

int rows = 5;
int columns = 5;
int[,] map = new int[rows, columns];
FillArray(map, 0, 1);
int i_max = rows - 1;
int j_max = columns - 1;
map[0, 0] = 1;
map[i_max, j_max] = 1;
PrintArray(map);
bool exit = false;
FindPath(map);

if (exit) Console.WriteLine("Выход есть!");
else Console.WriteLine("Никак не пройти до выхода");
Console.WriteLine();
PrintArray(map);

void FindPath(int[,] map, int i = 0, int j = 0)
{
    if (i < 0
        || i > i_max
        || j < 0
        || j > j_max
        || map[i, j] == 0
        || map[i, j] == 2)
    {
        return;
    }

    map[i, j] = 2;
    if (i == i_max && j == j_max)
    {
        exit = true;
        return;
    }
    FindPath(map, i + 1, j);
    FindPath(map, i - 1, j);
    FindPath(map, i, j + 1);
    FindPath(map, i, j - 1);
    FindPath(map, i + 1, j + 1);
    FindPath(map, i - 1, j - 1);
    FindPath(map, i + 1, j - 1);
    FindPath(map, i - 1, j + 1);
}

void FillArray(int[,] map, int minValue = 0, int maxValue = 0)
{
    maxValue++;
    Random random = new Random();
    int rows = map.GetLength(0);
    int columns = map.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            map[i, j] = random.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] map)
{
    int rows = map.GetLength(0);
    int columns = map.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(map[i, j] + "  ");
        }
        Console.WriteLine();
    }
}