﻿//  Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже

    if(firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else if(secondNumber < firstNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
else if(firstNumber == secondNumber)
{
    System.Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 8;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}