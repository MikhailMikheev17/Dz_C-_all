//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

System.Console.WriteLine("Enter a number : ");
int num = int.Parse(Console.ReadLine());

if( num < 100)
{
  System.Console.WriteLine("No third rank");
}
else 
{
  while(num > 999)
  {
    num = num /= 10;
  }
  int result  = num%10;
  System.Console.WriteLine($"{result}");
}







