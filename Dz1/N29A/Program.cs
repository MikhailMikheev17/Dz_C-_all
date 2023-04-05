// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

Console.Clear();

int Prompt( string message)
{
  System.Console.WriteLine(message);
  string readInput = Console.ReadLine();
  int res = int.Parse(readInput);
  return res;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
  int[] array = new int[length];
  Random random = new Random();
  for (int i = 0; i < length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);
  }
  return array;
}

void printArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.Write("]");
}

int length = Prompt("Длина массива");
int min = Prompt("min value > ");
int max = Prompt("max value > ");
int[] array = GenerateArray(length, min, max);

printArray(array);