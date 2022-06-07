// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
string Str_1 = Console.ReadLine();
Console.Write("Введите число 2: ");
string Str_2 = Console.ReadLine();

int Int_1 = int.Parse(Str_1);
int Int_2 = int.Parse(Str_2);

if (Int_1 > Int_2) Console.WriteLine($"max={Int_1}, min={Int_2}");
if (Int_1 < Int_2) Console.WriteLine($"max={Int_2}, min={Int_1}");
if (Int_1 == Int_2) Console.WriteLine($"{Int_1} = {Int_2}");