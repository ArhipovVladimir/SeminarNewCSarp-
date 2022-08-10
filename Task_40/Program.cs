// теорема треугольников
string TestTeorem (int a1, int b1, int c1)
{
    if (a1 < b1+c1 && b1 < a1+c1 && c1 < a1+ b1) return "можно";
    else return "нельзя";
}


Console.WriteLine("введите тричисла;");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Треугольник составить {TestTeorem(a, b, c)}");