// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] fillArray)
{
    int length = fillArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{fillArray[i] = new Random().Next(-100, 101)} ");
    }
    Console.WriteLine();
}

void EvenIndex(int[] evenArray)
{
    int length = evenArray.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if(i % 2 != 0) sum += evenArray[i];
    }
    Console.Write($"Сумма всех элементов с четным индексом: {sum}");
}

int[] array = new int[7];

FillArray(array);
EvenIndex(array);