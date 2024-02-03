// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


double FindDistance(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
}


System.Console.Write("Input Xa: ");
int Xa = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Xb: ");
int Xb = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"A({Xa}, {Ya}),  B({Xb}, {Yb})  -> {FindDistance(Xa, Ya, Xb, Yb)}");