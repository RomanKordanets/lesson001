// сортировка Шелла (усовершенственная сортировка вставками)
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

void ShellSort1(int[] array)
{
    int j;
    int step = array.Length / 2;
    while (step > 0)
    {
        for (int i = 0; i < (array.Length - step); i++)
        {
            j = i;
            while ((j >= 0) && (array[j] > array[j + step]))
            {
                int tmp = array[j];
                array[j] = array[j + step];
                array[j + step] = tmp;
                j -= step;
            }
        }
        step = step / 2;
    }
}

// Немного быстрее
void ShellSort(int[] array)
{
    int step = array.Length / 2;
    while (step > 0)
    {
        for (int i = step; i < array.Length; i++)
        {
            int value = array[i];
            for (int j = i - step; (j >= 0) && (array[j] > value); j = j - step)
                array[j + step] = array[j];
            array[j + step] = value;
        }
        step = step / 2;
    }
}

int[] array = GenerateRandomArray(10, 0, 10);
PrintArray(array);
int[] meArray = InsertionSort(array);
PrintArray(meArray);