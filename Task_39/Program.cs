// Реверсия (поворот массива)



int[] Fillarray(int site, int min, int max)
{
    int[] array = new int[site];
    Random r = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

void Printarray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

void Reverse(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2) 
    {
        int obj = array [index1];
        array[index1]=array[index2];
        array[index2]=obj;
        index1++;
        index2--;
    }
}

int[] array = Fillarray(12, 10, 30);
Printarray(array);
Reverse(array);
Console.WriteLine();
Printarray(array);
