// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0)
{
    num=num*-1;
}


if (num > 99 && num < 1000)
{
    int resalt = num % 10;
    Console.WriteLine(resalt);
}
else 
{
    Console.WriteLine ("Число не трехзначное");
}