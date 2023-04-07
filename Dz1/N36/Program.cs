// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Clear();

int Prompt(string message) // сообщение для user
{
  Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(value);
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

int GetSumNotEvenNum(int[] array)
{
  int sum = 0;
  for(int i = 0;i < array.Length;i++)
  {
    if(i % 2 != 0)
      sum += array[i];
  }
  return sum;
}

int length = Prompt("Enter length array > ");
int maxValue = Prompt("Enter max value > ");
int minValue = Prompt("Enter minValue > ");

int[] array = FillArray(length, minValue, maxValue);

PrintArray(array);

System.Console.WriteLine($"sum not even i = {GetSumNotEvenNum(array)}");
