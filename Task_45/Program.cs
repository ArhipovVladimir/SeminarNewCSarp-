// создание копии масива 



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

int [] Newarray (int[] array)
{
    int [] newArr = new int [array.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr [i] = array [i];
    }
    
    return newArr; 
}

int[] array = Fillarray(12, 10, 30);
Printarray(array);
int [] copyarray = Newarray(array);
Console.WriteLine();
Printarray(copyarray);
