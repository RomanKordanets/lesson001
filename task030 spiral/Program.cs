// Заполнение двумерного массива по спирали

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
int[,] FillMatrixSpiral(int n){
var matrix = new int[n, n];
int number = 1;
for (int i = 0; i <= n / 2; i++)     // сколько кругов делаем
{
    for (int kol = i; kol < n - i; kol++)   // идём вправо
    { matrix[i, kol] = number; number++; }

    for (int row = i + 1; row < n - i; row++)   // идём вниз
    { matrix[row, n - 1 - i] = number; number++; }

    for (int kol = n - i - 2; kol >= i; kol--)   // идём влево
    { matrix[n - 1 - i, kol] = number; number++; }

    for (int row = n - 2 - i; row > i; row--)   // идём вверх
    { matrix[row, i] = number; number++; }
}
return matrix;
}

int[,] matrix = FillMatrixSpiral(5);
PrintMatrix(matrix);