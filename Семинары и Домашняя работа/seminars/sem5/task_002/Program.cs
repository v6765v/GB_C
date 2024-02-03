// Задайте одномерный массив из 123 случайных чисел
// Найдите количество элментов массива
// Значения которых лежат в отрезке [10; 99]

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void Printarray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ");
    Console.Write("]");
}

int Counter(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        count++;
        
    }
    return count;
}

int length = Prompt("Input length array: ");
int minValue = Prompt("Input min array: ");
int maxValue = Prompt("Input max array: ");

int min = Prompt("Input min -> ");
int max = Prompt("Input max -> ");


int[] myarray = GenerateArray(length, minValue, maxValue);
Printarray(myarray);

System.Console.WriteLine();
int result = Counter(myarray, min, max);
Console.WriteLine($"The number of array elements belonging to the segment [ {min}, {max} ] -> {result}");

