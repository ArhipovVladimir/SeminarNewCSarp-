// перевод числа из десетичной
// ситсемы исчисления в двоичную
void ToBin(int n)
{
    if (n == 0) return; 
    ToBin(n/2);
    Console.Write(n%2);
    

}


Console.WriteLine("ведите число:");
int num = Convert.ToInt32(Console.ReadLine());
ToBin(num);
