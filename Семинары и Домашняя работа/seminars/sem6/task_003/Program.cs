// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

bool CheckingTheExistenceOfATriangle(int a, int b, int c)
{
    if ( a + b > c
      && a + c > b
      && b + c > a )
     return true;
    
    else return false;
}

int firstSide = Prompt("Input the First side of the triangle: ");
int secondSide = Prompt("Input the Second side of the triangle: ");
int thirdSide = Prompt("Input the Third side of the triangle: ");

System.Console.WriteLine(CheckingTheExistenceOfATriangle(firstSide, secondSide, thirdSide));