// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8

int [] CreateArray(int length)
{
    int[] array = new int[length];  // создаём массив array
    int index = 0;
    while (index < array.Length)  // заполняем массив
    {
        array[index] = new Random().Next(0, 1000);
        index++;
    }
    return array;
}
void PrintArray(int[] arr)
{
    int index = 0;
    Console.Write("[");
    while (index < arr.Length)
    {
        Console.Write(arr[index]);
        index++;
        if (index < arr.Length) Console.Write(", ");
    }
    Console.Write("]");
}

int [] arr = CreateArray(8);
PrintArray(arr);

