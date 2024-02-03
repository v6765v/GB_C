// **Задача 42:** Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void ConvertToBinary(int number)
{
    string str = string.Empty;
    while (number > 0)
    {
        str = number % 2 + str;
        number /= 2;   
    }
    System.Console.WriteLine(str);
}

int num = Prompt("Input number: ");

ConvertToBinary(num);