// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точек");
Console.Write("X1: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance (int xc, int yc, int xd, int yd)
{
    return Math.Round(Math.Sqrt((xc-xd)*(xc-xd)+(yc-yd)*(yc-yd)), 2, MidpointRounding.ToZero);
}

double result = Distance (xa,ya,xb,yb);
// Console.Writeline($"Расстояние между точками: {result}");
Console.WriteLine($"Расстояние между точками: {result}");