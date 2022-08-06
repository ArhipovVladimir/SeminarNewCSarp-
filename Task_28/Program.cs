// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Powdig(int num)
{
    int pow=1;
    for (int i= 1; i <= num ; i++)
        {
            pow=pow*i;
        }
    
    return pow;
}

Console.WriteLine("Введите число");
int dig=Convert.ToInt32(Console.ReadLine());
int power=Powdig(dig);
Console.WriteLine($"произведение чисел числа от 1 до {dig} равно {power}");