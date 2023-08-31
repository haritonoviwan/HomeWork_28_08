// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();
Console.Write("Введите глубину трехмерного массива: ");
int depth = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,,] myArray = GetArrayRandom(depth, rows, columns, 1, 10);
PrintArray(myArray);

int[,,] GetArrayRandom(int l, int m, int n, int minValue, int maxValue)
{
    int[,,] result = new int[l, m, n];
    for (int d = 0; d < l; d++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[d, i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int d = 0; d < array.GetLength(0); d++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"[{d}, {i}, {j}]: {array[d, i, j]} ");
            }
            Console.WriteLine();
        }
    }
}