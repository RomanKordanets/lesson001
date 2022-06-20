// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 26  [-4, -6, 4, 67] -> 0

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
    for (int i=0; i < array.Length; i+=2)
    {
        Console.Write(array[i] + " ");
        result = result + array[i];
    }
    return result;
}

int[] arr = CreareArray(5, 0, 10);
PrintArray(arr);
int result = Search(arr);
Console.WriteLine("сумма элементов: " + result);
