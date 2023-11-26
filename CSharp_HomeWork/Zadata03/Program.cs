// See https://aka.ms/new-console-template for more information
/*
 Напишите программу, которая  принимет на вход целое число из отрезка [10, 99]
  и показывает наибольшую цифру числа.
40 => 4
96 => 9
72 => 7
*/ 


Console.Write("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine()!);
while (number < 10 || number > 99)
{
    Console.Write("Вы ввели неверное число!\Введите число от 10 до 99: ");
    number = int.Parse(Console.ReadLine()!);
}
int first = number / 10;
int last = number % 10;
if (first>last)
{
    System.Console.WriteLine("Наибольшая " + first);
}
else
{
     System.Console.WriteLine("Наибольшее " + last);
}
