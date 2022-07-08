// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N с помощью рекурсии.
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int PrintSumNatural(int m, int n)
{
    if (m > n) return 0;
    return PrintSumNatural(m, n-1)+ n;
}
int m = Prompt("введите m => ");
int n = Prompt("введите n => ");
int s = PrintSumNatural(m,n);
System.Console.WriteLine($"sum {m}...{n} = {s}");
