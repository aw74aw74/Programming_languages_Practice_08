/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using static System.Console;

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

void FillArray(int[,] inArray, int row, int column, int count)
{
  int stop = inArray.GetLength(0) * inArray.GetLength(1);
  //---------- Top side ----------
  if (count < stop)
  {
    for (int iColumn = column; iColumn < inArray.GetLength(1) - column; iColumn++)
    {
      count++;
      inArray[row, iColumn] = count;
    }
  }
  //---------- Right side ----------
  if (count < stop)
  {
    for (int iRow = row; iRow < inArray.GetLength(0) - row - 1; iRow++)
    {
      count++;
      inArray[iRow + 1, inArray.GetLength(1) - column - 1] = count;
    }
  }
  //---------- Bottom side ----------
  if (count < stop)
  {
    for (int iColumn = inArray.GetLength(1) - column - 1; iColumn > column; iColumn--)
    {
      count++;
      inArray[inArray.GetLength(0) - row - 1, iColumn - 1] = count;
    }
  }
  //---------- Left side ----------
  if (count < stop)
  {
    for (int iRow = inArray.GetLength(0) - row - 1; iRow - 1 > row; iRow--)
    {
      count++;
      inArray[iRow - 1, column] = count;
    }
  }
  row++;
  column++;
  if (count < stop)
  {
    FillArray(inArray, row, column, count);
  }
  else return;
}

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = new int[rows, columns];
FillArray(array, 0, 0, 0);
PrintArray(array);