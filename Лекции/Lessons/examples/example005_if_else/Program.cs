Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "андрей")
{
    Console.WriteLine("Проси прощения");
}
else 
{
    Console.Write("Приветульки, ");
    Console.WriteLine(username);
}
