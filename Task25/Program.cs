// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число, в которое будет возводится первое число: ");
int degree = Convert.ToInt32(Console.ReadLine());

FindDegreeNumber(number, degree);

void FindDegreeNumber(int num, int degr)
{
    int temp = num;
    if (degr == 0) Console.WriteLine($"Число {num} в степени 0 = 1.");
    else if (degr > 0)
    {
        for (int i = 2; i <= degr; i++)
        {
            num = num * temp;
        }
        Console.WriteLine($"Число {temp} в степени {degr} = {num}.");
    }

    else if (degr < 0) Console.WriteLine("Вы ввели не натуральную степень.");

}