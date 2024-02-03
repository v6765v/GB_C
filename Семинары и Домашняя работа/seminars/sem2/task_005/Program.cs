// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

void CheckSqr( int num1, int num2 )
{
    if ( num1 == num2 * num2 )
       System.Console.WriteLine($"{num1} is square of {num2}");
    else
       System.Console.WriteLine($"{num1} is NOT square of {num2}");
}

System.Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

CheckSqr(n1, n2);
