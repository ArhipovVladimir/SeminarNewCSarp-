int num = new Random ().Next (10,100);


int maxdig = MaxDigit(num);
if (maxdig == 0)
{
    Console.WriteLine ($"{num} цыфры одинаковые");
}
else 
{
    Console.WriteLine ($"{num} -> {MaxDigit(num)}");
}

int MaxDigit (int number)
{
    int firstNum = number % 10;
    int toNum = number /10;
    if (firstNum == toNum) 
        {
        return 0;
        }
    if (firstNum > toNum)
        {
        return firstNum;
        }
        return toNum;
    
}