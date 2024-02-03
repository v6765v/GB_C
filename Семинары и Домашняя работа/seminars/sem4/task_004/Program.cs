// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36

int SumOfNumbers(int number)
{
    int res = 0;
    
    for (int i = 1; i <= number; i++ )
    {
       res = res + (i);
    }
    return res;
}

System.Console.Write("Enter the A -> ");
int A = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(SumOfNumbers(A));