// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int N = Prompt("Ведите N= ");
int index = 0;
while (index < N)
{
    index++;
    Console.Write(index*index*index + " ");
}