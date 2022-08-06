//  Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArr (int [] a)
{
    int len=a.Length;
    Random r = new Random();
    for (int i = 0 ; i < len; i++)  
    {
        a[i] = r.Next(0,2);
    }
}

void PrintArr (int [] arr)

{
    int len=arr.Length;
    Console.Write("[");
    for (int i = 0 ; i < len-1; i++)  
    {
        Console.Write ($"{arr[i]}, ");  
    }
    Console.Write($"{arr[7]}]");
}

int[] array = new int [8];

FillArr(array);
PrintArr(array);