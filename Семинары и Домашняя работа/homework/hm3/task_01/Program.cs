﻿// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
    
    if (number > 9999 && number < 1000000)
    {
            if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
           { 
            return true; 
           }
           return false;
    }
    else 
    System.Console.WriteLine($"Число не пятизначное");
    {
        return false; 
    }
    }



  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 12821;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}





// решение ебаного автотеста

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }