/* 
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

C2 = A2 + B2
C = sqrt(A2 + B2)
A = 




Console.WriteLine("Enter X of point A ");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y of point A ");
int YpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X of point B ");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X of point B ");
int YpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XpointA - XpointB) * (XpointA - XpointB) + (YpointA - YpointB) * (YpointA - YpointB));
Console.WriteLine(result); 
*/
class Program
{
    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double result = CalculateDistance(x1, y1, x2, y2);

        Console.WriteLine("Расстояние между точками ({0}, {1}) и ({2}, {3}) равно {4:F2}", x1, y1, x2, y2, result);
    }
}