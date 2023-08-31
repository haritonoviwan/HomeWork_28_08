// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int rows_1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов первой матрицы: ");
int columns_1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество строк второй матрицы: ");
int rows_2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов второй матрицы: ");
int columns_2 = int.Parse(Console.ReadLine() ?? "");
if (columns_1 != rows_2)
{
    Console.Write("Такие матрицы нельзя перемножить, число столбцов первой матрицы должно быть равно числу строк второй");
}
else
{
    int[,] firstMatrix = GetArrayRandom(rows_1, columns_1, 1, 10);
    int[,] secondMatrix = GetArrayRandom(rows_2, columns_2, 1, 10);
    int[,] result = MatrixProduct(firstMatrix, secondMatrix);
    Console.WriteLine();
    PrintArray(firstMatrix);
    Console.WriteLine(" x");
    PrintArray(secondMatrix);
    Console.WriteLine(" = ");
    PrintArray(result);
}

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

int[,] MatrixProduct(int[,] firstArray, int[,] secondArray)
{

    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            result[i, j] = sum;
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