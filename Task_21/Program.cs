﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (2,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.52

Console.Write("Введите x1: ");
    int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите y1: ");
    int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите z1: ");
    int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите x2: ");
    int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите y2: ");
    int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите z2: ");
    int z2 = int.Parse(Console.ReadLine());

Console.WriteLine(FindLehgth(x1, y1, z1, x2, y2, z2));

double FindLehgth(int x1, int x2, int y1, int y2, int z1, int z2)
{
double result;
result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

return result;
}