// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void function(int num)
{
  if ( num > 99 && num < 1000) 
  System.Console.WriteLine($"Number {num} -> the second digit {num / 10 % 10 } ");
  else
  System.Console.WriteLine("Input three-digit number, please");
}

System.Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

function(number);
