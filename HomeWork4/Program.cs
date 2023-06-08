Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double [size] ;
for (int i = 0 ; i< array.Length ; i++ )
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(10,101)),2);
}
Console.WriteLine($"Массив вещественных чисел [ {String.Join("; ", array)} ]");

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
        {
            max = array[z];
        }
    if (array[z] < min)
        {
            min = array[z];
        }
}
Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
