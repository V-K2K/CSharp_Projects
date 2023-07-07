// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number A ");
int numberA = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (numberA < 0) 
    numberA *= -1;

while (numberA != 0)
{
    sum = sum + numberA % 10;
    numberA = numberA / 10;
} 

Console.WriteLine($"Sum of this number is {sum}");

