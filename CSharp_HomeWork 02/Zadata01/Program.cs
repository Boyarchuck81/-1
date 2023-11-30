// See https://aka.ms/new-console-template for more information
/*
 Напишите программу, которая принимает на вход число и проверяет, 
 кратно ли оно одновременно 7 и 23.
a=50 => нет
a=7 => нет
a=322 => да
*/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 7 == 0 && numberA % 23== 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
