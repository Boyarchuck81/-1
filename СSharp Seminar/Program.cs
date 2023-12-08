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

/*
 ЗадачаНапишите программу, которая выводит случайное число из отрезка [10, 99]
  и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/ 
int number = new Random().Next(10,100);
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

/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
System.Console.WriteLine("Введите число: ");
int namberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int namberB = Convert.ToInt32(Console.ReadLine());
if (namberA * namberA == namberB || namberB * namberB == namberA)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

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


// Задача2.Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрица-тельные элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

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

