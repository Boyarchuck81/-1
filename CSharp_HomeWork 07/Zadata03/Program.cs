// /Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

 using static System.Console;
int[] numbers = { -33, 28, 5, -15, 63, 87, 43 };

void ReverseArray(int[] array, int Element1, int Element2)
{
    if (Element1 < Element2)
{
int arr = array[Element1];
array[Element1] = array[Element2];
array[Element2] = arr;
ReverseArray(array, Element1 + 1, Element2 - 1);
}
}
ReverseArray(numbers, 0, numbers.Length - 1);

foreach (int i in numbers)
{
    System.Console.Write($"{i}  ");
}