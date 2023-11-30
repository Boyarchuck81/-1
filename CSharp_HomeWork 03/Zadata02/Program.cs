/*Задача2. Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
*/ 

Console.Clear();
int size = 10;
int[] array = new int[size];
int[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10001);
    }
    return array;
}
void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write("\t");
    }
   
}
int CountEvenElements(int[]arr)
{
    int count = 0;
    for (int i = 0; i <arr.Length; i++)
    {
        if(arr[i]%2==0)
        count++;
    }
    return count;
}
int[] userArray = GetArray(size);
int countArray = CountEvenElements(userArray);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine("Количество четных элементов: " + countArray);