// Задача 72(доп): Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные:  data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }     info = {2, 3, 3, 1 }    выходные данные: 1, 7, 0, 1
// Решение с Мироном: --->>>

Console.Clear();

int[] arrayData = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] arrayInfo = { 2, 3, 3, 1 };

for (int i = 0; i < arrayInfo.Length; i++)
{
    int decNum = 0;
    for (int j = 0; j < arrayInfo[i]; j++)
    {
        arrayData[j] = arrayData[j] * (int)Math.Pow(2, arrayData.Length - i - 1);
        decNum += arrayData[i];
    }
    Console.Write($"{decNum} ");
}