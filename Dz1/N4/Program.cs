Console.Clear();

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Enter first number :");
string numFirst = Console.ReadLine();
int num1 = Convert.ToInt32(numFirst);

Console.WriteLine("Enter second number :");
string numSecond = Console.ReadLine();
int num2 = Convert.ToInt32(numSecond);

Console.WriteLine("Enter third  number :");
string numThird = Console.ReadLine();
int num3 = Convert.ToInt32(numThird);

int max = 0; // рассмотрим случай целых чисел

if (num1 > max)
{
  max = num1;
}

if (num2 > max)
{
  max = num2;
}

if (num3 > max)
{
  max = num3;
}

Console.WriteLine($"max = {max}");

