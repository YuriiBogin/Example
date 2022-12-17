int max (int arg1, int arg2, int arg3)
{
    int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    
    return result;
    
} 

int [] array = {11,21,3125,41,15,16,17,18,19};

for (int i=1; i < 9; i++)

Console.Write($"  {array[i]}");

int max1 = max(
    max(array[0], array[1], array[2]),
    max(array[3], array[4], array[5]),
    max(array[6], array[7], array[8]));

Console.WriteLine();
Console.WriteLine(max1);