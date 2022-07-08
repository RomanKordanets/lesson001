//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.     m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

int m = Prompt("Введите m >");
int n = Prompt("Введите n >");
System.Console.WriteLine(Akkerman(m, n));