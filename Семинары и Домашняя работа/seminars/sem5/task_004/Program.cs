// Задача 3. Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное 
// число в массиве.

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

bool SearchNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    { 
        if ( number == array[i]) 
        {
            Console.WriteLine($"Number belongs to the array");
            return true;
        }  
    }
    Console.WriteLine($"Number DOES NOT belongs to the array");
    return false;
}



int length = Prompt("Input length array: ");
int minValue = Prompt("Input min array: ");
int maxValue = Prompt("Input max array: ");

int num = Prompt("Input random number: ");

int[] myarray = GenerateArray(length, minValue, maxValue);
Printarray(myarray);

System.Console.WriteLine();

bool res = SearchNumber(myarray, num);
Console.WriteLine(res);


