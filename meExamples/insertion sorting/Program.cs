// Сортировка вставкой
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
int[] InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int temp = array[i];
        int j = i;
        while (j > 0 && temp < array[j - 1])
        {
            array[j] = array[j - 1];
            j--;
        }
        array[j] = temp;
    }
    return array;
}

int[] array = GenerateRandomArray(10, 0, 10);
PrintArray(array);
int[] meArray = InsertionSort(array);
PrintArray(meArray);