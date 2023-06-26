/* 
Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе 
число кратным первому. Если второе число некратно 
первому, то программа выводит остаток от деления.

34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Enter two numbers: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne % numberTwo == 0)
{
    Console.WriteLine($"Number {numberOne} is a multiple of {numberTwo}");
}    
else 
{
    int reminder = numberOne % numberTwo;
    Console.WriteLine($"Reminrder of {numberOne} / {numberTwo} is {reminder}");
}