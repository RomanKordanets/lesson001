// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
string Str_1 = Console.ReadLine();
int Int_1 = int.Parse(Str_1);
if (Int_1 % 2 == 1) Console.WriteLine($"{Int_1} нечётное");
else Console.WriteLine($"{Int_1} чётное");