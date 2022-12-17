void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index<length)
    {
        collection[index] = new Random().Next(10,25);

        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;

    while (position<count)
    {
        Console.Write($" {col[position]}");
        position++;
    }

}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

     while (index < count)
     {

        if (collection[index]==find) 
        {
            position = index;
            break;
        }
        
        index++;

     }
     
    return position;
}

int [] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите элемент массива");

int n = Convert.ToInt32(Console.ReadLine());

int pos = IndexOf(array,n);
if (pos == 0)
{
    Console.WriteLine($"Такого элемента {n} - НЕТ!");
}
else
Console.WriteLine($"Индекс элемента {n} = {pos}");
Console.ReadKey();