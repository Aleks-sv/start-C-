// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Math.Sqrt();
// Math.Pow(2, 10);
// double d = 3.1232423;
// double resD = Math.Round(d, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите координаты X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Distance(xa, ya, xb, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние от точки А до точки B: {distance}");

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}