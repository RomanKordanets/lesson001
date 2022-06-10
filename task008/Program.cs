// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
string number = Console.ReadLine();
int dayNumber = int.Parse(number);
Console.Write(dayNumber);
if (dayNumber == 6 || dayNumber == 7) Console.WriteLine(" -> да");
else if (dayNumber < 1 || dayNumber > 7) Console.WriteLine(" -> это вообще не день недели");
else Console.WriteLine(" -> нет");