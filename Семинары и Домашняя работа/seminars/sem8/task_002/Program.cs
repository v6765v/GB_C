// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// В итоге получается вот такой массив:

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int[,] GenerateNewMatrix(int rows)
{
    int[,] matrix = new int[rows, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
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

void ChangeRowsToColums(int[,] matrix, int numberRow, int numberColum)
{
    numberRow -= 1; numberColum -= 1;
    if (numberRow <= matrix.GetLength(0) 
    && numberColum <= matrix.GetLength(1)
    && numberRow >= 0)
    {
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int counter = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = counter;
            }
        }
    }
    else System.Console.WriteLine("Error. Input right rows");

}

int rows = Prompt("Input rows: ");

int[,] matr =  GenerateNewMatrix(rows);
System.Console.WriteLine();
System.Console.WriteLine($"Matrix:");
System.Console.WriteLine();
PrintMatrix(matr);

System.Console.WriteLine();

int row = Prompt("Input row : ");
int colum = Prompt("Input colum: ");
System.Console.WriteLine();
System.Console.WriteLine("New matrix:");
System.Console.WriteLine();
ChangeRowsToColums(matr, row, colum);

PrintMatrix(matr);