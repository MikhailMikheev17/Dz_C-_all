// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Clear();

int SetNumber(string text = "")
{
  System.Console.Write($"Enter a numer{text} : ");
  int num = int.Parse(Console.ReadLine());
  return num;
}

int Summa(int number)
{
  int result = 0;
  while (number > 0)
  {
    result += number % 10;
    number = number / 10;
  }
  return result;
}

int number = SetNumber();
System.Console.WriteLine($"summ all digit = {Summa(number)}");