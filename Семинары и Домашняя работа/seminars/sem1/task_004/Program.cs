// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{n} -> ");
int current = -1 * Math.abs(n);
while ( current <= n )
{
    
    System.Console.Write( current + ", ");
    current++;
}
