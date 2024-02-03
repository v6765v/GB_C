// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

System.Console.Write("Input the number of the day of the week: ");
 int dNum = Convert.ToInt32(System.Console.ReadLine());
 if ( dNum == 1 )
 {
    System.Console.WriteLine($"{dNum} -> Monday");

 }
 else if ( dNum == 2 )
 {
    System.Console.WriteLine($"{dNum} -> Tuesday");
 }
 else if ( dNum == 3 )
{
    System.Console.WriteLine($"{dNum} -> Wednesday");
}
 else if ( dNum == 4 )
 {
    System.Console.WriteLine($"{dNum} -> Thursdar");
 }
 else if ( dNum == 5 )
 {
     System.Console.WriteLine($"{dNum} -> Friday");
 }
 else if ( dNum == 6 )
 {
     System.Console.WriteLine($"{dNum} -> Saturday");
 }
 else if ( dNum == 7 )
 {
     System.Console.WriteLine($"{dNum} -> Sunday");
 }
 else 
 {
    System.Console.WriteLine("Invalid input");
 }