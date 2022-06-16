void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(80, 156);
        index++;
    } 

}

void PrintArray(int[] coll)
{
     int count = coll.Length;
     int possition = 0;
     while (possition < count)
     {
        Console.WriteLine(coll[possition]);
        possition++;
     }

}

int[] array = new int[5];

FillArray(array);
PrintArray(array);