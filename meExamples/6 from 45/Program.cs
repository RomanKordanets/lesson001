// 6 from 45
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
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int[] array = GenerateRandomArray(6, 1, 45);
PrintArray(array);