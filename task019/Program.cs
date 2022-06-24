// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return double.Parse(param);
}

var b1 = Prompt("Ведите b1= ");
var k1 = Prompt("Ведите k1= ");
var b2 = Prompt("Ведите b2= ");
var k2 = Prompt("Ведите k2= ");

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
Console.WriteLine($"Пересечение в точке: ({x:f2};{y:f2})");