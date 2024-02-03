// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("There is NO third digit");
        return false;
    }
    return true;
}

int number = Prompt("Input random number: ");
System.Console.WriteLine();
if (ValidateNumber(number))
{
    System.Console.Write("Third digit -> ");
    System.Console.WriteLine((GetThirdRank(number)));
}
