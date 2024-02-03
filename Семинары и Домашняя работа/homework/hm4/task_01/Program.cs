// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
    System.Console.Write(message);     // Вводим приглашение к вводу
    string readInput = System.Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // Приводим к числу
    return result; // Возвращаем резульат
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++ )
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("The exponent should not be than less 0!");
        return false;
    }
    return true;
}

int powerBase = Prompt("Enter the base: ");
int exponent = Prompt("Enter the exponent: ");

if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Number {powerBase} in a power {exponent} = {Power(powerBase, exponent)}");
}


// double ExponentiateANumber( double firstNumber, double secondNumber)
// {
//     if ( firstNumber > 0)
//     {
//         return Math.Pow(firstNumber, secondNumber);
//     }
//     return 0;
// }

// System.Console.Write("Enter the A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Enter the B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine();

// System.Console.WriteLine($"A number {A} in a power {B} = {ExponentiateANumber(A, B)}");
