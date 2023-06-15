// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int rows = 3;
int columns = 4;
int[,] numbers = GetMatrix(rows, columns , 0 ,10);
int [,] GetMatrix(int rows , int columns, int min, int max)
{
    int[,] numbers = new int[3, 4];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int[,] array = new int[5, 5];
        for (int j =  0; j < numbers.GetLength(1); j++) 
        {
            numbers[i,j] = new Random().Next(0,20);
        }
    }return numbers;
}
PrintNumber(numbers);
void PrintNumber(int[,] array)
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
double [] avgNumbers = new double [numbers.GetLength(1)];
for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArray(avgNumbers);
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("=");
        Console.Write( Math.Round(array[i],2) + "\t");

    }
    Console.WriteLine();
}
