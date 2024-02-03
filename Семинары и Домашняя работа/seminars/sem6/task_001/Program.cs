// Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int[] SortedArray(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        counter = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = counter;
    }
    return array;
}


int length = Prompt("Input length array: ");

int[] myarray = GenerateArray(length);
Printarray(myarray);

System.Console.WriteLine();

int[] sortArray = SortedArray(myarray);
Printarray(sortArray);