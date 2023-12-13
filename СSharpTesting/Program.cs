
// Задача1.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// Задача2.Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените отрица-тельные элементы на положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

Console.Clear();
int[] FillArray(int size)
{
  int[] array = new int[size];
  for(int i = 0; i < array.Length;i++)
{
     array [i] = new Random().Next(-10,10);
}
     return array;
}

void PrintArray(int[] inArray)
{
    for(int i = 0; i < inArray.Length; i++)
    {
        Console.Write(inArray[i] + " ");
    }
        System.Console.WriteLine();
}

int ChangeElement(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
            arr[i] == arr[i] * -1;
    }
    return arr2;
}

void PrintArray2(int[] arr2)
{
    for(int i = 0; i < arr2.Length; i++)
    {
        Console.Write(arr2[i] + " ");
    }
        System.Console.WriteLine();
}

int LengthArray = 10;
int[] arr = FillArray(LengthArray);
PrintArray(arr);

int number = Convert.ToInt32(Console.ReadLine());
ChangeElement(arr);
PrintArray2(arr2);
