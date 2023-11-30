// See https://aka.ms/new-console-template for more information
/*
 Напишите программу, которая  принимет на вход целое число из отрезка [10, 99]
  и показывает наибольшую цифру числа.
40 => 4
96 => 9
72 => 7
*/ 


int number = new Random().Next(10,99);
System.Console.WriteLine(number);
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
