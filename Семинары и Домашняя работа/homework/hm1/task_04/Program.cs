// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        System.Console.Write($"number = {number} -> ");
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}, ");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        PrintEvenNumbers(number);
    }
}