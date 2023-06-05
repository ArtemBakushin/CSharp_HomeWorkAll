  // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
  // Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int start, int finish)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(100, 1000);
    }
    return resultArray;
}



int[] array = GetArray(size, 100, 1000);
Console.WriteLine($"В массиве:  [ {string.Join("; ", array)} ]");

int count = 0;
for(int x = 0; x < array.Length ; x++)
{
    if ( array[x] % 2 == 0)
    count++;
}
Console.WriteLine($"{count} четных чисел");