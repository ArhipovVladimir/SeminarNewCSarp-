// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2*num2== num1)
  {
    Console.WriteLine("Первое число квдрат второго");
  }
else
  {
    Console.WriteLine("Первое число не квдрат второго");
  }


Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

int i = 0;

if (n < 0)
{
     i = n;
    n = -n;
}
else
{
   i = -n;
}

while (i <= n)
{
    Console.WriteLine(i);
    i++;
}


int a = Convert.ToInt32(Console.ReadLine());
int b = 100,
    i = 0;

while (i < 3){
    b = a / b;
    i++;
}

b = a / 100;

Console.WriteLine(b);
