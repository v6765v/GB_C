// Напишите программу, которая на вход принимает два
//  числа A и B, и возводит число А в целую степень 
//  B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8


int PowOfNumber (int numberOne, int numberTwo)
{
    
    if (numberTwo > 0)
    {
        return PowOfNumber(numberOne, numberTwo - 1) * numberOne;
    }
    else return 1;
}

System.Console.WriteLine(PowOfNumber(3, 5));