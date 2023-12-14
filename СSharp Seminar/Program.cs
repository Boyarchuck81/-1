// Тема 1 Простые алгоритмы

//Задача 1. Напишите программу, которая принимает на вход число и выдает его квадрат/
// System.Console.WriteLine("Введите число: "); //cw -бытрый ввызов этой команды
// int userNamber = Convert.ToInt32(Console.ReadLine());// возможно испльзование int.Parsre
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

// задача 8./*
// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает
//  число (number), а на выходе выводит все чётные
//  числа от 1 до number (включительно), 
//  разделеные знаком табуляции.
// */

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= number; i+=2)
// {
//     System.Console.Write(i + "\t");
// }

// Второй способ
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= number; i+=1)
// {
//   if(i % 2 == 0) 
// }
// System.Console.Write(i+"\t");


/*Домашняя работа
 Задача9.Напишите программу, которая выводит случайное число из отрезка [10, 99]
  и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/ 
// int number = new Random().Next(10,100);
// System.Console.WriteLine(number);
// int first = number / 10;
// int last = number % 10;
// if (first>last)
// {
//     System.Console.WriteLine("Наибольшая " + first);
// }
// else
// {
//      System.Console.WriteLine("Наибольшее " + last);
// }
// if (first == last){
//     System.Console.WriteLine("Цифры равны между собой");
// }

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// System.Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int second = numberA / 10 % 10;
// System.Console.WriteLine(second);

/*
Задача11. Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
*/ 
// int number = new Random().Next(100,1000);
// System.Console.WriteLine(number);
// int first = number / 100;
// int three = number % 10;
// int result = first * 10 + three;
// Console.WriteLine(result);

// Второй  способ
// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999)                     // 23 < 100 || 23 > 999 -> 1 + 0 = 1
// {  
//     Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3 * 1);
//            или 
// Console.Write($"{n1}{n3}");


// /*
// Задача 12.Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно

// */
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int numberC = numberA % numberB;
// if (numberA % numberB == 0)
// {
//     System.Console.WriteLine("кратно");
// }
// else
// {
//     System.Console.WriteLine($"некратно, остаток {numberC}");
// }

// Второй способ похожий

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int firstNumber = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int secondNumber = int.Parse(Console.ReadLine()!);
// if (firstNumber % secondNumber == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine($"нет, {firstNumber % secondNumber}");

/*НЕ РАБОТАЕТ ПОСЛЕДНЯЯ СТРОКА
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = number; i >= 100; i /= 10)
// {
//     result = i % 10;
// }
// if (number < 100)
// {
//     Console.WriteLine("Нет третьей цифры");
// }
// else
// {
//     Console.WriteLine($"Третья цифра = {result}");
// }

// Второй способ, но цифру ищем третью с конца
/ Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// number = Math.Abs(number); // модуль числа |-5| = 5
// if (number < 100)
//     Console.WriteLine("Третьей цифры нет");
// else{
//     Console.WriteLine(number % 1000 / 100);
// }
// 456 -> 4
// 3129 -> 1
// 59602 -> 6
// 123456 -> 4
// 9012381 -> 3
// % 100 -> 99(max)
// n % 1000 -> 999(max)
// |int| < 2175......

/*Домашняя задача
 Задача14.Напишите программу, которая принимает на вход число и проверяет, 
 кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA % 7 == 0 && numberA % 23== 0)
// {
//     System.Console.WriteLine("да");
// }
// else
// {
//     System.Console.WriteLine("нет");
// }

/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
*/
// Console.WriteLine("Введите номер дня недели: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA > 0 && numberA <= 5)
// {
//     System.Console.WriteLine("Рабочий день!");
// }
// else if (numberA == 6 || numberA == 7)
// {
//     System.Console.WriteLine("Ура!Выходной!");
// }
// else 
// {
//     System.Console.WriteLine("Нет такого дня недели");
// }

/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
// System.Console.WriteLine("Введите число: ");
// int namberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число: ");
// int namberB = Convert.ToInt32(Console.ReadLine());
// if (namberA * namberA == namberB || namberB * namberB == namberA)
// {
//     System.Console.WriteLine("да");
// }
// else
// {
//     System.Console.WriteLine("нет");
// }

/*Домашняя задача
Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=-4 -> 1
x=-34; y=-30 -> 3
*/ 
// Console.WriteLine("Введите координаты точки. X: ");
// int userX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки. Y: ");
// int userY = Convert.ToInt32(Console.ReadLine());
// if (userX>0 && userY>0) System.Console.WriteLine("Точка находится в первой четверти");
// if (userX<0 && userY>0) System.Console.WriteLine("Точка находится во второй четверти");
// if (userX<0 && userY<0) System.Console.WriteLine("Точка находится в третьей четверти");
// if (userX>0 && userY<0) System.Console.WriteLine("Точка находится в четвертой четверти");
// if (userX==0 || userY==0) System.Console.WriteLine("Точка находится на оси координат");

/*
Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/ 
// Console.WriteLine("Введите один из четырех номер четверти: ");
// int userCvoter = Convert.ToInt32(Console.ReadLine());
// if (userCvoter==1)
// System.Console.WriteLine("Все X и Y больше 0");
// if (userCvoter==2)
// System.Console.WriteLine("Все X меньше 0, и Y больше 0");
// if (userCvoter==3)
// System.Console.WriteLine("Все X и Y меньше 0");
// if (userCvoter==4)
// System.Console.WriteLine("Все X больше 0, Y меньше 0");

/*НЕПОНЯТЕН МЕТОД
Задача 19. Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число
 number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести 
Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
*/
// System.Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (10000 > number || number > 99999)
// {
//     System.Console.WriteLine("Число не пятизначное");
//     return;
// }
// int revN = 0;
// for (int i = number; i > 0; i = i / 10)
// {
//     revN = revN * 10 + i % 10;
// }
// if (number == revN)
// {
//     System.Console.WriteLine("Чиcло является палиндромом");

// }
// else
// {
//     System.Console.WriteLine("Не является палиндромом");
// }

/*НЕПОНЯТНО, КАК ВВОДИТЬ ДАННЫЕ
Задача 20.Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
// Console.WriteLine("Введите координаты точки A (x,y): ");
// int userAx = Convert.ToInt32(Console.ReadLine());
// int userAy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B (x,y): ");
// int userBx = Convert.ToInt32(Console.ReadLine());
// int userBy = Convert.ToInt32(Console.ReadLine());
// //int squareX = (userBx - userAx) * (userBx-userAx) 
// double squareX = Math.Pow(userBx - userAx, 2);// Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
// double squareY = Math.Pow(userBy - userAy, 2);
// double rootXY = Math.Sqrt(squareX + squareY);// Math.Sqrt находит квадратный корень
// System.Console.WriteLine(Math.Round(rootXY, 2));//Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить()

/*
Задача 21. Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве.
*/ 
// Console.WriteLine("Введите координаты точки A (x,y,z): ");
// int userAx = Convert.ToInt32(Console.ReadLine());
// int userAy = Convert.ToInt32(Console.ReadLine());
// int userAz = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B (x,y,z): ");
// int userBx = Convert.ToInt32(Console.ReadLine());
// int userBy = Convert.ToInt32(Console.ReadLine());
// int userBz = Convert.ToInt32(Console.ReadLine());
// double squareX = Math.Pow(userBx - userAx, 2);
// double squareY = Math.Pow(userBy - userAy, 2);
// double squareZ = Math.Pow(userBz - userAz, 2);
// double rootXY = Math.Sqrt(squareX + squareY+squareZ);
// System.Console.WriteLine(Math.Round(rootXY, 2));

/*
Задача 22. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
// System.Console.Write("Введите число: ");
// int usernumber = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= usernumber; i++)
// {
//     System.Console.WriteLine($"{i} * {i} = {Math.Pow(i, 2)}");
// }

/*
Задача 23. Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/ 
// System.Console.WriteLine("Enter number: ");
// int usernumber = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= usernumber; i++)
// {
//     System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
// }

/*ФУНКЦИИ НАЧАЛИСЬ
Задача 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= number; i++)
//     {
//      result = result + i;
     
//     }

// System.Console.WriteLine(result);


// Второй способ

// System.Console.Write("Введите число: ");
// int userA = Convert.ToInt32(Console.ReadLine());

// int Summer(int number)
// {
//     int summ = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         summ = summ + i;
//     }
//     return summ;
// }

// int userResult = Summer(userA);
// System.Console.WriteLine(userResult); 

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/ 
// System.Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Met(numberA, numberB);

// void Met(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result = result * a;
//     }
//     System.Console.WriteLine(result);
// }

/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/ 

// System.Console.WriteLine("Введите число ");
// int userA = Convert.ToInt32(Console.ReadLine());

// int Number(int a)
// {
//     int num = 0;
//      if (a == 0) num = 1;
//     if (a < 0) a = a * -1;
//     for (int i = userA; i > 0; i= i/10)
//     {
//         num++;
//     }
//     return num;
// }
// int userResalt = Number(userA);
// System.Console.WriteLine(userResalt);

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Sum(int num){
//     int root = 0;
//     int result = 0;
//     for (int i = number; i > 0; i = i / 10) {
//         root = i % 10;
//         result = result + root;
//     }
//     return result;
// }
// int userResalt = Sum(number);
// System.Console.WriteLine(userResalt);

/*Задача 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/ 
// System.Console.Write("Введите число: ");
// int userA = Convert.ToInt32(Console.ReadLine());

// int Summer(int number)
// {
//     int summ = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         summ = summ * i;
//     }
//     return summ;
// }

// int userResult = Summer(userA);
// System.Console.WriteLine(userResult);

//ВТОРОЙ СПОСОБ
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= number; i++)
//     {
//      result = result * i;
     
//     }

// System.Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// */
// Console.Clear();

// int[] GetArray(int start, int end, int size) // начало, конец и размер массива
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(start, end + 1);  // заполняем массив рандомными числами в диапазоне введеных данных
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");//[5, 7, 1, 4]
//     }
//     System.Console.Write("]");
// }

// System.Console.WriteLine("Задай диапазон массива от:");
// int userStart = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задай диапазон массива до:");
// int userEnd = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задай размер массива:");
// int userSize = Convert.ToInt32(Console.ReadLine());

// int[] userArray = GetArray(userStart, userEnd, userSize);
// PrintArray(userArray);

/* Задача 30. Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
*/ 
// int[] GetRunArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//        array[i] = new Random().Next(0,2);
//     } 
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]}, ");
//     }
// }
// int[] userArray = GetRunArray(8);
// PrintArray(userArray);

/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");//[5, 7, 1, 4]
//     }
//     System.Console.WriteLine("]");
// }
// int GetSumMinus(int[] arr)
// {
//     int sumMinus = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < 0)
//         {
//             sumMinus = sumMinus + arr[i]; // Прибавляем текущее отрицательное число к сумме
//         }
//     }
//     return sumMinus;
// }
// int GetSumPlus(int[] arr)
// {
//     int sumPlus = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             sumPlus = sumPlus + arr[i]; // Прибавляем текущее отрицательное число к сумме
//         }
//     }
//     return sumPlus;
// }
// int[] userArray = GetArray(8);
// int sumMinus = GetSumMinus(userArray);
// int sumPlus = GetSumPlus(userArray);
// PrintArray(userArray);
// Console.WriteLine("Сумма отрицательных чисел массива:" + sumMinus);
// Console.WriteLine("Сумма положительных чисел массива:" + sumPlus);

/*
Задача 32.Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
*/
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-99, 99);
//     }
//    return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.WriteLine("]");
// }
// void PrintNumArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int num = -1;
        
//         System.Console.Write(arr[i] * num);
//         if (i < arr.Length - 1)

//             System.Console.Write(", ");
//     }
//     System.Console.WriteLine("]");
// }
// int[] userArray = GetArray(size);
// int[] userNumArray = GetArray(size);
// PrintArray(userArray);
// PrintNumArray(userNumArray);
// PrintArray(userArray);

/*
Задача 33. Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве
*/
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Какое число нужно найти в массиве:");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-9, 9);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.WriteLine("]");
// }
// bool CheckNumber(int[] arr,int number)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     if (arr[i] == number)
//     {
//         return true;
//     }
// }
//      return false;
// }
// int[] userArray = GetArray(size);
// bool userNumber = CheckNumber(array, number);
// PrintArray(userArray);
// System.Console.WriteLine(userNumber);

/*Задача 34
Напишите программу, которая подсчитывает количество четных элементов в массиве 
целых положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив целых 
положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
*/ 
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write("\t");//[5, 7, 1, 4]
//     }
   
// }
// int CountEvenElements(int[]arr)
// {
//     int count = 0;
//     for (int i = 0; i <arr.Length; i++)
//     {
//         if(arr[i]%2==0)
//         count++;
//     }
//     return count;
// }
// int[] userArray = GetArray(size);
// int countArray = CountEvenElements(userArray);
// PrintArray(userArray);
// System.Console.WriteLine();
// System.Console.WriteLine("Количество четных элементов: " + countArray);

/*Задача 35
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99]. 
*/

// int size = 123;
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-99, 99);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.WriteLine("]");
// }
// int CountGetArray(int[] arr)
//     {
//         int count = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] >= 10 && arr[i] <= 99)
//             {
//                 count++;
//             }
//         }
//         return count;
//     }
// int[] userArray = GetArray(size);
// int countArray = CountGetArray(userArray);
// PrintArray(userArray);
// System.Console.WriteLine("Количество элементов лежащих в отрезке :" + countArray);

/*Задача 36
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых
чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив 
целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
*/
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write("\t");//[5, 7, 1, 4]
//     }

// }
// int SumOddElements(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 == 1)
//         sum = array[i] + sum;
// }
// return sum;
// }
// int[] userArray = GetArray(size);
// int sumArray = SumOddElements(userArray);
// PrintArray(userArray);
// System.Console.WriteLine();
// System.Console.WriteLine("Сумма нечетных элементов: " + sumArray);

/*Задача 37
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
*/

// int[] GetRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1) System.Console.Write(", ");// [5, 7, 1, 4

//     }

//     System.Console.Write("]");
// }

// int[] ProductArray(int[] arr)                // метод для перемножения пар чисел в одномерном массиве 
//                                 // и передачи результатов перемножения в новый массив
// {
//     int size=0;
//     if (arr.Length%2==1) size=arr.Length/2+1;            // условие, при котором если в исходном массиве нечетное число элементов, 
//     else size=arr.Length/2;                    // чтобы при перемножении пар элементов, начиная с концов массива создать иллюзию
//                                     // перемножения центрального элемента самого на себя
//     int[] res = new int[size];                    // создание нового массива, куда будут записаны результаты перемножения
//     for (int i = 0; i < size; i++)
//     {
//         if ((arr.Length%2==1)&&(i==size-1)) 
//         res[i]=arr[i];                                    // условие, при котором при нечетном количестве элементов исходного массива 
//         else res[i] = arr[i]*arr[arr.Length-i-1];        // средний его элемент будет приравнен к последнему элементу нового массива
//     }
//     return res;
// }
// int[] userArray = GetRandomArray(7);
// PrintArray(userArray);
// System.Console.WriteLine();
// int[] newArray = ProductArray(userArray);
// PrintArray(newArray);

/*Задача 38
Напишите программу для работы с массивом вещественных чисел.
Реализуйте класс ArrayOperations, который содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и
 возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и
 возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных
 чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив
 array и выводит его элементы с двумя знаками после запятой через табуляцию.
*/
// System.Console.WriteLine("Задай размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// Random arr = new Random();
// double[] GetArray(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round((arr.NextDouble() * (10 - 1) + 1), 2);
//     }
//     return array;
// }
// void PrintArray(double[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write("\t");//[5, 7, 1, 4]
//     }

// }
// double FindMax(double[] array)
 
// {
//     double max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//             max = array[i];
//     }
//     return max;
// }
// double FindMin(double[] array)
 
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//             min = array[i];
//     }
//     return min;
// }

// double CalcDifferenceBetweenMaxMin(double[] array)
//     {
//         double max = FindMax(array);
//         double min = FindMin(array);
//         double between = max - min;
//         return between;
//     }
// double[] userArray = GetArray(size);
// PrintArray(userArray);
// Console.WriteLine();
//  double maxNum = FindMax(userArray);
// double minNum = FindMin(userArray);
// double betweenNum = CalcDifferenceBetweenMaxMin(userArray);
//  Console.WriteLine($"Разность между максимальным и минимальным элементом = {betweenNum}");

/*
Задача 39: Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
*/ 
// int Prompt(string massage)
// {
//     System.Console.Write(massage);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] GenerateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] Reverse(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// void PrintArray(int[] arrayOne)
// {
//     System.Console.WriteLine("Массив:");
//     for (int i = 0; i < arrayOne.Length; i++)
//     {
//         System.Console.Write(arrayOne[i]);
//         if (i < arrayOne.Length - 1)
//             System.Console.Write("\t");
//     }
//     System.Console.WriteLine();
// }

// int length = Prompt("Длина массива: ");
// int min = Prompt("Минимальное значение: ");
// int max = Prompt("Максимальное значене: ");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);
// PrintArray(Reverse(array));

/*Задача 40
Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.
*/ 
// System.Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());
// bool Triangle (int numberA,int numberB,int numberC)
// {
//     if(numberA<numberB+numberC && numberB<numberA+numberC && numberC< numberB+numberA) return true;
//     else return false;
// }
// bool userNumber = Triangle ( numberA, numberB, numberC);
// System.Console.WriteLine(userNumber);

/*Задача 41
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/ 
/*Console.WriteLine("Введите числа, разделяя их запятой:");
string num = Console.ReadLine(); // Считываем ввод пользователя
int CountNumbers(string num)
{
     string[] numbers = num.Split(','); // Разделяем строку на числа через метод Split
     int count = 0;
        foreach (string i in numbers)
        {
            int parsedNumber;
            if (int.TryParse(i, out parsedNumber)) // Пытаемся преобразовать строку в число через int.TryParse
            {
                if (parsedNumber > 0) // Проверяем, является ли число больше 0
                {
                    count++;
                }
            }
        }
  return count;
}
     int count = CountNumbers(num);
    Console.WriteLine("Количество чисел больше 0: " + count);*/
//     System.Console.Write("Укажите количество чисел: ");
// int value = int.Parse(System.Console.ReadLine());

// int count = 0;

// for(int i = 0; i < value; i++)
// {
//     System.Console.Write("Введите число: ");
//     if(int.Parse(System.Console.ReadLine()) > 0 ) count++;
// }

// System.Console.WriteLine("Чисел со значением больше нуля было введено: " + count);

/*Задача 42
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
string binary = Convert.ToString(numberA, 2);
System.Console.WriteLine(binary);*/

    
    //     System.Console.Write("Введите число: ");
    //     int decimalNumber = Convert.ToInt32(Console.ReadLine());
    //     string binaryNumber = DecimalToBinary(decimalNumber)// перевод в строку
        
    //  string DecimalToBinary(int decimalNumber)
    // {
    //     string binaryNumber = "";// начало строки

    //     while (decimalNumber > 0)
    //     {
    //         int remainder = decimalNumber % 2; // Остаток от деления на 2
    //         binaryNumber = remainder + binaryNumber; // Добавляем остаток в начало строки
    //         decimalNumber /= 2; // Деление на 2
    //     }

    //     return binaryNumber;
    // }
    // Console.WriteLine(binaryNumber);

/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*Console.WriteLine("Введите значения b1, k1, b2 и k2, разделяя их запятой:");
string input = Console.ReadLine(); // Считываем ввод пользователя
double[] array = ParseInput(input);//Сохраняем значения в массив
double x = CrossPoint(array[0], array[1], array[2], array[3]);
double y = Cusp(x, array[0], array[1]);
double[] ParseInput(string input)
    {
        string[] numbers = input.Split(','); // Разделяем строку на числа
        double[] array = new double[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            double userNumber;
            if (double.TryParse(numbers[i], out userNumber)) // Пытаемся преобразовать строку в число
            {
                array[i] = userNumber;                      //записать в массив
            }
        }
        return array;
    }

double CrossPoint(double b1, double k1, double b2, double k2)
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
        }

        double x = (b2 - b1) / (k1 - k2);// вычисление точки пересечения
        return x;
    }

double Cusp(double x, double b, double k)
    {
        double y = k * x + b;// вычисление точки пересечения
        return y;
    }
Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");*/


// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// void CrossLine(double b1, double k1, double b2, double k2)
// {

//     if (k1 == k2)
//     {
//         if (b1 == b2)
//             System.Console.WriteLine("Прямые совпадают");
//         else
//             System.Console.WriteLine("Прямые параллельны");
//             return;
//     }
//     double x = (-b2 + b1) / (-k1 + k2);
//     double y = k2 * x + b2;
//     Console.WriteLine($"Две прямые пересекаются в точке с координатами X: {x}, Y: {y}");
// }
// CrossLine(b1, k1, b2, k2);

/*
Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/ 
// System.Console.WriteLine("Введите количество чисел Фибоначчи: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// void PrintFibonacci(int numberA)
// {
//     if(numberA<=0) return;
//     int[] fibArray = new int[numberA];
//     fibArray[0]=0;
//     fibArray[1]=1;
//        for (int i = 2; i < numberA; i++)
//        {
//         fibArray[i] = fibArray[i-1]+fibArray[i-2];
//         System.Console.Write(fibArray[i] +" " );
//        }    
// }
// PrintFibonacci(numberA);

/*Задача45
Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/ 
// int Prompt(string massage)
// {
//     System.Console.Write(massage);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] GenerateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] Reverse(int[] array)
// {
//     for (int i = 0; i < array.Length ; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// void PrintArray(int[] arrayOne)
// {
//     System.Console.WriteLine("Массив:");
//     for (int i = 0; i < arrayOne.Length; i++)
//     {
//         System.Console.Write(arrayOne[i]);
//         if (i < arrayOne.Length - 1)
//             System.Console.Write("\t");
//     }
//     System.Console.WriteLine();
// }

// int length = Prompt("Длина массива: ");
// int min = Prompt("Минимальное значение: ");
// int max = Prompt("Максимальное значене: ");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);
// PrintArray(Reverse(array));

/*Задача 46
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
*/ 
// System.Console.Write("Укажите количество строк: ");
// int userM = int.Parse(System.Console.ReadLine());
// System.Console.Write("Укажите количество столбцов: ");
// int userN = int.Parse(System.Console.ReadLine());
// int[,] matrix = new int[userM, userN];
// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < userM; i++)
//     {
//         for (int j = 0; j < userN; j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FeelArray(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] =  new Random().Next(1,10);
//         }
//     }
// }

// PrintArray(matrix);
// FeelArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);


/*Задача 47
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами
*/ 
// System.Console.Write("Укажите количество строк: ");
// int userM = int.Parse(System.Console.ReadLine());
// System.Console.Write("Укажите количество столбцов: ");
// int userN = int.Parse(System.Console.ReadLine());
// Console.WriteLine("Минимальная граница чисел: ");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальная граница чисел: ");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[userM, userN];
// Random num = new Random();
// void PrintArray(double[,] matr)
// {

//     for (int i = 0; i < userM; i++)
//     {
//         for (int j = 0; j < userN; j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }
// void CreateRandomMatrix(double[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//       matrix[i, j] = Math.Round((num.NextDouble() * maxLimitRandom - minLimitRandom) + minLimitRandom, 1);
//         }
//     }
// }
// CreateRandomMatrix(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

/*Задача 48
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
*/ 
// System.Console.Write("Укажите количество строк: ");
// int userM = int.Parse(System.Console.ReadLine());
// System.Console.Write("Укажите количество столбцов: ");
// int userN = int.Parse(System.Console.ReadLine());
// int[,] matrix = new int[userM, userN];
// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < userM; i++)
//     {
//         for (int j = 0; j < userN; j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FeelArray(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] =  i+j;
//         }
//     }
// }

// PrintArray(matrix);
// FeelArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

/*Задача 49
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
*/ 

// Console.Clear();
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void EvenIndex(int[,] newArr)
// {
//     for (int i = 0; i < newArr.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) newArr[i, j] = newArr[i, j] * newArr[i, j];
//         }
//     }
// }


// int[,] array2D = new int[3, 4];
// FillArray(array2D);
// PrintArray(array2D);
// System.Console.WriteLine();
// EvenIndex(array2D);
// PrintArray(array2D);// 

/*Задача 50
Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
*/
// Console.WriteLine("Enter the number of m for the matrix: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of n for the matrix: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the k value for each element: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateIncreasingMatrix(m, n, k);
// Console.WriteLine("Enter the position of the number to find (x): ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the position of the number to find (y): ");
// int y = Convert.ToInt32(Console.ReadLine());
// int[,] CreateIncreasingMatrix(int m, int n, int k)
// {
//    int[,] matrix = new int[m, n];
//    int number = 0;
//    for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = number;
//             number += k;
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//   int m = matrix.GetLength(0);
//   int n = matrix.GetLength(1);
//   for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//         }
// }
// int[] FindNumberByPosition(int[,] matrix, int x, int y)
// {
//  int m = matrix.GetLength(0);
//  int n = matrix.GetLength(1);
// if (x >= m || y >= n)
//     {
//      return new int[1];
//     }
//     int number = matrix[x, y];
//     return new int[] { number, 0 };
//     }
// void PrintCheckIfError(int[] result, int x, int y)
// {
//     if (result.Length == 1)
//     {
//     Console.WriteLine("There is no such index");
//     }
//     else
//     {
//     Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
//     }
// }
// PrintArray(matrix);
// int[] result = FindNumberByPosition(matrix, x, y);
// PrintCheckIfError(result, x, y);
// 
/*Задача 51
//  Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д
// */ 

// int TakeEnteredNumber(string message)
// {
//     System.Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// int[,] GetRandom2DArray(int start, int end, int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(start, end+1);
//         }
//     }
//     return array;
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int MainDiagonalSumm (int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == j) result = result + array [i,j];
//         }
//     }
//     return result;        
// }


// int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
// int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
// int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
// int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
// int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

// Print2DArray(user2DArray);

// int userMainDiagonalSum =  MainDiagonalSumm(user2DArray);
// System.Console.WriteLine($"Сумма элементов на главной диагонали равна:{userMainDiagonalSum}");

/*Задача 52
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
*/ 
// Console.WriteLine("Enter the number of m for the matrix: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number of n for the matrix: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the k value for each element: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateIncreasingMatrix(n, m, k);
// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//    int[,] matrix = new int[n, m];
//    int number = 1;
//    for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matrix[i, j] = number;
//             number += k;
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//   int n = matrix.GetLength(0);
//   int m = matrix.GetLength(1);
//   for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//         Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//         }
// }
// double [] FindAverageInColumns (int [,] matrix)
//  {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     double[] result = new double[columns];
//     for (int j = 0; j < columns; j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < rows; i++)
//         {
//             sum = sum + matrix[i, j];
//         }
//         result[j] = Math.Round((sum / rows),1);
//     }
//     return result;
//     }
//    void PrintListAvr(double[] result)
// {
//     Console.WriteLine("The averages in columns are:");
//    for (int i = 0; i < result.Length; i++)
//    {
//        Console.Write($"{result[i]:f2}"+"\t");
//    }
//    Console.WriteLine();
// }
//  double[] result = FindAverageInColumns(matrix);
// PrintArray(matrix);
// PrintListAvr(result);

/*Задача 53
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива
*/
// System.Console.Write("Укажите количество строк: ");
// int rows = int.Parse(System.Console.ReadLine());
// System.Console.Write("Укажите количество столбцов: ");
// int cols = int.Parse(System.Console.ReadLine());
// int[,] array = new int[rows, cols];
// void PrintArray(int[,] arr)
// {

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FeelArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void ReplacingString(int[,] arr)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             int temp = array[0, i];
//             array[0, i] = arr[rows - 1, i];
//             arr[rows - 1, i] = temp;
//         }
//     }
// }
// void PrintNewArray(int[,] arr)
// {
//  int rows = arr.GetLength(0);
//  int cols = arr.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FeelArray(array);
// System.Console.WriteLine("Исходный массив:");
// PrintArray(array);
// ReplacingString(array);
// System.Console.WriteLine("Массив после замены:");
// PrintArray(array);

/*Задача 54
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/ 

// int[,] newMatrix = new int[3, 4];
// FillmatrixRandom(newMatrix);
// PrintMatrix(newMatrix);
// SortRowsDescending(newMatrix);
// Console.WriteLine();
// PrintMatrix(newMatrix);
// void FillmatrixRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void SortRowsDescending(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

/*Задача 55. Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя*/

// Console.Write("Укажите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int cols = int.Parse(Console.ReadLine());
// int[,] array = new int[rows, cols];

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FeelArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void TransposeArray( ref int[,] arr)// ref -модификатор передачи назначения 
// {
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);
//     int[,] PrintNewArray = new int[cols, rows];
//     if (rows == cols)
//     {
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 PrintNewArray[j, i] = arr[i, j];
//             }
//         }
//         arr = PrintNewArray; // присваиваем PrintNewArray массиву array
//     }
//     else
//     {
//         Console.WriteLine("Невозможно заменить строки на столбцы, так как количество строк не равно количеству столбцов.");
//     }
// }

// void PrintNewArray(int[,] arr)
// {
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FeelArray(array);
// Console.WriteLine("Исходный массив:");
// PrintArray(array);
// Console.WriteLine("Массив после замены строк на столбцы:");
// TransposeArray(ref array);
// PrintNewArray(array);

/*Задача 56
Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
возвращает массив из двух элементов: номер строки 
с наименьшей суммой (нумерация начинается с 0) и саму сумму.
*/ 

// int[,] matrix = new int[4, 4];
// FillArrayRandom(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// NumberRowMinSumElements(matrix);
// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0; //Сумма минимальная в строчке
//     int minSumRow = 0;// номер строки минимальной
//     int sumRow = 0;// Сумма строки
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minRow += matrix[0, i];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка, сумма =  {minRow}");
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

/*Задача 57
Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, 
 сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/
//int TakeEnteredNumber(string message)
// {
//     System.Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int[,] GetRandom2DArray(int start, int end, int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// void PrintCount(int[,] array)
// {
//     for (int k = 0; k <= FindMax(array); k++)
//     {
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {

//                 if (k == array[i, j]) count++;
//             }
//         }
//         System.Console.WriteLine($"Число {k} встречается {count} разa.");
//     }
// }
// int FindMax(int[,] array)
// {
//     int max = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] > max) max = array[i, j];
//         }
//     }
//     return max;
// }
// int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
// int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
// int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
// int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
// int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);
// Print2DArray(user2DArray);
// PrintCount(user2DArray); 

/*Задача 58
Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/
// Console.Write("Укажите количество строк для первой матрицы: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Укажите количество столбцов для первой матрицы: ");
// int cols = int.Parse(Console.ReadLine());
// Console.Write("Укажите количество строк для второй матрицы: ");
// int rows2 = int.Parse(Console.ReadLine());
// Console.Write("Укажите количество столбцов для второй матрицы: ");
// int cols2 = int.Parse(Console.ReadLine());

// int[,] matrixA = new int[rows, cols];
// int[,] matrixB = new int[rows2, cols2];
// int[,] resultArray = new int[rows, cols2];

// FillArray(matrixA);
// Console.WriteLine("Первый массив:");
// PrintArray(matrixA);

// FillArray(matrixB);
// Console.WriteLine("Второй массив:");
// PrintArray(matrixB);

// MultiplyIfPossible(matrixA, matrixB);
// resultArray = MatrixMultiplication(matrixA, matrixB);

// Console.WriteLine("Результат умножения матриц:");
// PrintMatrix(resultArray);
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matrix)
// {
//     Random random = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = random.Next(1, 10);
//         }
//     }
// }

// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//         if (matrixA.GetLength(1) != matrixB.GetLength(0))
//         {
//             Console.WriteLine("Нельзя перемножить матрицы");
//         }
//         else
//         {
//             int[,] resultArray = MatrixMultiplication(matrixA, matrixB);
//             PrintMatrix(resultArray);
//         }
//     }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] resultArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             resultArray[i, j] = 0;
//             for (int k = 0; k < matrixA.GetLength(1); k++)
//             {
//                 resultArray[i, j] += matrixA[i, k] * matrixB[k, j];
//             }
//         }
//     }
//     return resultArray;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

/*Задача 59
Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
// Console.Write("Укажите количество строк: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int cols = int.Parse(Console.ReadLine());
// int[,] arr = new int[rows, cols];
// FillArray(arr);
// int minVal = arr[0, 0];
// int minRow = 0;
// int minCol = 0;
// FindMinValue(arr, ref minVal, ref minRow, ref minCol);
// Console.WriteLine("Исходный массив:");
// PrintArray(arr);
// int[,] newArr = RemoveRowAndColumn(arr, minRow, minCol);
// Console.WriteLine("Массив после удаления:");
// PrintNewArray(newArr);
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = random.Next(1, 10);
//         }
//     }
// }
// void FindMinValue(int[,] arr, ref int minVal, ref int minRow, ref int minCol)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] < minVal)
//             {
//                 minVal = arr[i, j];
//                 minRow = i;
//                 minCol = j;
//             }
//         }
//     }
// }

// int[,] RemoveRowAndColumn(int[,] arr, int rowToRemove, int colToRemove)
// {
//     int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
//     for (int i = 0, k = 0; i < arr.GetLength(0); i++)
//     {
//         if (i == rowToRemove) continue;
//         for (int j = 0, l = 0; j < arr.GetLength(1); j++)
//         {
//             if (j == colToRemove) continue;
//             newArr[k, l] = arr[i, j];
//             l++;
//         }
//         k++;
//     }
//     return newArr;
// }

// void PrintNewArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

/*Задача 60
Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/ 
// int[,,] array3D = new int[3, 3, 3];

// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
// FillArray(array3D);
// PrintIndex(array3D);

// Семинар 1

/*
Виды трансляций:
 - Компиляций(C#, C++, C, Paskal...)
 - Интерпретация(Python, Javascript)

C#(Статическая типизация данных): int n = 10; -> [10]
Python(динамическая типизация данных): n = 10 -> class <'int'> -> [10]
*/
// Ввод и вывод данных
// Console.Clear(); //  Очистка консоли
// Console.Write("Hello, world! "); // Строки внутри C# обрамляютмя двойными кавычками!!!
// Console.Write("Ivan\n"); // \n - принудительный перенос на новую строку
// Console.WriteLine("Hello Ivan!");
// Console.WriteLine("Hello Ivan!");
// Write - написать данные в консоль
// Read - считать данные из консоли

// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!;
// Console.WriteLine($"Привет, {name}!"); // форматированный вывод данных


// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!); // быстрее
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!); // double
// // int m = Convert.ToInt32(Console.ReadLine());
// // "456" -> 456 -> n = 456
// Console.WriteLine($"{n} + {m} = {n + m}");
// Console.WriteLine($"{n} - {m} = {n - m}");
// Console.WriteLine($"{n} * {m} = {n * m}");
// Console.WriteLine($"{n} : {m} = {n / m} (ост. {n % m})"); 
//Комментировать нескольстрочек можно, выделив их и нажав горячие клавиши Сntrl + / (cлэш)

// Задача 1.Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// // = - действие присвоение значения
// // == - проверка на равенство
// // != - проверка на неравенство
// if (m * m == n) // ; ЗАПРЕЩЕНО
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Фигурные скобки нужно ставить, когда внутри конструкции выполняется 2 или более строчки  


// int n = int.Parse("231");
// "231" -> ["231"] -> 231 -> [231]

// Задача 2.Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// (версия 1)

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // for(begin, condition, step)
// // 1 повторение = 1 итерация
// for(int i = -n; i <= n; i++) // i = (-1) * n  i++ <-> i = i + 1 
//     Console.Write($"{i} "); // i + " "
/*
1: i = -2
        |
        -2
2:    i++ <-> i = -2 + 1 = -1
                         |
                         -1
3:                        i++ <-> i = -1 + 1 = 0
                                              |
                                              0
                                              ...
                                              |
                                              2
                                              |
                                              i++ <-> i = 2 + 1 = 3(проверку условия не прошла)
*/
// break <-> метод флажка

// Задача 2(версия 2)
// /* начало комментария
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int i = -n;
// while (i <= n){
//     Console.Write($"{i} ");
//     i++;
// }

// // Задача 3.Напишите программу, которая принимает на вход трёхзначное целое число и на выходе пока-зывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// //  456 : 10 = 45(ост. 6)
// // 456 : 100 = 4(ост. 56)
// int n3 = n % 10;
// int n1 = n / 100;
// Console.Write(n1 + n3);

// Семинар 2

// Алгебра Логики(Булевская Алгебра) - 0(False) или 1(True)
// Алфавит десятичной СС: 0 1 2 3 4 5 6 7 8 9
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = 8 ->       1 * 1 = True
// n = 18 ->      1 * 0 = False
// Console.WriteLine(n > 3 && n < 15);  // ???
// n = 18 ->  1 * (0 + 1) = 1 * 1 = True
// 0 + 1 = 1
// 1 + 1 = 1
// 0 + 0 = 0
// Console.WriteLine(n > 3 && (n < 15 || n % 2 == 0));
// bool(Boolean) - True or False
// if (n > 10) == True
//    n *= 2;

// &&(and) - конъюнкция(логическое умножение)
// ||(or) - дизъюнкция(логическое сложение)

// Задание 1.Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999){ // 23 < 100 || 23 > 999 -> 1 + 0 = 1
//     Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
/*
a = 256 => 26
a = 891 => 81
*/  
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3 * 1);

// Задание 2.Напишите программу, которая принимает на вход трёхзначное число и возводит вторую циф-ру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// // 385 : 10 = 38 (ост. 5)
// // 38 : 10 = 3 (ост. 8)
// int n2 = (n / 10) % 10;
// int n3 = n % 10, result = 1;
// // 1 * n2 * n2... * n2
// //       n3 раз
// for (int i = 1; i <= n3; i++){
//     result = result * n2;
// }
// // n = 345, n2 = 4, n3 = 5
// // 1: result = 1 * 4 = 4
// // 2: result = 4 * 4 = 16
// // 3: result = 16 * 4 = 64
// // 4: result = 64 * 4 = 256
// // 5: result = 256 * 4 = 1024
// Console.WriteLine($"{n2}^{n3} = {result}");

// Задание 3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int firstNumber = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int secondNumber = int.Parse(Console.ReadLine()!);
// if (firstNumber % secondNumber == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine($"нет, {firstNumber % secondNumber}");

// Задание 4.Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// number = Math.Abs(number); // модуль числа |-5| = 5
// if (number < 100)
//     Console.WriteLine("Третьей цифры нет");
// else{
//     Console.WriteLine(number % 1000 / 100);
// }
// 456 -> 4
// 3129 -> 1
// 59602 -> 6
// 123456 -> 4
// 9012381 -> 3
// % 100 -> 99(max)
// n % 1000 -> 999(max)
// |int| < 2175......










// Семинар 3

// Задача1.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// Console.Clear();
// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   for(int i = 0; i < array.Length;i++)
// {
//      array [i] = new Random().Next(-5,6);
// }
//      return array;
// }

// void PrintArray(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write(inArray[i] + " ");
//     }
//         System.Console.WriteLine();
// }

// void FindNumberInArray(int num, int[] ar)
// {
//     bool flag = false;
//     foreach(int element in ar)
//     {
//         if(element == num)
//         {
//             flag = true;
//         }
        
//     }
//     if(flag) Console.Write("да");
//     else Console.Write("нет");
// }

// int LengthArray = 8;
// int[] arr = FillArray(LengthArray);
// PrintArray(arr);
// int LengthArray2 = 12;
// int[] arr2 = FillArray(LengthArray2);
// PrintArray(arr2);

// int number = Convert.ToInt32(Console.ReadLine());
// FindNumberInArray(number, arr);
// System.Console.WriteLine();
// FindNumberInArray(number, arr2);


// Задача2.Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрица-тельные элементы на положительные, а положительные на отрицательные.
// Пример МОЙ МЕТОД НЕ РАБОТАЕТ , смотри задачу 32
// [1 -5 6]
// => [-1 5 -6]

// Console.Clear();
// int[] FillArray(int size)
// {
//   int[] array = new int[size];
//   for(int i = 0; i < array.Length;i++)
// {
//      array [i] = new Random().Next(-10,10);
// }
//      return array;
// }

// void PrintArray(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write(inArray[i] + " ");
//     }
//         System.Console.WriteLine();
// }

// int ChangeElement(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//             arr[i] == arr[i] * -1;
//     }
//     return arr2;
// }

// int LengthArray = 10;
// int[] arr = FillArray(LengthArray);
// PrintArray(arr);

// int number = Convert.ToInt32(Console.ReadLine());
// ChangeElement(arr);
// PrintArray2(arr2);

ВТОРОЙ СПОСОБ

// Console.Clear();

//   int[] array = new int[10];
//   for(int i = 0; i < array.Length;i++)
// {
//      array [i] = new Random().Next(-10,11);
// }
  
// int[] ChangeElement(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//             array[i] = array[i]*-1;
//     }
//     return array;
// }

System.Console.WriteLine(string.Join(" ", array));
ChangeElement(array);
System.Console.WriteLine(string.Join(" ", array));

// Задача3.Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший раз-ряд числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]







// Семинар 4

// Массивы(Array)

// Список(List) <-> import array
// data = [34, 12.5, "Ivan", True]
// 34 - int
// 12.5 - double
// "Ivan" - string

// int[] array = new int[5];
// int[] array = {34, -10, 23, 9, 8};
// array.Length = 5
// [34, -10, 23, 9, 8]
//  0    1   2   3  4
// Console.WriteLine($"0-й элемент: {array[0]}");
// Console.WriteLine($"1-й элемент: {array[1]}");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine(string.Join(", ", array));

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 11); // [-10, 10]
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n]; // 0.0
// // Random().NextDouble() - (0, 1)
// // от 20 до 30
// // Random().NexDouble() * (end - start) + start;
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble() * (30 - 20) + 20, 2);
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Функции и процедуры

// void test(ref int m) // процедура
// {
//     m = m + 10;
// }

// Console.Clear();
// int n = 7;
// test(ref n);
// Console.WriteLine(n);

// Напишите программу, которая принимает от пользователя 2 числа и возвращает наибольшее из них
// int maxNumber(int a, int b){ // Функция
//     if (a > b)
//         return a;
//     return b; // a <= b
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Наибольшее значение: {maxNumber(n, m)}");

// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(-10, 11); // [-10, 10]
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// inputArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 0){
//     int x = n % 10;
//     Console.Write($"{x}, ");
//     n /= 10;
// }
// 567 : 10 = 56 (ост. 7)
// 567 : 10 = 56

// 56 : 10 = 5(ост. 6)
// 56 : 10 = 5

// Задача 1.Задайте одномерный массив, заполненный случайными числами. Определите количество про-стых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(1, 101); // [0, 100]
// }

// bool isPrime(int n){
//     for (int i = 2; i <= n / 2; i++){
//         if (n % i == 0)
//             return false;
//     }
//     return true;
// }
// // 9 % 3 = 0
// // 9:3
// // 9:1
// // 9:9
// // int [217]

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Простые числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (isPrime(array[i]) == true)
//         Console.Write($"{array[i]} ");
// }

// Задача 2.Задайте массив из N случайных целых чисел (N вводится с клавиатуры). Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(0, 101); // [-1000, 1000]
// }

// int isCheck(int[] array){
//     int count = 0;
//     foreach (int element in array){
//         if (element % 10 == 1 && element % 7 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Резльтат: {isCheck(array)}");

// Задача 3.Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находит-ся на 0-м индексе, младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// void inputArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = new Random().Next(0, 10); // [0; 9]
// }

// int formingNumber(int[] array)
// {
//     int result = 0;
//     int i = array.Length - 1;
//     foreach (int el in array){
//         result += el * Convert.ToInt32(Math.Pow(10, i));
//         i--;
//     }
//     return result;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 0 || n > 8){
//     Console.Write("Вы ошиблись! Введите число от 0 до 8: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine(

// Урок 4. Функции. Домашнее задание
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа за-вершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP] 

// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

// Строки
// Ivan
// 0123
// Console.Clear();
// string name = "Ivan"; // String
// // name[1] - char
// char m = '5';
// Console.WriteLine(name[1]);


// Напишите программу, которая принимает на вход число. Посчитайте сумму цифр этого числа
// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!; // "234567"
// int result = 0;
// for (int i = 0; i < number.Length; i++){
//     result += Convert.ToInt32(number[i].ToString());
// }
// Console.WriteLine($"Сумма цифр числа: {result}");


// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// void InputArray(int[] array){
//     for (int i = 0; i < 10; i++){
//         array[i] = new Random().Next(-10, 11); // [-10; 10]
//     }
// }

// int evenNumbers(int[] array){
//     int count = 0;
//     foreach (int el in array){
//         if (el % 2 == 0)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// int[] array = new int[10];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {evenNumbers(array)}");

// Задача4 из ДЗ.Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.   


// Console.Clear();
// int number = new Random().Next(1, 100001);
// int n = number;
// int count = 0;
// while (n > 0){
//     n /= 10;
//     count++;
// }
// Console.WriteLine(number);
// // Console.WriteLine(count);
// int[] array = new int[count];
// while (count > 0){
//     array[count - 1] = number % 10;
//     number /= 10; //  234567 : 10 = 23456
//     count--; // count = count - 1
// }
// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 31);
//         }
//     }
// }


// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// /*
// 1(Console.ReadLine()!). "4 5"
// 2(STRING.Split(" ")). ["4", "5"]
// 3(Select(x => int.Parse(x))). 4 5
// 4(ToArrat()). [4, 5]
// */
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);

// 10:39

// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 31);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void replaceMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i+=2) // (0, 0) (0, 2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2) // (0, 2) (0, 4) ... (2, 0) (2, 2) (2, 4) ...
//         {
//             matrix[i, j] = matrix[i, j] * matrix[i, j];
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// /*
// 1(Console.ReadLine()!). "4 5"
// 2(STRING.Split(" ")). ["4", "5"]
// 3(Select(x => int.Parse(x))). 4 5
// 4(ToArrat()). [4, 5]
// */
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// replaceMatrix(matrix);
// Console.WriteLine("Конечный массив: ");
// PrintMatrix(matrix);


// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 31);
//         }
//     }
// }


// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// int summaElement(int[,] matrix){
//     int result = 0;
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 result += matrix[i, i];
//         }   
//     }
//     return result;
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine($"Сумма элементов главной диагонали: {summaElement(matrix)}");

// void InputMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// double[] AVG(int[,] matrix){
//     double[] avg_array = new double[matrix.GetLength(0)];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         double summa = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             summa += matrix[i, j];
//         }
//         avg_array[i] = summa / matrix.GetLength(1);
//     }
//     return avg_array;
// }


// Console.Clear();
// Console.Write("Введите размеры двумерного массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine($"Среднее арифметическое строк: [{string.Join(", ", AVG(matrix))}]");

// Семинар 6

// Задание 1.
Console.Clear();
// char[] chars = {'a', 'b', 'c', 'd'};
// Console.Write("Введите символы через пробел: ");
// char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();
// /*
// 1. "a b 1 2 3 4 6 c d e"
// 2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
// 3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
// 4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
// */
// string result = string.Empty; // создание пустой строки
// // string result = "";
// foreach (char element in chars){
//     result = result + element;
// }
// Console.WriteLine(result);


// Задание 2
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’] 

// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// char[] chars = new char[initial.Length];
// // Hello
// // 01234
// for (int i = 0; i < initial.Length; i++){
//     chars[i] = initial[i];
// }
// Console.WriteLine($"Результат: [{string.Join(" ", chars)}]");

// Задание 3
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// bool is_vowels(char el, string vowels){
//     for (int i = 0; i < vowels.Length; i++){
//         if (vowels[i] == el)
//             return true;
//     }
//     return false;
// }

    
// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// string vowels = "aeuioy";
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i], vowels))
//         count++;
// }
// Console.WriteLine(count);

// https://learn.microsoft.com/ru-ru/dotnet/api/system.char.isupper?view=netframework-4.8

// bool is_vowels(char el, string vowels="aeuioy"){
//     for (int i = 0; i < vowels.Length; i++){
//         if (vowels[i] == el)
//             return true;
//     }
//     return false;
// }

    
// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// int count = 0;
// for (int i = 0; i < initial.Length; i++){
//     if (is_vowels(initial[i]))
//         count++;
// }
// Console.WriteLine(count);
// Семинар6

// Рекурсия
// Напишите программу, которая принимает от пользователя 2 числа. 
// Необходимо сложить введенные числа, без прямого сложения.

// int summa(int a, int b){
//     if (b == 0)
//         return a;
//     return summa(a + 1, b - 1);
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");

// /*
// a = 5 b = 3 S = summa

// S(5, 3) -> S(6, 2) -> S(7, 1) -> S(8, 0) -> 8
// */

// /*
// Задача 1.
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// */


// int summaCifr(int n){
//     if (n < 10)
//         return n;
//     return summaCifr(n / 10) + n % 10;
// }

// /* n = 456 S = summaCifr
// S(456) -> S(45) + 6 = 4 + 5 + 6 = 15
//             |
//             S(4) + 5 = 4 + 5
//               |
//               4




// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// // int result = 0;
// // while (n >= 10){ // n < 10 || n % 10 = n || n / 10 == 0
// //     result += n % 10;
// //     n /= 10;
// // }
// // Console.WriteLine(result + n);
// Console.WriteLine(summaCifr(n));

// Задача 2.
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// */
// string printNumbers(int n){
//     if (n == 0) // n == 1
//         return ""; // return "1 "
//     return printNumbers(n - 1) + $"{n} ";
// }
// /*
// n = 5 P = printNumbers
// P(5) -> P(4) + "5 " = "1 2 3 4 " + "5 " =  "1 2 3 4 5 "
//         |
//         P(3) + "4 " = "1 2 3 " + "4 " = "1 2 3 4 "
//         |
//         P(2) + "3 " = "1 2 " + "3 " = "1 2 3 "
//         |
//         P(1) + "2 " = "1 " + "2 " = "1 2 "
//         |
//         P(0) + "1 " = "" + "1 " = "1 "
//         |
//         ""
// */


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));

// /*
// Задача 3
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// */

// bool checkVowels(char s){
//     char[] c = {'e', 'u', 'i', 'y', 'a', 'o'};
//     foreach (char el in c){
//         if (el == s)
//             return false;
//     }
//     return true;
// }


// string printChars(string s){
//     if (s.Length == 0)
//         return "";

//     string s_new = String.Empty;
//     for (int i = 0; i < s.Length - 1; i++)
//         s_new += s[i];

//     if (checkVowels(s[s.Length - 1])){
//         return printChars(s_new) + $"{s[s.Length - 1]} ";
//     }
//     return printChars(s_new);
// }
// /*
// s = "hello" P = printChars
// P("hello") -> P("hell")
//                 |
//                 P("hel") + "l "
//                 |
//                 P("he") + "l "
//                 |
//                 P("h")
//                 |
//                 P("") + "h "
//                 |
//                 ""
// */



// Console.Clear();
// Console.Write("Введите строку: ");
// string initial = Console.ReadLine()!;
// Console.WriteLine(printChars(initial));


// using System;
// using System.Linq;

// class Program
// {
// static void Main()
// {
// Console.Write("Введите строку: ");
// string input = Console.ReadLine();

//     foreach (var c in input.Where(char.IsLetter))
//     {
//         if (char.IsWhiteSpace(c))
//             continue;

//         if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
//             || c == 'y' || c == 'A' || c == 'E' || c == 'I' || c == 'O'
//             || c == 'U' || c == 'Y' || (c >='J' && c <='N')
//             || (c >='R' && c <='T') || (c >='B' && c <='K')
//             || (c >='F' && c <='M') || c=='P' || c=='S'
// Продолжи   
// || c==‘V’ || c==‘W’ || c==‘X’ || c==‘Z’)
// {
// Console.Write©;
// }
// }
// }
// }

// https://learn.microsoft.com/ru-ru/dotnet/api/system.int32.minvalue?view=net-8.0

