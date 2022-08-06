

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



int [] GetSumNegPozit (int [] array)
{   
    int NegSum = 0;
    int PozSum =0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0) 
            {
                NegSum += array[i];
            }
            else
            {
                PozSum += array[i];
            }
        }
    return new int[] {NegSum,PozSum};
}


int [] array = FillArr (12, -9, 9);
PrintArr (array);
int [] sumNegPozit = GetSumNegPozit(array);
Console.WriteLine();
Console.WriteLine ($"Сумма положительных элементов = {sumNegPozit[1]}");
Console.WriteLine ($"Сумма отрицательных элементов = {sumNegPozit[0]}");

