// Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int[] ReverseElementSign(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        arrA[i] = (-1) * arrA[i];
    }
    return arrA;
}
int[] myArray = InitArray(12, -9, 9);
PrintArray(myArray);
int[] reverseArray = ReverseElementSign(myArray);
PrintArray(reverseArray);
