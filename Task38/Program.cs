// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и 
//минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMinNumberArray(double[] array)
{
    double minNumber = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}

double FindMaxNumberArray(double[] array)
{
    double maxNumber = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}

double[] arr = CreateArrayRndDouble(5, -10, 10);
PrintDoubleArray(arr);
double minNumber = FindMinNumberArray(arr);
double maxNumber = FindMaxNumberArray(arr);

if (minNumber < 0) Console.WriteLine($"Разница между максимальным и нимамальным значением = {Math.Round(maxNumber + minNumber, 2)}");
else Console.WriteLine($"Разница между максимальным и нимамальным значением = {Math.Round(maxNumber - minNumber, 2)}");