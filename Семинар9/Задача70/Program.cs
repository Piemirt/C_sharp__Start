// Задача 70: Напишите программу, которая печатает последовательность чисел, где каждое следующее равно сумме двух предыдущих. 
// На вход принимает 3 числа: n1, n2 и N, где n1 и n2 - первые числа последовательности, N – длина последовательности
// 3 и 4, N = 5 -> 3 4 7 11 18                  6 и 10, N = 4 -> 6 10 16 26
// Решение с Мироном: --->>>

Console.Clear();
/*
Console.Write("Введите первое число последовательности: ");
int numOne = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число последовательности: ");
int numTwo = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину последовательности: ");
int numThree = int.Parse(Console.ReadLine()!);

int[] result = RowLikeFibo(numThree, numOne, numTwo);
Console.Write(string.Join(", ", result));

int[] RowLikeFibo(int digit, int firstNum, int secondNum)
{
    int[] numbers = new int[digit];
    numbers[0] = firstNum;
    numbers[1] = secondNum;

    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }
    return numbers;
}
*/

//Ещё решение: --->>>

Console.Write("Введите превое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину последовотельности: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"{num1} {num2} ");
for (int i = 1; i <= n - 2; i++)
{
    int num3 = num1 + num2;
    Console.Write($"{num3} ");
    num1 = num2;
    num2 = num3;
}
