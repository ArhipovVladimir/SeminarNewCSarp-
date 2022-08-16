// задача 49 задайте двумерный массив. найдите элементы у которых оба 
// индекса четные. Заметните эти элементы на их квадраты  
// 

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

void CheckEven (int [,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i%2==0 && j%2==0) array [i,j] = array [i,j] * array [i,j];
        }
        
    } 

}

Console.WriteLine("Введите размер масиива MxN");
Console.Write("M:");
int m = GetUserInput();
Console.Write("N:");
int n = GetUserInput();
int [,] matrix = GetMatrix (m, n);
PrintMatrix(matrix);
CheckEven (matrix);
Console.WriteLine();
PrintMatrix(matrix);
