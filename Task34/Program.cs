// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{fillArray[i] = new Random().Next(100, 1000)} ");
    }
    Console.WriteLine();
}

void ModTwo(int[] modArray)
{
    int length = modArray.Length;
    for (int i = 0; i < length; i++)
    {
        if(modArray[i] % 2 == 0) Console.Write($"{modArray[i]} ");
    }
}

int[] array = new int[10];
FillArray(array);
ModTwo(array);