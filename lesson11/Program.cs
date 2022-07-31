// блядская рекурсия

void Recursion(int n)
{
if (n==0) return;
System.Console.WriteLine(n);
Recursion(n-1);
System.Console.WriteLine(n);
}

int n = 5;
Recursion(n);
