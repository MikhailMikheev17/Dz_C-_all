// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Clear();

Console.Write("Enter a five-digit number : ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine($"{number} - palindrome");
  }
  else
  {
    Console.WriteLine($"{number} - not a palindrome");
  }
}
else
{
  Console.WriteLine($"Error: {number} - not a five-digit number ");
}