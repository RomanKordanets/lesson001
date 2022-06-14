// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Ведите число: ");
int n = number;
int dig = 0;
int rev = 0;
while (n > 0)  // Цыфры в обратном порядке
{
    dig = n % 10;
    rev = rev * 10 + dig;
    n = n / 10;
}
//Console.WriteLine("Число с цифрами в обратном порядке: " + rev);
if (number == rev) Console.WriteLine("это палиндром");
else Console.WriteLine("не палиндром");