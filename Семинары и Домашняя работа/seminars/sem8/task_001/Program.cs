// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

// любую строку массива

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2


int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[,] GenerateNewMatrix(int rows, int colums )
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void ChangeRows(int[,] matrix, int row1, int row2)
{
    row1 -= 1; row2 -= 1;
    int counter = 0;
    if (row1 <= matrix.GetLength(0) 
    && row2 <= matrix.GetLength(0)
    && row1 >= 0
    && row2 >= 0
    && row1 != row2)
    {
    for (int j = 0; j < matrix.GetLength(1); j++ )
    {
            counter = matrix[row1 , j];
            matrix[row1 , j] = matrix[row2 , j];
            matrix[row2, j] = counter;
    }
    }
    else System.Console.WriteLine("Error. Input right rows");

}

int rows = Prompt("Input rows: ");
int colums = Prompt("Input colums: ");

int[,] matr =  GenerateNewMatrix(rows, colums);
System.Console.WriteLine();
System.Console.WriteLine($"Matrix:");
System.Console.WriteLine();
PrintMatrix(matr);

System.Console.WriteLine();

int row1 = Prompt("Input first rows : ");
int row2 = Prompt("Input second rows: ");
System.Console.WriteLine();
System.Console.WriteLine("New matrix:");
System.Console.WriteLine();
ChangeRows(matr, row1, row2);

PrintMatrix(matr);
