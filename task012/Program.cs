﻿// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)  2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int Exponentiation(int a, int b)  // int result = Math.Pow(a, b);
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = Prompt("Ведите A= ");
int b = Prompt("Ведите B= ");
int exponentiation = Exponentiation(a, b);
Console.WriteLine("a^b = " + exponentiation);