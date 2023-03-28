//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//Console.Clear();

//Console.WriteLine(" Enter a number :");
//int num = Convert.ToInt32(Console.ReadLine());

//int numSer = (num/10)%10;
//Console.WriteLine(numSer);

Console.Clear();

int Prompt( string message)
{
  Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(value);
  return result;
}

int number = Prompt(" Enter a a three - digit number :");
if (number < 100 || number >= 1000)
{
  Console.WriteLine("Not a a three - digit number, please repeat entering");
  return;
}

Console.WriteLine($" Введенное число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Second number {secondRank}");
