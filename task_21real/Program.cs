/* 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Enter X of point A ");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y of point A ");
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z of point A ");
int ZpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X of point B ");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X of point B ");
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z of point B ");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XpointA - XpointB) * (XpointA - XpointB) + (YpointA - YpointB) * (YpointA - YpointB) + (ZpointA - ZpointB) * (ZpointA - ZpointB));
Console.WriteLine($"Distance --> {Math.Round(result, 2)}"); 