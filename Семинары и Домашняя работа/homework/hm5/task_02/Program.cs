﻿// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Аргументы, передаваемые в метод/функцию:


// '18, 76, 11'
// На выходе:


// 18      76      11  
// Сумма нечетных элементов: 76

using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
      int sum = 0;
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum += array[i];
        }
        return sum;

    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
       for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
         if (i < array.Length - 1)
         {
           Console.Write("\t");
         }
      }
      Console.WriteLine();
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 18, 76, 11 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}