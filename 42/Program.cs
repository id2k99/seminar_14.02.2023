//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

Console.Clear();
int number = int.Parse(Console.ReadLine());

string res = DecToNum(number, 2);

Console.WriteLine($"{number}->{res}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}

