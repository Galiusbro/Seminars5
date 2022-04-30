// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double MinMaxDif(double[] minMaxArray)
{
    int length = minMaxArray.Length;
    double min = minMaxArray[0];
    double max = minMaxArray[1];
    double minmax = 0;

    for (int i = 0; i < length; i++)
    {
        if (min > minMaxArray[i]) min = minMaxArray[i];
        if (max < minMaxArray[i]) max = minMaxArray[i];
    }

    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");

    return minmax = max - min;
}



double[] array = { 141.123, 211, 43.3, 34.89, 45, 16.999, 71.167, 824.11, 93 };

Console.WriteLine(MinMaxDif(array));