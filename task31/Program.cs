﻿Console.Clear();
int[] GetRandomArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.WriteLine("]");
}

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP = sumP + array[i];
        }
        else
        {
            sumN = sumN + array[i];
        }
    }
    Console.WriteLine($"Сумма положительных = {sumP}, Сумма отрицательных = {sumN}");
}

System.Console.WriteLine("Введите размер массива, нижнее и верхнее значения");
int userLength = Convert.ToInt32(Console.ReadLine());
int userStart = Convert.ToInt32(Console.ReadLine());
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(userLength, userStart, userEnd);
PrintArray(userArray);
GetSum(userArray);
