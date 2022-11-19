// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int AccermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AccermanFunction(n - 1, 1);
    return AccermanFunction(n - 1, AccermanFunction(n, m - 1));
}

int accermanFunction = AccermanFunction(firstNumber, secondNumber);
Console.WriteLine($"A({firstNumber},{secondNumber}) -> {accermanFunction}");