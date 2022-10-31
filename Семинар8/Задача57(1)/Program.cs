// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Решение с Мироном: --->>>

Console.Clear();

int[,] matrix = new int[4,4];
Random generator = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = generator.Next(0, 10);
    }
}
 
PrintArray(matrix);
Console.WriteLine();
 
int[] rowArray = MatrixToRow(matrix);
GetFrequence(rowArray);
 
 
int[] MatrixToRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }
    }
    return result;
}
 
void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}
 
 
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
void GetFrequence(int[] sortedArray)
{
    SortArray(sortedArray);
    Console.WriteLine(string.Join(" ", rowArray));
    int currentElement = sortedArray[0];
    int count = 1;
    for (int i = 1; i < sortedArray.Length; i++)
    {
        if (sortedArray[i] != currentElement)
        {
            Console.WriteLine($"{currentElement} встречается {count} раз");
            currentElement = sortedArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{currentElement} встречается {count} раз");
}