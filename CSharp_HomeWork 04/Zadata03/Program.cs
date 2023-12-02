/* Задача3. Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
*/ 

System.Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Random arr = new Random();
double[] GetArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((arr.NextDouble() * (10 - 1) + 1), 2);
    }
    return array;
}
void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write("\t");
    }

}
double FindMax(double[] array)
 
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
double FindMin(double[] array)
 
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
    {
        double max = FindMax(array);
        double min = FindMin(array);
        double between = max - min;
        return between;
    }
double[] userArray = GetArray(size);
PrintArray(userArray);
Console.WriteLine();
 double maxNum = FindMax(userArray);
double minNum = FindMin(userArray);
double betweenNum = CalcDifferenceBetweenMaxMin(userArray);
 Console.WriteLine($"Разность между max и min элементом = {betweenNum}");