// Напишите программу, которая принимает на вход 
//  число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int ProductOfNumbers(int number)
{
    int res = 1;
    
    for (int i = 1; i <= number; i++ )
    {
       res = res * (i);
    }
    return res;
}

System.Console.Write("Enter the N -> ");
int N = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(ProductOfNumbers(N));