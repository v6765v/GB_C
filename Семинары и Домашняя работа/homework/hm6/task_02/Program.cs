// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// y = k1 * x + b1, 
// y = k2 * x + b2; 

// k1 != k2  - пересекаются

// k1 = k2, b1 != b2  - параллельны

// k1 = k2, b1 = b2 - совпадают

double Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    double result = Convert.ToDouble(readInput);
    return result;
}

void MutualArrangementOfStraightLines(double coefficient1, 
     double constant1, double coefficient2, double constant2)
{
    if (coefficient1 != coefficient2)
    {
        double x = (-constant1 + constant2) / (-coefficient2 + coefficient1);
        double y = coefficient2 * x + constant2;
        System.Console.WriteLine($"coordinates of the intersection point of two straight lines X = {x} , Y = {y}");
        System.Console.WriteLine($"A = ({x}, {y})");
    }

    if (coefficient1 == coefficient2 && constant1 != constant2)
    {
        System.Console.WriteLine($"straight lines are PARALLEL");
    }  
    
    if (coefficient1 == coefficient2 && constant1 == constant2)
    {
        System.Console.WriteLine($"straight lines are MATCH");
    }

}

double k1 = Prompt("Input k1: ");
double b1 = Prompt("Input b1: ");
double k2 = Prompt("Input k2: ");
double b2 = Prompt("Input b2: ");

MutualArrangementOfStraightLines(k1, b1, k2, b2);
