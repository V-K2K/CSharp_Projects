/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Enter 5 digit number ");
int num = Convert.ToInt32(Console.ReadLine());

// 1 Method - Remainder 
bool isPalindrome(int number)
{
    if (number / 10000 == number % 10 &&
          number / 1000 % 10 == number % 100 / 10)
          return true;
    return false;          
}

// Console.WriteLine(isPalindrome(num));

// 2 Method - String
bool isPalindrome2(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        return true;
    return false;
} 

Console.WriteLine(isPalindrome2(Convert.ToString(num)));
