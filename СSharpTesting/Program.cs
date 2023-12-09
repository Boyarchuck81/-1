Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)                     // 23 < 100 || 23 > 999 -> 1 + 0 = 1
{  
    Console.Write("Вы ошиблись!\nВведите трехзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 100;
int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3 * 1);
// или 
Console.Write($"{n1}{n3}");