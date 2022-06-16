int[]array = {8, 6, 4, 3, 2, 4, 0, 3 };

int n = array.Length;

int find = 4;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    
     index = index + 1;


}

