// Задача со звёздочкой: Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов. 
// Вывести на экран кол-во эл-ов самой длинной последовательности, эл-т самой последовательности и номер эл-та, который является её началом.
// [1 2 2 4 4 4 4 3 3 3] -> Count: 4     Element: 4     Position: 3

Console.Clear();

int[] numbers = CreateArray();
int[] result = FindMaxSequence(numbers);
Console.WriteLine($"Element: {result[0]}");
Console.WriteLine($"Count: {result[1]}");
Console.WriteLine($"Start: {result[2]}");

int[] CreateArray()
{
    return new int[] { 1, 2, 2, 4, 4, 4, 4, 3, 3, 3, 4 };
}

int[] FindMaxSequence(int[] numbers)
{
    int[] result = new int[3];
    int currentSequenceElement = numbers[0];
    int currentSequenceCounter = 0;
    int currentSequenceStart = 0;

    int maxSequenceElement = numbers[0];
    int maxSequenceCounter = 0;
    int maxSequenceStart = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != currentSequenceElement)
        {
            // сравнить текущую последовательность с максимальной
            if (currentSequenceCounter > maxSequenceCounter)
            {
                maxSequenceElement = currentSequenceElement;
                maxSequenceCounter = currentSequenceCounter;
                maxSequenceStart = currentSequenceStart;
            }

            currentSequenceElement = numbers[i];
            currentSequenceCounter = 0;
            currentSequenceStart = i;
        }
        currentSequenceCounter++;
    }
    return new int[] { maxSequenceElement, maxSequenceCounter, maxSequenceStart };
}