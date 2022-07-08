// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные
// числа в промежутке от M до N с помощью рекурсии.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
void PrintEvenNatural(int m, int n)
{
    if(m%2==1) m++;
    if (m > n)
    {
        return;
    }
    Console.Write($"{m},");
    PrintEvenNatural(m + 2, n);
}
PrintEvenNatural(Prompt("введите m => "), Prompt("введите n => "));