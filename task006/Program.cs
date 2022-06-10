// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);   //next первое число включительно, последнее не включая
Console.WriteLine(number);
Console.WriteLine((number / 100 * 10)+(number % 10));