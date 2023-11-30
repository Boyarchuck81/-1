/* Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр 
этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива
 должен быть равен количеству цифр.
*/ 

void int[] arr(newArray)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 100001); 
}

int formingNumber(int[] array)
{ 
    int result = 0;
    int i = array.Length - 1;
    foreach (int el in array){
        result += el * Convert.ToInt32(Math.Pow(100001, i));
        i--;
    }
    return result;
}

Console.Clear();
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);

new int[n] = int[] array;
newArray(array);
Console.WriteLine(int[] array);


