void Print (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i==0) Console.Write("[");
        if (i < arr.Length-1) Console.Write(arr[i]+", ");
        else Console.Write(arr[i]+"]");
    }
} 



int [] array = {-4,-8,8,2};
int [] arrayNeg = new int [array.Length];
for (int i = 0; i < array.Length; i++)
{
    arrayNeg[i]=array[i]*-1;
}
Print(array);
Console.Write("->");
Print(arrayNeg);
