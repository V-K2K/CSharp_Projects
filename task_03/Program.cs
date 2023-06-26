// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Enter number ");

int n = Convert.ToInt32(Console.ReadLine());

int negative_n = n * -1;

while (negative_n <= n) 
{
    Console.WriteLine (negative_n);
    negative_n = negative_n+1;
}
