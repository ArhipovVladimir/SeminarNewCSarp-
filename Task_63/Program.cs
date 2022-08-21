int GetUserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNatural(int num)
{
    if (num==0) return;
    PrintNatural (num-1);
    Console.Write($"{num}, ");
}


Console.Write("Введите число");
int num = GetUserInput();
PrintNatural(num);