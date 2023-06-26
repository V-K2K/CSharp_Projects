/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Enter 3 digit number");

int number = Convert.ToInt32(Console.ReadLine());
int integer = 0;
if (number < 100 || number > 999) Console.WriteLine ("Need 3 digit");
else {
    integer = number % 10;
    Console.WriteLine(integer);
}


