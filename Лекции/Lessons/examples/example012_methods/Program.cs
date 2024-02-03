// Type 1

// void Method1()
// {
//     System.Console.WriteLine("Author - ");
// }

// Method1();






// Type 2

// void Method2(string message)
// {
//     System.Console.WriteLine(message);
// }

// Method2(message: "Text message: ");                 





// void Method21(string message, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(message);
//         i++;
//     }

// }

// Method21( message: "Text", count: 4); 
// Method21( count: 3, message: "New text"); 






// Type 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);






// Type 4 

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
//
// string res = Method4(10, $"qwerty,\t");
// System.Console.WriteLine(res);






// string Method5(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
//
// string res = Method5(5, $"qwerty,\t");
// System.Console.WriteLine(res);




// Цикл for

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}




