// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new double[row, column];
    Random rnd = new Random();
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(min, max+1) + new Random().NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f3}" + "\t");
        }
        Console.WriteLine();
    }
}
int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int row = Promt("Количество строк >");
int column = Promt("Количество столбцов >");
int min = -100;
int max = 100;
double[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
