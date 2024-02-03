// Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами 
// в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}, ");
    }

    System.Console.Write("]");
}

System.Console.Write("Enter the array size: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the minimum number: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the maximum number: ");
int numSecond = Convert.ToInt32(Console.ReadLine());



// PrintArray(CreateRandomArray(size, numFirst, numSecond));


int[] myArray = CreateRandomArray(size, numFirst, numSecond);
PrintArray(myArray);