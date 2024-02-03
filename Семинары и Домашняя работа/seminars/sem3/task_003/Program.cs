// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек 
// в этой четверти (x и y).


void FindRange(int number)
{
    if (number > 0 && number <= 4)
    {
        if (number == 1)  System.Console.WriteLine($"(x > 0, y > 0)");
        else if (number == 2) System.Console.WriteLine($"(x < 0, y > 0)");
        else if (number == 3) System.Console.WriteLine($"(x < 0, y < 0)");
        else if (number == 4)  System.Console.WriteLine($"(x > 0, y < 0)");
    } 
    else System.Console.WriteLine("ERROR, Input number of range");
}

System.Console.Write("enter the quarter number: ");
int res = Convert.ToInt32(Console.ReadLine());

FindRange(res);