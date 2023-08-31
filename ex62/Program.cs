// Задача 62: Заполните спирально массив 4 на 4.

Console.Clear();
int[,] myArray = SpiralArray(4, 4);
PrintArray(myArray);

int[,] SpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int value = 1;
    int rowStart = 0, rowEnd = m - 1;
    int colStart = 0, colEnd = n - 1;
    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value++;
        }
        colEnd--;
        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
        }
        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
    }
    return array;
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