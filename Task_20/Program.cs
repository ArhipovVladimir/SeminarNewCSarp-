﻿// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetDistance(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay))), 2, MidpointRounding.ToZero);
}

Console.WriteLine ("Веедите Коородинаты первой точки");
Console.Write ("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Веедите Коородинаты второй точки");
Console.Write ("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = GetDistance (x1, y1, x2, y2);

Console.WriteLine ($"Растояние между точками {result}");