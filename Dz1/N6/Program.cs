﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.WriteLine("Enter number :");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

if (number % 2 == 0)
{
  Console.WriteLine("number is an even number");
}
else Console.WriteLine("number is not an even number");