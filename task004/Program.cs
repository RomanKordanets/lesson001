// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string Str_1 = Console.ReadLine();
int Int_1 = int.Parse(Str_1);
Console.Write($"{Int_1} => ");
for (int i=1; i<Int_1; i++){if (i % 2 == 0) Console.Write($"{i}, ");}