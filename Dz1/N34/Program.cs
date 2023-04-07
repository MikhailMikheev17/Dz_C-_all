// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
Console.Clear();

int[] FillArray(int length, int minValue, int maxValue)// создаем массив 
{
  int[] result = new int[length];
  Random rand = new Random();
  for (int i = 0; i < length; i++)
    result[i] = rand.Next(minValue, maxValue + 1);
  return result;
}

void PrintArray(int[] array)//распечатываем массив 
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.WriteLine("]");
}

int GetCountEven(int[] array)// находим кол-во четных элементов 
{
  int count = 0;
  int i = 0;
  for (i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
      count += 1;
  return count;
}
int Prompt(string message) // сообщение для user
{
  Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(value);
  return result;
}

int length = Prompt("Enter length array > ");
int maxValue = Prompt("Enter max value > ");
int minValue = Prompt("Enter minValue > ");

int[] array = FillArray(length, minValue, maxValue);

PrintArray(array);

System.Console.WriteLine($"Even numbers of the array = {GetCountEven(array)}");