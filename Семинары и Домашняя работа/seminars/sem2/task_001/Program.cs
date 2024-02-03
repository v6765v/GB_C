//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98 [10-100)

void DeleteSecondDigit()
{
    int randomNum = new Random().Next(100,1000);
    System.Console.WriteLine($"{randomNum} -> {randomNum / 100 * 10 + randomNum % 10}");
}

void DeleteSecond()
{
    int randomNum = new Random().Next(100, 999 + 1);
    int ed = randomNum % 10;
    int sot = randomNum / 100;
    System.Console.WriteLine($"{randomNum} -> {sot * 10 + ed}");
}

DeleteSecondDigit();
System.Console.WriteLine();
DeleteSecond();