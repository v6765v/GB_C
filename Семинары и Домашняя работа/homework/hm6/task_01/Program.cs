// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Input {i + 1} element -> ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]} ");
    }
}

int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] > 0) counter++;
    }
    return counter;
}

int length = Prompt("Input length array: ");

int[] myArray = InputArray(length);
PrintArray(myArray);

System.Console.WriteLine();

int N = CountPositiveNumbers(myArray);

System.Console.WriteLine($"The number of positive = {N}");