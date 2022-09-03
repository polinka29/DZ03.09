//*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

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

int SumArray(int[,] myarray, int i)
{
int sum = myarray[i, 0];
for(int j = 1;j < n;j++)
    {
    sum += myarray[i, j];
    }
return sum;
}

int minRows = 0;
int minSum = SumArray(myarray, 0);
for(int i = 1;i < m;i++)
{
  int SumRows = SumArray(myarray, i);
  if(minSum > SumRows)
    {
     minSum = SumRows;
     minRows = i;
    }
}

Console.WriteLine($"Минимальная сумма: {minSum} находится в {minRows+1} строке");
