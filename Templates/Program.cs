// Шпаргалка

int row = 4; int column = 4; int min = -10; int max = 10;

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int row = Prompt("Количество строк >");
int column = Prompt("Количество столбцов >");

int[] GenerateRandomArray(int row, int min, int max)
{
    var array = new int[row];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
int[] array = GenerateRandomArray(row, min, max);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
PrintArray(array);

int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
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
int[,] matrix = GenerateRandomMatrix(row, column, min, max);

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
PrintMatrix(matrix);

int[,] BubbleSortRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)  // количестко проходов
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}
int[,] myMatrix = BubbleSortRow(matrix);

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
int[,] matrixC = MultiplyingMatrix(matrixA, matrixB);

// все чётные натуральные числа
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
void PrintEvenNatural(int m, int n)
{
    if (m % 2 == 1) m++;
    if (m > n)
    {
        return;
    }
    Console.Write($"{m},");
    PrintEvenNatural(m + 2, n);
}
PrintEvenNatural(Prompt("введите m => "), Prompt("введите n => "));

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

// сумма от 1 до n
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}






//************************************************************************



// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Использовать рекурсию.
int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}
int PrintNatural(int number)
{
    if (number == 0)
    {
        return 0;
    }
    else return PrintNatural(number / 10) + number % 10;
}
System.Console.WriteLine(PrintNatural(Prompt("write number ")));


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}
int PrintNatural(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return (a * PrintNatural(a, b - 1));
    }

}
// PrintNatural(Prompt("write A "), Prompt("write B"));
System.Console.WriteLine(PrintNatural(Prompt("write A "), Prompt("write B")));
