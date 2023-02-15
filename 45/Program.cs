//Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.

int[] basearray = GetArray(10,1,10);
int[] copyarray = CopyArray(basearray);
Console.WriteLine(String.Join(" ", basearray));
Console.WriteLine(String.Join(" ", copyarray));

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] CopyArray(int [] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[i];
    }
    return array;
}