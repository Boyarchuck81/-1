// Тема 1 Простые алгоритмы

//Задача 1. Напишите программу, которая принимает на вход число и выдает его квадрат/
// System.Console.WriteLine("Введите число: "); //cw -бытрый ввызов этой команды
// int userNamber = Convert.ToInt32(Console.ReadLine());
// int result = userNamber * userNamber;
// System.Console.WriteLine(result);

// System.Console.WriteLine("Введите число: "); //cw быстрый вызов Console.WriteLine
// int userNamber = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(userNamber * userNamber);

//  /*Задача2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 
  
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// System.Console.WriteLine("Введите число 1: "); 
// int userNumberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число 2: "); 
// int userNumberB = Convert.ToInt32(Console.ReadLine());
// if(userNumberA==userNumberB * userNumberB)
// { 
//     System.Console.WriteLine("да");
// }
// else
// {
//     System.Console.WriteLine("нет");
// }
// Второй способ
// System.Console.WriteLine("Введите число 1: "); 
// int userNumberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число 2: "); 
// int userNumberB = Convert.ToInt32(Console.ReadLine());
// int sqNumber2 = userNumberB * userNumberB;
// bool result = userNumberA == sqNumber2;
// System.Console.WriteLine(result);

// Третий способ
// System.Console.WriteLine("Введите число a: "); 
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число b: "); 
// int b = Convert.ToInt32(Console.ReadLine());
// string txtresult = $"Число [a] не является квадратом числа [b]";   //если условие выполняется, частица "не" заменятся пустотой 
// if (a == b * b)
//     txtresult = txtresult.Replace(" не", "");
// System.Console.WriteLine(txtresult);

// Задача3.Программа, которая принмает номер и выдает день недели
// Console.WriteLine("Введите номер дня недели:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA == 1) Console.WriteLine("Понедельник");
// if (numberA == 2) Console.WriteLine("Вторник");
// if (numberA == 3) Console.WriteLine("Среда");
// if (numberA == 4) Console.WriteLine("Четверг");
// if (numberA == 5) Console.WriteLine("Пятница");
// if (numberA == 6) Console.WriteLine("Суббота");
// if (numberA == 7) Console.WriteLine("Воскресенье");
// else if (numberA > 7) System.Console.WriteLine("нет такого дня недели");

// Второй мой способ
// Console.WriteLine("Введите номер дня недели:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA <= 7) 
// {if (numberA == 1) Console.WriteLine("Понедельник");
// if (numberA == 2) Console.WriteLine("Вторник");
// if (numberA == 3) Console.WriteLine("Среда");
// if (numberA == 4) Console.WriteLine("Четверг");
// if (numberA == 5) Console.WriteLine("Пятница");
// if (numberA == 6) Console.WriteLine("Суббота");
// if (numberA == 7) Console.WriteLine("Воскресенье");}
// else  System.Console.WriteLine("нет такого дня недели");


/*
5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int start = numberA * -1;
// while (start <= numberA)  
// {
//    Console.Write(start+", ");
//    start = start + 1;
// }  

// // Второй способ
//  Console.WriteLine("Введите число: ");
// int numberA = int.Parse(Console.ReadLine());
// for(int i = -numberA; i <= numberA; i++)
//    Console.Write(i + " ");
// //          или 
//    System.Console.Write($"{i}, ");
  
/*
7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/
Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = numberA % 10;
System.Console.WriteLine(result);

