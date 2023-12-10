// See https://aka.ms/new-console-template for more information
int N = 10;
int[] arr = {1,2,3,4,5,6,7,8,9,10};
int i = 0;
while(i<N)                                //while(i < arr.Length)
{
    arr[i] = i + 1;
    if(arr[i] % 2 == 0)
    System.Console.Write($"{arr[i]} ");
    i = i + 1;     //i++
}