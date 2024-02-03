// Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

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
            System.Console.Write($"a[{i},{j}] {matrix[i, j]} \t ");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixElementsWithEvenIndexesAreReplacedByTheirSquares(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 == 0)
               matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
    }
    return matrix;
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

System.Console.WriteLine($"New Matrix:");
System.Console.WriteLine(
    
);
int[,] newMatr = MatrixElementsWithEvenIndexesAreReplacedByTheirSquares(matr);
PrintMatrix(newMatr);
