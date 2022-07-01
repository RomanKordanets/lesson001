// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива

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
int[,] BubbleSortRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)  // количестко проходов
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i,j] < matrix[i,j + 1])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,j + 1];
                    matrix[i,j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = GenerateRandomMatrix(4, 4, -10, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] myMatrix = BubbleSortRow(matrix);
PrintMatrix(myMatrix);