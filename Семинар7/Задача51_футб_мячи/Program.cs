// Задача доп. Дан двумерный массив из 2 строк и 22 столбцов. В его 1-ой строке записано кол-во мячей, забитых футб. командой в той или иной игре,
// во второй - кол-во пропущенных мячей в этой же игре.
// а) Для каждой проведённой игры напечатать словесный результат: "выигрыш", "ничья" или "проигрыш".
// б) Определить кол-во выигрышей данной команды.
// в) Определить кол-во выигрышей и кол-во проигрышей данной команды.
// г) Определить кол-во выигрышей, кол-во ничьих и кол-во проигрышей данной команды.
// д) Определить, в скольких играх разность забитых и пропущенных мячей была > или = трём.
// е) Определить общее число очков, набранное командой ( за выигрыш даются 3 очка, за ничью - 1, за проигрыш - 0).

Console.Clear();

int rows = 2;
int columns = 10;
int[,] numbers = new int[rows, columns];
FillArray(numbers, 0, 9);
PrintArray(numbers);
int wins = 0;
int loses = 0;
int draws = 0;
int points = 0;
CounterMatches(numbers);

Console.WriteLine("Количество побед: " + wins);
Console.WriteLine("Количество поражений: " + loses);
Console.WriteLine("Количество ничьих: " + draws);
points = wins * 3 + draws;
Console.WriteLine("Количество очков команды: " + points);

void CounterMatches(int[,] numbers)
{
    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            wins++;
            Console.WriteLine($"Победа! Счёт {numbers[0, i]} : {numbers[1, i]}");
        }
        if (numbers[0, i] < numbers[1, i])
        {
            loses++;
            Console.WriteLine($"Проигрыш! Счёт {numbers[0, i]} : {numbers[1, i]}");
        }
        if (numbers[0, i] == numbers[1, i])
        {
            draws++;
            Console.WriteLine($"Ничья! Счёт {numbers[0, i]} : {numbers[1, i]}");
        }
    }
}

void FillArray(int[,] numbers, int minBalls = 0, int maxBalls = 0)
{
    maxBalls++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(minBalls, maxBalls);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}