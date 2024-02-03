// Из двумерного массива целых чисел удалить строку 
// и столбец, на пересечении которых расположен 
// наименьший элемент.

// 1 2 3      0 0 0
// 4 5 6      0 5 6
// 7 8 9      0 8 9 





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

void DeleteMinimum(int[,] matrix)
{
    int min = matrix[0, 0];
    int minIndexi = 0;
    int minIndexj = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndexi = i;
                        minIndexj = j;
                    }
                }
            }
        }
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[minIndexi, j] = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, minIndexj] = 0;
            }
        }
}



int rows = Prompt("Input rows: ");
int colums = Prompt("Input columss: ");

int[,] matr =  GenerateNewMatrix(rows);
System.Console.WriteLine();
System.Console.WriteLine($"Matrix:");
System.Console.WriteLine();
PrintMatrix(matr);

DeleteMinimum(matr);
System.Console.WriteLine();
System.Console.WriteLine("New matrix:");
System.Console.WriteLine();

PrintMatrix(matr);