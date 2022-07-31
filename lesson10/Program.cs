//
using System.Linq;
string text = "(1,2) (2,3) (4,5) (6,7)"
.Replace("(", "")       // заменили в строке ( на пустой знак""
.Replace(")", "");      // заменили в строке ) на пустой знак""
Console.WriteLine(text);
var data = text.Split(" ") // Split(" ") разбили строку по пробелам
.Select(item => item.Split(','))   // выбери некий item и преврати его в 
.Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) // 
.ToArray();                 //  создали массив
for (int i = 0; i < data.Length; i++)    // печатаем массив
{
    Console.WriteLine(data[i].x);
    // for (int k = 0; k < data[i].Length; k++)
    //{
    //     Console.WriteLine(data[i][k]);
    // }
}