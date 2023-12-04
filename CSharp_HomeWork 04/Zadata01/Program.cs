
/*Задача1. Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная. 
5 12 16 q [STOP]
3 45 342 15 [STOP]
*/

Console.Clear();
while (true)
{
    Console.WriteLine("Введите любое целое число. Программа завершиться словом 'STOP' при вводе числа, сумма цифр которого четная, или при введении 'q'");
    string num = Console.ReadLine()!;
    if (num.ToLower() == "q") {
        Console.WriteLine("STOP");
        break;
    }
      if (int.TryParse(num, out int number))
      {
        int numSum = CDS(number);
        if (numSum % 2 == 0) {
            Console.WriteLine($"STOP");
            break;
        }
        else {
            Console.Write(" ");
        }
    }
    else {
    Console.WriteLine("Внимательно читайте условие! Попробуйте еще.");
    }
}

int CDS(int num) // CDS = CalculateDigitSum{
    int sum = 0;
    while (num != 0) {
        sum += num % 10; // Получаем последнюю цифру числа и добавляем её к сумме.
        num /= 10; // Удаляем последнюю цифру из числа.
    }
    return sum;
}

// Идеальное решение
// Задача 1: Бесконечный запрос чисел до ввода ‘q’ или числа с четнойсуммой цифр
// using System;
// class Program
// {
// static void Main()
// {
// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа
// {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа
// }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break;
// }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
// }
// }
// }
// }
