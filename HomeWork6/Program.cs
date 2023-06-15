﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] resMatrix = GetMatrix(rows, columns , -99 ,100);

PrintMatrix(resMatrix);
double [,] GetMatrix(int m, int n, double min , double max)
{
 double[,] matrix = new double[m, n]; 
for (int i = 0; i < matrix.GetLength(0); i++) 

for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(-99, 99) / 10.0 ;
}

return matrix ;
}
void PrintMatrix (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0 ; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
}
