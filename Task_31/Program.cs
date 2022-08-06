

int [] FillArr (int site, int min, int max)
{
    int[] array = new int [site];
    Random r = new Random();
    for (int i = 0 ; i < array.Length; i++)  
    {
        array [i] = r.Next(min,max+1);
    }
    return array;
}

void PrintArr (int [] arr)

{
    int len=arr.Length;
    Console.Write("[");
    for (int i = 0 ; i < len-1; i++)  
    {
        Console.Write ($"{arr[i]}, ");  
    }
    Console.Write($"{arr[len-1]}]");
}



int SumPozit (int [] ap)
{   
    int sump = 0;
    int len =ap.Length; 
    for (int i = 0; i < len; i++)
        {
            if (ap[i]>0) sump=sump+ap[i];
        }
    return sump;
}

int SumNegat (int [] an)
{   
    int sumn = 0;
    int len =an.Length; 
    for (int i = 0; i < len; i++)
        {
            if (an[i]<0) sumn=sumn+an[i];
        }
    return sumn;
}


Console.WriteLine($"введите длинну иамммива");
int site = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"введите диапозон от до");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int [] array = FillArr(site, min, max);
PrintArr(array);
int sp = SumPozit(array);
Console.WriteLine();
Console.WriteLine($"сумма положительных элементов массива равна {sp}");
int sn = SumNegat(array);
Console.WriteLine($"сумма отрицательных элементов массива равна {sn}");