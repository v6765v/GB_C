using System;
// Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"


void OneToN(int number)
{
    if (number >= 1)
    {
        OneToN(number - 1);
        System.Console.Write($"{number}, ");
    }
}

System.Console.Write("input N ->");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"N -> ");

OneToN(number);