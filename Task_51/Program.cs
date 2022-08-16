// задача 49 задайте двумерный массив.
// найдите сумму элементов находящейся на
// главной диагонали (0:0) (1:1) 

int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetMatrix (int m, int n)
{
    int [,] array = new int [m,n];
    
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(1, 9);
        }
    } 
    return array;
}

 
void PrintMatrix (int [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write ("[");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j],  3},");
            else Console.Write ($"{array[i,j],  3}]");
        }
        Console.WriteLine();
    } 

}

int SumElemOpt (int [,] array)
{
   int sum = 0;
   int length = 0;
   if (array.GetLength(0)>=array.GetLength(1))
        length = array.GetLength(1);   
   else 
        length = array.GetLength(0);
   for (int i = 0; i < length; i++)
   {
        sum += array [i,i]; 
   }
return sum;
}


Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
int [,] matrix = GetMatrix (m, n);
PrintMatrix(matrix);
int sum= SumElemOpt(matrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали {sum}");
