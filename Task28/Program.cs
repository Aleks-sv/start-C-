// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int findFactorial = FindFactorial(number);
Console.WriteLine($"Факториал числа {number} = {findFactorial}");

int FindFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        try
        {
             checked
        {
            factorial *= i;
        }
        }
        catch (Exception)
        {
            Console,WriteLine("Переполнение типа");
        }
       Console,WriteLine($"Факториа числа {number} = {factorial}");
    }
    return factorial;

}


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int factorial = Factorial(number);
// Console.WriteLine($"произведение чисел {number} = {factorial}");

// int Factorial(int n)
// {
//     if (n == 1) return 1;

//     return n * Factorial(n - 1);
// }