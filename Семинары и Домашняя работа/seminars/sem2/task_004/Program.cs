// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

bool ChekMultiPlisity(int num)
{
   if (num % 7 == 0 && num % 23 == 0)
   return true;
   else return false;
}

System.Console.Write("Input number: ");

int num = Convert.ToInt32(Console.ReadLine());

bool n = ChekMultiPlisity(num);

System.Console.WriteLine($"Number {num} -> {n}");