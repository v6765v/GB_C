//Задача 1. Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9].

// Найдите сумму отрицательных и положительных элементов 
// массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($" {array[i]}, ");
    }
    System.Console.Write($" {array[array.Length - 1]} ");
    System.Console.Write("]");
}

int SumOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += array[i]; 
        }
    }
    return count;
}



int SumofNegative(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            count += array[i];
        }
    }
    return count;
}

int length = Prompt("Array length: ");
int min = Prompt("minimum: ");
int max = Prompt("maximum: ");


int[] array = GenerateArray(length, min, max);
PrintArray(array);
System.Console.WriteLine();

int positive = SumOfPositive(array);
int negative = SumofNegative(array);

System.Console.WriteLine($"Sum of positive -> {positive}");
System.Console.WriteLine($"Sum of negative -> {negative}");




