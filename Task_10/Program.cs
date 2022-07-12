// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num1 = new Random ().Next (100, 1000);
Console.WriteLine($"{num1}->{dif(num1)}");

int dif (int num)
{
    int firsnum = num/100;
    int secnum = num % 10;
    int res = firsnum*10 + secnum;
    return res;
}



