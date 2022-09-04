/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


int[,] myarray1 = new int[2, 2];//первая матрица, он же массив

Console.WriteLine($"Матрица 1: ");

for (int i = 0; i < myarray1.GetLength(0); i++)
{
    for (int j = 0; j < myarray1.GetLength(1); j++)
    {
        myarray1[i, j] = new Random().Next(1, 10);
        Console.Write($"{myarray1[i, j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] myarray2 = new int[2, 2];//вторая матрица, он же массив
Console.WriteLine($"Матрица 2: ");

for (int i = 0; i < myarray2.GetLength(0); i++)
{
    for (int j = 0; j < myarray2.GetLength(1); j++)
    {
        myarray2[i, j] = new Random().Next(1, 10);
        Console.Write($"{myarray2[i, j]}   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] SumArray = new int[2, 2];//массив в который складываем произведение первых двух
Console.WriteLine($"Произведение двух матриц: ");

for (int i = 0; i < SumArray.GetLength(0); i++)
{
    for (int j = 0; j < SumArray.GetLength(1); j++)
    {
        if (i == 0 & j == 0)
        {
            SumArray[i, j] = myarray1[i,j] * myarray2[i, j] + myarray1[i, j + 1] * myarray2[i + 1, j];
        }
        if (i == 1 & j == 0)
        {
            SumArray[i, j] = myarray1[i, j] * myarray2[i - 1, j] + myarray1[i, j + 1] * myarray2[i, j];
        }

        if (i == 0 & j == 1)
        {
            SumArray[i, j] = myarray1[i, j - 1] * myarray2[i, j] + myarray1[i, j] * myarray2[i + 1, j];
        }

        if (i == 1 & j == 1)
        {
            SumArray[i, j] = myarray1[i, j - 1] * myarray2[i - 1, j] + myarray1[i, j] * myarray2[i, j];
        }
        Console.Write($"{SumArray[i, j]}   ");
    }
    Console.WriteLine();
}
