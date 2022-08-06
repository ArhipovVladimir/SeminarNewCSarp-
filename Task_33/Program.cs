void Print (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i==0) Console.Write("[");
        if (i < arr.Length-1) Console.Write(arr[i]+", ");
        else Console.Write(arr[i]+"]");
    }
} 

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

string FindDigt(int digit, int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==digit) return "да";
    }

return "нет";

}


int [] array = FillArr (12, 0, 12);
Console.Write("веедите искомое число");
int digt = Convert.ToInt32(Console.ReadLine());
Console.Write($"{digt}; массив ");
Print (array);
Console.Write($"-> {FindDigt(digt, array)}");
 

