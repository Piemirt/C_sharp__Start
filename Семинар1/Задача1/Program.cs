Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int sqr = number * number;
int sqr2 = (int)Math.Pow(number, 3);

Console.Write("Квадрат введённого числа = ");
Console.WriteLine(sqr);
Console.Write("Возведение в выбранную степень = ");
Console.WriteLine(sqr2);