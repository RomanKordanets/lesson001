// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11  82 -> 10  9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;  // счётчик
    int result = 0;                                  // результат

    for (int i = 0; i < counter; i++)
    {
        result = result + (numberN % 10);
        numberN = numberN / 10;
    }
    return result;
}

int numberN = Prompt("Ведите число N: ");
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);