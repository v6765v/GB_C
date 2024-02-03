//  Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void check(int num1, int num2)
{
   if ( num1 % num2 == 0 )
   {
    System.Console.WriteLine($"{num1} and {num2} -> is multiples");
   }
   else
   {
    System.Console.WriteLine($"{num1} and {num2} -> is NOT multiples ");
    System.Console.WriteLine($" remainder of division -> {num1 % num2}");
   }
}

System.Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

check(n1, n2);