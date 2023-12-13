// Создать функцию, которая выведет сумму и произведение элементов массива от 1 до n.
int n = 10;
int[] arr = new int[n];                 //создание массива
void FillArray(int[] arr)
{
int i = 0;
while(i < n)
{
  arr[i] = i + 1;
}
}                                        //заплнение массива
void PrintArray(int[] arr)
{
while(i < n)
{
  System.Console.Write($"arr[i] ");
}
}                                       //Вывод массива
void GetSumOfElements(int[] arr)
{
i = 0;
sum = 0;
while(i < n)
{
  sum = sum + arr[i];
}
}                                       //сумма элементов
void GetProductOfElements(int[] arr)
{
i = 0;
product = 0;
while(i < n)
{
product = product + arr[i];
}                                       //произведение элементов
}
System.Console.WriteLine(sum);
System.Console.WriteLine(product);      //вывод результатов

int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
System.Console.WriteLine(sum);
System.Console.WriteLine(product);                    //Домашняя работа