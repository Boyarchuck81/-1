// See https://aka.ms/new-console-template for more information
int N = 10;
int[] arr = new int[N];
int i = 0;
while(i<N)                                //while(i < arr.Length)
{
    arr[i] = i + 1;
    System.Console.Write($"{arr[i]} ");
    i = i + 1;     //i++
}