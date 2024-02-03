// Задайте значения M и N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


void MtoN(int numberOne, int numberTwo)
{
    if (numberOne != numberTwo)
    {
        if (numberOne > numberTwo)
        {
            MtoN(numberOne - 1, numberTwo);
            System.Console.Write($"{numberOne}, ");
        }
        if (numberOne < numberTwo)
        {
            MtoN(numberOne, numberTwo - 1);
            System.Console.Write($"{numberTwo}, ");
        }

    }
    else System.Console.Write($"{numberOne}, ");
}

System.Console.Write("input M -> ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("input N -> ");
int N = Convert.ToInt32(Console.ReadLine());



// System.Console.Write($" -> ");

MtoN(M, N);