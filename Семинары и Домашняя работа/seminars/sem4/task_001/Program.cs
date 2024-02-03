// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

int DigitCounter(int num)
{
       if ( num < 10 )
       return 1;

    int count = 0;
    while (num >= 0)
    {
        num /= 10;
        count++;
    }
    return count;

}

System.Console.Write("Input number: ");
int res = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"number of digit -> {DigitCounter(res)} ");