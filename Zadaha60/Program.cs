// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int o = new Random().Next(1, 5);
int[, ,] myarray = new int[m, n, o];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
       for (int k = 0; k < myarray.GetLength(2); k++)
       {
        myarray[i, j, k] = new Random().Next(1, 10);
        Console.Write($"{myarray[i , j , k]} ");
       }
    }
    Console.WriteLine();
}

void PrintArray(int[,,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            for (int k = 0; k < myarray.GetLength(2); k++)
            {
                Console.WriteLine($"{myarray[i, j, k]} [{i}, {j}, {k}] ");
            }
            Console.WriteLine();
        }
    }
}
PrintArray(myarray);
