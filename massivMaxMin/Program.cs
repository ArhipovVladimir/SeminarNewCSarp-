void FillArray(int[] coll)
{
    int len= coll.Length;
    int index =0;
    
    while (index < len)
    {
        coll[index] = new Random(). Next (1,1000);
        index++;
    }
}

void PrintArray(int[] arr)
{   
    int len=arr.Length;
    int index = 0;

    while (index < len)
    {
        Console.WriteLine(arr[index]);
        index++;
    
    }

}

int FinIndMax(int[] array)
{

int index=0;
int len=array.Length;
int max = array[0];
int maxInd=0;

while (index < len)
{
    if (array[index]>array[maxInd])
    {
        max=array[index];
        maxInd = index;
    }
    
    index++;
    
}
    return maxInd;
}


int FinIndMin(int[] array)
{
int index=0;
int len=array.Length;
int min = array[0];
int minInd=0;

while (index < len)
{
     
    if (array[index]<array[minInd])
    {
        min=array[index];
        minInd = index;
    }
    index++;
}
    return minInd;
}


int [] array = new int[10];

FillArray(array);
PrintArray(array);

int maxI = FinIndMax(array);

Console.WriteLine();
Console.WriteLine(maxI);


int minI = FinIndMin(array);

Console.WriteLine();
Console.WriteLine(minI);
