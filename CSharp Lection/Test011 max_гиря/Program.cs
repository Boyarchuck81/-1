// See https://aka.ms/new-console-template for more information
int N = 10;
int[] arr = {1,8,15,9,14,5,1,13,7,2};
int i = 0;
int max = arr[0];
while(i<N)                                //while(i < arr.Length)
{
    
    if(arr[i] > max){
    max = arr[i];}
    i++;     
}
System.Console.Write(max);