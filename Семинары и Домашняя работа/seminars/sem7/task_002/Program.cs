// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12




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


int SumMatrix(int[,] matrix)
{
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) 
            {
                counter += matrix[i, j];
            }
        }
    }
    return counter;
} 


int rows = Prompt("Input rows: ");
int colums = Prompt("Input colums: ");
int minValue = Prompt("Input minValue: ");
int maxValue = Prompt("Input maxValue: ");



int[,] matr =  GenerateMatrix(rows, colums, minValue, maxValue);
System.Console.WriteLine();
System.Console.WriteLine($"Matrix:");
System.Console.WriteLine();
PrintMatrix(matr);

System.Console.WriteLine();

int sumMatr = SumMatrix(matr);

System.Console.WriteLine($"the sum of the elements located on the main diagonal -> {sumMatr}");

System.Console.WriteLine();

