// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

int findBiggest(int num)
{
   int ed = num % 10;
   int dec = num / 10;
      if ( dec < ed ) return ed;
      else return dec;
}

int randomNum = new Random().Next(10, 99 + 1);

int biggest = findBiggest(randomNum);

System.Console.WriteLine($"{randomNum} -> biggest digit is {biggest} ");