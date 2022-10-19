// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень в которую будет возводится первое число: ");
int degree = Convert.ToInt32(Console.ReadLine());

double findDegreeNumber = FindDegreeNumber(number, degree);
Console.WriteLine($"Результат возведения числа {number} в cтепень {degree} = {findDegreeNumber}");

double FindDegreeNumber(double num, double degr)
{
    //double count = num;
    
    double temp = num;
    
    if (degr == 0) return 1;
    else if (degr > 0)
    {
        for (int i = 2; i <= degr; i++)
        {
            num = num * temp;
        }
    }
    else if (degr < 0)
    {
       double count = temp;
        for (int i = -1; i >= degr; i--)//-3
        {   
            num = 1 / count;
            count = count * temp;
        }
    }
    return num;
}