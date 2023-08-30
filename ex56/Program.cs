// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] myArray = GetArrayRandom(rows, columns, 1, 10);
int minRow = FindRowWithSmallestSumOfElements(myArray);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine(minRow);

int[,] GetArrayRandom(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int FindRowWithSmallestSumOfElements(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            result[i] = sum;
        }
    }
    int minIndex = 0;
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] < result[minIndex])
        {
            minIndex = i;
        }
        
    }
    return minIndex;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

