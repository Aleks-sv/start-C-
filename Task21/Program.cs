// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты x первой точки ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y первой точки ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z первой точки ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x второй точки ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y второй точки ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z второй точки ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance(ax, ay, az, bx, by, bz), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние от точки A до точки B: {distance}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}