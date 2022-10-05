// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();

Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine(number);
int tens = number / 10;
int ones = number % 10;
Console.WriteLine(tens);
Console.WriteLine(ones);

if (tens == ones)
{
    Console.Write("Числа равны");
}
else if (tens > ones)
{
    Console.WriteLine("max = " + tens);
    Console.WriteLine("min = " + ones);
}
else
{
    Console.WriteLine("max = " + ones);
    Console.WriteLine("min = " + tens);
}