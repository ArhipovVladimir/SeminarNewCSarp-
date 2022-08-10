// теорема треугольников


int GetUseImput()
{
    Console.Write("введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

string TestTeorem (int a1, int b1, int c1)
{
    if (a1 < b1+c1 && b1 < a1+c1 && c1 < a1+ b1) return "можно";
    else return "нельзя";

}

int num1 = GetUseImput();
int num2 = GetUseImput();
int num3 = GetUseImput();

string result = TestTeorem(num1, num1 , num1);
Console.WriteLine($"Треугольник составить {result}");