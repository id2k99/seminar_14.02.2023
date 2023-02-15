//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

int[] basearray = GetArray(10,0,10);
int[] reversearray = ReverseArray2(basearray);
Console.WriteLine(String.Join(" ", basearray));
Console.WriteLine(String.Join(" ", reversearray));
ReverseArray1(basearray);
Console.WriteLine(String.Join(" ", basearray));

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] ReverseArray2(int[] array)
{
    int[] resultarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultarray[i] = array[array.Length - 1 - i];
    }
    return resultarray;
}

void ReverseArray1(int[] inArray){
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}