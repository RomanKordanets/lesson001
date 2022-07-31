// foreach

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{matrix[i]} ");
    }
}
void FillArray(int[] matrix)
{
    foreach (int i in matrix)
    {
        matrix[i] = new Random().Next(1, 10);
    }
}

int[] matrix = new int[9];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);