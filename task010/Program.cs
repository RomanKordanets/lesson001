// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int x1 = Prompt("Ведите Ax= ");
int y1 = Prompt("Ведите Ay= ");
int z1 = Prompt("Ведите Az= ");
int x2 = Prompt("Ведите Bx= ");
int y2 = Prompt("Ведите By= ");
int z2 = Prompt("Ведите Bz= ");
int a = x1-x2;
int b = y1-y2;
int c = z1-z2;
double l = Math.Sqrt(a*a+b*b+c*c); // корень квадратный
Console.WriteLine("Расстояние между А и B = "+ l);