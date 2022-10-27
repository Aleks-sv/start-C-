// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите первый числовой коэффициет для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второй числовой коэффициет для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первый числовой коэффициет для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второй числовой коэффициет для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

FindPointIntersection(k1, b1, k2, b2);

void FindPointIntersection (double pointOne, double pointTwo, double PointThree, double pointFour)
{
    double coordX = (pointFour - pointTwo)/(pointOne - PointThree);
    double coordY = pointOne * coordX + pointTwo;
    Console.WriteLine($"({Math.Round(coordX, 2)}, {Math.Round(coordY, 2)})");
}