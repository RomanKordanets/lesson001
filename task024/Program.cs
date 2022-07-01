// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов

int[,] GenerateRandomMatrix(int row, int column, int min, int max)
{
    var matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] SumItemRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] = array[i] + matrix[i, j];
        }
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
(int, int) MinSumRow(int[] array)
{
    int minSum = 0;
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum) { minSum = array[i]; position = i + 1; }
    }
    return (position, minSum);
}

int row = 4; int column = 4; int min = -10; int max = 10;
int[,] matrix = GenerateRandomMatrix(row, column, min, max);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] sumRow = SumItemRows(matrix);
PrintArray(sumRow);
(int position, int minSum) = MinSumRow(sumRow);
System.Console.WriteLine($"строка {position} с наименьшей суммой {minSum}");