// Демонстрация решения
// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sumdig(int num)
{
    int sum=0;
    for (int i= num; i > 0 ; i--)
        {
            sum=sum+i;
        }
    
    return sum;
}

Console.WriteLine("Введите число");
int dig=Convert.ToInt32(Console.ReadLine());
int summa=Sumdig(dig);
Console.WriteLine($"Сумма чисел числа от 1 до {dig} равна {summa}");