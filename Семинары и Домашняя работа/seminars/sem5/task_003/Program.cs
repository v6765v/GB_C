// Задача 2. Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие 
//  отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]


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

int[] ReplacingTheSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = (-1) * array[i];
    }
    return array;
}

int length = Prompt("Input length array: ");
int minValue = Prompt("Input min array: ");
int maxValue = Prompt("Input max array: ");

int[] myarray = GenerateArray(length, minValue, maxValue);
Printarray(myarray);

System.Console.WriteLine();

int[] res = ReplacingTheSign(myarray);
Printarray(res);