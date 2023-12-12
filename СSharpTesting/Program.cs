Console.Clear();
// Задача1.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] FillArray(int size)
{
  int[] array = new int[size];
  for(int i = 0; i < array.Length;i++)
{
     array [i] = new Random().Next(-5,6);
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
int LengthArray = 8;
int[] arr = FillArray(LengthArray);

int LengthArray2 = 12;
int[] arr2 = FillArray(LengthArray2);