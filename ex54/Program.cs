// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] myArray = GetArrayRandom(rows, columns, 1, 10);
int[,] resultArray = OrderElementsOfEachRow(myArray);
PrintArray(myArray);
Console.WriteLine();
PrintArray(resultArray);

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

int[,] OrderElementsOfEachRow(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < result.GetLength(1) - j - 1; k++)
            {
                if (result[i, k] < result[i, k + 1])
                {
                    int temp = result[i, k];
                    result[i, k] = result[i, k + 1];
                    result[i, k + 1] = temp;
                }
            }
        }
    }
    return result;
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