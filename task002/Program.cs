// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
string Str_1 = Console.ReadLine();
Console.Write("Введите число 2: ");
string Str_2 = Console.ReadLine();
Console.Write("Введите число 3: ");
string Str_3 = Console.ReadLine();
int Int_1 = int.Parse(Str_1);
int Int_2 = int.Parse(Str_2);
int Int_3 = int.Parse(Str_3);
int max = Int_1;

if (max < Int_2) max = Int_2;
if (max < Int_3) max = Int_3;
Console.WriteLine($"{Int_1}, {Int_2}, {Int_3} => {max}");