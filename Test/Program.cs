// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна трём символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] RowCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newArray.Length - count] = array[i];
            count--;
        }
    }
    return newArray;
}

string[] array = new string[18] { "There", "are", "different", "kinds", "of",
 "animals", "on", "our", "planet", "and", "all", "of", "them", "are", "very",
 "important", "for", "it" };
PrintArray(array);
string[] newArray = RowCount(array);
PrintArray(newArray);