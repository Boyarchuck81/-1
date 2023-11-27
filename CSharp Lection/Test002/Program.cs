// See https://aka.ms/new-console-template for more information
int maxNumber(int a, int b){ // Функция
    if (a > b)
        return a;
    return b; // a <= b
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Наибольшее значение: {maxNumber(n, m)}");




void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-10, 11); // [-10, 10]
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
inputArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


