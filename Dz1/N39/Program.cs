// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Clear();

int Prompt(string message) // сообщение для user
{
  Console.Write(message);
  string value = Console.ReadLine();
  int  result = Convert.ToInt32(value);
  return result;
}

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

int FindDiff(int[] array)
{
  int i = 0;
  int max = 0;
  int min = array[i];
  while (i < array.Length)
  {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
    i++;
  }
  int diff = max - min;
  return diff;
}

int length = Prompt("Enter length array > ");
int maxValue = Prompt("Enter max value > ");
int minValue = Prompt("Enter minValue > ");

int[] array = FillArray(length, minValue, maxValue);
PrintArray(array);

System.Console.WriteLine($"diff between max and min = {FindDiff(array)}");



