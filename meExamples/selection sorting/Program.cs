// Сортировка выбором (почти не применяется)

int[] array = { 9, 4, 8, 2, 3 };
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");   // Join = соединить
// Cортировка
for (int i = 0; i < array.Length; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[MinIndex])
            MinIndex = j;
    }
    int temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");