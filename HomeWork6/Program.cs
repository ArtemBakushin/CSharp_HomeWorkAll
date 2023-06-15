// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int numberLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberColumn =Convert.ToInt32(Console.ReadLine());
int [,] resMatrix = GetMatrix(5, 6 , 0, 20);
int [,] GetMatrix(int line, int column, int min, int max)
{
    int[,] matrix = new int[line, column];
   for (int i = 0; i < matrix.GetLength (0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(min , max+1);
        if(i< matrix.Length && j < matrix.Length)
        {
            
        }
    }
   }return matrix;
}
void PrintMatrix (int[,] array)
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
PrintMatrix(resMatrix);

if (numberLine < resMatrix.GetLength(0) && numberColumn < resMatrix.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine(resMatrix[numberLine, numberColumn]);
}
else 
{
    Console.WriteLine();
Console.WriteLine($"{numberLine}{numberColumn} -> такого числа в массиве нет");
}