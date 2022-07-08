// Есть монотонная последовательность, каждое число встречается ровно то количество раз,
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности
// до N-го значения, желательно использовать рекурсию: N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void Recursion(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            System.Console.Write($"{i} ");
        }
    }
    return;
}
int n = Prompt("введите n => ");
Recursion(n);
