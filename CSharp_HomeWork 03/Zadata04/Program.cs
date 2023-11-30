// See https://aka.ms/new-console-template for more information
/* 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый -
 на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.


Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр 
этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива
 должен быть равен количеству цифр.
*/ 

int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.WriteLine();
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
PrintArray(Reverse(array));



