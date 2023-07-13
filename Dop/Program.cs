/* Task 0
Напишите программу, 
которая на вход принимает число и выдаёт его квадрат 
(число умноженное на само себя).
*/

/* Console.WriteLine("Enter number ");
int num = Convert.ToInt32(Console.ReadLine()); // считывает то что ввел пользователь, конвертирует в число 
// (Все что вводит пользователь - этот строка), и только после этого записывает в переменную

int sq = num * num;
Console.WriteLine(sq);
*/



/* Task 1
Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
*/

/* Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
    {
        Console.WriteLine("Da");
    }
else
    Console.WriteLine("NET");

*/

/* Task 2
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/

/* Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());

if(a<b)
{
    Console.WriteLine($"Number {a} < {b}");
}
else 
    Console.WriteLine($"Number {a} > {b}");
*/



/* Task 4
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number c ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if(max < b)
    {
        max = b;
    }
if(max < c)
{
   max = c; 
}
Console.WriteLine(max);
*/

/* Task5
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
*/

/* Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

for(int i=-a; i<=a; i++)
{
    Console.Write($"{i} ");
}
/*

/* Task 6 
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

/* Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Da");
}
else
    Console.WriteLine("NET");
*/



/* Task 7
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/

/* Console.WriteLine("Enter 3 digit number ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 10;
Console.WriteLine(b);
*/


/* Task 8

Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
/* Console.WriteLine("Enter number ");
int a = Convert.ToInt32(Console.ReadLine());
for(int i=2; i<=a; i+=2) // i+=2 = i=i+2
{
    Console.Write($"{i} ");
}
*/

/* Task 9 
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/


/*
int a = new Random().Next(10, 100); // Дай мне новое рандомное число из промежутка 10 - 99
// Первое число - жесткое, оно включено в рандом ,  второе не жесткое - не включено тоесть пишем 
// не 1 меньше

Console.WriteLine(a);
int first = a / 10;
int second = a % 10;

if(first < second)
{
   Console.Write(second); 
}
else Console.Write(first);
*/

/* Task 10
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
*/

/* Console.WriteLine("Enter 3 digit number ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int c = b % 10; 
Console.WriteLine(c);
*/

/*Task 11
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

/* int a = new Random().Next(100, 1000);
Console.WriteLine(a);
//int b = a / 100 ;
//int c = a % 10;

int b = a / 100 * 10 ;
int c = a % 10;
Console.WriteLine($"{b+c}");
*/

/*  Task 12
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
*/

/* Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b ");
int b = Convert.ToInt32(Console.ReadLine());

if(a%b==0)
{
    Console.WriteLine("True");
}
else
{
    int reminder = a % b;
    Console.WriteLine(reminder);
}
*/

/* Task 13
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
*/

Console.WriteLine("Enter number a ");
int a = Convert.ToInt32(Console.ReadLine());

// if(a < 100)
// {
//     Console.WriteLine("Not a 3 digit number ");
// } 

int NumberSearch (int number) // функция принимает на вход целое число
{
    int result = 0;
    while (number>999)
    {
        number = number / 10;
    }
    result = number % 10;
    return result;
}

if (a > 99)
{
    int third = NumberSearch(a); // Заводим переменную 
    // где мы вызываем функцию которая ищет 3-е число и как аргумент задаем ей нашу переменную a 
    Console.WriteLine(third);
}
else Console.WriteLine("Not a 3 digit number ");