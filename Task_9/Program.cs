int num = new Random ().Next (10,100);
int firstNum = num % 10;
int toNum = num /10;
if (firstNum == toNum) 
{
    Console.WriteLine("цифры равны");
}
if (firstNum> toNum)
{
    Console.WriteLine($"{num} -> {firstNum}");
}
else 
{
    Console.WriteLine($"{num} -> {toNum}");
} 