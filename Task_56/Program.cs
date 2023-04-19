/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using static System.Console;

int[,] GetArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(min, max + 1);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}

int SumRowArray(int[,] arr)
{
  int sumMinRow = 0;
  int result = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int sumCurrentRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sumCurrentRow += arr[i, j];
    }
    if ((i == 0) || (sumMinRow > sumCurrentRow))
    {
      sumMinRow = sumCurrentRow;
      result = i;
    }
  }
  return result + 1;
}

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,] array = GetArray(rows, columns, 1, 10);

WriteLine();
PrintArray(array);
WriteLine($"{SumRowArray(array)} строка");
