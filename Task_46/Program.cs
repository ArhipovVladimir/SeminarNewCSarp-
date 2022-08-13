int [,] GetMatrix ( int m, int n)
{
    int [,] array = new int [m,n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            array [i, j] = rnd.Next (1, 100);
        }
    } 
    return array;
}
 
void PrintMatrix (int [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            if (j == 0) Console.Write ("[");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j],  3},");
            else Console.Write ($"{array[i,j],  3}]");
               
        }
        Console.WriteLine();
    } 

}

int [,] matrixResult = GetMatrix (3,4);
PrintMatrix(matrixResult);
