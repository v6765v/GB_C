// **Задача 44:** Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8


// f(1) = 0
// f(2) = 1
// f(n) = f(n-1) - f(n-2)

int Prompt(string message) 
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] Fibonacci(int length, int firstNum, int secondNum)
{
    int[] array = new int[length];
    for (int i = 2; i < length; i++)
    {
        array[0] = firstNum;
        array[1] = secondNum;
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void Printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"f({i}) -> {array[i]}");
    }
}

int N = Prompt("Input numbers of digit: ");
int firstNumber = Prompt("Input First Number: ");
int secondNumber = Prompt("Input Second Number: ");

int[] myarray = Fibonacci(N, firstNumber, secondNumber);
Printarray(myarray);



