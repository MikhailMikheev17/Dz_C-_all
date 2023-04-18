// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Start();

void Start()
{
  int rows = SetNumber("rows");
  int columns = SetNumber("columns");
  int min = SetNumber("min value  ");
  int max = SetNumber("max value  ");

  int[,] matrix = GetMatrix(rows, columns, min, max);
  PrintMatrix(matrix);
  System.Console.WriteLine();

  int[] newArr = GetNewArray(matrix);
  System.Console.WriteLine("new array of sum");  
  PrintArray(newArr);

  System.Console.WriteLine();
  FindMin(newArr);
}

int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];

  var rand = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(minValue, maxValue + 1);
    }
  }

  return array;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.WriteLine("]");
}

int[] GetNewArray(int[,] array)
{
  int[] arr = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }

    arr[i] = sum;
  }
  return arr;
}

void FindMin(int[] array)
{
  int min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
      System.Console.Write($" min sum in row {i}");
    }
  }
}

