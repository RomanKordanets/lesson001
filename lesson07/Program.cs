// 

int[] CreateArray(int len, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
int [] MultPair (int[] array)
{
    int[] result = new int [(array.Length+1)/2];
    for(int i=0; i<array/2; i++)
    {
        result[i] = array[i] * array[array.Length - 1-i]
    }
    if(array.Length %2 ==1) result[(array.Length)/2];
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int element = array[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int len= prompt()
int min= prompt()
int max= prompt()




//  ******************************************************************
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] ProizvPar(int[] array)
{
    int[] rez = new int[array.Length/2];
   for(int i = 0; i < (array.Length/2); i++)
{
   rez[i]= array[i] * array[array.Length - i -1];
}
return rez;
}
int[] myArray = InitArray(9, 1, 10);
PrintArray(myArray);
int[] myArray2 = ProizvPar(myArray);
PrintArray(myArray2);
