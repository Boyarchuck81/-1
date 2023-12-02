// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
x=2; y=3 -> 1 
x=-5; y=3 -> 2
x=-3; y=-2 -> 3
x=4; y=-2 -> 4
*/ 

Console.WriteLine("Введите координаты точки. X: ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки. Y: ");
int userY = Convert.ToInt32(Console.ReadLine());
if (userX>0 && userY>0) System.Console.WriteLine("Точка находится в первой четверти");
if (userX<0 && userY>0) System.Console.WriteLine("Точка находится во второй четверти");
if (userX<0 && userY<0) System.Console.WriteLine("Точка находится в третьей четверти");
if (userX>0 && userY<0) System.Console.WriteLine("Точка находится в четвертой четверти");
if (userX==0 || userY==0) System.Console.WriteLine("Точка не находится ни на одной координатной четверти");

//Идеальное решение
using System;
class Program
{
static void Main()
{
Console.Write("Введите координаты точки X и Y через пробел:");string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
Console.WriteLine("1");
else if (x < 0 && y > 0)
Console.WriteLine("2");
else if (x < 0 && y < 0)
Console.WriteLine("3");
else if (x > 0 && y < 0)
Console.WriteLine("4");
else
Console.WriteLine("Точка находится на оси координат");
}
}
