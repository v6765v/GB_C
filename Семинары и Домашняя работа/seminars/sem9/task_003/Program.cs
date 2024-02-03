// Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

int FindSum(int number)
{
    if (number > 0)
    {
        return FindSum(number / 10) + number % 10;
    }
    else return number;
}

System.Console.Write("input N -> ");
int N = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(FindSum(N));