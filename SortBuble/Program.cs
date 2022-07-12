void FillArray (int [] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
    {
        collection[index] = new Random().Next (1, 100);
        index++; 
    }
}

void PrintArray (int [] collection)
{
    int length = collection.Length;
    int index=0;
    while (index < length)
    {
        Console.Write($"{collection[index]}, ");
        index++; 
    }
}

void SortBuble (int[] col)
{
    int length = col.Length;
    int sortetPos=0;    
    while (sortetPos<length-1)
    {
        int index=0;
        while (index<length-1-sortetPos)
        {
            if (col[index] > col[index+1])
            {
                (col[index] , col[index+1]) = (col[index+1] , col[index]);
            }
            index++;
        }
        sortetPos++;

    }
}

int [] array = new int [50];

FillArray (array);
Console.Clear();
PrintArray (array);
SortBuble (array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив");
PrintArray (array);
