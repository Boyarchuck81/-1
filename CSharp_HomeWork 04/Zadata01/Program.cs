
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