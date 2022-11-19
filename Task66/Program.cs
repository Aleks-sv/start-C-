// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int FindSumNaturalNumbers(int numberOne, int numberTwo)
{
    if (numberTwo == numberOne) return numberOne;
    if (numberTwo > numberOne) return numberOne + FindSumNaturalNumbers(numberOne + 1, numberTwo);
    return numberTwo + FindSumNaturalNumbers(numberOne, numberTwo + 1);
}

int findSum = FindSumNaturalNumbers(firstNumber, secondNumber);
Console.WriteLine($"{findSum}");