// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreareArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
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
int Search(int[] array)
{
    int result = 0;
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)  result++;
    }
    return result;
}

int[] arr = CreareArray(5, 100, 1000);
PrintArray(arr);
int result = Search(arr);
Console.WriteLine("чётных чисел в массиве: " + result);