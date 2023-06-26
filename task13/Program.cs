/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter number from -2147483648 to 2147483648");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 == 0)
    Console.WriteLine("Third digit is not exist");
else
{
    while (num / 1000 != 0)
    {
        num = num / 10;
        // delete all digits on right side
    }
    int thirdDigit = num % 10;
    Console.WriteLine($"Third digit is {thirdDigit}");
}
