Console.Write("Введите длину массива: ");
int size =Convert.ToInt32(Console.ReadLine());

int [] GetArray (int size , int start , int finish)
{
    int [] resultArrray = new int [size];
    for (int i = 0 ; i < resultArrray.Length ; i++)
    {
        resultArrray[i] = new Random().Next(start , finish);
    }
    return resultArrray;
}
int [] array = GetArray(size ,-100 , 100);
Console.WriteLine($"В массиве: [ {String.Join("; ", array)}]");

int numbSum = 0 ;
for(int x = 0 ; x < array.Length ; x++)
{
    if(x % 2 != 0) 
    {
        numbSum += array[x];
    }
}
Console.WriteLine($"сумма элементов стоящих на нечетных позициях {numbSum}");