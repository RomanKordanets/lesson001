// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
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
    Console.WriteLine();
}
int[,] MultiplyingMatrix(int[,] matrixA, int[,] matrixB)
{
    var matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("умножение невозможно"); System.Environment.Exit(0);
    }
    return matrix;
}

int rowMatrixA = Promt("Количество строк матрицы А >");
int columnMatrixA = Promt("Количество столбцов матрицы А >");
int rowMatrixB = Promt("Количество строк матрицы В >");
int columnMatrixB = Promt("Количество столбцов матрицы В>");
int min = -10; int max = 10;
int[,] matrixA = GenerateRandomMatrix(rowMatrixA, columnMatrixA, min, max);
int[,] matrixB = GenerateRandomMatrix(rowMatrixB, columnMatrixB, min, max);
int[,] matrixC = MultiplyingMatrix(matrixA, matrixB);
PrintMatrix(matrixA);
PrintMatrix(matrixB);
PrintMatrix(matrixC);