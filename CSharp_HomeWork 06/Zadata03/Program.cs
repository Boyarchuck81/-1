// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


{
//  void Main(string[] args)
{
// Входная строка для проверки
string input = "везение";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
bool IsPalindrome(string str)
{
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}
}