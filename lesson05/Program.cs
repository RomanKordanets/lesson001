// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] InitArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(min, max + 1);
    }
    return arrA;
}
void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}
int CalcSumElements(int[] arrA, int sign = 1)
{
    int sum = 0;
    foreach (int element in arrA)
    {
        if (element*sign > 0)
        {
            sum += element;
        }
    }
    return sum;
}
int[] myArray = InitArray(12, -9, 9);
int sumPositive = CalcSumElements(myArray);
System.Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
int sumNegative = CalcSumElements(myArray, -1);
System.Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
PrintArray(myArray);
