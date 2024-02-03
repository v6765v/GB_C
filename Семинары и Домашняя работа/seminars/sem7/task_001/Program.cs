// Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 4 8 19

// 5 -2 33 -2

// 77 3 8 1


int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[,] GenerateMatrix(int rows, int colums, int minValue, int maxValue )
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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


int rows = Prompt("Input rows: ");
int colums = Prompt("Input colums: ");
int minValue = Prompt("Input minValue: ");
int maxValue = Prompt("Input maxValue: ");



int[,] matr =  GenerateMatrix(rows, colums, minValue, maxValue);
PrintMatrix(matr);

System.Console.WriteLine();

