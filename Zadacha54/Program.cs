// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int[,] myarray = new int[m, n];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i, j] = new Random().Next(1, 10);
        Console.Write($"{myarray[i , j]} ");
    }
    Console.WriteLine();
}

void Newarray(int[,] array)
{
for(int i = 0;i < m;i++)
{
    for(int j = 0;j < n;j++)
    {
    array[i, j] = new Random().Next(10);
    }
}
    return;
}

void PrintArray(int[,] array)
{
for(int i = 0;i < m;i++)
    {
    for(int j = 0;j < n;j++)
      {
       Console.Write(array[i, j] + " ");
      }
    Console.WriteLine();
    }
    return;
}
Console.WriteLine();

void MaxToMinArray(int[,] array)
{
for(int i = 0;i < m;i++)
{
  for(int j = 0;j < n;j++)
    {
    for(int k = 0;k < n - 1;k++)
     {
      if(array[i, k] < array[i, k + 1])
        {
        int temp = array[i, k + 1];
        array[i, k + 1] = array[i, k];
        array[i, k] = temp;
        }
     }
    }
}
    return;
}
Console.WriteLine();
MaxToMinArray(myarray);
PrintArray(myarray);