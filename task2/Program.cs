// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите значение b1 И k1 через запятую");
string inputS1=Console.ReadLine();
string[] array1 =inputS1.Split(',');
Console.WriteLine("Введите значение b2 И k2 через запятую");
string inputS2=Console.ReadLine();
string[] array2 =inputS2.Split(',');
double b1=Convert.ToDouble(array1[0]);
double k1=Convert.ToDouble(array1[1]);
double b2=Convert.ToDouble(array2[0]);
double k2=Convert.ToDouble(array2[1]);
//Console.WriteLine((double)2/(double)(-4));
//y = k2 * x + b2;
double x=(b2-b1)/(k1-k2);
//Console.WriteLine((double)x);
double y = k1 * x + b1;
if ( k1==k2) Console.WriteLine("Не пересекаются");
else Console.WriteLine("("+x+","+y+")");