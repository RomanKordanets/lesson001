// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if(numberInt < 100 && numberInt > 1000) Console.WriteLine("Введено неверное число");
else Console.WriteLine("Вторая цыфра числа: " + numberInt % 100 / 10);  // или (n/10)%10