int[] FillArr(int site, int min, int max)
{
    int[] array = new int[site];
    Random r = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i] + "]");
    }
}

int[] PowArry(int[] array)
{
    int newLenArr = (array.Length / 2 + array.Length % 2);
    int [] newArray = new int [newLenArr];
    int i=0;
    while (i<array.Length/2)
    {
        newArray [i] = array[i]*array[array.Length-1-i];
        i++;
    }
        
    if (array.Length % 2==1) 
    {
        newArray [newArray.Length-1] = array[array.Length/2];
    }
    return newArray;
}


Console.Write("Введите размер массива ");
int site = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите границы массива ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] array = FillArr(site, min, max);
Print(array);
Console.WriteLine();
Print (PowArry(array));
