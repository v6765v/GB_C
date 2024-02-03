// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

void TableOfSquares(int number)
{
    int res = 0;
    int count = 1;
    while (count <= number) 
    {
    res = count*count;
    System.Console.Write($"{res}, ");
    count++;
    }
}

System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


System.Console.Write($"Number {num} ->  ");
TableOfSquares(num);