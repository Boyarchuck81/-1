// See https://aka.ms/new-console-template for more information

// int N = 10;
int[] arr = {1,8,15,9,14,5,1,13,7,2};
int max = arr[0];
foreach(int element in arr)                             
{
    if(element > max){
    max = element;} 
}
System.Console.WriteLine(max);
                     