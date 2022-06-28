// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int row = 4;
int column = 4;
int[,] array = GenerateArray(row, column, -10, 10);
PrintArray(array);
int numberRow = Promt("Введите № строки >");
int numberColumn = Promt("Введите № столбца >");
if (numberRow > row || numberColumn > column || numberRow <= 0 || numberColumn <= 0)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"[{numberRow},{numberColumn}] = {array[numberRow - 1, numberColumn - 1]}");
}