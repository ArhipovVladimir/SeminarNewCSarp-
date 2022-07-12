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
    int i=0;    
    while (i<length-1)
    {
        int j=0;
        while (j<length-1-i)
        {
            if (col[j] < col[j+1])
            {
                (col[j] , col[j+1]) = (col[j+1] , col[j]);
            }
            j++;
        }
        i++;

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
