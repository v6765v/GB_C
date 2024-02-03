// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    System.Console.WriteLine("It is NOT a day of the week");
    return false;
}

int weekday = Prompt("Input day of the week: ");

if (ValidateWeekday(weekday))
{
    if (IsWeekend(weekday))
    {
        System.Console.WriteLine("Yippee, weekend");
    }
    else
    {
        System.Console.WriteLine("Working day");
    }
}