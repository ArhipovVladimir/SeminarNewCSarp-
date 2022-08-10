// не используя рекурсию вывести первые N
// чисел Фибоначчи. Первые два числа фибоначчи: 1 и 0
// если N = 5 -> 0 1 1 2 3
// если N = 3 -> 0 1 1
// если N = 7 -> 0 1 1 2 3 5 8

void Fibbo (int d)
{   int n1 =0;
    int n2 =1; 
    int temp = 0;
    Console.Write($"{n1 }");
    Console.Write($"{n2 }");
    for (int i = 2 ; i < d; i++)
    {   
        n1=n2;
        n2=temp+n1;
        Console.Write($"{n2} ");
        temp = n1;
    }
}

Console.WriteLine("введите число:");
int digit = Convert.ToInt32(Console.ReadLine());
Fibbo(digit);