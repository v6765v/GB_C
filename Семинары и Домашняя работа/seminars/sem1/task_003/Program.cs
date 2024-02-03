// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8

System.Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if ( num >= 100 && num <= 999 )
{
    System.Console.WriteLine($"{num} -> {num % 10}");
}
else
{
    System.Console.WriteLine("Invalid input");
}