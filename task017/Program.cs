// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива. [3, 7, 22, 2, 78] -> 76

double[] CreareArray(int len, int min, int max)
{
    Random rnd = new Random();
    double[] array = new double[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    int index = 0;
    Console.Write("[");
    while (index < array.Length)
    {
        Console.Write(array[index]);
        index++;
        if (index < array.Length) Console.Write(", ");
    }
    Console.WriteLine("]");
}
double Max(double[] array)
{
    double max = array[0];
    for (int i=1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i=1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double[] arr = CreareArray(5, 0, 99);
PrintArray(arr);
double max = Max(arr);
double min = Min(arr);
Console.WriteLine("max-min = " + max + "-" + min + " = " + (max-min));