/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Enter number of the day: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 7 || nubber1 < 1)
{
   Console.WriteLine("Not exist"); 
}
else if (number1 > 5 )
{
    Console.WriteLine("Yes");
}
else 
Console.WriteLine("No");
