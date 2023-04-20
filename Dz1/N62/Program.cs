// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

Start();

void Start()
{
  int rows = SetNumber("Rows ");
  int columns = SetNumber("Columns ");
  int[,] arr = new int[rows, columns];
  FillArraySpiral(arr, rows, columns);
  PrintMatrix(arr);
}


int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}


void FillArraySpiral(int[,] array, int rows, int columns)
{
  int temp = 1;
  int i = 0;
  int j = 0;

  while (temp <= array.GetLength(0) * array.GetLength(1))
  {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
      j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
      i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
      j--;
    else
      i--;
  }

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


